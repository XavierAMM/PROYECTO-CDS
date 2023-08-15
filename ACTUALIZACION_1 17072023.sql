-- A�ADIR EL NOMBRE DE LA BASE DE DATOS AQUI
USE PROYECTO_CDS;

BEGIN TRANSACTION
-- A�adir datos a la tabla ESTADO
GO
INSERT INTO ESTADO (nombre, letra, descripcion) VALUES
('Activo', 'A', 'Cuando el objeto est� funcionando'),
('Inactivo', 'I', 'Cuando el objeto no est� funcionando'),
('Pendiente', 'P', 'Cuando el objeto est� pendiente de revisi�n/aceptaci�n'),
('Rechazado', 'R', 'Cuando el objeto ha sido rechazado'),
('Finalizado', 'F', 'Cuando el objeto ha finalizado el tiempo de duraci�n'),
('Aceptado', 'A', 'Cuando el objeto ha sido aceptado');

-- A�adir datos a la tabla MODULO
GO
INSERT INTO MODULO (nombre, nombre_objeto, estado_id) VALUES
('Usuario', 'objModUsuarios', default),
('Personal', 'objModPersonal', default),
('Bodega', 'objModBodegas', default),
('Producto', 'objModProductos', default),
('Proveedor', 'objModProveedores', default),
('Transacci�n', 'objModTransacciones', default),
('Inventario', 'objModInventarios', default),
('Acceso y Seguridad', 'objModAccesoSeguridad', default);

-- A�adir datos a la tabla OPCION
GO
INSERT INTO OPCION (nombre, descripcion, modulo_id, nombre_objeto, estado_id) VALUES
	-- M�dulo Usuarios
('Ver Usuario','Muetra la informaci�n del usuario actual',1,'objOpcVerUsuario',default),
('Lista Usuarios','Revisa toda la lista de usuarios',1,'objOpcListaUsuarios',default),
('Modificar Usuarios','Crea, edita y elimina usuarios de la lista',1,'objOpcModificarUsuarios',default),
	-- M�dulo Personales
('Lista Personal','Revisa toda la lista de personales',2,'objOpcListaPersonales',default),
('Modificar Personal','Crea, edita y elimina personales de la lista',2,'objOpcModificarPersonales',default),
('Asignar Perfil','Asigna perfiles a los usuarios',2,'objOpcAsignarPerfil',default),
('Registrar Solicitud','Registra una solicitud de permiso en estado pendiente',2,'objOpcRegistrarSolicitud',default),
('Aprobar/Rechazar Solicitud','Aprueba o rechaza una solicitud mandada',2,'objOpcAceptarRechazarSolicitud',default),
	-- M�dulo Bodegas
('Lista Bodegas','Revisa toda la lista de Bodegas',3,'objOpcListaBodegas',default),
('Modificar Bodega','Crea, edita y elimina Bodegas de la lista',3,'objOpcModificarBodegas',default),
('Asignar Personal','Asigna un personal a una bodega',3,'objOpcAsignarPersonal',default),
('Asignar Categor�a','Asigna una categor�a a una bodega',3,'objOpcAsignarCategoria',default),
	-- M�dulo Productos
('Lista Productos','Revisa toda la lista de Productos',4,'objOpcListaProductos',default),
('Modificar Productos','Crea, edita y elimina Productos de la lista',4,'objOpcModificarProductos',default),
	-- M�dulo Proveedores
('Lista Proveedores','Revisa toda la lista de Proveedores',5,'objOpcListaProveedores',default),
('Modificar Proveedores','Crea, edita y elimina Proveedores de la lista',5,'objOpcModificarProveedores',default),
	-- M�dulo Transacciones
('Lista Transacciones','Revisa toda la lista de Transacciones',6,'objOpcListaTransacciones',default),
('Registrar Transacci�n','Registra una nueva Transacci�n a la lista',6,'objOpcRegistrarTransaccion',default),
('Modificar Transacciones','Edita y elimina Transacciones espec�ficas',6,'objOpcModificarTransacciones',default),
	-- M�dulo Inventarios
('Lista Inventarios','Revisa toda la lista de Inventarios',7,'objOpcListaInventarios',default),
('Modificar Inventarios','Crea, edita y elimina Inventarios de la lista',7,'objOpcModificarInventarios',default),
	-- M�dulo Acceso y Seguridad
('Modificar M�dulos','Crea, edita y elimina m�dulos',8,'objOpcModificarModulos',default),
('Modificar Opciones','Crea, edita y elimina opciones',8,'objOpcModificarOpciones',default),
('Modificar Perfiles','Crea, edita y elimina perfiles de usuarios',8,'objOpcModificarPerfiles',default),
('Opciones a Perfil','Asigna opciones de m�dulos a un perfil',8,'objOpcOpcionesPerfil',default);

-- A�adir datos a la tabla PERFIL
GO
INSERT INTO PERFIL (nombre, descripcion, estado_id) VALUES
('Consultor', 'Perfil por defecto, solo visualiza los elementos del programa', default),
('Moderador', 'Manejar� los usuarios del programa junto con los proveedores de los productos', default),
('Supervisor del Personal', 'Perfil encargado de la gesti�n y supervisi�n del personal',default),
('Encargado de Bodegas', 'Perfil responsable de la gesti�n de las bodegas, con permisos para ver y modificar informaci�n de las bodegas', default),
('Analista de Inventarios', 'Perfil encargado del an�lisis y gesti�n de los productos y el inventario,', default),
('Supervisor de Transacciones', 'Perfil responsable de la supervisi�n y gesti�n de las transacciones', default),
('Gestor de Acceso y Seguridad', 'Perfil encargado de la administraci�n del acceso y la seguridad del sistema', default),
('Administrador', 'Tiene acceso total a todas las funciones del programa', default);

-- A�adir datos a la tabla PERFIL_X_OPCION
GO
INSERT INTO PERFIL_X_OPCION (perfil_id, opcion_id, estado_id) VALUES
	--CONSULTOR
(1,1,default),
(1,2,default),
(1,4,default),
(1,9,default),
(1,13,default),
(1,15,default),
(1,17,default),
(1,20,default),
	-- MODERADOR
(2,1,default),
(2,2,default),
(2,3,default),
(2,3,default),
(2,4,default),
(2,7,default),
(2,9,default),
(2,13,default),
(2,15,default),
(2,16,default),
(2,17,default),
(2,20,default),
	-- SUPERVISOR DE PERSONAL
(3,1,default),
(3,2,default),
(3,4,default),
(3,5,default),
(3,6,default),
(3,7,default),
(3,8,default),
(3,9,default),
(3,13,default),
(3,15,default),
(3,17,default),
(3,20,default),
	-- ENCARGADO DE BODEGAS
(4,1,default),
(4,2,default),
(4,4,default),
(4,7,default),
(4,9,default),
(4,10,default),
(4,11,default),
(4,12,default),
(4,13,default),
(4,15,default),
(4,17,default),
(4,20,default),
	-- ANALISTA DE INVENTARIOS
(5,1,default),
(5,2,default),
(5,4,default),
(5,7,default),
(5,9,default),
(5,13,default),
(5,14,default),
(5,15,default),
(5,17,default),
(5,20,default),
(5,21,default),
	-- SUPERVISOR DE TRANSACCIONES
(6,1,default),
(6,2,default),
(6,4,default),
(6,7,default),
(6,9,default),
(6,13,default),
(6,15,default),
(6,17,default),
(6,18,default),
(6,19,default),
(6,20,default),
	-- GESTOR DE ACCESO Y SEGURIDAD
(7,1,default),
(7,2,default),
(7,4,default),
(7,7,default),
(7,9,default),
(7,13,default),
(7,15,default),
(7,17,default),
(7,20,default),
(7,22,default),
(7,23,default),
(7,24,default),
(7,25,default),
	-- ADMINISTRADOR
(8,1,default),
(8,2,default),
(8,3,default),
(8,4,default),
(8,5,default),
(8,6,default),
(8,7,default),
(8,8,default),
(8,9,default),
(8,10,default),
(8,11,default),
(8,12,default),
(8,13,default),
(8,14,default),
(8,15,default),
(8,16,default),
(8,17,default),
(8,18,default),
(8,19,default),
(8,20,default),
(8,21,default),
(8,22,default),
(8,23,default),
(8,24,default),
(8,25,default);

COMMIT