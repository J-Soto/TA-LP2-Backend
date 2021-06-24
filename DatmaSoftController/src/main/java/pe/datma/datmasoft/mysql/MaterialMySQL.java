package pe.datma.datmasoft.mysql;




import java.sql.*;
import java.util.ArrayList;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.MaterialDAO;
import pe.datma.datmasoft.modulos.Documento;
import pe.datma.datmasoft.modulos.Video;
import pe.datma.datmasoft.rrhh.Distrito;

public class MaterialMySQL implements MaterialDAO{

    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertarMaterialVideo(Video video) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL INSERTAR_MATERIAL_VIDEO(?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_material", java.sql.Types.INTEGER);
            cs.setInt("_fidactividad", video.getActividad().getIdActividad());
            cs.setInt("_tipoarchivo", video.getTipoMaterial());
            cs.setString("_descripcion", video.getDescripcion());
            cs.setString("_link", video.getLinkVideo());
            cs.setString("_duracion", video.getDuracion());
            cs.executeUpdate();
            video.setIdMaterial(cs.getInt("_id_material"));
            resultado = video.getIdMaterial();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int insertarMaterialDocumento(Documento documento) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL LISTAR_MATERIAL_DOCUMENTO(?,?,?,?,?)}");
            cs.registerOutParameter("_id_material", java.sql.Types.INTEGER);
            cs.setInt("_fidactividad", documento.getActividad().getIdActividad());
            cs.setInt("_tipoarchivo", documento.getTipoMaterial());
            cs.setString("_descripcion", documento.getDescripcion());
            cs.setBytes("_archivo", documento.getDocPDF());
            cs.executeUpdate();
            documento.setIdMaterial(cs.getInt("_id_material"));
            resultado = documento.getIdMaterial();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificarMaterialVideo(Video video) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_MATERIAL_VIDEO(?,?,?,?)}");
            cs.setInt("_id_material_video", video.getIdMaterial());
            cs.setString("_descripcion", video.getDescripcion());
            cs.setString("_link", video.getLinkVideo());
            cs.setString("_duracion", video.getDuracion());
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
    public int modificarMaterialDocumento(Documento documento) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_MATERIAL_DOCUMENTO(?,?,?,?)}");
            cs.setInt("_id_material", documento.getIdMaterial());
            cs.setInt("_tipoarchivo", documento.getTipoMaterial());
            cs.setString("_descripcion", documento.getDescripcion());
            cs.setBytes("_archivo", documento.getDocPDF());
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
    public ArrayList<Video> listarVideos() {
        ArrayList<Video> videos = new ArrayList<Video>();
           
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call LISTAR_MATERIAL_VIDEO()}";
            cs = con.prepareCall(instruccion);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Video video = new Video();
                video.setDescripcion(rs.getString("descripcion"));
                video.setLinkVideo(rs.getString("link"));
                video.setDuracion(rs.getString("duracion"));
                
                videos.add(video);
            }
            
            rs.close();
            cs.close();
            con.close();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return videos;
    }

    @Override
    public ArrayList<Documento> listarDocumentos() {
        ArrayList<Documento> documentos = new ArrayList<Documento>();
           
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call LISTAR_MATERIAL_DOCUMENTO()}";
            cs = con.prepareCall(instruccion);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Documento documento = new Documento();
                documento.setIdMaterial(rs.getInt("idmaterial"));
                documento.setTipoMaterial(rs.getInt("tipoarchivo"));
                documento.setDescripcion(rs.getString("descripcion"));
                documento.setEstado(rs.getInt("activo"));
                documento.setDocPDF(rs.getBytes("archivo"));
              
                documentos.add(documento);
            }
            
            rs.close();
            cs.close();
            con.close();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return documentos;
    }

    @Override
    public int eliminarMaterial(int idMaterial) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ELIMINAR_MATERIAL(?)}");
            cs.setInt("_id_material", idMaterial);
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
