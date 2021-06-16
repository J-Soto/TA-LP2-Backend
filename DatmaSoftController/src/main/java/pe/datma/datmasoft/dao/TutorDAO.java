package pe.datma.datmasoft.dao;


import java.util.ArrayList;
import pe.datma.datmasoft.rrhh.Tutor;

public interface TutorDAO {
    public int insertarTutor(Tutor tutor);
    public int modificarTutor(Tutor tutor);
    public int eliminarTutor(int idTutor, int idUsuario);
    public ArrayList<Tutor> listarTutores(String nombre);
    public ArrayList<Tutor> listarTodosTutores();
}
