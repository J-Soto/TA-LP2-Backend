package pe.datma.datmasoft.mysql;

import java.sql.CallableStatement;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.ActividadDAO;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.datma.datmasoft.modulos.Actividad;
import pe.datma.datmasoft.modulos.Asistencia;
import pe.datma.datmasoft.modulos.Documento;
import pe.datma.datmasoft.modulos.Video;
import pe.datma.datmasoft.rrhh.Usuario;

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
                actividad.setHoraInicioStr(rs.getString("horainicio"));
                actividad.setHoraFinStr(rs.getString("horafin"));
                actividad.setIdSemana(rs.getInt("fidsemana"));
                actividades.add(actividad);
            }
            
            rs.close();
            cs.close();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return actividades;
    }
    
    @Override
    public ArrayList<Actividad> listarActividadesIdSemana(int idSemana) {
        ArrayList<Actividad> actividades = new ArrayList<>();
           
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call LISTAR_ACTIVIDADES_POR_ID_SEMANA(?)}";
            cs = con.prepareCall(instruccion);
            cs.setInt("_idsemana", idSemana);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Actividad actividad = new Actividad();
                actividad.setNombre(rs.getString("nombre"));
                actividad.setFecha(rs.getTimestamp("fechaInicial"));
                actividad.setHoraInicioStr(rs.getString("horainicio"));
                actividad.setHoraFinStr(rs.getString("horafin"));
                actividad.setIdSemana(rs.getInt("fidsemana"));
                actividades.add(actividad);
            }
            
            rs.close();
            cs.close();
        } catch (ClassNotFoundException | SQLException e) {
            System.out.println(e.getMessage());
        }finally{
            try{con.close();}catch(SQLException ex){System.out.println(ex.getMessage());}
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
            cs.setString("_horainicio", actividad.getHoraInicioStr());
            cs.setString("_horafin", actividad.getHoraFinStr());
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
            cs.setString("_horainicio", actividad.getHoraInicioStr());
            cs.setString("_horafin", actividad.getHoraFinStr());
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

    @Override
    public ArrayList<Asistencia> listarAsistenciasPorIdActividadYGrupo(int idActividad, int idGrupo) {
        ArrayList<Asistencia> asistencias = new ArrayList<>();
        
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{CALL LISTAR_ASISTENCIAS_POR_ID_ACTIVIDAD(?,?)}";
            cs = con.prepareCall(instruccion);
            cs.setInt("_idactividad", idActividad);
            cs.setInt("_idgrupo", idGrupo);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Asistencia asistencia = new Asistencia();
                asistencia.setId(rs.getInt("idasistencia"));
                asistencia.setUsuario(new Usuario());
                asistencia.getUsuario().setIdUsuario(rs.getInt("fidusuario"));
                asistencia.getUsuario().setIdPersona(rs.getInt("idtutor"));
                asistencia.setDescripcion(rs.getString("descripcion"));
                asistencia.setTipo(rs.getInt("tipoasistencia"));
                asistencias.add(asistencia);
            }
            
            rs.close();
            cs.close();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        
        return asistencias;
    }

    @Override
    public ArrayList<Documento> listarDocumentosPorIdActividad(int idActividad) {
        ArrayList<Documento> documentos = new ArrayList<>();
        
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{CALL LISTAR_DOCUMENTOS_POR_ID_ACTVIDAD(?)}";
            cs = con.prepareCall(instruccion);
            cs.setInt("_idactividad", idActividad);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Documento documento = new Documento();
                documento.setIdMaterial(rs.getInt("idmaterial"));
                documento.setTipoMaterial(rs.getInt("tipoarchivo"));
                documento.setDescripcion(rs.getString("descripcion"));
                documento.setDocPDF(rs.getBytes("archivo"));
                
                documentos.add(documento);
            }
            
            rs.close();
            cs.close();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        
        return documentos;
    }

    @Override
    public ArrayList<Video> listarVideosPorIdActividad(int idActividad) {
        ArrayList<Video> videos = new ArrayList<>();
        
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{CALL LISTAR_VIDEOS_POR_ID_ACTVIDAD(?)}";
            cs = con.prepareCall(instruccion);
            cs.setInt("_idactividad", idActividad);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Video video = new Video();
                video.setIdMaterial(rs.getInt("idmaterial"));
                video.setTipoMaterial(rs.getInt("tipoarchivo"));
                video.setDescripcion(rs.getString("descripcion"));
                video.setLinkVideo(rs.getString("link"));
                video.setDuracion(rs.getString("duracion"));
                videos.add(video);
            }
            
            rs.close();
            cs.close();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        
        return videos;
    }    
}
