package pe.datma.datmasoft.dao;

import java.util.ArrayList;
import pe.datma.datmasoft.rrhh.Distrito;


public interface DistritoDAO {
    
    ArrayList<Distrito> listarDistritos();
    int insertarDistrito(Distrito distrito);
    int modificarDistrito(Distrito distrito);
}
