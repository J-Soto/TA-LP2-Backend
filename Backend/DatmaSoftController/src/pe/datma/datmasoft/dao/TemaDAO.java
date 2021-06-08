package pe.datma.datmasoft.dao;

import java.util.ArrayList;
import pe.datma.datmasoft.modulos.Tema;

public interface TemaDAO {
    ArrayList<Tema> listar();
    int insertar(Tema tema);
    int modificar(Tema tema);
}
