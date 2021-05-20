

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

/******************NIÑO********************/

DROP PROCEDURE IF EXISTS INSERTAR_NIÑO;

DELIMITER $
CREATE PROCEDURE INSERTAR_NIÑO(
    OUT _id_niño INT,
    IN _fidseguro INT,
    IN _fiddistrito INT,
    IN  _dni VARCHAR(8),
    IN _nombre VARCHAR(75),
    IN _apellidopaterno VARCHAR(25),
    IN _apellidomaterno VARCHAR(25),
    IN _fecha_nacimiento DATE,
    IN _genero CHAR(1),
    IN _edad TINYINT
)
BEGIN
    INSERT INTO persona (dni,nombre,apellidopaterno,apellidomaterno,fechanacimiento,genero,edad)
    VALUES (_dni,_nombre,_apellidopaterno,_apellidomaterno,_fecha_nacimiento,_genero,_edad);

    SET _id_niño = @@last_insert_id;

    INSERT INTO persona_distrito (fiddistrito,fidpersona)
    VALUES (_fiddistrito,_id_niño);


    INSERT INTO niño(fidpersona, fidseguro,activo)
    VALUES (_id_niño, _fidseguro,1); /*Comienza activo*/

END$



DROP PROCEDURE IF EXISTS MODIFICAR_NIÑO;

DELIMITER $
CREATE PROCEDURE MODIFICAR_NIÑO(
    IN _id_niño INT,
    IN _fidseguro INT,
    IN _fiddistrito INT,
    IN  _dni VARCHAR(8),
    IN _nombre VARCHAR(75),
    IN _apellidopaterno VARCHAR(25),
    IN _apellidomaterno VARCHAR(25),
    IN _fecha_nacimiento DATE,
    IN _genero CHAR(1),
    IN _edad TINYINT
)
BEGIN
    UPDATE persona SET
                       dni = _dni, nombre = _nombre, apellidopaterno = _apellidopaterno, apellidomaterno = _apellidomaterno,
                       fechanacimiento = _fecha_nacimiento, genero = _genero, edad = _edad
    WHERE persona.idpersona = _id_niño;

    UPDATE niño SET
        fidseguro = _fidseguro
    WHERE niño.fidpersona = _id_niño;

    UPDATE persona_distrito SET
        fiddistrito = _fiddistrito
    WHERE fidpersona = _id_niño;

END$


DROP PROCEDURE IF EXISTS ELIMINAR_NIÑO;

DELIMITER $
CREATE PROCEDURE ELIMINAR_NIÑO(
    IN _id_niño INT
)
BEGIN

    UPDATE niño SET
        activo = 0
    WHERE niño.fidpersona = _id_niño;

    UPDATE niño_cuidador SET
        activo = 0
    WHERE fidniño = _id_niño;

END$


DROP PROCEDURE IF EXISTS LISTAR_NIÑOS;

DELIMITER $
CREATE PROCEDURE LISTAR_NIÑOS()
BEGIN

    SELECT p.idpersona, p.dni, p.nombre, p.apellidopaterno, p.apellidomaterno, p.fechanacimiento, p.genero,
           p.edad, d.iddistrito, d.nombre as nombredistrito, s.idseguro, s.proveedor/*, nc.fidcuidador*/
    FROM persona p
             INNER JOIN persona_distrito pd ON pd.fidpersona = p.idpersona
             INNER JOIN distrito d ON d.iddistrito = pd.fiddistrito
             INNER JOIN niño ON niño.fidpersona = p.idpersona
             INNER JOIN seguro s ON niño.fidseguro = s.idseguro
        /*INNER JOIN niño_cuidador nc ON nc.fidniño = niño.fidpersona;*/
    WHERE niño.activo = 1;
END$


DELIMITER $
CREATE PROCEDURE LISTAR_NIÑO_ID(
    IN _id_niño INT
)
BEGIN

    SELECT p.idpersona, p.dni, p.nombre, p.apellidopaterno, p.apellidomaterno, p.fechanacimiento, p.genero,
           p.edad, d.iddistrito, d.nombre as nombredistrito, s.idseguro, s.proveedor/*, nc.fidcuidador*/
    FROM persona p
             INNER JOIN persona_distrito pd ON pd.fidpersona = p.idpersona
             INNER JOIN distrito d ON d.iddistrito = pd.fiddistrito
             INNER JOIN niño ON niño.fidpersona = p.idpersona
             INNER JOIN seguro s ON niño.fidseguro = s.idseguro
        /*INNER JOIN niño_cuidador nc ON nc.fidniño = niño.fidpersona;*/
    WHERE niño.activo = 1
    AND niño.fidpersona = _id_niño;

END$

/******* PSICOLOGO **********/
DROP PROCEDURE IF EXISTS INSERTAR_PSICOLOGO;
DELIMITER $
CREATE PROCEDURE INSERTAR_PSICOLOGO(
    OUT _id_psicologo INT,
    OUT _id_usuario INT,
    IN _fiddistrito INT,
    IN  _dni VARCHAR(8),
    IN _nombre VARCHAR(75),
    IN _apellidopaterno VARCHAR(25),
    IN _apellidomaterno VARCHAR(25),
    IN _fecha_nacimiento DATE,
    IN _genero CHAR(1),
    IN _edad TINYINT,
    IN _telefono VARCHAR(9),
    IN _celular VARCHAR(9),
    IN _correo VARCHAR(100),
    IN _user VARCHAR(75),
    IN _password VARCHAR(25)
)
BEGIN
    INSERT INTO persona (dni,nombre,apellidopaterno,apellidomaterno,fechanacimiento,genero,edad,telefono,celular,correo)
    VALUES (_dni,_nombre,_apellidopaterno,_apellidomaterno,_fecha_nacimiento,_genero,_edad,_telefono,_celular,_correo);

    SET _id_psicologo = @@last_insert_id;

    INSERT INTO usuario(user, password,activo,tipo)
    VALUES (_user,_password,1,1); /*tipo -> 1 (psicologo)*/

    SET _id_usuario = @@last_insert_id;

    INSERT INTO psicologo(fidpersona,fidusuario,activo)
    VALUES (_id_psicologo,_id_usuario,1);

    INSERT INTO persona_distrito (fiddistrito,fidpersona)
    VALUES (_fiddistrito,_id_psicologo);
END$

/*SELECT * FROM persona p
INNER JOIN psicologo psi ON p.idpersona = psi.fidpersona
INNER JOIN usuario u ON u.idusuario = psi.fidusuario
INNER JOIN persona_distrito pd ON pd.fidpersona = p.idpersona
INNER JOIN distrito d ON d.iddistrito = pd.fiddistrito;
CALL INSERTAR_PSICOLOGO(@idpsico,@iduser,1,'34567332','Eduardo','Perez','Galvez','1995-4-2','M','25','990384323','','edu@gmail.com','edu_9345','12345');
*/



DROP PROCEDURE IF EXISTS MODIFICAR_PSICOLOGO;
DELIMITER $
CREATE PROCEDURE MODIFICAR_PSICOLOGO(
    IN _id_psicologo INT,
    IN _id_usuario INT,
    IN _fiddistrito INT,
    IN  _dni VARCHAR(8),
    IN _nombre VARCHAR(75),
    IN _apellidopaterno VARCHAR(25),
    IN _apellidomaterno VARCHAR(25),
    IN _fecha_nacimiento DATE,
    IN _genero CHAR(1),
    IN _edad TINYINT,
    IN _telefono VARCHAR(9),
    IN _celular VARCHAR(9),
    IN _correo VARCHAR(100),
    IN _user VARCHAR(75),
    IN _password VARCHAR(25)
)
BEGIN
    UPDATE persona
    SET
        dni = _dni, nombre = _nombre, apellidopaterno = _apellidopaterno, apellidomaterno = _apellidomaterno,
        fechanacimiento = _fecha_nacimiento, genero = _genero, edad = _edad, telefono = _telefono,
        celular = _celular, correo = _correo
    WHERE idpersona = _id_psicologo;

    UPDATE usuario
    SET
        user = _user, password = _password
    WHERE idusuario = _id_usuario;

    UPDATE persona_distrito
    SET fiddistrito = _fiddistrito
    WHERE fidpersona = _id_psicologo;

END$



DROP PROCEDURE IF EXISTS ELIMINAR_PSICOLOGO;
DELIMITER $
CREATE PROCEDURE ELIMINAR_PSICOLOGO(
    IN _id_psicologo INT,
    IN _id_usuario INT
)
BEGIN
    UPDATE psicologo
    SET activo = 0
    WHERE fidpersona = _id_psicologo;

    UPDATE grupo_psicologo
    SET activo = 0
    WHERE fidpsicologo = _id_psicologo;

    UPDATE usuario
    SET activo = 0
    WHERE idusuario = _id_usuario;

END$

DROP PROCEDURE IF EXISTS LISTAR_PSICOLOGOS;
DELIMITER $
CREATE PROCEDURE LISTAR_PSICOLOGOS()
BEGIN
    SELECT p.idpersona, p.dni, p.nombre, p.apellidopaterno, p.apellidomaterno, p.fechanacimiento, p.genero,
           p.edad, p.telefono, p.celular, p.correo ,d.iddistrito, d.nombre as namedist, u.idusuario, u.user, u.password
    FROM persona p
             INNER JOIN psicologo psi ON p.idpersona = psi.fidpersona
             INNER JOIN usuario u ON u.idusuario = psi.fidusuario
             INNER JOIN persona_distrito pd ON pd.fidpersona = p.idpersona
             INNER JOIN distrito d ON d.iddistrito = pd.fiddistrito
    WHERE psi.activo = 1;

END$

#######################################################################################################
#TABLA CUIDADOR
#######################################################################################################

DELIMITER $$
CREATE DEFINER=`admin`@`%` PROCEDURE `INSERTAR_CUIDADOR`(
    OUT _id_cuidador INT,
    OUT _id_usuario INT,
    OUT _gestante INT,
    OUT _bajosrecursos INT,
    IN _fiddistrito INT,
    IN _id_tipointernet INT,
    IN _id_dispositivoelectronico INT,
    IN _id_dia INT,
    IN _id_periodo INT,
    IN _id_redsocial INT,
    IN _dni VARCHAR(8),
    IN _nombre VARCHAR(75),
    IN _apellidopaterno VARCHAR(25),
    IN _apellidomaterno VARCHAR(25),
    IN _fecha_nacimiento DATE,
    IN _genero CHAR(1),
    IN _edad TINYINT,
    IN _telefono VARCHAR(9),
    IN _celular VARCHAR(9),
    IN _correo VARCHAR(100),
    IN _user VARCHAR(75),
    IN _password VARCHAR(25)
)
BEGIN
	INSERT INTO persona (dni,nombre,apellidopaterno,apellidomaterno,fechanacimiento,genero,edad,telefono,celular,correo)
    VALUES (_dni,_nombre,_apellidopaterno,_apellidomaterno,_fecha_nacimiento,_genero,_edad,_telefono,_celular,_correo);
    
    SET _id_cuidador = @@last_insert_id;
    
    INSERT INTO usuario(user, password,activo,tipo) 
    VALUES (_user,_password,1,2); /*tipo -> 2 (cuidador)*/
    
    SET _id_usuario = @@last_insert_id;
    
    INSERT INTO cuidador(fidpersona,fidusuario,gestante,bajosrecursos,activo)
    VALUES (_id_cuidador,_id_usuario,_gestante,_bajosrecursos,1);
    
    INSERT INTO persona_distrito (fiddistrito,fidpersona)
    VALUES (_fiddistrito,_id_psicologo);
    
    INSERT INTO cuidador_tipointernet (fidcuidador,fidtipointernet,activo)
    VALUES (_id_cuidador,_id_tipointernet,1);
    
    INSERT INTO cuidador_dispositivoelectronico (fidcuidador,fiddispositivoelectronico,activo)
    VALUES (_id_cuidador,_id_dispositivoelectronico,1);
    
    INSERT INTO cuidador_dia (fidcuidador,fiddia,activo)
    VALUES (_id_cuidador,_id_dia,1);
    
    INSERT INTO cuidador_periodo (fidcuidador,fidperiodo,activo)
    VALUES (_id_cuidador,_id_periodo,1);
    
    INSERT INTO cuidador_redsocial (fidcuidador,fidredsocial,activo)
    VALUES (_id_cuidador,_id_redsocial,1);
    
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`admin`@`%` PROCEDURE `MODIFICAR_CUIDADOR`(
	IN _id_cuidador INT,
    IN _id_usuario INT,
    IN _gestante INT,
    IN _bajosrecursos INT,
    IN _fiddistrito INT,
    IN _id_tipointernet INT,
    IN _id_dispositivoelectronico INT,
    IN _id_dia INT,
    IN _id_periodo INT,
    IN _id_redsocial INT,
    IN _dni VARCHAR(8),
    IN _nombre VARCHAR(75),
    IN _apellidopaterno VARCHAR(25),
    IN _apellidomaterno VARCHAR(25),
    IN _fecha_nacimiento DATE,
    IN _genero CHAR(1),
    IN _edad TINYINT,
    IN _telefono VARCHAR(9),
    IN _celular VARCHAR(9),
    IN _correo VARCHAR(100),
    IN _user VARCHAR(75),
    IN _password VARCHAR(25)
)
BEGIN
	UPDATE persona
    SET 
    dni = _dni, nombre = _nombre, apellidopaterno = _apellidopaterno, apellidomaterno = _apellidomaterno,
    fechanacimiento = _fecha_nacimiento, genero = _genero, edad = _edad, telefono = _telefono,
    celular = _celular, correo = _correo
    WHERE idpersona = _id_cuidador;
    
    UPDATE usuario
    SET 
    user = _user, password = _password
    WHERE idusuario = _id_usuario;
    
    UPDATE persona_distrito
    SET
    fiddistrito = _fiddistrito
    WHERE fidpersona = _id_cuidador;
    
    UPDATE cuidador
    SET
    fidusuario = _id_usuario, gestante = _gestante, bajosrecursos = _bajosrecursos
    WHERE fidpersona = _id_cuidador;
    
    UPDATE cuidador_tipointernet 
    SET
    fidtipointernet =  _id_tipointernet
    WHERE fidcuidador = _id_cuidador;
    
    UPDATE cuidador_dispositivoelectronico 
    SET
    fiddispositivoelectronico = _id_dispositivoelectronico
    WHERE fidcuidador = _id_cuidador;
    
    UPDATE cuidador_dia 
    SET
    fiddia = _id_dia
    WHERE fidcuidador = _id_cuidador;
    
    UPDATE cuidador_periodo 
    SET
    fidperiodo = _id_periodo
    WHERE fidcuidador = _id_cuidador;
	
    UPDATE cuidador_redsocial
    SET
    fidredsocial = _id_redsocial
    WHERE fidcuidador = _id_cuidador;

END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`admin`@`%` PROCEDURE `ELIMINAR_CUIDADOR`(
	IN _id_cuidador INT,
    IN _id_usuario INT
)
BEGIN
	UPDATE cuidador
    SET activo = 0
    WHERE fidpersona = _id_cuidador;
    
    UPDATE usuario
    SET activo = 0 
    WHERE idusuario = _id_usuario;
    
    UPDATE cuidador_dispositivoelectronico 
    SET activo = 0
	WHERE fidcuidador = _id_cuidador;
    
    UPDATE cuidador_dia  
    SET activo = 0
	WHERE fidcuidador = _id_cuidador;

    UPDATE cuidador_periodo   
    SET activo = 0
	WHERE fidcuidador = _id_cuidador;

    UPDATE cuidador_redsocial    
    SET activo = 0
	WHERE fidcuidador = _id_cuidador;
    
    UPDATE cuidador_tipointernet     
    SET activo = 0cuidador_tipointernet
	WHERE fidcuidador = _id_cuidador;

END$$
DELIMITER ;
