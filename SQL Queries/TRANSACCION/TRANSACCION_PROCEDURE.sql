use PROYECTO_CDS;
GO
CREATE PROCEDURE PD_OBTENER_PRODUCTOS_TRANSACCIONES
@inventario_id int
as
begin
	SELECT p.nombre, concat(p.cantidad,' ',tu.abreviacion) as cantidad, concat(p.cantidad_maxima,' ',tu.abreviacion) AS cantidad_maxima, concat(p.cantidad_minima,' ',tu.abreviacion) as cantidad_minima, p.precio_compra, p.precio_venta,
	c.nombre as categoria, pr.nombre_empresa as proveedor, p.producto_id, p.tipo_unidad_id, p.categoria_id, tu.descripcion as tipo_unidad, p.proveedor_id
	FROM producto p
	JOIN TIPO_UNIDAD tu on tu.tipo_unidad_id = p.tipo_unidad_id
	join categoria c on c.categoria_id = p.categoria_id
	join proveedor pr on pr.proveedor_id = p.proveedor_id
	where p.inventario_id = @inventario_id and p.estado_id = 1
end

go
CREATE PROCEDURE PD_OBTENER_PRODUCTOS_TRANSACCIONES_SEGUN_Id
@producto_id int
as
begin
	SELECT p.nombre, concat(p.cantidad,' ',tu.abreviacion) as cantidad, concat(p.cantidad_maxima,' ',tu.abreviacion) AS cantidad_maxima, concat(p.cantidad_minima,' ',tu.abreviacion) as cantidad_minima, p.precio_compra, p.precio_venta,
	c.nombre as categoria, pr.nombre_empresa as proveedor, p.producto_id, p.tipo_unidad_id, p.categoria_id, tu.descripcion as tipo_unidad, p.proveedor_id
	FROM producto p
	JOIN TIPO_UNIDAD tu on tu.tipo_unidad_id = p.tipo_unidad_id
	join categoria c on c.categoria_id = p.categoria_id
	join proveedor pr on pr.proveedor_id = p.proveedor_id
	where p.producto_id= @producto_id and p.estado_id = 1
end


GO
CREATE PROCEDURE PD_OBTENER_BODEGA_USUARIO_ID
@usuario_id int
AS
BEGIN
	DECLARE @personal_id int
	SELECT @personal_id = personal_id from personal where usuario_id = @usuario_id
	SELECT B.* FROM BODEGA B
	JOIN PERSONAL_X_BODEGA pxb on pxb.bodega_id = b.bodega_id
	WHERE B.ESTADO_ID = 1 and pxb.personal_id = @personal_id and pxb.estado_id = 1
END

GO
CREATE PROCEDURE PD_EVALUAR_PERSONAL_TIENE_BODEGA
@usuario_id int, @result int output
AS
begin
	DECLARE @personal_id int
	SELECT @personal_id = personal_id from personal where usuario_id = @usuario_id
	IF EXISTS (SELECT 1 FROM PERSONAL_X_BODEGA WHERE personal_id = @personal_id and estado_id = 1) begin
		set @result = 1 -- existe
	end else begin
		set @result = 0 -- no existe
	end
end

GO
CREATE PROCEDURE PD_OBTENER_INVENTARIO_SEGUN_BODEGA_ID
@bodega_id int
as
begin
	SELECT inventario_id, nombre, bodega_id, fecha_creacion, saldo_final, estado_id, categoria_id FROM INVENTARIO WHERE bodega_id = @bodega_id AND estado_id = 1
end


GO
CREATE PROCEDURE PD_OBTENER_TEMP_TRANSACCION
@inventario_id int, @usuario_id int
as
begin
	declare @personal_x_bodega_id int
	declare @personal_id int
	select @personal_id = personal_id from PERSONAL where usuario_id = @usuario_id and estado_id = 1
	select @personal_x_bodega_id = personal_x_bodega_id from PERSONAL_X_BODEGA where personal_id = @personal_id
	select tt.nombre as tipo_transaccion, p.nombre as producto, concat(temp.cantidad,' ',tu.abreviacion) as cantidad, temp.fecha_transaccion, 
	temp.temp_transaccion_id, tt.tipo_transaccion_id, p.producto_id, tu.tipo_unidad_id
	from temp_transaccion temp
	join TIPO_TRANSACCION tt on tt.tipo_transaccion_id = temp.tipo_transaccion_id
	join producto p on p.producto_id = temp.producto_id
	join TIPO_UNIDAD tu on tu.tipo_unidad_id = temp.tipo_unidad_id
	where temp.personal_x_bodega_id = @personal_x_bodega_id and temp.inventario_id = @inventario_id
	order by temp.temp_transaccion_id desc
end


GO
CREATE PROCEDURE PD_OBTENER_PRODUCTOS_TRANSACCIONES_FILTRO
@inventario_id int, @filtro varchar(200)
as
begin
	SELECT p.nombre, concat(p.cantidad,' ',tu.abreviacion) as cantidad, concat(p.cantidad_maxima,' ',tu.abreviacion) AS cantidad_maxima, concat(p.cantidad_minima,' ',tu.abreviacion) as cantidad_minima, p.precio_compra, p.precio_venta,
	c.nombre as categoria, pr.nombre_empresa as proveedor, p.producto_id, p.tipo_unidad_id, p.categoria_id, tu.descripcion as tipo_unidad, p.proveedor_id
	FROM producto p
	JOIN TIPO_UNIDAD tu on tu.tipo_unidad_id = p.tipo_unidad_id
	join categoria c on c.categoria_id = p.categoria_id
	join proveedor pr on pr.proveedor_id = p.proveedor_id
	where p.inventario_id = @inventario_id and p.estado_id = 1 and
	(p.nombre like '%'+@filtro+'%' or c.nombre like '%'+@filtro+'%' or pr.nombre_empresa like '%'+@filtro+'%')
end


GO
CREATE PROCEDURE PD_ACTUALIZAR_TEMP_TRANSACCION
@tipo_transaccion_id int, @usuario_id int, @inventario_id int, @producto_id int, @tipo_unidad_id int, @cantidad numeric(10,2)
as
begin	
	declare @personal_x_bodega_id int 
	declare @personal_id int 
	select @personal_id = personal_id from PERSONAL where usuario_id = @usuario_id and estado_id = 1
	select @personal_x_bodega_id = personal_x_bodega_id from PERSONAL_X_BODEGA where personal_id = @personal_id
	
	insert into TEMP_TRANSACCION (tipo_transaccion_id, personal_x_bodega_id, inventario_id, fecha_transaccion, producto_id, tipo_unidad_id, cantidad) values
	(@tipo_transaccion_id, @personal_x_bodega_id, @inventario_id, CURRENT_TIMESTAMP, @producto_id, @tipo_unidad_id, @cantidad)

	if @tipo_transaccion_id = 1 begin --agregar
		update producto set cantidad = cantidad + @cantidad where producto_id = @producto_id
	end else begin --restar
		update producto set cantidad = cantidad - @cantidad where producto_id = @producto_id
	end
end

GO
CREATE PROCEDURE PD_ELIMINAR_1_TEMP_TRANSACCION
@temp_transaccion_id int, @modo int -- 0 = guardar, 1 = borrar
as
begin
	declare @producto_id int
	declare @tipo_transacccion_id int
	declare @cantidad numeric(10,2)
	SELECT @producto_id = producto_id, @tipo_transacccion_id = tipo_transaccion_id, @cantidad = cantidad from TEMP_TRANSACCION where temp_transaccion_id = @temp_transaccion_id
	
	if @modo = 1 begin
		if @tipo_transacccion_id = 1 begin-- agregar
			update PRODUCTO set cantidad = cantidad - @cantidad where producto_id = @producto_id
		end else begin -- quitar
			update PRODUCTO set cantidad = cantidad + @cantidad where producto_id = @producto_id
		end
	end
	DELETE FROM TEMP_TRANSACCION WHERE temp_transaccion_id = @temp_transaccion_id
end

GO
CREATE PROCEDURE PD_INSERTAR_TRANSACCION
@tipo_transaccion_id int, @usuario_id int, @inventario_id int, @producto_id int, @tipo_unidad_id int, @cantidad numeric(10,2)
as
begin
	declare @personal_x_bodega_id int 
	declare @personal_id int 
	select @personal_id = personal_id from PERSONAL where usuario_id = @usuario_id and estado_id = 1
	select @personal_x_bodega_id = personal_x_bodega_id from PERSONAL_X_BODEGA where personal_id = @personal_id

	insert into TRANSACCION (tipo_transaccion_id, personal_x_bodega_id, inventario_id, fecha_transaccion, producto_id, tipo_unidad_id, cantidad, estado_id) values
	(@tipo_transaccion_id, @personal_x_bodega_id, @inventario_id, CURRENT_TIMESTAMP, @producto_id, @tipo_unidad_id, @cantidad, 1)
end

GO
CREATE PROCEDURE VISTA_BODEGAS
as
begin
	SELECT * FROM BODEGA WHERE estado_id = 1
end

GO
ALTER PROCEDURE PD_OBTENER_TRANSACCION_SEGUN_INVENTARIO
@inventario_id int, @fecha_min datetime, @fecha_max datetime
as
begin
	SELECT tt.nombre as tipo_transaccion, concat(pers.nombre1,' ',pers.apellido1) as persona, i.nombre as inventario, p.nombre PRODUCTO, CONCAT(tr.cantidad,' ',tu.abreviacion) as cantidad, CONCAT(p.cantidad,' ',tu.abreviacion) as cantidad_actual, CONCAT(p.cantidad_maxima,' ',tu.abreviacion) as cantidad_maxima, CONCAT(P.cantidad_minima,' ',tu.abreviacion) as cantidad_minima,
	tr.fecha_transaccion
	FROM TRANSACCION tr
	JOIN TIPO_TRANSACCION tt on tt.tipo_transaccion_id = tr.tipo_transaccion_id
	JOIN PERSONAL_X_BODEGA pxb on pxb.personal_x_bodega_id = tr.personal_x_bodega_id
	JOIN PERSONAL per on per.personal_id = pxb.personal_id
	JOIN USUARIO u on u.usuario_id = per.usuario_id
	JOIN PERSONA pers on pers.persona_id = u.persona_id
	JOIN INVENTARIO i on i.inventario_id = tr.inventario_id
	JOIN PRODUCTO p on p.producto_id = tr.producto_id
	JOIN TIPO_UNIDAD tu on tu.tipo_unidad_id = tr.tipo_unidad_id
	WHERE tr.estado_id = 1 and tr.inventario_id = @inventario_id and (tr.fecha_transaccion >= @fecha_min and tr.fecha_transaccion <= @fecha_max)
	order by tr.transaccion_id desc
end

GO
CREATE PROCEDURE PD_OBTENER_TRANSACCION_SEGUN_INVENTARIO_FILTRO
@inventario_id int, @fecha_min datetime, @fecha_max datetime, @filtro varchar(50)
as
begin
	SELECT tt.nombre as tipo_transaccion, concat(pers.nombre1,' ',pers.apellido1) as persona, i.nombre as inventario, p.nombre PRODUCTO, CONCAT(p.cantidad,' ',tu.abreviacion) as cantidad, CONCAT(tr.cantidad,' ',tu.abreviacion) as cantidad_actual, CONCAT(p.cantidad_maxima,' ',tu.abreviacion) as cantidad_maxima, CONCAT(P.cantidad_minima,' ',tu.abreviacion) as cantidad_minima,
	tr.fecha_transaccion
	FROM TRANSACCION tr
	JOIN TIPO_TRANSACCION tt on tt.tipo_transaccion_id = tr.tipo_transaccion_id
	JOIN PERSONAL_X_BODEGA pxb on pxb.personal_x_bodega_id = tr.personal_x_bodega_id
	JOIN PERSONAL per on per.personal_id = pxb.personal_id
	JOIN USUARIO u on u.usuario_id = per.usuario_id
	JOIN PERSONA pers on pers.persona_id = u.persona_id
	JOIN INVENTARIO i on i.inventario_id = tr.inventario_id
	JOIN PRODUCTO p on p.producto_id = tr.producto_id
	JOIN TIPO_UNIDAD tu on tu.tipo_unidad_id = tr.tipo_unidad_id
	WHERE tr.estado_id = 1 and tr.inventario_id = @inventario_id and (tr.fecha_transaccion between @fecha_min and @fecha_max) and
	(tt.nombre like '%'+@filtro+'%' or pers.nombre1 like '%'+@filtro+'%' or pers.apellido1 like '%'+@filtro+'%' or i.nombre like '%'+@filtro+'%' or p.nombre like '%'+@filtro+'%')
	order by tr.transaccion_id desc
end



