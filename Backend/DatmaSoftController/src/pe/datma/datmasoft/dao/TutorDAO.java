package pe.datma.datmasoft.dao;


import java.util.ArrayList;
import pe.datma.datmasoft.rrhh.Tutor;

public interface TutorDAO {
    ArrayList<Tutor> listar();
    ArrayList<Tutor> listar(int idCuidador);
}
