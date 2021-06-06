
DELIMITER $

-- semana,curso_tema,tema,asistencia

-- semana
create procedure insertar_semana(
	out _idsemana int,
    in _fidcurso int,
	in _nombre varchar(25),
    in _descripcion varchar(45),
    in _fechainicio date
)
begin
	insert into semana (fidcurso, nombre, descripcion, fechainicio) values (_fidcurso, _nombre, _descripcion, _fechainicio);
    set _idsemana = last_insert_id();
end$

create procedure modificar_semana(
	in _idsemana int,
	in _fidcurso int,
	in _nombre varchar(25),
    in _descripcion varchar(45),
    in _fechainicio date
)
begin
	update semana set fidcurso = _fidcurso, nombre = _nombre, descripcion = _descripcion, fechainicio = _fechainicio where idsemana = _idsemana;
end$

create procedure listar_semana()
begin
	select * from semana;
end$

-- tema
create procedure insertar_tema(
	out _idtema int,
    in _nombre varchar(45),
    in _descripcion varchar(75)
)
begin
	insert into tema(nombre, descripcion) values (_nombre, _descripcion);
    set _idtema = last_insert_id();
end$

create procedure modificar_tema(
	in _idtema int,
    in _nombre varchar(45),
    in _descripcion varchar(75)
)
begin
	update tema set nombre = _nombre, descripcion = _descripcion where idtema = _idtema;
end$

create procedure listar_tema()
begin
	select * from tema;
end$

-- asistencia
create procedure insertar_asistencia(
	out _idasistencia int,
    in _fidusuario int,
    in _fidactividad int,
    in _descripcion varchar(250),
    in _tipoasistencia int
)
begin
	insert into asistencia (fidusuario, fidactividad, descripcion, activo, tipoasistencia) values 
		(_fidusuario, _fidactividad, _descripcion, 1, _tipoasistencia);
	set _idasistencia = last_insert_id();
end$

create procedure modificar_asistencia(
	in _idasistencia int,
    in _fidusuario int,
    in _fidactividad int,
    in _descripcion varchar(250),
    in _tipoasistencia int
)
begin
	update asistencia set fidusuario = _fidusuario, fidactividad = _fidactividad, descripcion = _descripcion, tipoasistencia = _tipoasistencia where idasistencia = _idasistencia;
end$

create procedure listar_asistencia()
begin
	select * from asistencia;
end$

create procedure eliminar_asistencia(
	in _idasistencia int
)
begin
	update asistencia set activo = 0 where idasistencia = _idasistencia;
end$

-- curso_tema
create procedure insertar_cursotema(
	out _id_cursotema int,
    in _fidcurso int,
    in _fidtema int,
    in _fechainicio date,
    in _fechafin date
)
begin
	insert into curso_tema (fidcurso, fidtema, fechainicio, fechafin, activo) values (_fidcurso, _fidtema, _fechainicio, _fechafin, 1);
    set _id_cursotema = last_insert_id();
end$

create procedure modificar_cursotema(
	in _id_cursotema int,
    in _fidcurso int,
    in _fidtema int,
    in _fechainicio date,
    in _fechafin date
)
begin
	update curso_tema set fidcurso = _fidcurso, fidtema = _fidtema, fechainicio = _fechainicio, fechafin = _fechafin where idcurso_tema = _id_cursotema;
end$

create procedure eliminar_cursotema(
	in _id_cursotema int
)
begin
	update curso_tema set activo = 0 where idcurso_tema = _id_cursotema;
end$

create procedure listar_cursotema()
begin
	select * from curso_tema;
end$