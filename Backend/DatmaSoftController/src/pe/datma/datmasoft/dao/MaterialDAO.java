package pe.datma.datmasoft.dao;


import java.util.ArrayList;
import pe.datma.datmasoft.modulos.Material;

public interface MaterialDAO {
    int insertar(Material material);
    int modificar(Material material);
    int eliminar(int idMaterial);
    ArrayList<Material> listar();
}
