package pe.datma.datmasoft.dao;


import java.util.ArrayList;
import pe.datma.datmasoft.modulos.Curso;

public interface CursoDAO {
    int insertar(Curso modulo);
    int modificar(Curso modulo);
    int eliminar(int idModulo);
    ArrayList<Curso> listar(int idModulo);
}
