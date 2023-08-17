use PROYECTO_CDS;

GO
CREATE PROCEDURE PD_OBTENER_MODULOS
@modo int
as
begin
	if(@modo = 0) begin
		select m.modulo_id, m.nombre, m.nombre_objeto, m.orden, m.estado_id, e.letra as estado
		from modulo m
		join ESTADO e on e.estado_id = m.estado_id
		where e.estado_id = 1
		order by orden
	end else if @modo = 1 begin
		select m.modulo_id, m.nombre, m.nombre_objeto, m.orden, m.estado_id, e.letra as estado
		from modulo m
		join ESTADO e on e.estado_id = m.estado_id	
		order by m.estado_id, orden
	end
end


GO
CREATE PROCEDURE PD_AGREGAR_MODULO
@nombre varchar(50), @nombre_objeto varchar(50), @orden int
AS
BEGIN
	insert into MODULO (nombre, nombre_objeto, estado_id, orden) values
	(@nombre, @nombre_objeto, 1, @orden)	
END

GO
CREATE PROCEDURE PD_ACTUALIZAR_MODULO
@modulo_id int, @nombre varchar(50), @nombre_objeto varchar(50), @orden int
as
begin
	update MODULO set nombre = @nombre, nombre_objeto = @nombre_objeto, orden = @orden
	where modulo_id = @modulo_id
end

GO
CREATE PROCEDURE PD_INACTIVAR_ACTIVAR_MODULO
@accion int, @modulo_id int
as
begin
	if @accion = 1 begin -- inactivar
		update MODULO set estado_id = 2 where modulo_id = @modulo_id
	end else if @accion = 2 begin -- activar
		update MODULO set estado_id = 1 where modulo_id = @modulo_id
	end
end

GO
CREATE PROCEDURE PD_MODULO_BUSCAR_NOMBRE
@modo int, @nombre varchar(50)
as
begin
	if @modo = 0 begin
		select m.modulo_id, m.nombre, m.nombre_objeto, m.orden, m.estado_id, e.letra as estado
		from modulo m
		join ESTADO e on e.estado_id = m.estado_id
		where e.estado_id = 1 and (m.nombre like '%'+ @nombre+ '%' or m.nombre_objeto like '%'+ @nombre+'%')
		order by orden
	end else if @modo = 1 begin
		select m.modulo_id, m.nombre, m.nombre_objeto, m.orden, m.estado_id, e.letra as estado
		from modulo m
		join ESTADO e on e.estado_id = m.estado_id
		where m.nombre like '%'+ @nombre+ '%' or m.nombre_objeto like '%'+ @nombre+'%'
		order by m.estado_id, orden
	end
end



