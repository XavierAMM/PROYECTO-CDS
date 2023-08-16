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
CREATE PROCEDURE VISTA_ESTADO_A_I
as
begin
	select * from ESTADO where estado_id = 1 or estado_id = 2
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
@modulo_id int, @nombre varchar(50), @nombre_objeto varchar(50), @estado_id int, @orden int
as
begin
	update MODULO set nombre = @nombre, nombre_objeto = @nombre_objeto, estado_id = @estado_id, orden = @orden
	where modulo_id = @modulo_id
end

GO
CREATE PROCEDURE PD_ELIMINAR_MODULO
@modulo_id int
as
begin
	delete from MODULO where modulo_id = @modulo_id
end