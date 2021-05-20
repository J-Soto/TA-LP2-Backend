package pe.datma.datmasoft.dao;

import pe.datma.datmasoft.rrhh.Infante;

import java.util.ArrayList;

public interface InfanteDAO {
    int insertar(Infante infante);
    int modificar(Infante infante);
    int eliminar(int idInfante);
    ArrayList<Infante> listar();
    ArrayList<Infante> listar(int idInfante);
}
