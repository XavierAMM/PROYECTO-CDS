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
