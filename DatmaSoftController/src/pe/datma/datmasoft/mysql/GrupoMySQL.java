package pe.datma.datmasoft.mysql;

import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.GrupoDAO;
import pe.datma.datmasoft.familias.Grupo;

import java.sql.*;
import java.util.ArrayList;
import pe.datma.datmasoft.rrhh.Distrito;
import pe.datma.datmasoft.rrhh.Psicologo;
import pe.datma.datmasoft.rrhh.Tutor;

public class GrupoMySQL implements  GrupoDAO{
    Connection con;
    CallableStatement cst;
    ResultSet rs;

    @Override
    public int insertarGrupo(int idCurso, Grupo grupo) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call INSERTAR_GRUPO(?,?,?,?)}";
            cst = con.prepareCall(instruccion);
            
            cst.registerOutParameter("_idgrupo", java.sql.Types.INTEGER); 
            cst.setInt("_fidcurso2", idCurso);
            cst.setString("_nombre", grupo.getNombrePromocion());
            cst.setInt("_maxtutores", grupo.getMaxCantCuidadores());
            cst.executeUpdate();
            
            grupo.setIdGrupo(cst.getInt("_idgrupo"));
            
            resultado = cst.getInt("_idgrupo");
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
    public int modificarGrupo(Grupo grupo) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call MODIFICAR_GRUPO(?,?,?)}";
            cst = con.prepareCall(instruccion);
            cst.setInt("_idgrupo", grupo.getIdGrupo()); 
            cst.setString("_nombre", grupo.getNombrePromocion());
            cst.setInt("_maxtutores", grupo.getMaxCantCuidadores());
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
    public int eliminarGrupo(int idGrupo) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call ELIMINAR_GRUPO(?)}";
            cst = con.prepareCall(instruccion);
            cst.setInt("_idgrupo",idGrupo);
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
    public ArrayList<Grupo> listarGrupoPorIdCurso(int idCurso) {
        ArrayList<Grupo> grupos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call LISTAR_GRUPO_POR_ID_CURSO(?)}";
            cst = con.prepareCall(instruccion);
            cst.setInt("_idcurso", idCurso);
            rs = cst.executeQuery();   
            
            while(rs.next()){
                Grupo grupo = new Grupo();
                
                grupo.setIdGrupo(rs.getInt("idgrupo"));
                grupo.setNombrePromocion(rs.getString("nombre_grupo"));
                grupo.setMaxCantCuidadores(rs.getInt("maxtutores"));
                
                grupos.add(grupo);
            }
            cst.close();
            con.close();       
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{ con.close(); }catch(Exception ex){}
        }
        return grupos;
    }
    
    
    ////////////////
    //grupo-tutor:

    @Override
    public int insertarGrupoTutor(int idTutor, int idGrupo, int numInfantes) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call INSERTAR_GRUPO_TUTOR(?,?,?,?)}";
            cst = con.prepareCall(instruccion);
            cst.registerOutParameter("_idgrupo_tutor", java.sql.Types.INTEGER);
            cst.setInt("_fidtutor", idTutor);
            cst.setInt("_fidgrupo2", idGrupo);
            cst.setInt("_nroinfantes", numInfantes);
            cst.executeUpdate();
            resultado = cst.getInt("_idgrupo_tutor");
            
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
    public int modificarGrupoTutor(int idTutor, int idGrupo, int numInfantes) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call MODIFICAR_GRUPO_TUTOR(?,?,?)}";
            cst = con.prepareCall(instruccion);
            cst.setInt("_idtutor", idTutor);
            cst.setInt("_idgrupo", idGrupo);
            cst.setInt("_nroinfantes", numInfantes);
            cst.executeUpdate();
            
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
    public int eliminarGrupoTutor(int idTutor, int idGrupo) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call ELIMINAR_TUTOR_DE_GRUPO(?,?)}";
            cst = con.prepareCall(instruccion);
            cst.setInt("_idtutor", idTutor);
            cst.setInt("_idgrupo", idGrupo);
            cst.executeUpdate();
            
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
    public ArrayList<Tutor> listarTutoresPorIdGrupo(int idGrupo) {
        ArrayList<Tutor> tutores = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call LISTAR_TUTORES_POR_ID_GRUPO(?)}";
            cst = con.prepareCall(instruccion);
            cst.setInt("_idgrupo", idGrupo);
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
                tutor.setGrupos(new ArrayList<Grupo>());
                Grupo grupo = new Grupo();
                grupo.setIdGrupo(idGrupo);
                grupo.setCantInfantes(rs.getInt("nroinfantes"));
                tutor.getGrupos().add(grupo); //Este tutor pertenece al grupo con el id recibido
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

    ///////////////////
    //grupo-psicologo:

    @Override
    public int insertarGrupoPsicologo(int idPsicologo, int idGrupo) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call INSERTAR_GRUPO_PSICOLOGO(?,?,?)}";
            cst = con.prepareCall(instruccion);
            cst.registerOutParameter("_idgrupo_psicologo", java.sql.Types.INTEGER);
            cst.setInt("_fidpsicologo", idPsicologo);
            cst.setInt("_fidgrupo", idGrupo);
            cst.executeUpdate();
            resultado = cst.getInt("_idgrupo_psicologo");
            
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
    public int eliminarGrupoPsicologo(int idPsicologo, int idGrupo) {
        
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call ELIMINAR_PSICOLOGO_DE_GRUPO(?,?)}";
            cst = con.prepareCall(instruccion);
            cst.setInt("_idpsicologo", idPsicologo);
            cst.setInt("_idgrupo", idGrupo);
            cst.executeUpdate();
            
            resultado = 1;
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
    public ArrayList<Psicologo> listarPsicologosPorIdGrupo(int idGrupo) {
        ArrayList<Psicologo> psicologos = new ArrayList<>();
        
         try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            String instruccion = "{call LISTAR_PSICOLOGOS_POR_ID_GRUPO(?)}";
            cst = con.prepareCall(instruccion);
            cst.setInt("_idgrupo", idGrupo);
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
   
    
}