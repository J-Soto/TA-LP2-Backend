package pe.datma.datmasoft.dao;


import java.util.ArrayList;
import pe.datma.datmasoft.modulos.Curso;

public interface CursoDAO {
    int insertarCurso(Curso modulo);
    int modificarCurso(Curso modulo);
    int eliminarCurso(int idModulo);
    int insertarRequerimiento(int idCursoDep,int idCursoReq,String descripcion);
    ArrayList<Curso> listarCurso(int idModulo);
}
