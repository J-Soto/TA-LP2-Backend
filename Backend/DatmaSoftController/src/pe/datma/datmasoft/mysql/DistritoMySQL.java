package pe.datma.datmasoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.DistritoDAO;
import pe.datma.datmasoft.rrhh.Distrito;


public class DistritoMySQL implements DistritoDAO{

    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    
    @Override
    public ArrayList<Distrito> listarDistritos(String nombre) {
        ArrayList<Distrito> distritos = new ArrayList<>();
           
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call LISTAR_DISTRITOS(?)}";
            cs = con.prepareCall(instruccion);
            cs.setString("_nombre", nombre);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Distrito distrito = new Distrito();
                distrito.setIdDistrito(rs.getInt("iddistrito"));
                distrito.setNombre(rs.getString("nombre"));
              
                distritos.add(distrito);
            }
            
            rs.close();
            cs.close();
            con.close();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        
        return distritos;
    }

    @Override
    public int insertarDistrito(Distrito distrito) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL INSERTAR_DISTRITO(?,?)}");
            cs.registerOutParameter("_id_distrito", java.sql.Types.INTEGER);
            cs.setString("_nombre",distrito.getNombre());
            cs.executeUpdate();
            distrito.setIdDistrito(cs.getInt("_id_distrito"));
            resultado = distrito.getIdDistrito();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificarDistrito(Distrito distrito) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_DISTRITO(?,?)}");
            cs.setInt("_id_distrito", distrito.getIdDistrito());
            cs.setString("_nombre", distrito.getNombre());
            cs.executeUpdate();
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;
    }
    
    
}
