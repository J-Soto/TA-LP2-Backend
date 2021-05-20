package pe.datma.datmasoft.dao;

import pe.datma.datmasoft.rrhh.Cuidador;
import pe.datma.datmasoft.rrhh.Infante;

import java.util.ArrayList;

public interface InfanteCuidadorDAO {
    int insertar(int idInfante, int idCuidador);
    int eliminarInfante(int idInfante);
    int eliminarCuidador(int idCuidador);
    ArrayList<Cuidador> listarCuidadores(int idInfante);
    ArrayList<Infante> listarInfantes(int idCuidador);
}
