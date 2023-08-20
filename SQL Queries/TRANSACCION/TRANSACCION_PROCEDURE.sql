use PROYECTO_CDS;
GO
CREATE PROCEDURE PD_OBTENER_PRODUCTOS_TRANSACCIONES
@inventario_id int
as
begin
	SELECT p.nombre, p.cantidad, tu.descripcion as tipo_unidad, p.cantidad_maxima, p.cantidad_minima, p.precio_compra, p.precio_venta,
	c.nombre as categoria, pr.nombre_empresa as proveedor, p.producto_id, p.tipo_unidad_id, p.categoria_id, p.proveedor_id
	FROM producto p
	JOIN TIPO_UNIDAD tu on tu.tipo_unidad_id = p.tipo_unidad_id
	join categoria c on c.categoria_id = p.categoria_id
	join proveedor pr on pr.proveedor_id = p.proveedor_id
	where p.inventario_id = @inventario_id and p.estado_id = 1
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
@personal_x_bodega_id int, @inventario_id int
as
begin
	select tt.nombre as tipo_transaccion, p.nombre as producto, concat(temp.cantidad,' ',tu.descripcion) as cantidad, temp.fecha_transaccion, temp.motivo, temp.temp_transaccion_id
	from temp_transaccion temp
	join TIPO_TRANSACCION tt on tt.tipo_transaccion_id = temp.tipo_transaccion_id
	join producto p on p.nombre = temp.producto_id
	join TIPO_UNIDAD tu on tu.tipo_unidad_id = temp.tipo_unidad_id
	where temp.personal_x_bodega_id = @personal_x_bodega_id and temp.inventario_id = @inventario_id
end


