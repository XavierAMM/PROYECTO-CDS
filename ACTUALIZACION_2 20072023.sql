-- AÑADIR EL NOMBRE DE LA BASE DE DATOS AQUI
USE PROYECTO_CDS;

BEGIN TRANSACTION 
-- 1. Eliminar tabla campo cargo_id en personal por perfil_id
	-- Eliminar clave foránea en personal
	ALTER TABLE PERSONAL DROP CONSTRAINT FK_PERSONAL_CARGO
	-- Eliminar el campo cargo_id
	ALTER TABLE PERSONAL DROP COLUMN CARGO_ID 
	-- Añadir nuevo campo perfil_id
	ALTER TABLE PERSONAL ADD perfil_id INT NOT NULL
	-- Añadir propiedad de clave foránea al nuevo perfil_id
	ALTER TABLE PERSONAL ADD CONSTRAINT FK_PERSONAL_PERFIL
	FOREIGN KEY (PERFIL_ID) REFERENCES PERFIL(PERFIL_ID)
	
-- 2. Eliminar tabla cargo
	DROP TABLE CARGO;
	
-- 3. Cambiar nombre de campo en personal de "fecha_contratacion" a "fecha_asignacion"
	-- Agregar una nueva columna con el nuevo nombre
	ALTER TABLE PERSONAL ADD fecha_asignacion DATE;	
	-- Eliminar la columna antigua
	ALTER TABLE PERSONAL DROP COLUMN fecha_contratacion;

-- 4. Eliminar el campo perfil_id a la tabla usuario
	-- Eliminar la clave foránea
	ALTER TABLE USUARIO DROP CONSTRAINT FK_USUARIO_PERFIL
	-- Eliminar el campo perfil_id
	ALTER TABLE USUARIO DROP COLUMN perfil_id
		
-- 5. Modificar tabla de Perfil_X_Opcion
	-- Eliminar los datos de la tabla Perfil_X_Opcion
	DELETE FROM PERFIL_X_OPCION 
	-- Eliminar el identity y ponerlo en 0, después reactivarlo
	SET IDENTITY_INSERT PERFIL_X_OPCION ON  
	DBCC CHECKIDENT ('PERFIL_X_OPCION', RESEED, 0)	
	SET IDENTITY_INSERT PERFIL_X_OPCION OFF 
	-- Añadir nuevos datos a la tabla	
	INSERT INTO PERFIL_X_OPCION (perfil_id, opcion_id) VALUES
		--Consultor
		(1,2),  -- Ver Movimientos
		(1,3),  -- Ver Productos*
		(1,6),  -- Ver Inventarios*
		(1,7),  -- Ver Bodegas*
		(1,9),  -- Solicitud de Permiso*
		(1,10),  -- Mi perfil
		(1,12), -- Ayuda
		(1,13), -- Cerrar Sesión
		--Supervisor de bodega
		(2,2),  -- Ver Movimientos
		(2,3),  -- Ver Productos*
		(2,6),  -- Inventarios
		(2,7),  -- Bodegas
		(2,9),  -- Solicitud de Permiso*
		(2,10),  -- Mi perfil
		(2,12), -- Ayuda
		(2,13), -- Cerrar Sesión 
		--Supervisor de personal
		(3,2),  -- Ver Movimientos
		(3,3),  -- Ver Productos*
		(1,6),  -- Ver Inventarios*
		(3,8),  -- Asignar Cargo (No puede asignar un cargo mayor o igual al suyo)
		(3,9),  -- Solicitud de Permiso (Aceptar/Rechazar)
		(3,10),  -- Mi perfil
		(3,12), -- Ayuda
		(3,13), -- Cerrar Sesión
		--Gestor de Transacciones
		(4,1),  -- Transacciones
		(4,2),  -- Ver Movimientos
		(4,3),  -- Ver Productos*
		(4,6),  -- Ver Inventarios*
		(4,9),  -- Solicitud de Permiso*
		(4,10),  -- Mi perfil
		(4,12), -- Ayuda
		(4,13), -- Cerrar Sesión
		--Supervisor de Productos
		(5,2),  -- Ver Movimientos
		(5,3),  -- Productos
		(5,4),  -- Categorias
		(5,5),  -- Proveedores
		(5,6),  -- Ver Inventarios*
		(5,9),  -- Solicitud de Permiso*
		(5,10),  -- Mi perfil
		(5,12), -- Ayuda
		(5,13), -- Cerrar Sesión
		--Moderador
		(6,1),  -- Transacciones
		(6,2),  -- Ver Movimientos
		(6,3),  -- Productos
		(6,4),  -- Categorias
		(6,5),  -- Proveedores
		(6,6),  -- Inventarios
		(6,7),  -- Bodegas
		(6,8),  -- Asignar Cargo (No puede asignar un cargo mayor o igual al suyo)
		(6,9),  -- Solicitud de Permiso (Aceptar/Rechazar)
		(6,10),  -- Mi perfil
		(6,11),  -- Sistema* (Solo Cargos y Usuarios)
		(6,12), -- Ayuda
		(6,13), -- Cerrar Sesión
		--Moderador
		(7,1),  -- Transacciones
		(7,2),  -- Ver Movimientos
		(7,3),  -- Productos
		(7,4),  -- Categorias
		(7,5),  -- Proveedores
		(7,6),  -- Inventarios
		(7,7),  -- Bodegas
		(7,8),  -- Asignar Cargo (No puede asignar un cargo mayor o igual al suyo)
		(7,9),  -- Solicitud de Permiso (Aceptar/Rechazar)
		(7,10),  -- Mi perfil
		(7,11),  -- Sistema (Solo Cargos y Usuarios)
		(7,12), -- Ayuda
		(7,13) -- Cerrar Sesión 
				
-- 6. Modificar tabla de Opcion
	-- Eliminamos el constraint en perfil_x_opcion
	ALTER TABLE PERFIL_X_OPCION DROP CONSTRAINT FK_PERFILX_OPCION
	-- Eliminar los datos de la tabla Opcion
	DELETE FROM OPCION
	-- Eliminar el identity y ponerlo en 0, después reactivarlo
	SET IDENTITY_INSERT OPCION ON 
	DBCC CHECKIDENT ('OPCION', RESEED, 0)	
	SET IDENTITY_INSERT OPCION OFF		
	-- Añadir nuevos datos a la tabla	
	INSERT INTO OPCION  (nombre, nombre_objeto, descripcion, modulo_id) VALUES
	('Transacciones','objOpcTransacciones','',1),
	('Ver Movimientos','objOpcVerMovimientos','',1),
	('Productos','objOpcProductos','',2),
	('Categorias','objOpcCategorias','',2),
	('Proveedores','objOpcProveedores','',2),
	('Inventarios','objOpcInventarios','',3),
	('Bodegas','objOpcBodegas','',3),
	('Asignar Cargo','objOpcAsignarCargo','',4),
	('Solicitud de Permiso','objOpcSolicitudDePermiso','',4),
	('Mi Perfil','objOpcMiPerfil','',5),
	('Sistema','objOpcSistema','',5),
	('Ayuda','objOpcAyuda','',5),
	('Cerrar Sesión','objOpcCerrarSesion','',5)	
	-- Volvemos a crear el constraint en perfil_x_opcion
	ALTER TABLE PERFIL_X_OPCION ADD CONSTRAINT FK_PERFILX_OPCION
	FOREIGN KEY (opcion_id) REFERENCES OPCION(opcion_id)		
	
-- 7. Modificar tabla de Modulo
	-- Eliminar foreign key de opcion
	ALTER TABLE OPCION DROP CONSTRAINT FK_OPCION_MODULO
	-- Eliminar los datos de la tabla Modulo
	DELETE FROM MODULO
	-- Eliminar el identity y ponerlo en 0, después reactivarlo	
	SET IDENTITY_INSERT MODULO ON
	DBCC CHECKIDENT ('MODULO', RESEED, 0)
	SET IDENTITY_INSERT MODULO OFF; 
	-- Añadir nuevos datos a la tabla	
	INSERT INTO MODULO (nombre, nombre_objeto) VALUES
	('Transacciones','objModTransacciones'),
	('Productos','objModProductos'),
	('Inventarios','objModInventarios'),
	('Personal','objModPersonal'),
	('Opciones','objModOpciones')  	
	-- Añadir la foreign key de opcion
	ALTER TABLE OPCION ADD CONSTRAINT FK_OPCION_MODULO
	FOREIGN KEY (modulo_id) REFERENCES MODULO(modulo_id)  			

-- 8. Modificar tabla de Perfil	con los nuevos datos	
	-- Eliminamos clave foránea de perfil_x_opcion
	ALTER TABLE PERFIL_X_OPCION DROP CONSTRAINT FK_PERFILX_PERFIL
	-- Eliminar los datos de la tabla Perfil	
	DELETE FROM PERFIL
	-- Eliminar el identity y ponerlo en 0, después reactivarlo
	SET IDENTITY_INSERT PERFIL ON 
	DBCC CHECKIDENT ('PERFIL', RESEED, 0)	
	SET IDENTITY_INSERT PERFIL OFF	
	-- Añadir nuevos datos a la tabla	
	INSERT INTO PERFIL (nombre, descripcion) VALUES
	('Consultor','Perfil por defecto, solo visualiza los elementos del programa'),
	('Supervisor de Bodega','Perfil responsable de la gestión de las bodegas, con permisos para ver y modificar información de las bodegas'),
	('Supervisor de Personal','Perfil encargado de la gestión y supervisión del personal'),
	('Gestor de Transacciones','Perfil responsable de la supervisión y gestión de las transacciones'),
	('Supervisor de Productos','Perfil responsable de la supervisión y gestión de los productos'),
	('Moderador','Perfil con casi todas las opciones disponibles'),
	('Administrador','Tiene acceso total a todas las funciones del programa')	
	-- Añadir la clave foránea en perfil_x_opcion
	ALTER TABLE PERFIL_X_OPCION ADD CONSTRAINT FK_PERFILX_PERFIL
	FOREIGN KEY (perfil_id) REFERENCES PERFIL(perfil_id)

COMMIT