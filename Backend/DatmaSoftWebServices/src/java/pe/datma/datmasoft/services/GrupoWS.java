package pe.datma.datmasoft.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.datma.datmasoft.dao.GrupoDAO;
import pe.datma.datmasoft.familias.Grupo;
import pe.datma.datmasoft.mysql.GrupoMySQL;

@WebService(serviceName = "GrupoWS")
public class GrupoWS {
    private GrupoDAO daoGrupo;
    
    public GrupoWS() {
        this.daoGrupo = new GrupoMySQL();
    }
    
    @WebMethod(operationName = "listarGrupoPorIdCurso")
    public ArrayList<Grupo> listarGrupoPorIdCurso(@WebParam(name = "idCurso") int idCurso) {
        ArrayList<Grupo> arr = new ArrayList<>();
        try {
            arr = daoGrupo.listarGrupoPorIdCurso(idCurso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return arr;
    }
    
    @WebMethod(operationName = "insertarGrupo")
    public int insertarGrupo(@WebParam(name = "idCurso") int idCurso, @WebParam(name = "grupo") Grupo grupo) {
        int resultado = 0;
        try {
             resultado = daoGrupo.insertarGrupo(idCurso, grupo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarGrupo")
    public int eliminarGrupo(@WebParam(name = "idGrupo")int idGrupo) {
        int resultado = 0;
        try {
            resultado = daoGrupo.eliminarGrupo(idGrupo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
