package pe.datma.datmasoft.dao;

import pe.datma.datmasoft.familias.Grupo;

import java.util.ArrayList;

public interface GrupoDAO {
    int insertar(Grupo grupo, int idModulo);
    int modificar(Grupo grupo);
    int eliminar(int idGrupo);
    ArrayList<Grupo> listar(int idGrupo);
}
