package pe.datma.datmasoft.mysql;


import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.TemaDAO;
import pe.datma.datmasoft.modulos.Tema;

public class TemaMySQL implements TemaDAO {
    Connection con;
    CallableStatement cst;
    ResultSet rs;
    
    @Override
    public ArrayList<Tema> listar() {
        ArrayList<Tema> arr = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String query = "{call LISTAR_TEMA()}";
            cst = con.prepareCall(query);
            rs = cst.executeQuery();
            while (rs.next()) {
                Tema tema = new Tema();
                tema.setId(rs.getInt("idtema"));
                tema.setNombre(rs.getString("nombre"));
                tema.setDescripcion(rs.getString("descripcion"));
                arr.add(tema);
            }
        } catch(ClassNotFoundException | SQLException ex) {
            System.out.println(ex.getMessage());
        } finally {
            try { rs.close(); } catch (SQLException ex) {}
            try { cst.close(); } catch (SQLException ex) {}
            try { con.close(); } catch (SQLException ex) {}
        }
        return arr;
    }

    @Override
    public int insertar(Tema tema) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String query = "{call INSERTAR_TEMA(?,?,?)}";
            cst = con.prepareCall(query);
            
            cst.registerOutParameter("_idtema", java.sql.Types.INTEGER); 
            cst.setString("_nombre", tema.getNombre());
            cst.setString("_descripcion", tema.getDescripcion());
           
            cst.executeUpdate();
            tema.setId(cst.getInt("_idtema"));
            resultado = cst.getInt("_idtema");
        }catch(ClassNotFoundException | SQLException ex){
            System.out.println(ex.getMessage());
        }finally{
            try{ cst.close(); }catch(SQLException ex){}
            try{ con.close(); }catch(SQLException ex){}
        }
        return resultado;
    }

    @Override
    public int modificar(Tema tema) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String query = "{call MODIFICAR_TEMA(?,?,?)}";
            cst = con.prepareCall(query);
            
            cst.setInt("_idtema", tema.getId());
            cst.setString("_nombre", tema.getNombre());
            cst.setString("_descripcion", tema.getDescripcion());
           
            cst.executeUpdate();
            resultado = 1;
        } catch(ClassNotFoundException | SQLException ex) {
            System.out.println(ex.getMessage());
        } finally {
            try { cst.close(); }catch(SQLException ex){}
            try { con.close(); }catch(SQLException ex){}
        }
        return resultado;
    }
    
}
