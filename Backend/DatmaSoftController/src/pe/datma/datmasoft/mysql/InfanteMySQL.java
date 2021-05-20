package pe.datma.datmasoft.mysql;

import pe.datma.datmasoft.dao.InfanteDAO;
import pe.datma.datmasoft.rrhh.Distrito;
import pe.datma.datmasoft.rrhh.Infante;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;

public class InfanteMySQL implements InfanteDAO {
    Connection con;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public ArrayList<Infante> listar() {
        ArrayList<Infante> infantes = new ArrayList<>();

        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(pe.datma.datmasoft.config.DBManager.url, pe.datma.datmasoft.config.DBManager.user, pe.datma.datmasoft.config.DBManager.password);
            String instruccion = "{CALL LISTAR_NIÑOS()}";
            cs = con.prepareCall(instruccion);
            rs = cs.executeQuery();

            while(rs.next()){
                Infante infante = new Infante();
                infante.setIdInfante(rs.getInt("idpersona"));
                infante.setDNI(rs.getString("dni"));
                infante.setNombre(rs.getString("nombre"));
                infante.setApellidoPaterno(rs.getString("apellidopaterno"));
                infante.setApellidoMaterno(rs.getString("apellidomaterno"));
                infante.setFechaNacimiento(rs.getDate("fechanacimiento"));
                infante.setGenero(rs.getString("genero").charAt(0));
                infante.setEdad(rs.getInt("edad"));
                infante.setDistrito(new Distrito());
                infante.getDistrito().setIdDistrito(rs.getInt("iddistrito"));
                infante.getDistrito().setNombre(rs.getString("nombredistrito"));
                infante.setIdSeguroPrincipal(rs.getInt("idseguro"));
                infante.setProveedorSeguro(rs.getString("proveedor"));
                infantes.add(infante);
                infante.setActivo(1);
            }

            rs.close();
            con.close();
        }catch (Exception ex){
            System.out.println(ex.getMessage());
            infantes = null;
        }finally {
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return infantes;
    }



    @Override
    public int insertar(Infante infante) {
        int resultado = 0;

        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(pe.datma.datmasoft.config.DBManager.url, pe.datma.datmasoft.config.DBManager.user, pe.datma.datmasoft.config.DBManager.password);
            String instruccion = "{CALL INSERTAR_NIÑO(?,?,?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(instruccion);

            cs.registerOutParameter("_id_niño", java.sql.Types.INTEGER);
            cs.setInt("_fidseguro",infante.getIdSeguroPrincipal());
            cs.setInt("_fiddistrito",infante.getDistrito().getIdDistrito());
            cs.setString("_dni",infante.getDNI());
            cs.setString("_nombre",infante.getNombre());
            cs.setString("_apellidopaterno",infante.getApellidoPaterno());
            cs.setString("_apellidomaterno",infante.getApellidoMaterno());
            cs.setDate("_fecha_nacimiento",new java.sql.Date(infante.getFechaNacimiento().getTime()));
            cs.setString("_genero",String.valueOf(infante.getGenero()));
            cs.setInt("_edad",infante.getEdad());

            cs.executeUpdate();
            infante.setIdInfante(cs.getInt("_id_niño"));

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
    public int modificar(Infante infante) {
        int resultado = 0;

        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(pe.datma.datmasoft.config.DBManager.url, pe.datma.datmasoft.config.DBManager.user, pe.datma.datmasoft.config.DBManager.password);
            String instruccion = "{CALL MODIFICAR_NIÑO(?,?,?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(instruccion);

            cs.setInt("_id_niño", infante.getIdInfante());
            cs.setInt("_fidseguro",infante.getIdSeguroPrincipal());
            cs.setInt("_fiddistrito",infante.getDistrito().getIdDistrito());
            cs.setString("_dni",infante.getDNI());
            cs.setString("_nombre",infante.getNombre());
            cs.setString("_apellidopaterno",infante.getApellidoPaterno());
            cs.setString("_apellidomaterno",infante.getApellidoMaterno());
            cs.setDate("_fecha_nacimiento",new java.sql.Date(infante.getFechaNacimiento().getTime()));
            cs.setString("_genero",String.valueOf(infante.getGenero()));
            cs.setInt("_edad",infante.getEdad());

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
    public int eliminar(int idInfante) {
        int resultado = 0;

        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(pe.datma.datmasoft.config.DBManager.url, pe.datma.datmasoft.config.DBManager.user, pe.datma.datmasoft.config.DBManager.password);
            String instruccion = "{CALL ELIMINAR_NIÑO(?)}";
            cs = con.prepareCall(instruccion);

            cs.setInt("_id_niño",idInfante);

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
    public ArrayList<Infante> listar(int idInfante) {
        ArrayList<Infante> infantes = new ArrayList<>();

        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(pe.datma.datmasoft.config.DBManager.url, pe.datma.datmasoft.config.DBManager.user, pe.datma.datmasoft.config.DBManager.password);
            String instruccion = "{CALL LISTAR_NIÑO_ID(?)}";
            cs = con.prepareCall(instruccion);
            cs.setInt("_id_niño",idInfante);
            rs = cs.executeQuery();

            while(rs.next()){
                Infante infante = new Infante();
                infante.setIdInfante(rs.getInt("idpersona"));
                infante.setDNI(rs.getString("dni"));
                infante.setNombre(rs.getString("nombre"));
                infante.setApellidoPaterno(rs.getString("apellidopaterno"));
                infante.setApellidoMaterno(rs.getString("apellidomaterno"));
                infante.setFechaNacimiento(rs.getDate("fechanacimiento"));
                infante.setGenero(rs.getString("genero").charAt(0));
                infante.setEdad(rs.getInt("edad"));
                infante.setDistrito(new Distrito());
                infante.getDistrito().setIdDistrito(rs.getInt("iddistrito"));
                infante.getDistrito().setNombre(rs.getString("nombredistrito"));
                infante.setIdSeguroPrincipal(rs.getInt("idseguro"));
                infante.setProveedorSeguro(rs.getString("proveedor"));
                infantes.add(infante);
                infante.setActivo(1);
            }

            rs.close();
            con.close();
        }catch (Exception ex){
            System.out.println(ex.getMessage());
            infantes = null;
        }finally {
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return infantes;
    }

}
