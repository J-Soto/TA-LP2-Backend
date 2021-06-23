/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.services;

import java.awt.Image;
import java.sql.Connection;
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
            Connection con=DBManager.getInstance().getConnection();
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
}
