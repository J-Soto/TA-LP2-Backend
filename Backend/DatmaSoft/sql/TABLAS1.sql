

DELIMITER $
#######################################################################################################
#TABLA ACTIVIDAD_MATERIAL
#######################################################################################################

CREATE PROCEDURE INSERTAR_ACTIVIDAD(
	OUT _id_actividad INT,
	OUT _id_tipo_actividad INT,
    IN _nombre VARCHAR(45),
    IN _fecha_inicial DATE,
    IN _hora_inicio TIME,
    IN _hora_fin TIME,
)
BEGIN
	INSERT INTO actividad('nombre',fechainicial,horainicio,horafin,activo) VALUES(_nombre,_fecha_inicial,_hora_inicio,_hora_fin,1);
    SET _id_actividad = @@last_insert_id;
    SET _id_tipo_actividad = @@last_insert_id;
END$


CREATE PROCEDURE LISTAR_ACTIVIDAD()
BEGIN
	SELECT nombre,fechainicial,horainicio,horafin 
    FROM actividad 
END$


CREATE PROCEDURE MODIFICAR_ACTIVIDAD(
	IN _id_actividad INT,
    IN _nombre VARCHAR(45),
    IN _fecha_inicial DATE,
    IN _hora_inicio TIME,
    IN _hora_fin TIME,
)
BEGIN
	UPDATE actividad 
	SET actividad.nombre=_nombre,
	actividad.fechainicial=_fecha_inicial,
	actividad.horainicio=_hora_inicio,
	actividad.horafin=_hora_fin 
    WHERE _id_actividad=idactividad;
END$

CREATE PROCEDURE ELIMINAR_ACTIVIDAD(IN _id_actividad INT)
BEGIN
	UPDATE actividad SET activo=0 WHERE _id_actividad=idactividad;
END$


#######################################################################################################
#TABLA actividad_material
#######################################################################################################
CREATE PROCEDURE INSERTAR_ACTIVIDAD_MATERIAL(
	OUT _id_actividad INT,
	OUT _id_actividad_material INT,
	OUT _id_material INT,
)
BEGIN
	INSERT INTO actividad_material(activo) VALUES(1);
	SET _id_actividad = @@last_insert_id;
    SET _id_actividad_material = @@last_insert_id;
    SET _id_material = @@last_insert_id;
END$

CREATE PROCEDURE LISTAR_ACTIVIDAD_MATERIAL()
BEGIN
	SELECT *
    FROM actividad_material 
END$

CREATE PROCEDURE ELIMINAR_ACTIVIDAD_MATERIAL(IN _id_actividad_material INT)
BEGIN
	UPDATE actividad_material SET activo=0 WHERE _id_actividad_material=idactividad;
END$


#######################################################################################################
#TABLA ASISTENCIA
#######################################################################################################

CREATE PROCEDURE INSERTAR_ASISTENCIA(
	OUT _id_asistencia INT,
	OUT _id_usuario INT,
	OUT _id_actividad INT,
	OUT _id_tipo_asistencia INT,
    IN _descripcion VARCHAR(250),
)
BEGIN
	INSERT INTO asistencia('descripcion',activo) VALUES(_descripcion,1);
    SET _id_asistencia = @@last_insert_id;
    SET _id_usuario = @@last_insert_id;
    SET _id_actividad = @@last_insert_id;
    SET _id_tipo_asistencia = @@last_insert_id;
END$


CREATE PROCEDURE LISTAR_ASISTENCIA()
BEGIN
	SELECT descripcion 
    FROM  asistencia
END$


CREATE PROCEDURE MODIFICAR_ASISTENCIA(
    IN _descripcion VARCHAR(250),
    IN id_asistencia INT,
)
BEGIN
	UPDATE asistencia 
	SET asistencia.descripcion=_descripcion
    WHERE _id_asistencia=id_asistencia;
END$

CREATE PROCEDURE ELIMINAR_ASISTENCIA(IN id_asistencia INT)
BEGIN
	UPDATE asistencia SET activo=0 WHERE _id_asistencia=idactividad;
END$



#######################################################################################################
#TABLA DIA
#######################################################################################################

CREATE PROCEDURE INSERTAR_DIA(
	OUT _id_dia INT,
    IN _nombre VARCHAR(25),
)
BEGIN
	INSERT INTO dia('nombre',activo) VALUES(_nombre,1);
    SET _id_dia = @@last_insert_id;
END$


CREATE PROCEDURE LISTAR_DIA()
BEGIN
	SELECT nombre 
    FROM  dia
END$


CREATE PROCEDURE MODIFICAR_DIA(
    IN nombre VARCHAR(25),
    IN id_dia INT,
)
BEGIN
	UPDATE dia 
	SET dia.nombre=_nombre
    WHERE _id_dia=id_dia;
END$

CREATE PROCEDURE ELIMINAR_DIA(IN id_dia INT)
BEGIN
	UPDATE dia SET activo=0 WHERE _id_dia=idactividad;
END$




#######################################################################################################
#TABLA EJE
#######################################################################################################

CREATE PROCEDURE INSERTAR_EJE(
	OUT _id_eje INT,
    IN _nombre VARCHAR(45),
)
BEGIN
	INSERT INTO eje('nombre',activo) VALUES(_nombre,1);
    SET _id_eje = @@last_insert_id;
END$


CREATE PROCEDURE LISTAR_EJE()
BEGIN
	SELECT nombre 
    FROM  eje
END$


CREATE PROCEDURE MODIFICAR_EJE(
    IN nombre VARCHAR(45),
    IN id_eje INT,
)
BEGIN
	UPDATE eje 
	SET eje.nombre=_nombre
    WHERE _id_eje=id_eje;
END$

CREATE PROCEDURE ELIMINAR_EJE(IN id_eje INT)
BEGIN
	UPDATE eje SET activo=0 WHERE _id_eje=idactividad;
END$



#######################################################################################################
#TABLA DISTRITO
#######################################################################################################

CREATE PROCEDURE INSERTAR_DISTRITO(
	OUT _id_distrito INT,
    IN _nombre VARCHAR(45),
)
BEGIN
	INSERT INTO distrito('nombre',activo) VALUES(_nombre,1);
    SET _id_distrito = @@last_insert_id;
END$


CREATE PROCEDURE LISTAR_DISTRITO()
BEGIN
	SELECT nombre 
    FROM  distrito
END$


CREATE PROCEDURE MODIFICAR_DISTRITO(
    IN nombre VARCHAR(45),
    IN id_distrito INT,
)
BEGIN
	UPDATE distrito 
	SET distrito.nombre=_nombre
    WHERE _id_distrito=id_distrito;
END$

CREATE PROCEDURE ELIMINAR_DISTRITO(IN id_distrito INT)
BEGIN
	UPDATE distrito SET activo=0 WHERE _id_distrito=idactividad;
END$




#######################################################################################################
#TABLA DISPOSITIVO_ELECTRONICO
#######################################################################################################

CREATE PROCEDURE INSERTAR_DISPOSITIVO_ELECTRONICO(
	OUT _id_dispositivoelectronico INT,
    IN _nombre VARCHAR(45),
)
BEGIN
	INSERT INTO dispositivoelectronico('nombre',activo) VALUES(_nombre,1);
    SET _id_dispositivoelectronico = @@last_insert_id;
END$


CREATE PROCEDURE LISTAR_DISPOSITIVO_ELECTRONICO()
BEGIN
	SELECT nombre 
    FROM  dispositivoelectronico
END$


CREATE PROCEDURE MODIFICAR_DISPOSITIVO_ELECTRONICO(
    IN nombre VARCHAR(45),
    IN id_dispositivoelectronico INT,
)
BEGIN
	UPDATE dispositivoelectronico 
	SET dispositivoelectronico.nombre=_nombre
    WHERE _id_dispositivoelectronico=id_dispositivoelectronico;
END$

CREATE PROCEDURE ELIMINAR_DISPOSITIVO_ELECTRONICO(IN id_dispositivoelectronico INT)
BEGIN
	UPDATE dispositivoelectronico SET activo=0 WHERE _id_dispositivoelectronico=idactividad;
END$









