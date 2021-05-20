/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.mysql;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.TipoInternetDAO;
import pe.datma.datmasoft.logistica.TipoInternet;

/**
 *
 * @author JLHP
 */
public class TipoInternetMySQL implements TipoInternetDAO {
    Connection con;
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<TipoInternet> listar() {
        ArrayList<TipoInternet> tipoInternets = new ArrayList<TipoInternet>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_TIPOINTERNET()}");
            rs = cs.executeQuery();
            while(rs.next()){
                TipoInternet tipoInternet=new TipoInternet();
                tipoInternet.setIdTipoInternet(rs.getInt("idtipointernet"));
                tipoInternet.setDescripcion(rs.getString("descripcion"));
                tipoInternets.add(tipoInternet);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return tipoInternets;
    }

    @Override
    public int insertar(TipoInternet tipoInternet) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_TIPOINTERNET(?,?)}");
            cs.registerOutParameter("_id_tipointernet", java.sql.Types.INTEGER);
            cs.setString("_descripcion", tipoInternet.getDescripcion());
            cs.executeUpdate();
            tipoInternet.setIdTipoInternet(cs.getInt("_id_tipointernet"));
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(TipoInternet tipoInternet) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_TIPOINTERNET(?,?)}");
            cs.setInt("_id_tipointernet", tipoInternet.getIdTipoInternet());
            cs.setString("_descripcion", tipoInternet.getDescripcion());
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

    @Override
    public int eliminar(int idTipoInternet) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ELIMINAR_TIPOINTERNET(?)}");
            cs.setInt("_id_tipointernet", idTipoInternet);
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
