package pe.datma.datmasoft.mysql;

import java.sql.CallableStatement;
import pe.datma.datmasoft.config.DBManager;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.datma.datmasoft.dao.TutorDAO;
import pe.datma.datmasoft.rrhh.Distrito;
import pe.datma.datmasoft.rrhh.Tutor;

public class TutorMySQL implements TutorDAO {
    Connection con;
    CallableStatement cst;
    ResultSet rs;
    
    
    @Override
    public int insertarTutor(Tutor tutor) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call INSERTAR_TUTOR(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}";
            cst = con.prepareCall(instruccion);
            
            cst.registerOutParameter("_id_tutor", java.sql.Types.INTEGER); //id_persona
            cst.registerOutParameter("_id_usuario", java.sql.Types.INTEGER);
            cst.setInt("_fiddistrito", tutor.getDistrito().getIdDistrito());
            cst.setString("_dni", tutor.getDNI());
            cst.setString("_nombre", tutor.getNombre());
            cst.setString("_apellidopaterno", tutor.getApellidoPaterno());
            cst.setString("_apellidomaterno", tutor.getApellidoMaterno());
            cst.setDate("_fechanacimiento", new java.sql.Date(tutor.getFechaNacimiento().getTime()));
            cst.setString("_genero", String.valueOf(tutor.getGenero()));
            cst.setInt("_edad", tutor.getEdad());
            cst.setString("_telefono", tutor.getTelefono());
            cst.setString("_celular", tutor.getCelular());
            cst.setString("_correo", tutor.getCorreo());
            cst.setString("_user", tutor.getUser());
            cst.setString("_password", tutor.getPassword());
            cst.setBytes("_foto", tutor.getFotoPerfil());
            cst.setInt("_gestante",tutor.getGestante() );
            cst.setInt("_preferenciaDias",tutor.getDia() );
            cst.setInt("_preferenciaTurno",tutor.getTurno() );
            cst.setInt("_bajorecursos",tutor.getBajoRecursos() );
            cst.setInt("_tipoInternet",tutor.getTiposConexion());
            cst.setInt("_redSocial",tutor.getRedesSociales());
            cst.setInt("_tipoDispositivo",tutor.getDispositivos() );
            
            cst.executeUpdate();
            tutor.setIdPersona(cst.getInt("_id_tutor")); //idPersona == idTutor
            tutor.setIdUsuario(cst.getInt("_id_usuario"));
            tutor.setActivo(1);
            tutor.setActivoTutor(1);
            
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
    public int modificarTutor(Tutor tutor) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call MODIFICAR_TUTOR(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}";
            cst = con.prepareCall(instruccion);
            
            cst.setInt("_id_tutor", tutor.getIdPersona()); //id_persona
            cst.setInt("_id_usuario", tutor.getIdUsuario());
            cst.setInt("_fiddistrito", tutor.getDistrito().getIdDistrito());
            cst.setString("_dni", tutor.getDNI());
            cst.setString("_nombre", tutor.getNombre());
            cst.setString("_apellidopaterno", tutor.getApellidoPaterno());
            cst.setString("_apellidomaterno", tutor.getApellidoMaterno());
            cst.setDate("_fechanacimiento", new java.sql.Date(tutor.getFechaNacimiento().getTime()));
            cst.setString("_genero", String.valueOf(tutor.getGenero()));
            cst.setInt("_edad", tutor.getEdad());
            cst.setString("_telefono", tutor.getTelefono());
            cst.setString("_celular", tutor.getCelular());
            cst.setString("_correo", tutor.getCorreo());
            cst.setString("_user", tutor.getUser());
            cst.setString("_password", tutor.getPassword());
            cst.setBytes("_foto", tutor.getFotoPerfil());
            cst.setInt("_gestante",tutor.getGestante() );
            cst.setInt("_preferenciaDias",tutor.getDia() );
            cst.setInt("_preferenciaTurno",tutor.getTurno() );
            cst.setInt("_bajorecursos",tutor.getBajoRecursos() );
            cst.setInt("_tipoInternet",tutor.getTiposConexion());
            cst.setInt("_redSocial",tutor.getRedesSociales());
            cst.setInt("_tipoDispositivo",tutor.getDispositivos() );
            
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
    public int eliminarTutor(int idTutor, int idUsuario) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call ELIMINAR_TUTOR(?,?)}";
            cst = con.prepareCall(instruccion);
            cst.setInt("_id_tutor", idTutor);
            cst.setInt("_id_usuario", idUsuario);
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
    public ArrayList<Tutor> listarTutores() {
        ArrayList<Tutor> tutores = new ArrayList<>();
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call LISTAR_TUTORES()}";
            cst = con.prepareCall(instruccion);
            rs = cst.executeQuery();
            
            while(rs.next()){
                Tutor tutor = new Tutor();
                tutor.setIdPersona(rs.getInt("idpersona"));
                tutor.setDNI(rs.getString("dni"));
                tutor.setNombre(rs.getString("nombre"));
                tutor.setApellidoPaterno(rs.getString("apellidopaterno"));
                tutor.setApellidoMaterno(rs.getString("apellidomaterno"));
                tutor.setFechaNacimiento(rs.getDate("fechanacimiento"));
                tutor.setGenero(rs.getString("genero").charAt(0));
                tutor.setEdad(rs.getInt("edad"));
                tutor.setTelefono(rs.getString("telefono"));
                tutor.setCelular(rs.getString("celular"));
                tutor.setCorreo(rs.getString("correo"));
                tutor.setDistrito(new Distrito());
                tutor.getDistrito().setIdDistrito(rs.getInt("iddistrito"));
                tutor.getDistrito().setNombre(rs.getString("nombre_distrito"));
                tutor.setIdUsuario(rs.getInt("idusuario"));
                tutor.setUser(rs.getString("user"));
                tutor.setPassword(rs.getString("password"));
                tutor.setTipo(rs.getInt("tipo"));
                tutor.setFotoPerfil(rs.getBytes("foto"));
                tutor.setGestante(rs.getInt("gestante"));
                tutor.setDia(rs.getInt("preferenciaDias"));
                tutor.setTurno(rs.getInt("preferenciaTurno"));
                tutor.setBajoRecursos(rs.getInt("bajosrecursos"));
                tutor.setTiposConexion(rs.getInt("tipointernet"));
                tutor.setRedesSociales(rs.getInt("redsocial"));
                tutor.setDispositivos(rs.getInt("tipodispositivo"));
                tutor.setActivo(1);
                tutor.setActivoTutor(1);
                tutores.add(tutor);
            }
           
            
            cst.close();
            con.close();       
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{ con.close(); }catch(Exception ex){}
        }
        
        return tutores;
    }
}
