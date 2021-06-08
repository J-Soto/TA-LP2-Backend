package pe.datma.datmasoft.dao;

import java.util.ArrayList;
import pe.datma.datmasoft.modulos.Asistencia;

public interface AsistenciaDAO {
    int insertar(Asistencia asistencia);
    int modificar(Asistencia asistencia);
    ArrayList<Asistencia> listar();
}
