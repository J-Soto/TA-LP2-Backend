package pe.datma.datmasoft.mysql;



import java.sql.*;
import java.util.ArrayList;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.CursoDAO;
import pe.datma.datmasoft.modulos.Curso;

public class CursoMySQL implements CursoDAO {

    Connection con;
    CallableStatement cs;
    ResultSet rs;
    
    @Override
    public int insertarCurso(Curso modulo) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int modificarCurso(Curso modulo) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminarCurso(int idModulo) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

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
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Curso> listarCurso(int idModulo) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
  
}
