/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.main;



import java.util.ArrayList;
import java.util.Date;
import pe.datma.datmasoft.dao.TutorDAO;
import pe.datma.datmasoft.mysql.TutorMySQL;
import pe.datma.datmasoft.rrhh.Distrito;
import pe.datma.datmasoft.rrhh.Tutor;

/**
 *
 * @author maldo
 */
public class Principal {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Tutor tutor = new Tutor();
        TutorDAO daoTutor = new TutorMySQL();
        tutor.setDistrito(new Distrito());
        tutor.getDistrito().setIdDistrito(1);
        tutor.setDNI("77891233");
        tutor.setNombre("Mariana");
        tutor.setApellidoPaterno("Gomez");
        tutor.setApellidoMaterno("Perez");
        tutor.setFechaNacimiento(new Date());
        tutor.setGenero('F');
        tutor.setEdad(20);
        tutor.setCelular("998123123");
        tutor.setTelefono("35373283");
        tutor.setCorreo("tut_nuevo@hotmail.com");
        tutor.setUser("tutornew12");
        tutor.setPassword("123");
        tutor.setFotoPerfil(null);
        tutor.setGestante(0);
        tutor.setDia(1111);
        tutor.setTurno(11);
        tutor.setBajoRecursos(1);
        tutor.setTiposConexion(11111);
        tutor.setRedesSociales(11111);
        tutor.setDispositivos(11111);
      
        //int resultado = daoTutor.insertarTutor(tutor);
       
        ArrayList<Tutor> tutores = new ArrayList<>();
        
        tutores = daoTutor.listarTutores();
        
        System.out.println(tutores.get(1).getCorreo());
        
    }
}
