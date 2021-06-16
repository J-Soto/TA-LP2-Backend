package pe.datma.datmasoft.mysql;

import java.sql.CallableStatement;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.ActividadDAO;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.datma.datmasoft.modulos.Actividad;
import pe.datma.datmasoft.modulos.Documento;

public class ActividadMySQL implements ActividadDAO{

    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public ArrayList<Actividad> listarActividad() {
        ArrayList<Actividad> actividades = new ArrayList<Actividad>();
           
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call LISTAR_ACTIVIDAD()}";
            cs = con.prepareCall(instruccion);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Actividad actividad = new Actividad();
                actividad.setNombre(rs.getString("nombre"));
                actividad.setFecha(rs.getTimestamp("fechaInicial"));
                actividad.setHoraInicio(rs.getTime("horainicio").toLocalTime());
                actividad.setHoraFin(rs.getTime("horafin").toLocalTime());
              
                actividades.add(actividad);
            }
            
            rs.close();
            cs.close();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return actividades;
    }

    @Override
    public int eliminarActividad(int idActividad) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ELIMINAR_ACTIVIDAD(?)}");
            cs.setInt("_id_actividad", idActividad);
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
    public int insertarActividad(Actividad actividad,int idsemana) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL INSERTAR_ACTIVIDAD(?,?,?,?,?,?,?)}");
            cs.registerOutParameter("idactividad", java.sql.Types.INTEGER);
            cs.setInt("_fidsemana", idsemana);
            cs.setString("_nombre", actividad.getNombre());
            cs.setDate("_fechaInicial", new java.sql.Date(actividad.getFecha().getTime()));
            cs.setTime("_horainicio", java.sql.Time.valueOf(actividad.getHoraInicio()));
            cs.setTime("_horafin", java.sql.Time.valueOf(actividad.getHoraFin()));
            cs.setString("_link", actividad.getLinkZoom());
            cs.executeUpdate();
            actividad.setIdActividad(cs.getInt("idactividad"));
            resultado = actividad.getIdActividad();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificarActividad(Actividad actividad) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_ACTIVIDAD(?,?,?,?,?,?)}");
            cs.setInt("_id_actividad", actividad.getIdActividad());
            cs.setString("_nombre", actividad.getNombre());
            cs.setDate("_fechaInicial", new java.sql.Date(actividad.getFecha().getTime()));
            cs.setTime("_horainicio", java.sql.Time.valueOf(actividad.getHoraInicio()));
            cs.setTime("_horafin", java.sql.Time.valueOf(actividad.getHoraFin()));
            cs.setString("_link", actividad.getLinkZoom());
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
