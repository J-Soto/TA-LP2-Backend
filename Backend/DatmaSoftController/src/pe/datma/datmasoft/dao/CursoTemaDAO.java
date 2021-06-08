package pe.datma.datmasoft.dao;

import java.util.ArrayList;
import pe.datma.datmasoft.modulos.CursoTema;

public interface CursoTemaDAO {
    int insertar(CursoTema ct);
    int modificar(CursoTema ct);
    ArrayList<CursoTema> listar();
}
