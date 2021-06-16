package pe.datma.datmasoft.dao;

import java.util.ArrayList;
import pe.datma.datmasoft.modulos.Semana;

public interface SemanaDAO {
    int insertar(Semana semana, int fidCursoTema);
    int modificar(Semana semana);
    ArrayList<Semana> listar();
}
