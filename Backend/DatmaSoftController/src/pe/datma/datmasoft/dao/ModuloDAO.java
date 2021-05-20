package pe.datma.datmasoft.dao;

import pe.datma.datmasoft.cursos.Modulo;

import java.util.ArrayList;

public interface ModuloDAO {
    int insertar(Modulo modulo);
    int modificar(Modulo modulo);
    int eliminar(int idModulo);
    ArrayList<Modulo> listar(int idModulo);
}
