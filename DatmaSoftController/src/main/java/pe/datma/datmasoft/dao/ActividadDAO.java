package pe.datma.datmasoft.dao;


import java.util.ArrayList;
import pe.datma.datmasoft.modulos.Actividad;

public interface ActividadDAO {
    ArrayList<Actividad> listarActividad();
    int eliminarActividad(int idActividad);
    int insertarActividad(Actividad actividad,int idsemana);
    int modificarActividad(Actividad actividad);
}
