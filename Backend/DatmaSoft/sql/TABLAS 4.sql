

DELIMITER $
#######################################################################################################
#TABLA REDSOCIAL
#######################################################################################################

CREATE PROCEDURE INSERTAR_REDSOCIAL(
	OUT _id_redsocial INT,
    IN _nombre VARCHAR(25)
)
BEGIN
	INSERT INTO redsocial(nombre,activo) VALUES(_nombre,1);
    SET _id_redsocial = @@last_insert_id;
END$

CREATE PROCEDURE LISTAR_REDSOCIAL()
BEGIN
	SELECT * FROM redsocial;
END$

CREATE PROCEDURE MODIFICAR_REDSOCIAL(
	IN _id_redsocial INT,
    IN _nombre VARCHAR(25)
)
BEGIN
	UPDATE redsocial SET nombre=_nombre WHERE _id_redsocial=idredsocial;
END$

CREATE PROCEDURE ELIMINAR_REDSOCIAL(IN _id_redsocial INT)
BEGIN
	UPDATE redsocial SET activo=0 WHERE _id_redsocial=idredsocial;
END$

#######################################################################################################
#TABLA SEGURO
#######################################################################################################
CREATE PROCEDURE INSERTAR_SEGURO(
	OUT _id_seguro INT,
    IN _proveedor VARCHAR(45)
)
BEGIN
	INSERT INTO seguro(proveedor) VALUES(_proveedor);
    SET _id_seguro = @@last_insert_id;
END$

CREATE PROCEDURE LISTAR_SEGURO()
BEGIN
	SELECT * FROM seguro;
END$

CREATE PROCEDURE MODIFICAR_SEGURO(
	IN _id_seguro INT,
    IN _proveedor VARCHAR(45)
)
BEGIN
	UPDATE seguro SET proveedor=_proveedor WHERE _id_seguro=idseguro;
END$

CREATE PROCEDURE ELIMINAR_SEGURO(IN _id_seguro INT)
BEGIN
	UPDATE seguro SET activo=0 WHERE _id_seguro=idseguro;
END$

#######################################################################################################
#TABLA USUARIO
#######################################################################################################
CREATE PROCEDURE INSERTAR_USUARIO(
	OUT _id_usuario INT,
    IN _user VARCHAR(75),
    IN _password VARCHAR(25),
    IN _tipo TINYINT(1)
)
BEGIN
	INSERT INTO usuario(`user`,`password`,tipo,activo) VALUES(_user,_password,_tipo,1);
    SET _id_usuario = @@last_insert_id;

    IF _tipo=0 THEN INSERT INTO cuidador(fidusuario) VALUES(_id_usuario);
	ELSE INSERT INTO psicologo(fidusuario) VALUES(_id_usuario);
    END IF;
END$

CREATE PROCEDURE LISTAR_USUARIO()
BEGIN
	SELECT U.*,P.* 
    FROM usuario U,persona P,cuidador C,psicologo PSI
    WHERE C.fidusuario=U.idusuario
    OR PSI.fidusuario=U.idusuario;
END$

CREATE PROCEDURE MODIFICAR_USUARIO(
	IN _id_usuario INT,
    IN _user VARCHAR(75),
    IN _password VARCHAR(25)
)
BEGIN
	UPDATE usuario SET usuario.user=_user,usuario.password=_password 
    WHERE _id_usuario=idusuario;
END$

CREATE PROCEDURE ELIMINAR_USUARIO(IN _id_usuario INT)
BEGIN
	UPDATE usuario SET activo=0 WHERE _id_usuario=idusuario;
END$
#######################################################################################################
#TABLA TIPOACTIVIDAD
#######################################################################################################
CREATE PROCEDURE INSERTAR_TIPOACTIVIDAD(
	OUT _id_tipoactividad INT,
    IN _descripcion VARCHAR(75),
    IN _sincrono TINYINT(1)
)
BEGIN
	INSERT INTO tipoactividad(descripcion,sincrono) VALUES(_descripcion,_sincrono);
    SET _id_tipoactividad = @@last_insert_id;
END$

CREATE PROCEDURE LISTAR_TIPOACTIVIDAD()
BEGIN
	SELECT * FROM tipoactividad;
END$

CREATE PROCEDURE MODIFICAR_TIPOACTIVIDAD(
	IN _id_tipoactividad INT,
	IN _descripcion VARCHAR(75),
    IN _sincrono TINYINT(1)
)
BEGIN
	UPDATE tipoactividad SET descripcion=_descripcion,sincrono=_sincrono 
    WHERE _id_tipoactividad=idtipoactividad;
END$

CREATE PROCEDURE ELIMINAR_TIPOACTIVIDAD(IN _id_tipoactividad INT)
BEGIN
	UPDATE tipoactividad SET activo=0 WHERE _id_tipoactividad=idtipoactividad;
END$

#######################################################################################################
#TABLA TIPOINTERNET
#######################################################################################################
CREATE PROCEDURE INSERTAR_TIPOINTERNET(
	OUT _id_tipointernet INT,
    IN _descripcion VARCHAR(45)
)
BEGIN
	INSERT INTO tipointernet(descripcion,activo) VALUES(_descripcion,1);
    SET _id_tipointernet = @@last_insert_id;
END$

CREATE PROCEDURE LISTAR_TIPOINTERNET()
BEGIN
	SELECT * FROM tipointernet;
END$

CREATE PROCEDURE MODIFICAR_TIPOINTERNET(
	IN _id_tipointernet INT,
	IN _descripcion VARCHAR(45)
)
BEGIN
	UPDATE tipointernet SET descripcion=_descripcion 
    WHERE _id_tipointernet=idtipointernet;
END$

CREATE PROCEDURE ELIMINAR_TIPOINTERNET(IN _id_tipointernet INT)
BEGIN
	UPDATE tipointernet SET activo=0 WHERE _id_tipointernet=idtipointernet;
END$

#######################################################################################################
#TABLA TIPOASISTENCIA
#######################################################################################################
CREATE PROCEDURE INSERTAR_TIPOASISTENCIA(
	OUT _id_tipoasistencia INT,
    IN _descripcion VARCHAR(45)
)
BEGIN
	INSERT INTO tipointernet(descripcion) VALUES(_descripcion);
    SET _id_tipoasistencia = @@last_insert_id;
END$

CREATE PROCEDURE LISTAR_TIPOASISTENCIA()
BEGIN
	SELECT * FROM tipoasistencia;
END$

CREATE PROCEDURE MODIFICAR_TIPOASISTENCIA(
	IN _id_tipoasistencia INT,
	IN _descripcion VARCHAR(45)
)
BEGIN
	UPDATE tipoasistencia SET descripcion=_descripcion 
    WHERE _id_tipoasistencia=idtipoasistencia;
END$

CREATE PROCEDURE ELIMINAR_TIPOASISTENCIA(IN _id_tipoasistencia INT)
BEGIN
	UPDATE tipoasistencia SET activo=0 WHERE _id_tipoasistencia=idtipoasistencia;
END$
#######################################################################################################
#TABLA PERIODO
#######################################################################################################

CREATE PROCEDURE INSERTAR_PERIODO(
	OUT _id_periodo INT,
    IN _nombre VARCHAR(25),
	IN _activo TINYINT(1)
)
BEGIN
	INSERT INTO redsocial(nombre,activo) VALUES(_nombre,_activo);
    SET _id_periodo = @@last_insert_id;
END$

CREATE PROCEDURE LISTAR_PERIODO()
BEGIN
	SELECT * FROM periodo;
END$

CREATE PROCEDURE MODIFICAR_REDSOCIAL(
	IN _id_periodo INT,
    IN _nombre VARCHAR(25)
)
BEGIN
	UPDATE periodo SET nombre=_nombre WHERE _id_periodo=idperiodo;
END$

CREATE PROCEDURE ELIMINAR_PERIODO(IN _id_periodo INT)
BEGIN
	UPDATE periodo SET activo=0 WHERE _id_periodo=idperiodo;
END$

