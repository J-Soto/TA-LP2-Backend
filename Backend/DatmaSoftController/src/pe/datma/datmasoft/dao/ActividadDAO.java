package pe.datma.datmasoft.dao;

import pe.datma.datmasoft.cursos.actividades.sincrona.Actividad;

import java.util.ArrayList;

public interface ActividadDAO {
    ArrayList<Actividad> listar();
    ArrayList<Actividad> listar(int idActividad);
}
