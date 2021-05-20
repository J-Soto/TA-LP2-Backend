package pe.datma.datmasoft.dao;

import pe.datma.datmasoft.rrhh.Cuidador;

import java.util.ArrayList;

public interface CuidadorDAO {
    ArrayList<Cuidador> listar();
    ArrayList<Cuidador> listar(int idCuidador);
}
