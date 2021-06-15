package pe.datma.datmasoft.dao;

import java.util.ArrayList;
import pe.datma.datmasoft.modulos.Asistencia;

public interface AsistenciaDAO {
    ArrayList<Asistencia> listarAsistencia();
    int insertarAsistencia(Asistencia asistencia);
    int modificarAsistencia(Asistencia asistencia);
    int eliminarAsistencia(int idAsistencia);
}
