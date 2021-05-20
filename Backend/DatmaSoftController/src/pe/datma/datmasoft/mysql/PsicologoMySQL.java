package pe.datma.datmasoft.mysql;

import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.dao.PsicologoDAO;
import pe.datma.datmasoft.rrhh.Distrito;
import pe.datma.datmasoft.rrhh.Psicologo;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;

public class PsicologoMySQL implements PsicologoDAO {

    Connection con;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public ArrayList<Psicologo> listar() {
        ArrayList<Psicologo> psicologos = new ArrayList<>();

        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, pe.datma.datmasoft.config.DBManager.user, pe.datma.datmasoft.config.DBManager.password);
            String instruccion = "{CALL LISTAR_PSICOLOGOS()}";
            cs = con.prepareCall(instruccion);
            rs = cs.executeQuery();

            while(rs.next()){
                Psicologo psicologo = new Psicologo();
                psicologo.setIdPsicologo(rs.getInt("idpersona"));
                psicologo.setDNI(rs.getString("dni"));
                psicologo.setNombre(rs.getString("nombre"));
                psicologo.setApellidoPaterno(rs.getString("apellidopaterno"));
                psicologo.setApellidoMaterno(rs.getString("apellidomaterno"));
                psicologo.setFechaNacimiento(rs.getDate("fechanacimiento"));
                psicologo.setGenero(rs.getString("genero").charAt(0));
                psicologo.setEdad(rs.getInt("edad"));
                psicologo.setTelefono(Integer.parseInt(rs.getString("telefono")));
                psicologo.setCelular(Integer.parseInt(rs.getString("celular")));
                psicologo.setCorreo(rs.getString("correo"));
                psicologo.setDistrito(new Distrito());
                psicologo.getDistrito().setIdDistrito(rs.getInt("iddistrito"));
                psicologo.getDistrito().setNombre(rs.getString("namedist"));
                psicologo.setIdUsuario(rs.getInt("idusuario"));
                psicologo.setUser(rs.getString("user"));
                psicologo.setPassword(rs.getString("password"));
                psicologo.setActivo(true);
                psicologo.setTipo(1);
                psicologos.add(psicologo);
            }

            rs.close();
            con.close();
        }catch (Exception ex){
            System.out.println(ex.getMessage());
            psicologos = null;
        }finally {
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }

        return psicologos;
    }


    @Override
    public int insertar(Psicologo psicologo) {
        int resultado = 0;

        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, pe.datma.datmasoft.config.DBManager.user, pe.datma.datmasoft.config.DBManager.password);
            String instruccion = "{CALL INSERTAR_PSICOLOGO(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(instruccion);

            cs.registerOutParameter("_id_psicologo", java.sql.Types.INTEGER);
            cs.registerOutParameter("_id_usuario", java.sql.Types.INTEGER);
            cs.setInt("_fiddistrito",psicologo.getDistrito().getIdDistrito());
            cs.setString("_dni",psicologo.getDNI());
            cs.setString("_nombre",psicologo.getNombre());
            cs.setString("_apellidopaterno",psicologo.getApellidoPaterno());
            cs.setString("_apellidomaterno",psicologo.getApellidoMaterno());
            cs.setDate("_fecha_nacimiento",new java.sql.Date(psicologo.getFechaNacimiento().getTime()));
            cs.setString("_genero",String.valueOf(psicologo.getGenero()));
            cs.setInt("_edad",psicologo.getEdad());
            cs.setString("_telefono",String.valueOf(psicologo.getTelefono()));
            cs.setString("_celular",String.valueOf(psicologo.getCelular()));
            cs.setString("_correo",psicologo.getCorreo());
            cs.setString("_user",psicologo.getUser());
            cs.setString("_password",psicologo.getPassword());
            cs.executeUpdate();

            psicologo.setIdPsicologo(cs.getInt("_id_psicologo"));
            psicologo.setIdUsuario(cs.getInt("_id_usuario"));

            rs.close();
            con.close();
            resultado = 1;
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally {
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }

        return resultado;
    }

    @Override
    public int modificar(Psicologo psicologo) {
        int resultado = 0;

        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, pe.datma.datmasoft.config.DBManager.user, pe.datma.datmasoft.config.DBManager.password);
            String instruccion = "{CALL MODIFICAR_PSICOLOGO(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(instruccion);

            cs.setInt("_id_psicologo", psicologo.getIdPsicologo());
            cs.setInt("_id_usuario", psicologo.getIdUsuario());
            cs.setInt("_fiddistrito",psicologo.getDistrito().getIdDistrito());
            cs.setString("_dni",psicologo.getDNI());
            cs.setString("_nombre",psicologo.getNombre());
            cs.setString("_apellidopaterno",psicologo.getApellidoPaterno());
            cs.setString("_apellidomaterno",psicologo.getApellidoMaterno());
            cs.setDate("_fecha_nacimiento",new java.sql.Date(psicologo.getFechaNacimiento().getTime()));
            cs.setString("_genero",String.valueOf(psicologo.getGenero()));
            cs.setInt("_edad",psicologo.getEdad());
            cs.setString("_telefono",String.valueOf(psicologo.getTelefono()));
            cs.setString("_celular",String.valueOf(psicologo.getCelular()));
            cs.setString("_correo",psicologo.getCorreo());
            cs.setString("_user",psicologo.getUser());
            cs.setString("_password",psicologo.getPassword());
            cs.executeUpdate();


            rs.close();
            con.close();
            resultado = 1;
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally {
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }

        return resultado;
    }

    @Override
    public int eliminar(int idPsicologo, int idUsuario) {
        int resultado = 0;

        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, pe.datma.datmasoft.config.DBManager.user, pe.datma.datmasoft.config.DBManager.password);
            String instruccion = "{CALL ELIMINAR_PSICOLOGO(?,?)}";
            cs = con.prepareCall(instruccion);

            cs.setInt("_id_psicologo",idPsicologo);
            cs.setInt("_id_usuario", idUsuario);
            cs.executeUpdate();

            rs.close();
            con.close();
            resultado = 1;
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }finally {
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }

        return resultado;
    }

}
