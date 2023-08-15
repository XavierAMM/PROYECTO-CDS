USE PROYECTO_CDS;

BEGIN TRANSACTION

ALTER TABLE MODULO ADD orden int
GO
DROP TABLE ELIMINAR_USUARIO;
update modulo set orden = 1 where modulo_id = 1
update modulo set orden = 2 where modulo_id = 2
update modulo set orden = 3 where modulo_id = 3
update modulo set orden = 4 where modulo_id = 4
update modulo set orden = 5 where modulo_id = 5

ALTER TABLE PERSONA DROP COLUMN nombre2
ALTER TABLE PERSONA DROP COLUMN apellido2
ALTER TABLE PERSONA ALTER COLUMN nombre1 varchar(50) not null
ALTER TABLE PERSONA ALTER COLUMN apellido1 varchar(50) not null
ALTER TABLE PERSONA ALTER COLUMN fecha_nacimiento date not null


insert into persona (nombre1, apellido1, telefono, correo_electronico, fecha_nacimiento) values 
('Xavier','Mancero','0996005896','xavier.mancerom@ug.edu.ec','20021209')

insert into usuario (persona_id, usuario, contraseña) values
(1, 'admin','1234')

insert into personal (usuario_id, direccion_hogar, estado_id, perfil_id, fecha_asignacion) values
(1, 'Acuarela del Río', 1, 7, CURRENT_TIMESTAMP)

CREATE TABLE TIPO_PREGUNTA(
	tipo_pregunta_id int not null identity(1,1) primary key,
	pregunta varchar(100),
	estado_id int not null DEFAULT 1
)

ALTER TABLE TIPO_PREGUNTA ADD CONSTRAINT FK_TIPO_PREGUNTA_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

INSERT INTO TIPO_PREGUNTA VALUES 
('¿Cuál era el nombre de tu primera mascota?',default),
('¿Cuál era el nombre de la ciudad en la que naciste?',default),
('¿Cuál era el apodo de tu infancia?',default),
('¿Cuál es el nombre de la ciudad en la que se conocieron tus padres?',default),
('¿Cuál es el nombre de tu primo mayor?',default),
('¿Cómo se llamaba la primera escuela a la que asististe?',default)

ALTER TABLE USUARIO ADD tipo_pregunta_id int
GO
UPDATE USUARIO SET tipo_pregunta_id = 1 where usuario_id = 1
GO
ALTER TABLE USUARIO ALTER COLUMN tipo_pregunta_id int not null
GO
ALTER TABLE USUARIO ADD CONSTRAINT FK_USUARIO_TIPO_PREGUNTA
FOREIGN KEY (tipo_pregunta_id) REFERENCES TIPO_PREGUNTA(tipo_pregunta_id)
GO
ALTER TABLE USUARIO ADD respuesta_pregunta varchar(200)
GO
UPDATE USUARIO SET respuesta_pregunta = 'Merlina' where usuario_id = 1
GO
ALTER TABLE USUARIO ALTER COLUMN respuesta_pregunta varchar(200) not null
GO
ALTER TABLE PERFIL ADD prioridad int
GO
UPDATE PERFIL SET prioridad = perfil_id
GO
ALTER TABLE PERFIL ALTER COLUMN prioridad int not null
GO
ALTER TABLE OPCION ADD orden int
GO
UPDATE OPCION SET orden = opcion_id
GO
ALTER TABLE OPCION ALTER COLUMN orden int not null
GO
UPDATE OPCION SET nombre_objeto = 'UC_'+ nombre 
GO
UPDATE OPCION SET nombre_objeto = 'UC_Cerrar_Sesion' where nombre = 'Cerrar Sesión'
UPDATE OPCION SET nombre_objeto = 'UC_Ver_Movimientos' where nombre = 'Ver Movimientos'
GO
UPDATE MODULO SET nombre_objeto = 'UC_' + 
GO
UPDATE OPCION SET estado_id = 2 where opcion_id = 13
GO
UPDATE PERFIL_X_OPCION SET estado_id = 2 where opcion_id = 13

commit
