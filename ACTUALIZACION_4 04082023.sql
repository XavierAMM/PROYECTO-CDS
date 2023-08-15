USE PROYECTO_CDS;
go
update opcion set nombre = 'Asignar Perfil' where opcion_id = 8
go
drop table CATEGORIA_X_BODEGA
go
alter table inventario add categoria_id int not null
go
alter table inventario add constraint FK_INVENTARIO_CATEGORIA
foreign key (categoria_id) references CATEGORIA(categoria_id)
go
ALTER TABLE PERSONAL_X_BODEGA drop column fecha_finalizacion
go
INSERT INTO OPCION VALUES ('A/R Solicitud', 'UC_AR_Solicitud','',4,1,10)
go
UPDATE OPCION SET orden = orden + 1 where orden >= 10
UPDATE OPCION SET nombre_objeto = 'UC_Asignar_Perfil' where nombre = 'Asignar Perfil'
UPDATE OPCION SET nombre_objeto = 'UC_Solicitud_Permiso' where nombre = 'Solicitud de Permiso'
UPDATE OPCION SET nombre_objeto = 'UC_Mi_Perfil' where nombre = 'Mi Perfil'
UPDATE PERFIL_X_OPCION SET estado_id = 2 where 
perfil_x_opcion_id = 19
or perfil_x_opcion_id = 2
or perfil_x_opcion_id = 3
or perfil_x_opcion_id = 4
or perfil_x_opcion_id = 10
or perfil_x_opcion_id = 18
or perfil_x_opcion_id = 27
or perfil_x_opcion_id = 28
or perfil_x_opcion_id = 37
or perfil_x_opcion_id = 50
GO
INSERT INTO PERFIL_X_OPCION VALUES (3, 14, 1), (6, 14, 1), (7, 14, 1)
GO
UPDATE PERFIL SET prioridad = 5 where perfil_id = 3
UPDATE PERFIL SET prioridad  = 3 where perfil_id = 5
GO 
INSERT INTO OPCION_ACEPTAR_RECHAZAR VALUES ('Aceptar',1),('Rechazar',1)
GO
alter table PRODUCTO alter column inventario_id int null
go
alter table inventario alter column bodega_id int null
go
alter table usuario alter column persona_id int null
go
ALTER PROCEDURE [dbo].[PD_AÑADIR_NUEVO_USUARIO]
@usuario VARCHAR(50), @contraseña varchar(50), @tipo_pregunta_id int, @respuesta_pregunta varchar(200), @result int output
as
begin	
	insert into usuario (usuario, contraseña, estado_id, tipo_pregunta_id, respuesta_pregunta) 
	values (@usuario, @contraseña, 1, @tipo_pregunta_id, @respuesta_pregunta);
	set @result = SCOPE_IDENTITY()
	insert into personal (usuario_id, direccion_hogar, estado_id, perfil_id, fecha_asignacion) 
	values (@result, '',1, 1, CURRENT_TIMESTAMP)
end
GO
CREATE PROCEDURE PD_ASIGNAR_PERSONA_A_USUARIO
@usuario_id int, @persona_id int
as
begin
	update usuario set persona_id = @persona_id where usuario_id = @usuario_id
end


