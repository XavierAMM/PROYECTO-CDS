use PROYECTO_CDS;

GO
CREATE PROCEDURE PD_OBTENER_MODULOS_MODO
@modo int
as
begin
	if(@modo = 0) begin
		select m.modulo_id, m.nombre, m.nombre_objeto, e.nombre as estado, m.orden, m.estado_id
		from modulo m
		join ESTADO e on e.estado_id = m.estado_id
		where m.estado_id = 1
		order by m.orden
	end else if @modo = 1 begin
		select m.modulo_id, m.nombre, m.nombre_objeto, e.nombre as estado, m.orden, m.estado_id
		from modulo m
		join ESTADO e on e.estado_id = m.estado_id	
		order by m.estado_id, m.orden
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
		select m.modulo_id, m.nombre, m.nombre_objeto, e.nombre as estado, m.orden, m.estado_id
		from modulo m
		join ESTADO e on e.estado_id = m.estado_id
		where m.estado_id = 1 and (m.nombre like '%'+ @nombre+ '%' or m.nombre_objeto like '%'+ @nombre+'%')
		order by m.orden
	end else if @modo = 1 begin
		select m.modulo_id, m.nombre, m.nombre_objeto, e.nombre as estado, m.orden, m.estado_id
		from modulo m
		join ESTADO e on e.estado_id = m.estado_id
		where m.nombre like '%'+ @nombre+ '%' or m.nombre_objeto like '%'+ @nombre+'%'
		order by m.estado_id, m.orden
	end
end

----------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE PD_OBTENER_OPCIONES_MODO
@modo int
as
begin
	if @modo = 0 begin
		select o.opcion_id, o.nombre, o.nombre_objeto, m.nombre as modulo, o.descripcion, e.nombre as estado, o.modulo_id, o.estado_id,  o.orden
		from opcion o
		join modulo m on m.modulo_id = o.modulo_id
		join estado e on e.estado_id = o.estado_id
		where o.estado_id = 1
		order by o.orden
	end else if @modo = 1 begin
		select o.opcion_id, o.nombre, o.nombre_objeto, m.nombre as modulo, o.descripcion, e.nombre as estado, o.modulo_id, o.estado_id,  o.orden
		from opcion o
		join modulo m on m.modulo_id = o.modulo_id
		join estado e on e.estado_id = o.estado_id		
		order by o.estado_id, o.orden
	end
end

GO
CREATE PROCEDURE PD_OBTENER_OPCIONES_FILTRAR
@modo int, @nombre varchar(50)
as
begin
	if @modo = 0 begin
		select o.opcion_id, o.nombre, o.nombre_objeto, m.nombre as modulo, o.descripcion, e.nombre as estado, o.modulo_id, o.estado_id,  o.orden
		from opcion o
		join modulo m on m.modulo_id = o.modulo_id
		join estado e on e.estado_id = o.estado_id
		where o.estado_id = 1 and (o.nombre like '%' + @nombre + '%' or o.nombre_objeto like '%' + @nombre + '%' or o.descripcion like '%' + @nombre + '%' or m.nombre like '%' + @nombre + '%')
		order by o.orden
	end else if @modo = 1 begin
		select o.opcion_id, o.nombre, o.nombre_objeto, m.nombre as modulo, o.descripcion, e.nombre as estado, o.modulo_id, o.estado_id,  o.orden
		from opcion o
		join modulo m on m.modulo_id = o.modulo_id
		join estado e on e.estado_id = o.estado_id
		where o.nombre like '%' + @nombre + '%' or o.nombre_objeto like '%' + @nombre + '%' or o.descripcion like '%' + @nombre + '%' or m.nombre like '%' + @nombre + '%'
		order by o.estado_id, o.orden
	end
end

GO
CREATE PROCEDURE PD_AGREGAR_OPCION
@nombre varchar(50), @nombre_objeto varchar(50), @descripcion varchar(250), @modulo_id int, @orden int
as
begin
	declare @opcion_id int
	INSERT INTO opcion (nombre, nombre_objeto, descripcion, modulo_id, orden, estado_id) values
	(@nombre, @nombre_objeto, @descripcion, @modulo_id, @orden, 1)
	set @opcion_id = SCOPE_IDENTITY()
	INSERT INTO PERFIL_X_OPCION (perfil_id, opcion_id, estado_id) values
	(7, @opcion_id, 1)
end

GO
CREATE PROCEDURE PD_EDITAR_OPCION
@opcion_id int, @nombre varchar(50), @nombre_objeto varchar(50), @descripcion varchar(250), @modulo_id int, @orden int
as
begin
	update opcion set nombre = @nombre, nombre_objeto = @nombre_objeto, descripcion = @descripcion, modulo_id = @modulo_id, @orden = orden 
	where opcion_id = @opcion_id
end

GO
CREATE PROCEDURE PD_INACTIVAR_ACTIVAR_OPCION
@accion int, @opcion_id int
as
begin
	if @accion = 1 begin -- inactivar
		update OPCION set estado_id = 2 where opcion_id= @opcion_id
	end else if @accion = 2 begin -- activar
		update OPCION set estado_id = 1 where opcion_id= @opcion_id
	end
end

----------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------

GO
CREATE PROCEDURE PD_OBTENER_PERFILES_MODO
@modo int
as
begin
	if @modo = 0 begin
		select p.perfil_id, p.nombre, p.descripcion, e.nombre as estado, p.prioridad, p.estado_id 
		from perfil p
		join estado e on e.estado_id = p.estado_id
		where p.estado_id = 1
		order by p.prioridad
	end else if @modo = 1 begin
		select p.perfil_id, p.nombre, p.descripcion, e.nombre as estado, p.prioridad, p.estado_id 
		from perfil p
		join estado e on e.estado_id = p.estado_id		
		order by p.estado_id, p.prioridad 
	end
end

GO
CREATE PROCEDURE PD_OBTENER_PERFILES_FILTRAR
@modo int, @nombre varchar(50)
as
begin
	if @modo = 0 begin
		select p.perfil_id, p.nombre, p.descripcion, e.nombre as estado, p.prioridad, p.estado_id 
		from perfil p
		join estado e on e.estado_id = p.estado_id
		where p.estado_id = 1 and (p.nombre like '%' + @nombre + '%' or p.descripcion like '%' + @nombre + '%')
		order by p.prioridad
	end else if @modo = 1 begin
		select p.perfil_id, p.nombre, p.descripcion, e.nombre as estado, p.prioridad, p.estado_id 
		from perfil p
		join estado e on e.estado_id = p.estado_id
		where p.nombre like '%' + @nombre + '%' or p.descripcion like '%' + @nombre + '%'
		order by p.estado_id, p.prioridad 
	end
end


GO
CREATE PROCEDURE PD_AGREGAR_PERFIL
@nombre varchar(50), @descripcion varchar(250), @prioridad int
as
begin	
	insert into perfil (nombre, descripcion, estado_id, prioridad) values
	(@nombre, @descripcion, 1, @prioridad)
end

GO
CREATE PROCEDURE PD_EDITAR_PERFIL
@perfil_id int, @nombre varchar(50), @descripcion varchar(250), @prioridad int
as
begin
	update perfil set nombre = @nombre, descripcion = @descripcion, prioridad = @prioridad
	where perfil_id = @perfil_id
end

GO
CREATE PROCEDURE PD_INACTIVAR_ACTIVAR_PERFIL
@accion int, @perfil_id int
as
begin
	if @accion = 1 begin -- inactivar
		update perfil set estado_id = 2 where perfil_id= @perfil_id
	end else if @accion = 2 begin -- activar
		update PERFIL set estado_id = 1 where perfil_id= @perfil_id
	end
end

----------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------
GO
CREATE PROCEDURE PD_OBTENER_PERFIL_X_OPCION_MODO
@modo int
as
begin
	if @modo = 0 begin
		SELECT pxo.perfil_x_opcion_id, p.nombre as perfil, m.nombre as modulo, o.nombre as opcion, e.nombre as estado,
		pxo.perfil_id, m.modulo_id, pxo.opcion_id, pxo.estado_id
		FROM PERFIL_X_OPCION pxo
		JOIN perfil p on p.perfil_id = pxo.perfil_id
		JOIN opcion o on o.opcion_id = pxo.opcion_id
		JOIN modulo m on m.modulo_id = o.modulo_id
		JOIN estado e on e.estado_id = pxo.estado_id
		where pxo.estado_id = 1		
		order by pxo.perfil_id
	end else if @modo = 1 begin
		SELECT pxo.perfil_x_opcion_id, p.nombre as perfil, m.nombre as modulo, o.nombre as opcion, e.nombre as estado,
		pxo.perfil_id, m.modulo_id, pxo.opcion_id, pxo.estado_id
		FROM PERFIL_X_OPCION pxo
		JOIN perfil p on p.perfil_id = pxo.perfil_id
		JOIN opcion o on o.opcion_id = pxo.opcion_id
		JOIN modulo m on m.modulo_id = o.modulo_id
		JOIN estado e on e.estado_id = pxo.estado_id		
		order by pxo.estado_id, pxo.perfil_id
	end
end


GO
CREATE PROCEDURE PD_OBTENER_PERFILES_X_OPCION_FILTRAR
@modo int, @nombre varchar(50)
as
begin
	if @modo = 0 begin
		SELECT pxo.perfil_x_opcion_id, p.nombre as perfil, m.nombre as modulo, o.nombre as opcion, e.nombre as estado,
		pxo.perfil_id, m.modulo_id, pxo.opcion_id, pxo.estado_id
		FROM PERFIL_X_OPCION pxo
		JOIN perfil p on p.perfil_id = pxo.perfil_id
		JOIN opcion o on o.opcion_id = pxo.opcion_id
		JOIN modulo m on m.modulo_id = o.modulo_id
		JOIN estado e on e.estado_id = pxo.estado_id
		where pxo.estado_id = 1 and (p.nombre like '%'+@nombre+'%' or m.nombre like '%'+@nombre+'%' or o.nombre like '%'+@nombre+'%')
		order by pxo.perfil_id
	end else if @modo = 1 begin
		SELECT pxo.perfil_x_opcion_id, p.nombre as perfil, m.nombre as modulo, o.nombre as opcion, e.nombre as estado,
		pxo.perfil_id, m.modulo_id, pxo.opcion_id, pxo.estado_id
		FROM PERFIL_X_OPCION pxo
		JOIN perfil p on p.perfil_id = pxo.perfil_id
		JOIN opcion o on o.opcion_id = pxo.opcion_id
		JOIN modulo m on m.modulo_id = o.modulo_id
		JOIN estado e on e.estado_id = pxo.estado_id
		where p.nombre like '%'+@nombre+'%' or m.nombre like '%'+@nombre+'%' or o.nombre like '%'+@nombre+'%'
		order by pxo.estado_id, pxo.perfil_id
	end
end

GO
CREATE PROCEDURE PD_AGREGAR_PERFIL_X_OPCION
@perfil_id varchar(50), @opcion_id varchar(250)
as
begin	
	insert into PERFIL_X_OPCION (perfil_id, opcion_id, estado_id) values
	(@perfil_id, @opcion_id, 1)
end

GO
CREATE PROCEDURE PD_EDITAR_PERFIL_X_OPCION
@perfil_x_opcion_id int, @perfil_id varchar(50), @opcion_id varchar(250)
as
begin
	update PERFIL_X_OPCION set perfil_id = @perfil_id, opcion_id = @opcion_id
	where perfil_x_opcion_id = @perfil_x_opcion_id
end

GO
CREATE PROCEDURE PD_INACTIVAR_ACTIVAR_PERFIL_X_OPCION
@accion int, @perfil_x_opcion_id int
as
begin
	if @accion = 1 begin -- inactivar
		update PERFIL_X_OPCION set estado_id = 2 where perfil_x_opcion_id= @perfil_x_opcion_id
	end else if @accion = 2 begin -- activar
		update PERFIL_X_OPCION set estado_id = 1 where perfil_x_opcion_id = @perfil_x_opcion_id
	end
end

GO
CREATE PROCEDURE PD_PERFIL_NO_ADMIN
@modo int
as
begin
	SELECT * FROM PERFIL WHERE estado_id = 1 and perfil_id <> 7
end

GO
CREATE PROCEDURE PD_EVALUAR_NUEVO_PERFIL_X_OPCION
@perfil_id int, @opcion_id int, @result int output
as
begin
	set @result = 0
	declare @estado_id int
	-- RESULT 0 (Es único) , 1 (No es único), -1 (Se encuentra inactivo)
	SELECT @estado_id = estado_id FROM PERFIL_X_OPCION WHERE perfil_id = @perfil_id and opcion_id = @opcion_id
	if @@ROWCOUNT > 0 begin
		if @estado_id = 2 begin
			set @result = -1
		end else begin
			set @result = 1
		end
	end
end
----------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------
GO
CREATE PROCEDURE PD_OBTENER_USUARIO_MODO
@modo int
as
begin
	if @modo = 0 begin
		select u.usuario_id, u.usuario, p.nombre1 as nombre, p.apellido1 as apellido, p.telefono, p.correo_electronico, p.fecha_nacimiento, pe.direccion_hogar, pf.nombre as perfil, e.nombre as estado,
		u.persona_id, pe.personal_id, pf.perfil_id, e.estado_id
		from USUARIO u
		join persona p on p.persona_id = u.persona_id
		join personal pe on pe.usuario_id = u.usuario_id 
		join perfil pf on pf.perfil_id = pe.perfil_id
		join estado e on e.estado_id = u.estado_id
		where u.estado_id = 1		
	end else if @modo = 1 begin
		select u.usuario_id, u.usuario, p.nombre1 as nombre, p.apellido1 as apellido, p.telefono, p.correo_electronico, p.fecha_nacimiento, pe.direccion_hogar, pf.nombre as perfil, e.nombre as estado,
		u.persona_id, pe.personal_id, pf.perfil_id, e.estado_id
		from USUARIO u
		join persona p on p.persona_id = u.persona_id
		join personal pe on pe.usuario_id = u.usuario_id 
		join perfil pf on pf.perfil_id = pe.perfil_id
		join estado e on e.estado_id = u.estado_id
		order by u.estado_id
	end
end


GO
CREATE PROCEDURE PD_OBTENER_USUARIOS_FILTRAR
@modo int, @nombre varchar(50)
as
begin
	if @modo = 0 begin
		select u.usuario_id, u.usuario, p.nombre1 as nombre, p.apellido1 as apellido, p.telefono, p.correo_electronico, p.fecha_nacimiento, pe.direccion_hogar, pf.nombre as perfil, e.nombre as estado,
		u.persona_id, pe.personal_id, pf.perfil_id, e.estado_id
		from USUARIO u
		join persona p on p.persona_id = u.persona_id
		join personal pe on pe.usuario_id = u.usuario_id 
		join perfil pf on pf.perfil_id = pe.perfil_id
		join estado e on e.estado_id = u.estado_id
		where u.estado_id = 1 and (u.usuario like '%'+@nombre+'%' or p.nombre1 like '%'+@nombre+'%' or p.apellido1 like '%'+@nombre+'%' or pf.nombre like '%'+@nombre+'%')
	end else if @modo = 1 begin
		select u.usuario_id, u.usuario, p.nombre1 as nombre, p.apellido1 as apellido, p.telefono, p.correo_electronico, p.fecha_nacimiento, pe.direccion_hogar, pf.nombre as perfil, e.nombre as estado,
		u.persona_id, pe.personal_id, pf.perfil_id, e.estado_id
		from USUARIO u
		join persona p on p.persona_id = u.persona_id
		join personal pe on pe.usuario_id = u.usuario_id 
		join perfil pf on pf.perfil_id = pe.perfil_id		
		join estado e on e.estado_id = u.estado_id
		where u.usuario like '%'+@nombre+'%' or p.nombre1 like '%'+@nombre+'%' or p.apellido1 like '%'+@nombre+'%' or pf.nombre like '%'+@nombre+'%'
		order by u.estado_id
	end
end

GO
CREATE PROCEDURE PD_INACTIVAR_ACTIVAR_USUARIO
@accion int, @usuario_id int
as
begin
	if @accion = 1 begin -- inactivar
		update USUARIO set estado_id = 2 where usuario_id = @usuario_id
	end else if @accion = 2 begin -- activar
		update USUARIO set estado_id = 1 where usuario_id = @usuario_id
	end
end

----------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------
GO
CREATE PROCEDURE PD_EDITAR_USUARIO
@usuario_id int, @usuario varchar(50), @contraseña varchar(50),
@nombre1 varchar(50), @apellido1 varchar(50), @telefono varchar(10), @correo_electronico varchar(100), @fecha_nacimiento date,
@direccion_hogar varchar(200)
as
begin
	declare @persona_id int
	select @persona_id = persona_id from usuario where usuario_id = @usuario_id
	UPDATE USUARIO set
		usuario = @usuario,
		contraseña = @contraseña
	WHERE usuario_id = @usuario_id

	UPDATE PERSONA set
		nombre1 = @nombre1,
		apellido1 = @apellido1,
		telefono = @telefono,
		correo_electronico = @correo_electronico,
		fecha_nacimiento = @fecha_nacimiento
	where persona_id = @persona_id

	update personal set direccion_hogar = @direccion_hogar where usuario_id = @usuario_id
end


GO
CREATE PROCEDURE PD_EVALUAR_EDITAR_NOMBRE_USUARIO_UNICO
@usuario varchar(50), @usuario_id int, @result int output
as
begin
	SET NOCOUNT ON;
    
    IF EXISTS (SELECT 1 FROM usuario WHERE usuario = @usuario and usuario_id <> @usuario_id)
        SET @result = 0
    ELSE
        SET @result = 1
end




