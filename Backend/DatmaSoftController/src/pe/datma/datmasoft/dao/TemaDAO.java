package pe.datma.datmasoft.dao;

import java.util.ArrayList;
import pe.datma.datmasoft.modulos.Tema;

public interface TemaDAO {
    ArrayList<Tema> listar();
    ArrayList<Tema> listar(int idEje);
}
