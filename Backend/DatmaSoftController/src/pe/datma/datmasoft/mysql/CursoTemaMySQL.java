package pe.datma.datmasoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.CursoTemaDAO;
import pe.datma.datmasoft.modulos.CursoTema;
import pe.datma.datmasoft.modulos.Tema;

public class CursoTemaMySQL implements CursoTemaDAO {
    Connection con;
    CallableStatement cst;
    ResultSet rs;

    @Override
    public int insertar(CursoTema ct) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String query = "{call INSERTAR_CURSOTEMA(?,?,?,?,?)}";
            cst = con.prepareCall(query);
            
            cst.registerOutParameter("_id_cursotema", java.sql.Types.INTEGER);
            cst.setInt("_fidcurso", ct.getCurso().getIdCurso());
            cst.setInt("_fidtema", ct.getTema().getId());
            cst.setDate("_fechainicio", new java.sql.Date(ct.getFechainicio().getTime()));
            cst.setDate("_fechafin", new java.sql.Date(ct.getFechafin().getTime()));
            
            cst.executeUpdate();
            ct.setId(cst.getInt("_id_cursotema"));
            resultado = 1;
        } catch(ClassNotFoundException | SQLException ex){
            System.out.println(ex.getMessage());
        } finally{
            try{ cst.close(); }catch(SQLException ex){}
            try{ con.close(); }catch(SQLException ex){}
        }
        return resultado;
    }

    @Override
    public int modificar(CursoTema ct) {
        int resultado = 0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String query = "{call MODIFICAR_CURSOTEMA(?,?,?,?,?)}";
            cst = con.prepareCall(query);
            
            cst.setInt("_id_cursotema", ct.getId());
            cst.setInt("_fidcurso", ct.getCurso().getIdCurso());
            cst.setInt("_fidtema", ct.getTema().getId());
            cst.setDate("_fechainicio", new java.sql.Date(ct.getFechainicio().getTime()));
            cst.setDate("_fechafin", new java.sql.Date(ct.getFechafin().getTime()));
            
            cst.executeUpdate();
            resultado = 1;
        } catch(ClassNotFoundException | SQLException ex){
            System.out.println(ex.getMessage());
        } finally{
            try{ cst.close(); }catch(SQLException ex){}
            try{ con.close(); }catch(SQLException ex){}
        }
        return resultado;
    }

    @Override
    public ArrayList<CursoTema> listar() {
        ArrayList<CursoTema> arr = new ArrayList<>();
        TemaMySQL temasql = new TemaMySQL();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String query = "{call LISTAR_CURSOTEMA()}";
            cst = con.prepareCall(query);
            rs = cst.executeQuery();
            ArrayList<Tema> arrTema = temasql.listar();
            while (rs.next()) {
                CursoTema ct = new CursoTema();
                ct.setId(rs.getInt("idcurso_tema"));
                ct.setFechainicio(rs.getDate("fechainicio"));
                ct.setFechafin(rs.getDate("fechafin"));
                for (Tema t: arrTema) {
                    if (t.getId() == rs.getInt("fidtema")) {
                        ct.setTema(t);
                        break;
                    }
                }
                // TODO: setear curso
                arr.add(ct);
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
