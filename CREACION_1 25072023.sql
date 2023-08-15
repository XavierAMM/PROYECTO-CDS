-- AÑADIR EL NOMBRE DE LA BASE DE DATOS AQUI
USE PROYECTO_CDS;
GO
BEGIN TRANSACTION
------ ACCESO Y SEGURIDAD ------ 
-- 1. Estado
CREATE TABLE ESTADO(
	estado_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre VARCHAR(50),
	letra CHAR(1),
	descripcion VARCHAR(250) )

-- 2. Módulo
CREATE TABLE MODULO(
	modulo_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(50),
	nombre_objeto varchar(50),	
	estado_id INT NOT NULL DEFAULT 1 )

ALTER TABLE MODULO ADD CONSTRAINT FK_MODULO_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 3. Opcion 
CREATE TABLE OPCION(
	opcion_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(50),
	nombre_objeto varchar(50),
	descripcion varchar(250),
	modulo_id INT NOT NULL,
	estado_id INT NOT NULL DEFAULT 1 )

ALTER TABLE OPCION ADD CONSTRAINT FK_OPCION_MODULO
FOREIGN KEY (modulo_id) REFERENCES MODULO(modulo_id)

ALTER TABLE OPCION ADD CONSTRAINT FK_OPCION_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 4. Persona 
CREATE TABLE PERSONA(
	persona_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre1 VARCHAR(50),
	nombre2 VARCHAR(50),
	apellido1 VARCHAR(50),
	apellido2 VARCHAR(50),
	telefono VARCHAR(10),
	correo_electronico VARCHAR(100),
	fecha_nacimiento DATE,
	estado_id INT NOT NULL DEFAULT 1 )

ALTER TABLE PERSONA ADD CONSTRAINT FK_PERSONA_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 5. Perfil
CREATE TABLE PERFIL(
	perfil_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(50),
	descripcion varchar(250),
	estado_id int not null DEFAULT 1 )

ALTER TABLE PERFIL ADD CONSTRAINT FK_PERFIL_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 6. Usuario 
CREATE TABLE USUARIO(
	usuario_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	persona_id INT NOT NULL,
	usuario VARCHAR(50) NOT NULL,
	contraseña VARCHAR(50) NOT NULL,
	perfil_id INT NOT NULL,
	estado_id INT NOT NULL DEFAULT 1 )

ALTER TABLE USUARIO ADD CONSTRAINT FK_USUARIO_PERSONA
FOREIGN KEY (persona_id) REFERENCES PERSONA(persona_id)

ALTER TABLE USUARIO ADD CONSTRAINT FK_USUARIO_PERFIL
FOREIGN KEY (perfil_id) REFERENCES PERFIL(perfil_id)

ALTER TABLE USUARIO ADD CONSTRAINT FK_USUARIO_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 7. Inicio_sesion 
CREATE TABLE INICIO_SESION(
	inicio_sesion_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	usuario_id INT NOT NULL,
	fecha_ultimo_inicio DATETIME,
	estado_id INT NOT NULL DEFAULT 1 );

ALTER TABLE INICIO_SESION ADD CONSTRAINT FK_INICIO_USUARIO
FOREIGN KEY (usuario_id) REFERENCES USUARIO(usuario_id)

ALTER TABLE INICIO_SESION ADD CONSTRAINT FK_INICIO_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 8. Registro 
CREATE TABLE REGISTRO(
	registro_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	usuario_id INT NOT NULL,
	fecha_creacion DATETIME,
	estado_id INT NOT NULL DEFAULT 1 )
	
ALTER TABLE REGISTRO ADD CONSTRAINT FK_REGISTRO_USUARIO
FOREIGN KEY (usuario_id) REFERENCES USUARIO(usuario_id)

ALTER TABLE REGISTRO ADD CONSTRAINT FK_REGISTRO_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 9. Eliminar_Usuario 
CREATE TABLE ELIMINAR_USUARIO(
	eliminar_usuario_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	usuario_id INT NOT NULL,
	fecha_eliminacion DATETIME,
	estado_id INT NOT NULL DEFAULT 1 )

ALTER TABLE ELIMINAR_USUARIO ADD CONSTRAINT FK_ELIMINAR_USUARIO
FOREIGN KEY (usuario_id) REFERENCES USUARIO(usuario_id)

ALTER TABLE ELIMINAR_USUARIO ADD CONSTRAINT FK_ELIMINAR_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

------ PERSONAL ------ 
-- 10. Tipo_Permiso 
CREATE TABLE TIPO_PERMISO(
	tipo_permiso_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(100) not null,
	descripcion varchar(200),	
	estado_id int not null default 1 )

ALTER TABLE TIPO_PERMISO ADD CONSTRAINT FK_TIPO_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 11. Opcion_Aceptar_Rechazar 
CREATE TABLE OPCION_ACEPTAR_RECHAZAR(
	opcion_aceptar_rechazar_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,	
	descripcion varchar(100),
	estado_id int not null default 1 )

ALTER TABLE OPCION_ACEPTAR_RECHAZAR ADD CONSTRAINT FK_OPCION_ACEPTAR_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 12. Perfil_x_Opcion (Acceso y Seguridad) 
CREATE TABLE PERFIL_X_OPCION(
	perfil_x_opcion_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	perfil_id int not null,
	opcion_id int not null,
	estado_id INT NOT NULL DEFAULT 1 )

ALTER TABLE PERFIL_X_OPCION ADD CONSTRAINT FK_PERFILX_PERFIL
FOREIGN KEY (perfil_id) REFERENCES PERFIL(perfil_id)

ALTER TABLE PERFIL_X_OPCION ADD CONSTRAINT FK_PERFILX_OPCION
FOREIGN KEY (opcion_id) REFERENCES OPCION(opcion_id)

ALTER TABLE PERFIL_X_OPCION ADD CONSTRAINT FK_PERFILX_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- XX. Cargo (Eliminada)
CREATE TABLE CARGO(
	cargo_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(100),
	descripcion varchar(200),
	estado_id int not null default 1 )

ALTER TABLE CARGO ADD CONSTRAINT FK_CARGO_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 13. Personal 
CREATE TABLE PERSONAL(
	personal_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	usuario_id int not null,
	direccion_hogar varchar(200),
	cargo_id int not null,
	fecha_contratacion datetime,
	estado_id int not null default 1 )

ALTER TABLE PERSONAL ADD CONSTRAINT FK_PERSONAL_USUARIO
FOREIGN KEY (usuario_id) REFERENCES USUARIO(usuario_id)

ALTER TABLE PERSONAL ADD CONSTRAINT FK_PERSONAL_CARGO
FOREIGN KEY (cargo_id) REFERENCES CARGO(cargo_id)

ALTER TABLE PERSONAL ADD CONSTRAINT FK_PERSONAL_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 14. Solicitud_Permiso 
CREATE TABLE SOLICITUD_PERMISO(
	solicitud_permiso_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	personal_id INT NOT NULL,
	tipo_permiso_id int not null,
	fecha_inicio datetime,
	fecha_fin datetime,
	comentario varchar(250),
	estado_id int not null default 1 )

ALTER TABLE SOLICITUD_PERMISO ADD CONSTRAINT FK_SOLICITUD_PERSONAL
FOREIGN KEY (personal_id) REFERENCES PERSONAL(personal_id)

ALTER TABLE SOLICITUD_PERMISO ADD CONSTRAINT FK_PERSONAL_TIPO
FOREIGN KEY (tipo_permiso_id) REFERENCES TIPO_PERMISO(tipo_permiso_id)

ALTER TABLE SOLICITUD_PERMISO ADD CONSTRAINT FK_SOLICITUD_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 15. Aceptar_Rechazar_Solicitud 
CREATE TABLE ACEPTAR_RECHAZAR_SOLICITUD(
	aceptar_rechazar_solicitud_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,	
	usuario_modificacion_id int not null,
	solicitud_permiso_id int not null,
	opcion_aceptar_rechazar_id int not null,
	estado_id int not null default 1
)

ALTER TABLE ACEPTAR_RECHAZAR_SOLICITUD ADD CONSTRAINT FK_ACEPTAR_USUARIO
FOREIGN KEY (usuario_modificacion_id) REFERENCES USUARIO(usuario_id)

ALTER TABLE ACEPTAR_RECHAZAR_SOLICITUD ADD CONSTRAINT FK_ACEPTAR_SOLICITUD
FOREIGN KEY (solicitud_permiso_id) REFERENCES SOLICITUD_PERMISO(solicitud_permiso_id)

ALTER TABLE ACEPTAR_RECHAZAR_SOLICITUD ADD CONSTRAINT FK_ACEPTAR_OPCION
FOREIGN KEY (opcion_aceptar_rechazar_id) REFERENCES OPCION_ACEPTAR_RECHAZAR(opcion_aceptar_rechazar_id)

ALTER TABLE ACEPTAR_RECHAZAR_SOLICITUD ADD CONSTRAINT FK_ACEPTAR_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

------ PRODUCTO ------ 
-- 16. Categoría 
CREATE TABLE CATEGORIA(
	categoria_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(100) not null,
	descripcion varchar(200),
	estado_id int not null default 1 )

ALTER TABLE CATEGORIA ADD CONSTRAINT FK_CATEGORIA_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 17. Pais 

CREATE TABLE PAIS(
	pais_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(100) not null,	
	estado_id int not null default 1 )

ALTER TABLE PAIS ADD CONSTRAINT FK_PAIS_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 18. Ciudad 
CREATE TABLE CIUDAD(
	ciudad_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(100) not null,	
	pais_id int not null,	
	estado_id int not null default 1 )

ALTER TABLE CIUDAD ADD CONSTRAINT FK_CIUDAD_PAIS
FOREIGN KEY (pais_id) REFERENCES PAIS(pais_id)

ALTER TABLE CIUDAD ADD CONSTRAINT FK_CIUDAD_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 19. Proveedor

CREATE TABLE PROVEEDOR(
	proveedor_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre_empresa varchar(100) not null,
	direccion varchar(250),
	ciudad_id int not null,
	telefono varchar(10),
	correo_electronico varchar(100),
	estado_id int not null default 1 )

ALTER TABLE PROVEEDOR ADD CONSTRAINT FK_PROVEEDOR_CIUDAD
FOREIGN KEY (ciudad_id) REFERENCES CIUDAD(ciudad_id)

ALTER TABLE PROVEEDOR ADD CONSTRAINT FK_PROVEEDOR_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 20. Tipo_Unidad
CREATE TABLE TIPO_UNIDAD(
	tipo_unidad_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	descripcion varchar(200),
	estado_id int not null default 1 )

ALTER TABLE TIPO_UNIDAD ADD CONSTRAINT FK_TIPO_UNIDAD_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

------ BODEGA ------ 
-- 21. Bodega 
CREATE TABLE BODEGA(
	bodega_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(100),
	direccion varchar(200),
	ciudad_id INT NOT NULL,
	tamaño_bodega_m3 numeric(10,2),
	fecha_creacion datetime,
	estado_id int not null default 1 )

ALTER TABLE BODEGA ADD CONSTRAINT FK_BODEGA_CIUDAD
FOREIGN KEY (ciudad_id) REFERENCES CIUDAD(ciudad_id)

ALTER TABLE BODEGA ADD CONSTRAINT FK_BODEGA_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 22. Personal_X_Bodega 
CREATE TABLE PERSONAL_X_BODEGA(
	personal_x_bodega_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	personal_id int not null,
	bodega_id int not null,
	fecha_asignacion datetime,
	fecha_finalizacion datetime,
	estado_id int not null default 1 )

ALTER TABLE PERSONAL_X_BODEGA ADD CONSTRAINT FK_PERSONAL_X_BODEGA_PERSONAL
FOREIGN KEY (personal_id) REFERENCES PERSONAL(personal_id)

ALTER TABLE PERSONAL_X_BODEGA ADD CONSTRAINT FK_PERSONAL_X_BODEGA_BODEGA
FOREIGN KEY (bodega_id) REFERENCES BODEGA(bodega_id)

ALTER TABLE PERSONAL_X_BODEGA ADD CONSTRAINT FK_PERSONAL_X_BODEGA_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 23. Categoria_X_Bodega 
CREATE TABLE CATEGORIA_X_BODEGA(
	categoria_x_bodega_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	categoria_id int not null,
	bodega_id int not null,
	fecha_asociacion datetime,	
	estado_id int not null default 1 )

ALTER TABLE CATEGORIA_X_BODEGA ADD CONSTRAINT FK_CATEGORIA_X_BODEGA_CATEGORIA
FOREIGN KEY (categoria_id) REFERENCES CATEGORIA(categoria_id)

ALTER TABLE CATEGORIA_X_BODEGA ADD CONSTRAINT FK_CATEGORIA_X_BODEGA_BODEGA
FOREIGN KEY (bodega_id) REFERENCES BODEGA(bodega_id)

ALTER TABLE CATEGORIA_X_BODEGA ADD CONSTRAINT FK_CATEGORIA_X_BODEGA_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

------ TRANSACCIONES ------ 
-- 24. Inventario 
CREATE TABLE INVENTARIO(
	inventario_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	bodega_id int not null,
	nombre varchar(100),
	fecha_creacion datetime,
	saldo_final numeric(10,2),
	estado_id int not null default 1 )

ALTER TABLE INVENTARIO ADD CONSTRAINT FK_INVENTARIO_BODEGA
FOREIGN KEY (bodega_id) REFERENCES BODEGA(bodega_id)

ALTER TABLE INVENTARIO ADD CONSTRAINT FK_INVENTARIO_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 25. Producto (Producto) 
CREATE TABLE PRODUCTO(
	producto_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	codigo varchar(10) NOT NULL,
	nombre varchar(100) not null,
	descripcion varchar(200),
	precio_compra numeric(10,2) not null,
	precio_venta numeric(10,2) not null,
	tipo_unidad_id int not null,
	cantidad_minima numeric(10,2) not null,
	cantidad_maxima numeric(10,2) not null,
	categoria_id int not null,
	inventario_id int not null,
	proveedor_id int not null,
	estado_id int not null default 1 )

ALTER TABLE PRODUCTO ADD CONSTRAINT FK_PRODUCTO_TIPO_UNIDAD
FOREIGN KEY (tipo_unidad_id) REFERENCES TIPO_UNIDAD(tipo_unidad_id)

ALTER TABLE PRODUCTO ADD CONSTRAINT FK_PRODUCTO_CATEGORIA
FOREIGN KEY (categoria_id) REFERENCES CATEGORIA(categoria_id)

ALTER TABLE PRODUCTO ADD CONSTRAINT FK_PRODUCTO_INVENTARIO
FOREIGN KEY (inventario_id) REFERENCES INVENTARIO(inventario_id)

ALTER TABLE PRODUCTO ADD CONSTRAINT FK_PRODUCTO_PROVEEDOR
FOREIGN KEY (proveedor_id) REFERENCES PROVEEDOR(proveedor_id)

ALTER TABLE PRODUCTO ADD CONSTRAINT FK_PRODUCTO_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 26. Tipo_Transaccion 
CREATE TABLE TIPO_TRANSACCION(
	tipo_transaccion_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(100) not null,
	estado_id int not null default 1 )

ALTER TABLE TIPO_TRANSACCION ADD CONSTRAINT FK_TIPO_TRANSACCION_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

-- 27. Transaccion
CREATE TABLE TRANSACCION(
	transaccion_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	tipo_transaccion_id int not null,
	personal_x_bodega_id int not null,
	inventario_id int not null,
	fecha_transaccion datetime,
	motivo varchar(200),
	producto_id int not null,
	tipo_unidad_id int not null,
	cantidad numeric(10,2) not null,
	estado_id int not null default 1 )

ALTER TABLE TRANSACCION ADD CONSTRAINT FK_TRANSACCION_TIPO_TRANSACCION
FOREIGN KEY (tipo_transaccion_id) REFERENCES TIPO_TRANSACCION(tipo_transaccion_id)

ALTER TABLE TRANSACCION ADD CONSTRAINT FK_TRANSACCION_PERSONAL_X_BODEGA
FOREIGN KEY (personal_x_bodega_id) REFERENCES PERSONAL_X_BODEGA(personal_x_bodega_id)

ALTER TABLE TRANSACCION ADD CONSTRAINT FK_TRANSACCION_PRODUCTO
FOREIGN KEY (producto_id) REFERENCES PRODUCTO(producto_id)

ALTER TABLE TRANSACCION ADD CONSTRAINT FK_TRANSACCION_TIPO_UNIDAD
FOREIGN KEY (tipo_unidad_id) REFERENCES TIPO_UNIDAD(tipo_unidad_id)

ALTER TABLE TRANSACCION ADD CONSTRAINT FK_TRANSACCION_INVENTARIO
FOREIGN KEY (inventario_id) REFERENCES INVENTARIO(inventario_id)

ALTER TABLE TRANSACCION ADD CONSTRAINT FK_TRANSACCION_TIPO_ESTADO
FOREIGN KEY (estado_id) REFERENCES ESTADO(estado_id)

COMMIT