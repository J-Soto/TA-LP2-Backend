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
    CallableStatement cst;
    ResultSet rs;
    
    
    @Override
    public ArrayList<Distrito> listarDistritos() {
        ArrayList<Distrito> distritos = new ArrayList<>();
           
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call LISTAR_DISTRITOS()}";
            cst = con.prepareCall(instruccion);
            rs = cst.executeQuery();
            
            while(rs.next()){
                Distrito distrito = new Distrito();
                distrito.setIdDistrito(rs.getInt("iddistrito"));
                distrito.setNombre(rs.getString("nombre"));
              
                distritos.add(distrito);
            }
            
            rs.close();
            cst.close();
            con.close();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        
        return distritos;
    }
    
}
