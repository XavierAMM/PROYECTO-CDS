USE PROYECTO_CDS;

go
CREATE TABLE TEMP_TRANSACCION(
	temp_transaccion_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	tipo_transaccion_id int not null,
	personal_x_bodega_id int not null,
	inventario_id int not null,
	fecha_transaccion datetime,
	motivo varchar(200),
	producto_id int not null,
	tipo_unidad_id int not null,
	cantidad numeric(10,2) not null)

ALTER TABLE TEMP_TRANSACCION ADD CONSTRAINT FK_TEMP_TRANSACCION_TIPO_TRANSACCION
FOREIGN KEY (tipo_transaccion_id) REFERENCES TIPO_TRANSACCION(tipo_transaccion_id)

ALTER TABLE TEMP_TRANSACCION ADD CONSTRAINT FK_TEMP_TRANSACCION_PERSONAL_X_BODEGA
FOREIGN KEY (personal_x_bodega_id) REFERENCES PERSONAL_X_BODEGA(personal_x_bodega_id)

ALTER TABLE TEMP_TRANSACCION ADD CONSTRAINT FK_TEMP_TRANSACCION_PRODUCTO
FOREIGN KEY (producto_id) REFERENCES PRODUCTO(producto_id)

ALTER TABLE TEMP_TRANSACCION ADD CONSTRAINT FK_TEMP_TRANSACCION_TIPO_UNIDAD
FOREIGN KEY (tipo_unidad_id) REFERENCES TIPO_UNIDAD(tipo_unidad_id)

ALTER TABLE TEMP_TRANSACCION ADD CONSTRAINT FK_TEMP_TRANSACCION_INVENTARIO
FOREIGN KEY (inventario_id) REFERENCES INVENTARIO(inventario_id)


go
INSERT INTO TIPO_TRANSACCION VALUES ('Agregar',1), ('Restar',1)
go
alter table transaccion drop column motivo
go
alter table temp_transaccion drop column motivo
GO 
ALTER TABLE TIPO_UNIDAD ADD abreviacion varchar(10)