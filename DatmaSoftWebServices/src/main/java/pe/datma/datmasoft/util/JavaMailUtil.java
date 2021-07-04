/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.util;

import java.util.Properties;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.mail.Authenticator;
import javax.mail.Message;
import javax.mail.PasswordAuthentication;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeMessage;

/**
 *
 * @author JLHP
 */
public class JavaMailUtil {
    public static void sendMail(String recipient,String recUser,String recPassword,
            String recNombre,String recMensaje,int motivo) throws Exception{
        Properties properties = new Properties();  
        properties.put("mail.smtp.auth", "true");  
        properties.put("mail.smtp.starttls.enable", "true");  
        properties.put("mail.smtp.host", "smtp.gmail.com");  
        properties.put("mail.smtp.ssl.trust", "smtp.gmail.com");
        properties.put("mail.smtp.port", "587");  

        String myAccountEmail="datma.soft@gmail.com";
        String password="GuaniraGod";
        
        Session session=Session.getInstance(properties,new Authenticator(){
            @Override
            protected PasswordAuthentication getPasswordAuthentication() {
                return new PasswordAuthentication(myAccountEmail,password); //To change body of generated methods, choose Tools | Templates.
            }
        });
        
        Message message=prepareMessage(session,myAccountEmail,recipient,
                recUser,recPassword,recNombre,recMensaje,motivo);
        Transport.send(message);
        System.out.println("Mensaje enviado con exito\n");
    }

    private static Message prepareMessage(Session session,String myAccountEmail,
            String recipient,String recUser,String recPassword,
            String recNombre,String recMensaje,int motivo) {
        try {
            Message message=new MimeMessage(session);
            message.setFrom(new InternetAddress(myAccountEmail));
            message.setRecipient(Message.RecipientType.TO, 
                    new InternetAddress(recipient));
            //motivo: 0->nuevo usuario,1->actualizar usuario,2->eliminar curso
            if(motivo==0){
                message.setSubject("Confirmación DATMA");
                message.setText("Estimado(a) "+recNombre+", ha pasado el último filtro y ha"+
                    " sido aceptado(a) en el programa. A continuación se le"+
                    " daran los datos que le permitiran ingresar a su cuenta."+
                    "\n\nUsuario: "+recUser+"\nContraseña: "+recPassword+"\n\n"+
                    "Se aconseja cambiar su usuario y contraseña lo antes posible"+
                    " por razones de seguridad.");
            }else if(motivo==1){
                message.setSubject("Credenciales DATMA");
                message.setText("Estimado(a) "+recNombre+", ha actualizado"+
                    " satisfactoriamente sus datos.\n\n"+
                    "Usuario: "+recUser+"\nContraseña: "+recPassword);
            }else{
                message.setSubject("Información DATMA");
                message.setText("Estimado(a) "+recNombre+", se informa:\n "+recMensaje);
            }
            
            return message;
        } catch (Exception ex) {
            Logger.getLogger(JavaMailUtil.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
    }
}
