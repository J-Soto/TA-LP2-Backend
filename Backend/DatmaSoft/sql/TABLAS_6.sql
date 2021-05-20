#
# Tabla grupo
#

create procedure insertar_grupo(
    out _id_grupo int,
    in _id_modulo int,
    in _nombre varchar(25)
)
begin
    insert into grupo(fidmodulo, nombre) values (_id_modulo, _nombre);
    set _id_grupo = last_insert_id();
end;

create procedure modificar_grupo(
    in _id_grupo int,
    in _nombre varchar(25)
)
begin
    update grupo set nombre=_nombre where idgrupo = _id_grupo;
end;

create procedure listar_grupo()
begin
    select * from grupo;
end;

create procedure eliminar_grupo(
    in _id_grupo int
)
begin
    update grupo set activo=0 where idgrupo = _id_grupo;
end;

#
# Tabla grupo_niño_cuidador
#

create procedure insertar_grupo_infante_cuidador(
    out _id_grupo_infante_cuidador int,
    in _id_grupo int,
    in _id_infante_cuidador int
)
begin
    insert into grupo_niño_cuidador(fidgrupo, fidniño_cuidador) values (_id_grupo, _id_infante_cuidador);
    set _id_grupo_infante_cuidador = last_insert_id();
end;

create procedure listar_grupo_infante_cuidador()
begin
    select * from grupo_niño_cuidador;
end;

create procedure modificar_grupo_infante_cuidador(
    in _idgrupo_infante_cuidador int,
    in _fidgrupo int,
    in _fidinfante_cuidador int
)
begin
    update grupo_niño_cuidador
    set fidgrupo = _fidgrupo, fidniño_cuidador=_fidinfante_cuidador
    where idgrupo_niño_cuidador = _idgrupo_infante_cuidador;
end;

create procedure eliminar_grupo_infante_cuidador(
    in _idgrupo_infante_cuidador int
)
begin
    delete from grupo_niño_cuidador where idgrupo_niño_cuidador = _idgrupo_infante_cuidador;
end;

#
# Tabla material
#

create procedure insertar_material(
    out _id_material int,
    in _tipoarchivo varchar(8),
    in _link varchar(200),
    in _descripcion varchar(75)
)
begin
    insert into
        material(tipoarchivo, link, descripcion)
    values (_tipoarchivo, _link, _descripcion);
    set _id_material = last_insert_id();
end;

create procedure listar_material()
begin
    select * from material;
end;

create procedure modificar_material(
    in _id_material int,
    in _tipoarchivo varchar(8),
    in _link varchar(200),
    in _descripcion varchar(75)
)
begin
    update material set tipoarchivo=_tipoarchivo,link=_link,descripcion=_descripcion where idmaterial=_id_material;
end;

create procedure eliminar_material(
    in _id_material int
)
begin
    update material set activo = 0 where idmaterial=_id_material;
end;

#
# Tabla modulo
#

create procedure insertar_modulo(
    out _id_modulo int,
    in _fechainicial date,
    in _fechafinal date
)
begin
    insert into modulo(fechainicial, fechafinal) VALUES (_fechainicial, _fechafinal);
    set _id_modulo = last_insert_id();
end;

create procedure listar_modulo()
begin
    select * from modulo;
end;

create procedure modificar_modulo(
    in _id_modulo int,
    in _fechainicial date,
    in _fechafinal date
)
begin
    update modulo set fechafinal=_fechafinal, fechainicial=_fechainicial where idmodulo=_id_modulo;
end;

create procedure eliminar_modulo(
    in _id_modulo int
)
begin
    update modulo set activo = 0 where idmodulo = _id_modulo;
end;

#
# Tabla modulo_actividad
#

create procedure insertar_modulo_actividad(
    out _id_modulo_actividad int,
    in _id_modulo int,
    in _id_actividad int
)
begin
    insert into modulo_actividad(fidmodulo, fidactividad) values (_id_modulo, _id_actividad);
    set _id_modulo_actividad = last_insert_id();
end;

create procedure listar_modulo_actividad()
begin
    select * from modulo_actividad;
end;

create procedure modificar_modulo_actividad(
    in _id_modulo_actividad int,
    in _id_modulo int,
    in _id_actividad int
)
begin
    update modulo_actividad
    set fidmodulo=_id_modulo,fidactividad=_id_actividad
    where idmodulo_actividad = _id_modulo_actividad;
end;

create procedure eliminar_modulo_actividad(
    in _id_modulo_actividad int
)
begin
    delete from modulo_actividad
    where idmodulo_actividad = _id_modulo_actividad;
end;

#
# Tabla modulo_eje
#

create procedure insertar_modulo_eje(
    out _id_modulo_eje int,
    in _id_modulo int,
    in _id_eje int
)
begin
    insert into modulo_eje(fidmodulo, fideje) values(_id_modulo, _id_eje);
    set _id_modulo_eje = last_insert_id();
end;

create procedure listar_modulo_eje()
begin
    select * from modulo_eje;
end;

create procedure modificar_modulo_eje(
    in _id_modulo_eje int,
    in _id_modulo int,
    in _id_eje int
)
begin
    update modulo_eje set fideje=_id_eje, fidmodulo = _id_modulo where idmodulo_eje=_id_modulo_eje;
end;

create procedure eliminar_modulo_eje(
    in _id_modulo_eje int
)
begin
    delete from modulo_eje where idmodulo_eje = _id_modulo_eje;
end;