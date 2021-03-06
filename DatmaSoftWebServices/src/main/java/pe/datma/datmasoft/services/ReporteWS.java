/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.services;

import java.awt.Image;
import java.sql.Connection;
import java.sql.DriverManager;
import java.util.HashMap;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.swing.ImageIcon;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import pe.datma.datmasoft.config.DBManager;
import pe.datma.datmasoft.servlets.ReportePreferenciasTutor;
import pe.datma.datmasoft.servlets.ReportePsicologos;

/**
 *
 * @author JLHP
 */
@WebService(serviceName = "ReporteWS")
public class ReporteWS {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "reportePsicologos")
    public byte[] reportePsicologos() {
        byte[] arreglo=null;
        try {
            JasperReport reporte=(JasperReport)
                    JRLoader.loadObject(ReportePsicologos.class.getResource(
                    "/pe/datma/datmasoft/reportes/ReportePsicologos.jasper"));
            //Cargar imagen
            String rutaImagen=ReportePsicologos.class.getResource(
                    "/pe/datma/datmasoft/img/DATMA_logo.png").getPath();
            rutaImagen=rutaImagen.replace("%20", " ");
            Image logo=(new ImageIcon(rutaImagen)).getImage();
            //Arreglo de Parametros
            HashMap hm=new HashMap();
            hm.put("Logo_DATMA", logo);
            //Objeto conexion
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con=DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            //Poblar Reporte
            JasperPrint jp=JasperFillManager.fillReport(reporte,hm,con);
            //Cerrar Conexion
            con.close();
            //Mostrarlo via web
            arreglo=JasperExportManager.exportReportToPdf(jp);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return arreglo;
    }
    
    @WebMethod(operationName = "reportePreferencias")
    public byte[] reportePreferencias() {
        byte[] arreglo=null;
        try {
            JasperReport reporte = (JasperReport) JRLoader.loadObject(ReportePreferenciasTutor.class.getResource(
                "/pe/datma/datmasoft/reportes/ReportePreferenciasTutor.jasper"));
            String rutaSubreporte1 = ReportePreferenciasTutor.class.getResource(
                    "/pe/datma/datmasoft/reportes/PreferenciasDias.jasper").getPath().replace("%20", " ");
            String rutaSubreporte2 = ReportePreferenciasTutor.class.getResource(
                    "/pe/datma/datmasoft/reportes/PreferenciasInternet.jasper").getPath().replace("%20", " ");
            String rutaSubreporte3 = ReportePreferenciasTutor.class.getResource(
                    "/pe/datma/datmasoft/reportes/PreferenciasTurno.jasper").getPath().replace("%20", " ");
            String rutaSubreporte4 = ReportePreferenciasTutor.class.getResource(
                    "/pe/datma/datmasoft/reportes/ReporteDispositivos.jasper").getPath().replace("%20", " ");
            String rutaSubreporte5 = ReportePreferenciasTutor.class.getResource(
                    "/pe/datma/datmasoft/reportes/ReporteRedes.jasper").getPath().replace("%20", " ");
            //Referencia a la imagen
            String rutaImagen = ReportePreferenciasTutor.class.getResource(
                    "/pe/datma/datmasoft/img/DATMA_logo.png").getPath().replace("%20", " ");
            Image logo = (new ImageIcon(rutaImagen)).getImage();
            //Arreglo de parametros que ingresan a la generaci??n del reporte
            HashMap hm = new HashMap();
            hm.put("Logo", logo);
            hm.put("ReporteDias",rutaSubreporte1);
            hm.put("ReporteInternet",rutaSubreporte2);
            hm.put("ReporteTurno",rutaSubreporte3);
            hm.put("ReporteDispositivos",rutaSubreporte4);
            hm.put("ReporteRedes",rutaSubreporte5);
            //Objeto de conexion
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con=DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            //Poblar el reporte
            JasperPrint jp = JasperFillManager.fillReport(reporte, hm, con);
            //Cerramos la conexion
            con.close();
            //Mostrarlo via web
            arreglo=JasperExportManager.exportReportToPdf(jp);
        } catch (Exception ex) {
            ex.printStackTrace();
        }
        return arreglo;
    }
}
