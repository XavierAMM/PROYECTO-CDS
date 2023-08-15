USE PROYECTO_CDS;


GO
CREATE PROCEDURE PD_VALIDAR_INICIO_SESION
	@usuario varchar(50), @contraseña varchar(50), @result int OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @estado_id int;
    DECLARE @usuario_id int;
    
    SET @result = 0;
    
    SELECT @estado_id = estado_id, @usuario_id = usuario_id
    FROM USUARIO WHERE usuario = @usuario AND contraseña = @contraseña;
    
    IF @@ROWCOUNT > 0
    BEGIN        
        IF @estado_id = 1        
            SET @result = @usuario_id;		
		ELSE IF @estado_id = 2         
            SET @result = -1;        
    END
END;


GO
CREATE PROCEDURE PD_OBTENER_USUARIO
@usuario_id int
AS
BEGIN
		SELECT U.*, p.nombre1 as nombre, p.apellido1 as apellido, p.telefono, p.correo_electronico, p.fecha_nacimiento, tp.pregunta, pe.personal_id, pe.direccion_hogar, pe.fecha_asignacion, per.nombre as perfil
		FROM USUARIO U
		JOIN PERSONA P ON p.persona_id = u.persona_id
		JOIN TIPO_PREGUNTA TP ON u.tipo_pregunta_id = tp.tipo_pregunta_id
		JOIN PERSONAL PE ON PE.usuario_id = u.usuario_id
		JOIN PERFIL PER on PER.perfil_id = pe.perfil_id
		WHERE u.usuario_id = @usuario_id and u.estado_id = 1
END


GO
CREATE PROCEDURE PD_USUARIO_UNICO
@usuario varchar(50),
@result int OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    
    IF EXISTS (SELECT 1 FROM usuario WHERE usuario = @usuario)
        SET @result = 0
    ELSE
        SET @result = 1
END



GO
CREATE PROCEDURE PD_AÑADIR_NUEVA_PERSONA
@nombre1 VARCHAR(50), @apellido1 VARCHAR(50), @telefono varchar(10), @correo_electronico varchar(100), @fecha_nacimiento date, @result int output
as
begin
	insert into PERSONA (nombre1, apellido1, telefono, correo_electronico, fecha_nacimiento, estado_id)
	values (@nombre1, @apellido1, @telefono, @correo_electronico, @fecha_nacimiento, 1);
	set @result = SCOPE_IDENTITY() 
end


GO
CREATE PROCEDURE PD_AÑADIR_NUEVO_USUARIO
@persona_id int, @usuario VARCHAR(50), @contraseña varchar(50), @tipo_pregunta_id int, @respuesta_pregunta varchar(200)
as
begin
	declare @usuario_id int
	insert into usuario (persona_id, usuario, contraseña, estado_id, tipo_pregunta_id, respuesta_pregunta) 
	values (@persona_id, @usuario, @contraseña, 1, @tipo_pregunta_id, @respuesta_pregunta);
	set @usuario_id = SCOPE_IDENTITY()
	insert into personal (usuario_id, direccion_hogar, estado_id, perfil_id, fecha_asignacion) 
	values (@usuario_id, '',1, 1, CURRENT_TIMESTAMP)
end

GO
CREATE PROCEDURE VIEW_TIPO_PREGUNTA
AS
BEGIN
	SELECT * FROM TIPO_PREGUNTA WHERE estado_id = 1
END



GO 
CREATE PROCEDURE PD_OBTENER_USUARIO_X_USUARIO_CORREO
@usuario varchar(50), @correo_electronico varchar(100), @result int output
as
BEGIN
	set @result = 0
	declare @usuario_id int
	declare @estado_id int

	select @usuario_id = u.usuario_id, @estado_id = u.estado_id from usuario u JOIN persona p on p.persona_id= u.persona_id WHERE u.usuario = @usuario and p.correo_electronico = @correo_electronico
	
	IF @@ROWCOUNT > 0

	IF @estado_id = 1
		SET @result = @usuario_id
	ELSE IF @estado_id = 2
		SET @result = -1
END


GO
CREATE PROCEDURE PD_ACTUALIZAR_CONTRASEÑA
@usuario_id int, @contraseña varchar(50)
as
begin
	update usuario set contraseña = @contraseña where usuario_id = @usuario_id
end

GO
CREATE PROCEDURE PD_OBTENER_PERFIL_USUARIO
@usuario_id int, @result int output
as
begin
	SELECT @result = perfil_id
	FROM PERSONAL where usuario_id = @usuario_id
end


GO
CREATE PROCEDURE VISTA_OBTENER_MODULOS
as
begin
	SELECT * FROM MODULO WHERE ESTADO_ID = 1 ORDER BY orden desc
end


GO
CREATE PROCEDURE PD_OBTENER_OPCIONES_MODULO
@modulo_id int
as
begin
	SELECT * FROM OPCION WHERE ESTADO_ID = 1 AND modulo_id = @modulo_id ORDER BY ORDEN DESC
end

GO
CREATE PROCEDURE PD_VALIDAR_PERFIL_X_OPCION
@perfil_id int, @nombre_objeto varchar(50), @result int output
as
begin
	select *
	from PERFIL_X_OPCION pxo
	JOIN OPCION O ON O.opcion_id = PXO.opcion_id
	WHERE perfil_id = @perfil_id AND o.nombre_objeto = @nombre_objeto

	IF @@ROWCOUNT > 0
		set @result = 1
	else
		set @result = 0
end



