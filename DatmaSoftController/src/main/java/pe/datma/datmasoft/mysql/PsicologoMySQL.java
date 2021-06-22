package pe.datma.datmasoft.mysql;

import at.favre.lib.crypto.bcrypt.BCrypt;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.PsicologoDAO;
import pe.datma.datmasoft.rrhh.Distrito;
import pe.datma.datmasoft.rrhh.Psicologo;


public class PsicologoMySQL  implements PsicologoDAO{

    Connection con;
    CallableStatement cst;
    ResultSet rs;
    
    
    @Override
    public int insertarPsicologo(Psicologo psicologo) {
        int resultado = -1;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call INSERTAR_PSICOLOGO(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}";
            cst = con.prepareCall(instruccion);
            cst.registerOutParameter("_id_psicologo", java.sql.Types.INTEGER); //id_persona
            cst.registerOutParameter("_id_usuario", java.sql.Types.INTEGER);
            cst.setInt("_fiddistrito", psicologo.getDistrito().getIdDistrito());
            cst.setString("_dni", psicologo.getDNI());
            cst.setString("_nombre", psicologo.getNombre());
            cst.setString("_apellidopaterno", psicologo.getApellidoPaterno());
            cst.setString("_apellidomaterno", psicologo.getApellidoMaterno());
            cst.setDate("_fechanacimiento", new java.sql.Date(psicologo.getFechaNacimiento().getTime()));
            cst.setString("_genero", String.valueOf(psicologo.getGenero()));
            cst.setInt("_edad", psicologo.getEdad());
            cst.setString("_telefono", psicologo.getTelefono());
            cst.setString("_celular", psicologo.getCelular());
            cst.setString("_correo", psicologo.getCorreo());
            cst.setString("_user", psicologo.getUser());
            String hash = BCrypt.withDefaults().hashToString(12, psicologo.getPassword().toCharArray());
            cst.setString("_password", hash);
            cst.setBytes("_foto", psicologo.getFotoPerfil());
            
            
            cst.executeUpdate();
            psicologo.setIdPersona(cst.getInt("_id_psicologo")); //idPersona == idPsicologo
            psicologo.setIdUsuario(cst.getInt("_id_usuario"));
            psicologo.setActivo(1);
            psicologo.setActivoPsicologo(1);
            
            resultado = cst.getInt("_id_psicologo");
            cst.close();
            con.close();       
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{ con.close(); }catch(Exception ex){}
        }
        
        return resultado;
    }

    @Override
    public int modificarPsicologo(Psicologo psicologo) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call MODIFICAR_PSICOLOGO(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}";
            cst = con.prepareCall(instruccion);
            
            cst.setInt("_id_psicologo", psicologo.getIdPersona()); //id_persona
            cst.setInt("_id_usuario", psicologo.getIdUsuario());
            cst.setInt("_fiddistrito", psicologo.getDistrito().getIdDistrito());
            cst.setString("_dni", psicologo.getDNI());
            cst.setString("_nombre", psicologo.getNombre());
            cst.setString("_apellidopaterno", psicologo.getApellidoPaterno());
            cst.setString("_apellidomaterno", psicologo.getApellidoMaterno());
            cst.setDate("_fechanacimiento", new java.sql.Date(psicologo.getFechaNacimiento().getTime()));
            cst.setString("_genero", String.valueOf(psicologo.getGenero()));
            cst.setInt("_edad", psicologo.getEdad());
            cst.setString("_telefono", psicologo.getTelefono());
            cst.setString("_celular", psicologo.getCelular());
            cst.setString("_correo", psicologo.getCorreo());
            cst.setString("_user", psicologo.getUser());
            String hash = BCrypt.withDefaults().hashToString(12, psicologo.getPassword().toCharArray());
            cst.setString("_password", hash);
            cst.setBytes("_foto", psicologo.getFotoPerfil());

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
    public int eliminarPsicologo(int idPsicologo, int idUsuario) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call ELIMINAR_PSICOLOGO(?,?)}";
            cst = con.prepareCall(instruccion);
            cst.setInt("_id_psicologo", idPsicologo);
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
    public ArrayList<Psicologo> listarPsicologos(String nombre) {
        ArrayList<Psicologo> psicologos = new ArrayList<>();
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call LISTAR_PSICOLOGOS(?)}";
            cst = con.prepareCall(instruccion);
            cst.setString("_nombre", nombre);
            rs = cst.executeQuery();
            
            while(rs.next()){
                Psicologo psicologo = new Psicologo();
                psicologo.setIdPersona(rs.getInt("idpersona"));
                psicologo.setDNI(rs.getString("dni"));
                psicologo.setNombre(rs.getString("nombre"));
                psicologo.setApellidoPaterno(rs.getString("apellidopaterno"));
                psicologo.setApellidoMaterno(rs.getString("apellidomaterno"));
                psicologo.setFechaNacimiento(rs.getDate("fechanacimiento"));
                psicologo.setGenero(rs.getString("genero").charAt(0));
                psicologo.setEdad(rs.getInt("edad"));
                psicologo.setTelefono(rs.getString("telefono"));
                psicologo.setCelular(rs.getString("celular"));
                psicologo.setCorreo(rs.getString("correo"));
                psicologo.setDistrito(new Distrito());
                psicologo.getDistrito().setIdDistrito(rs.getInt("iddistrito"));
                psicologo.getDistrito().setNombre(rs.getString("nombre_distrito"));
                psicologo.setIdUsuario(rs.getInt("idusuario"));
                psicologo.setUser(rs.getString("user"));
                psicologo.setPassword(rs.getString("password"));
                psicologo.setTipo(rs.getInt("tipo"));
                psicologo.setFotoPerfil(rs.getBytes("foto"));
               
                psicologo.setActivo(1);
                psicologo.setActivoPsicologo(1);
                psicologos.add(psicologo);
            }
           
            
            cst.close();
            con.close();       
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{ con.close(); }catch(Exception ex){}
        }
        
        return psicologos;
    }

    @Override
    public ArrayList<Psicologo> listarTodosPsicologos() {
        ArrayList<Psicologo> psicologos = new ArrayList<>();
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call LISTAR_TODOS_PSICOLOGOS()}";
            cst = con.prepareCall(instruccion);
            rs = cst.executeQuery();
            
            while(rs.next()){
                Psicologo psicologo = new Psicologo();
                psicologo.setIdPersona(rs.getInt("idpersona"));
                psicologo.setDNI(rs.getString("dni"));
                psicologo.setNombre(rs.getString("nombre"));
                psicologo.setApellidoPaterno(rs.getString("apellidopaterno"));
                psicologo.setApellidoMaterno(rs.getString("apellidomaterno"));
                psicologo.setFechaNacimiento(rs.getDate("fechanacimiento"));
                psicologo.setGenero(rs.getString("genero").charAt(0));
                psicologo.setEdad(rs.getInt("edad"));
                psicologo.setTelefono(rs.getString("telefono"));
                psicologo.setCelular(rs.getString("celular"));
                psicologo.setCorreo(rs.getString("correo"));
                psicologo.setDistrito(new Distrito());
                psicologo.getDistrito().setIdDistrito(rs.getInt("iddistrito"));
                psicologo.getDistrito().setNombre(rs.getString("nombre_distrito"));
                psicologo.setIdUsuario(rs.getInt("idusuario"));
                psicologo.setUser(rs.getString("user"));
                psicologo.setPassword(rs.getString("password"));
                psicologo.setTipo(rs.getInt("tipo"));
                psicologo.setFotoPerfil(rs.getBytes("foto"));
               
                psicologo.setActivo(1);
                psicologo.setActivoPsicologo(1);
                psicologos.add(psicologo);
            }
           
            
            cst.close();
            con.close();       
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{ con.close(); }catch(Exception ex){}
        }
        
        return psicologos;
    }

    
    //BuscarPsicologoPorIdUsuario
    @Override
    public Psicologo buscarPsicologoPorIdUsuario(int idUsuario) {
        Psicologo psicologo = new Psicologo();
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call BUSCAR_PSICOLOGO_POR_ID_USUARIO(?)}";
            cst = con.prepareCall(instruccion);
            cst.setInt("_id_usuario", idUsuario);
            
            rs = cst.executeQuery();
            rs.next();      
            psicologo.setIdPersona(rs.getInt("idpersona"));
            psicologo.setDNI(rs.getString("dni"));
            psicologo.setNombre(rs.getString("nombre"));
            psicologo.setApellidoPaterno(rs.getString("apellidopaterno"));
            psicologo.setApellidoMaterno(rs.getString("apellidomaterno"));
            psicologo.setFechaNacimiento(rs.getDate("fechanacimiento"));
            psicologo.setGenero(rs.getString("genero").charAt(0));
            psicologo.setEdad(rs.getInt("edad"));
            psicologo.setTelefono(rs.getString("telefono"));
            psicologo.setCelular(rs.getString("celular"));
            psicologo.setCorreo(rs.getString("correo"));
            psicologo.setDistrito(new Distrito());
            psicologo.getDistrito().setIdDistrito(rs.getInt("iddistrito"));
            psicologo.getDistrito().setNombre(rs.getString("nombre_distrito"));
            psicologo.setIdUsuario(rs.getInt("idusuario"));
            psicologo.setUser(rs.getString("user"));
            psicologo.setPassword(rs.getString("password"));
            psicologo.setTipo(rs.getInt("tipo"));
            psicologo.setFotoPerfil(rs.getBytes("foto"));
            psicologo.setActivo(1);
            psicologo.setActivoPsicologo(1);
                
            
            cst.close();
            con.close();       
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{ con.close(); }catch(Exception ex){}
        }
        
        return psicologo;
    }
    
    

}
