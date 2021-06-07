package pe.datma.datmasoft.mysql;

import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.GrupoDAO;
import pe.datma.datmasoft.familias.Grupo;

import java.sql.*;
import java.util.ArrayList;

public class GrupoMySQL implements  GrupoDAO{
    Connection con;
    CallableStatement cst;
    ResultSet rs;

    @Override
    public int insertar(Grupo grupo, int idModulo) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call INSERTAR_GRUPO(?,?,?,?)}";
            cst = con.prepareCall(instruccion);
            
            cst.registerOutParameter("idgrupo", java.sql.Types.INTEGER); 
            cst.setInt("fidcurso", idModulo);
            cst.setString("_nombre", grupo.getNombrePromocion());
            cst.setInt("_maxtutores", grupo.getMaxCantCuidadores());
           
            cst.executeUpdate();
            grupo.setIdGrupo(cst.getInt("idgrupo"));
            cst.close();
            con.close();       
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{ con.close(); }catch(Exception ex){}
        }
        return resultado;
    }

    @Override
    public int modificar(Grupo grupo) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call MODIFICAR_GRUPO(?,?,?)}";
            cst = con.prepareCall(instruccion);
            cst.setInt("_id_grupo", grupo.getIdGrupo()); //id_persona
            cst.setString("_nombre", grupo.getNombrePromocion());
            cst.setInt("_maxtutores", grupo.getMaxCantCuidadores());
            cst.executeUpdate();
            cst.close();
            con.close();       
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{ con.close(); }catch(Exception ex){}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idGrupo) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call ELIMINAR_GRUPO(?)}";
            cst = con.prepareCall(instruccion);
            cst.setInt("_id_grupo",idGrupo);
            cst.executeUpdate();
            cst.close();
            con.close();       
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{ con.close(); }catch(Exception ex){}
        }
        return resultado;
    }

    @Override
    public ArrayList<Grupo> listar(int idGrupo) {
        ArrayList<Grupo> grupos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call LISTAR_GRUPO()}";
            cst = con.prepareCall(instruccion);
            rs = cst.executeQuery();   
            while(rs.next()){
                Grupo  grupo = new Grupo();
                grupo.setNombrePromocion(rs.getString("nombre"));
                grupo.setMaxCantCuidadores(rs.getInt("maxtutores"));
                grupos.add(grupo);
            }
            cst.close();
            con.close();       
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{ con.close(); }catch(Exception ex){}
        }
        return grupos;
    }
   
}
