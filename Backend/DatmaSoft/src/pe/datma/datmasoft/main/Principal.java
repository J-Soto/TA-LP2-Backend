/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.main;



import java.util.ArrayList;
import java.util.Date;
import pe.datma.datmasoft.dao.GrupoDAO;
import pe.datma.datmasoft.dao.PsicologoDAO;
import pe.datma.datmasoft.dao.TutorDAO;
import pe.datma.datmasoft.familias.Grupo;
import pe.datma.datmasoft.mysql.GrupoMySQL;
import pe.datma.datmasoft.mysql.PsicologoMySQL;
import pe.datma.datmasoft.mysql.TutorMySQL;
import pe.datma.datmasoft.rrhh.Distrito;
import pe.datma.datmasoft.rrhh.Psicologo;
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
        tutor.setDNI("87654321");
        tutor.setNombre("Juana");
        tutor.setApellidoPaterno("Gomez");
        tutor.setApellidoMaterno("Perez");
        tutor.setFechaNacimiento(new Date());
        tutor.setGenero('F');
        tutor.setEdad(40);
        tutor.setCelular("998123123");
        tutor.setTelefono("35373283");
        tutor.setCorreo("tutorprueba1@hotmail.com");
        tutor.setUser("xyz");
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
        


        
//        Psicologo psicologo = new Psicologo();
//        PsicologoDAO daoPsicologo = new PsicologoMySQL();
//        psicologo.setDistrito(new Distrito());
//        psicologo.getDistrito().setIdDistrito(2);
//        psicologo.setDNI("77894564");
//        psicologo.setNombre("Jorge");
//        psicologo.setApellidoPaterno("Uriol");
//        psicologo.setApellidoMaterno("Perez");
//        psicologo.setFechaNacimiento(new Date());
//        psicologo.setGenero('M');
//        psicologo.setEdad(70);
//        psicologo.setCelular("998123123");
//        psicologo.setTelefono("35373283");
//        psicologo.setCorreo("psico1@hotmail.com");
//        psicologo.setUser("psico123");
//        psicologo.setPassword("12345");
//        psicologo.setFotoPerfil(null);
//        daoPsicologo.insertarPsicologo(psicologo);

       GrupoDAO daoGrupo = new GrupoMySQL();
       //daoGrupo.eliminarGrupoPsicologo(9, 2);
       //ArrayList<Psicologo> psicos = new ArrayList<>();
        
       //daoGrupo.insertarGrupoTutor(10, 2, 1);
       
//       Grupo grupo = new Grupo();
//       grupo.setIdGrupo(4);
//       grupo.setMaxCantCuidadores(5);
//       grupo.setNombrePromocion("Explosion de Iqui");
//       
//       daoGrupo.modificarGrupo(grupo);
//       
//       daoGrupo.eliminarGrupo(3);
//       
    }
}
