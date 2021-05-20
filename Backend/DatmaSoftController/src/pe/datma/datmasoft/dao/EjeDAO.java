package pe.datma.datmasoft.dao;

import pe.datma.datmasoft.cursos.Eje;
import pe.datma.datmasoft.cursos.actividades.sincrona.Actividad;

import java.util.ArrayList;

public interface EjeDAO {
    ArrayList<Eje> listar();
    ArrayList<Eje> listar(int idEje);
}
