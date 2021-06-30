package pe.datma.datmasoft.dao;


import java.util.ArrayList;
import pe.datma.datmasoft.modulos.Actividad;
import pe.datma.datmasoft.modulos.Asistencia;
import pe.datma.datmasoft.modulos.Documento;
import pe.datma.datmasoft.modulos.Video;

public interface ActividadDAO {
    ArrayList<Actividad> listarActividad();
    ArrayList<Actividad> listarActividadesIdSemana(int idSemana);
    int eliminarActividad(int idActividad);
    int insertarActividad(Actividad actividad,int idsemana);
    int modificarActividad(Actividad actividad);
    
    
    ArrayList<Asistencia> listarAsistenciasPorIdActividadYGrupo(int idActividad, int idGrupo);
    ArrayList<Documento> listarDocumentosPorIdActividad(int idActividad);
    ArrayList<Video> listarVideosPorIdActividad(int idActividad);
}
