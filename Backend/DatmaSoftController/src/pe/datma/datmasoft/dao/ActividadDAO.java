package pe.datma.datmasoft.dao;


import java.util.ArrayList;
import pe.datma.datmasoft.modulos.Actividad;

public interface ActividadDAO {
    ArrayList<Actividad> listar();
    ArrayList<Actividad> listar(int idActividad);
}
