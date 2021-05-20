package pe.datma.datmasoft.dao;

import pe.datma.datmasoft.cursos.actividades.asincrona.Material;

import java.util.ArrayList;

public interface MaterialDAO {
    int insertar(Material material);
    int modificar(Material material);
    int eliminar(int idMaterial);
    ArrayList<Material> listar();
}
