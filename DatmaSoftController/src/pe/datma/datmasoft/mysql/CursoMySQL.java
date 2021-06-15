package pe.datma.datmasoft.mysql;



import java.sql.*;
import java.util.ArrayList;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.CursoDAO;
import pe.datma.datmasoft.familias.Grupo;
import pe.datma.datmasoft.modulos.Curso;
import pe.datma.datmasoft.modulos.Requerimiento;
import pe.datma.datmasoft.modulos.Semana;
import pe.datma.datmasoft.modulos.Tema;

public class CursoMySQL implements CursoDAO {

    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertarRequerimiento(int idCursoDep, int idCursoReq, String descripcion) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL INSERTAR_REQUERIMIENTO(?,?,?,?)}");
            cs.registerOutParameter("_id_req", java.sql.Types.INTEGER);
            cs.setInt("_fid_curso_1",idCursoDep);
            cs.setInt("_fid_curso_2",idCursoReq);
            cs.setString("_descripcion", descripcion);
            cs.executeUpdate();
            resultado=cs.getInt("_id_req");
            cs.close();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    
    @Override
    public int eliminarRequerimiento(int idCursoDep, int idRequerimiento) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL ELIMINAR_REQUERIMIENTO(?,?)}");
            cs.setInt("_idcurso",idCursoDep);
            cs.setInt("_idrequerimiento",idRequerimiento);
            cs.executeUpdate();
            
            resultado = 1;
            cs.close();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificarRequerimiento(int idCursoDep, int idRequerimiento, String descripcion) {
       int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL MODIFICAR_REQUERIMIENTO(?,?,?)}");
            cs.setInt("_idcurso",idCursoDep);
            cs.setInt("_idrequerimiento",idRequerimiento);
            cs.setString("_descripcion", descripcion);
            cs.executeUpdate();
            
            resultado = 1;
            cs.close();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
    
    //Curso:
    
    @Override
    public int insertarCurso(Curso curso) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL INSERTAR_CURSO(?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_curso", java.sql.Types.INTEGER);
            cs.setString("_nombre", curso.getDescripcion());
            cs.setDate("_fecha_inicial", new java.sql.Date(curso.getFechaInicio().getTime()));
            cs.setDate("_fecha_final", new java.sql.Date(curso.getFechaFin().getTime()));
            cs.setDate("_fecha_inscripcion", new java.sql.Date(curso.getFechaInscripcion().getTime()));
            cs.setInt("_cant_semanas", curso.getCantSemanas());
            cs.executeUpdate();
            curso.setIdCurso(cs.getInt("_id_curso"));
            
            resultado = cs.getInt("_id_curso");
            cs.close();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;  
    }

    @Override
    public int modificarCurso(Curso curso) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL MODIFICAR_CURSO(?,?,?,?,?,?)}");
            cs.setInt("_idcurso", curso.getIdCurso());
            cs.setString("_nombre", curso.getDescripcion());
            cs.setDate("_fecha_inicial", new java.sql.Date(curso.getFechaInicio().getTime()));
            cs.setDate("_fecha_final", new java.sql.Date(curso.getFechaFin().getTime()));
            cs.setDate("_fecha_inscripcion", new java.sql.Date(curso.getFechaInscripcion().getTime()));
            cs.setInt("_cant_semanas", curso.getCantSemanas());
            cs.executeUpdate();
            
            cs.close();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;  
    }

    
    @Override
    public int eliminarCurso(int idCurso) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL ELIMINAR_CURSO(?)}");
            cs.setInt("_idcurso", idCurso);       
            cs.executeUpdate();
            
            cs.close();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado; 
    }

    @Override
    public ArrayList<Curso> listarCursos() {
        ArrayList<Curso> cursos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL LISTAR_CURSOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Curso curso = new Curso();
                curso.setIdCurso(rs.getInt("idcurso"));
                curso.setDescripcion(rs.getString("nombre"));
                curso.setFechaInicio(rs.getDate("fechainicial"));
                curso.setFechaFin(rs.getDate("fechafinal"));
                curso.setFechaInscripcion(rs.getDate("fechainscripcion"));
                curso.setCantSemanas(rs.getInt("cantsemanas"));
                cursos.add(curso);
            }
            cs.close();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return cursos;
    }

    @Override
    public ArrayList<Curso> listarCursosPorNombre(String nombreCurso) {
        ArrayList<Curso> cursos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL LISTAR_CURSOS_POR_NOMBRE(?)}");
            cs.setString("_nombre_curso", nombreCurso);
            rs = cs.executeQuery();
            while(rs.next()){
                Curso curso = new Curso();
                curso.setIdCurso(rs.getInt("idcurso"));
                curso.setDescripcion(rs.getString("nombre"));
                curso.setFechaInicio(rs.getDate("fechainicial"));
                curso.setFechaFin(rs.getDate("fechafinal"));
                curso.setFechaInscripcion(rs.getDate("fechainscripcion"));
                curso.setCantSemanas(rs.getInt("cantsemanas"));
                cursos.add(curso);
            }
            cs.close();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return cursos;
    }

    //Metodos complementarios de cursos
    
    @Override
    public ArrayList<Grupo> listarGruposPorIdCurso(int idCurso) {
        ArrayList<Grupo> grupos = new ArrayList<>();
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL LISTAR_GRUPOS_POR_ID_CURSO(?)}");
            cs.setInt("_idcurso", idCurso);
            rs = cs.executeQuery();
            while(rs.next()){
                Grupo grupo = new Grupo();
                grupo.setIdGrupo(rs.getInt("idgrupo"));
                grupo.setNombrePromocion(rs.getString("nombre"));
                grupo.setMaxCantCuidadores(rs.getInt("maxtutores"));
                grupos.add(grupo);
            }
            cs.close();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return grupos;
    }
    

    @Override
    public ArrayList<Tema> listarTemasPorIdCurso(int idCurso) {
        ArrayList<Tema> temas = new ArrayList<>();
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL LISTAR_TEMAS_POR_ID_CURSO(?)}");
            cs.setInt("_idcurso", idCurso);
            rs = cs.executeQuery();
            while(rs.next()){
                Tema tema = new Tema();
                tema.setId(rs.getInt("idtema"));
                tema.setNombre(rs.getString("nombre_tema"));
                tema.setDescripcion(rs.getString("descripcion"));
                tema.setFechaInicio(rs.getDate("fechainicio"));
                tema.setFechaFin(rs.getDate("fechafin"));
                temas.add(tema);
            }
            cs.close();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return temas;
    }

    @Override
    public ArrayList<Semana> listarSemanasPorIdCurso(int idCurso) {
        ArrayList<Semana> semanas = new ArrayList<>();
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL LISTAR_SEMANAS_POR_ID_CURSO(?)}");
            cs.setInt("_idcurso", idCurso);
            rs = cs.executeQuery();
            while(rs.next()){
                Semana semana = new Semana();
                semana.setId(rs.getInt("idsemana"));
                semana.setNombre(rs.getString("nombre"));
                semana.setDescripcion(rs.getString("descripcion"));
                semana.setFechaInicio(rs.getDate("fechainicio"));
                semanas.add(semana);
            }
            cs.close();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return semanas;
    }

    @Override
    public ArrayList<Requerimiento> listarRequerimientoPorIdCurso(int idCurso) {
        ArrayList<Requerimiento> requerimientos = new ArrayList<>();
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL LISTAR_REQUERIMIENTOS_POR_ID_CURSO(?)}");
            cs.setInt("_idcurso", idCurso);
            rs = cs.executeQuery();
            while(rs.next()){
                Requerimiento requerimiento = new Requerimiento();
                requerimiento.setIdRequerimiento(rs.getInt("idrequerimiento"));
                requerimiento.setIdCursoReq(rs.getInt("idcurso_prerequerido"));
                requerimiento.setDescripcion(rs.getString("descripcion"));
                requerimientos.add(requerimiento);
            }
            cs.close();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return requerimientos;
    }    
    
    
    //curso-tema: 

    @Override
    public int insertarCursoTema(int idCurso, int idTema, java.util.Date fechaInicio, java.util.Date fechaFin) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL INSERTAR_CURSO_TEMA(?,?,?,?,?)}");
            cs.registerOutParameter("_id_curso_tema", java.sql.Types.INTEGER);
            cs.setInt("_fidcurso", idCurso);
            cs.setInt("_fidtema", idTema);
            cs.setDate("_fechainicio", new java.sql.Date(fechaInicio.getTime()));
            cs.setDate("_fechafin", new java.sql.Date(fechaFin.getTime()));
            cs.executeUpdate();
            
            resultado = cs.getInt("_id_curso_tema");
            cs.close();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificarCursoTema(int idCurso, int idTema, java.util.Date fechaInicio, java.util.Date fechaFin) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL MODIFICAR_CURSO_TEMA(?,?,?,?)}");
            cs.setInt("_fidcurso", idCurso);
            cs.setInt("_fidtema", idTema);
            cs.setDate("_fechainicio", new java.sql.Date(fechaInicio.getTime()));
            cs.setDate("_fechafin", new java.sql.Date(fechaFin.getTime()));
            cs.executeUpdate();
            
            resultado = 1;
            cs.close();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;   
    }

    @Override
    public int eliminarCursoTema(int idCurso, int idTema) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{CALL ELIMINAR_CURSO_TEMA(?,?)}");
            cs.setInt("_fidcurso", idCurso);
            cs.setInt("_fidtema", idTema);
            cs.executeUpdate();
            resultado = 1;
            cs.close();
            con.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;  
    }
    
  
}
