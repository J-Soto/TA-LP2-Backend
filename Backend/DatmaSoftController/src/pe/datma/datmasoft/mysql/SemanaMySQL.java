package pe.datma.datmasoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.SemanaDAO;
import pe.datma.datmasoft.modulos.Semana;

public class SemanaMySQL implements SemanaDAO {
    Connection con;
    CallableStatement cst;
    ResultSet rs;

    @Override
    public int insertar(Semana semana) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String query = "{call INSERTAR_SEMANA(?,?,?,?,?)}";
            cst = con.prepareCall(query);
            
            cst.registerOutParameter("_idsemana", java.sql.Types.INTEGER); 
            cst.setInt("_fidcurso", semana.getCurso().getIdCurso());
            cst.setString("_nombre", semana.getNombre());
            cst.setString("_descripcion", semana.getDescripcion());
            cst.setDate("_fechainicio", new java.sql.Date(semana.getFechaInicio().getTime()));
           
            cst.executeUpdate();
            resultado = cst.getInt("_idsemana");
            semana.setId(cst.getInt("_idsemana"));
        }catch(ClassNotFoundException | SQLException ex){
            System.out.println(ex.getMessage());
        }finally{
            try{ cst.close(); }catch(SQLException ex){}
            try{ con.close(); }catch(SQLException ex){}
        }
        return resultado;
    }

    @Override
    public int modificar(Semana semana) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String query = "{call MODIFICAR_SEMANA(?,?,?,?,?)}";
            cst = con.prepareCall(query);
            
            cst.setInt("_idsemana", semana.getId());
            cst.setInt("_fidcurso", semana.getCurso().getIdCurso());
            cst.setString("_nombre", semana.getNombre());
            cst.setString("_descripcion", semana.getDescripcion());
            cst.setDate("_fechainicio", new java.sql.Date(semana.getFechaInicio().getTime()));
           
            cst.executeUpdate();
            resultado = 1;
        }catch(ClassNotFoundException | SQLException ex){
            System.out.println(ex.getMessage());
        }finally{
            try { cst.close(); } catch(SQLException ex) {}
            try { con.close(); } catch(SQLException ex) {}
        }
        return resultado;
    }

    @Override
    public ArrayList<Semana> listar() {
        ArrayList<Semana> arr = new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String query = "{call LISTAR_SEMANA()}";
            cst = con.prepareCall(query);
            rs = cst.executeQuery();
            while (rs.next()) {
                Semana semana = new Semana();
                semana.setId(rs.getInt("idsemana"));
                semana.setNombre(rs.getString("nombre"));
                semana.setDescripcion(rs.getString("descripcion"));
                semana.setFechaInicio(rs.getDate("fechainicio"));
                arr.add(semana);
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
    
}
