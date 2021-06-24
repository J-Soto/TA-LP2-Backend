package pe.datma.datmasoft.dao;

import pe.datma.datmasoft.rrhh.Psicologo;

import java.util.ArrayList;

public interface PsicologoDAO {
    ArrayList<Psicologo> listarPsicologos(String nombre);
    int insertarPsicologo(Psicologo psicologo);
    int modificarPsicologo(Psicologo psicologo);
    int eliminarPsicologo(int idPsicologo, int idUsuario);
    ArrayList<Psicologo> listarTodosPsicologos();
    ArrayList<Psicologo> listarPsicologosPorIdCurso(int idCurso);
    int cursosDictandoPorPsicologo(int idPsicologo);
    
    Psicologo buscarPsicologoPorIdUsuario(int idUsuario);
    
}

