/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.servlets;

import java.awt.Image;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;
import java.util.HashMap;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.swing.ImageIcon;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import pe.datma.datmasoft.config.DBManager;

/**
 *
 * @author JLHP
 */
public class ReportePreferenciasTutor extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
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
            String rutaImagen = ReportePreferenciasTutor.class.getResource("/pe/datma/datmasoft/img/DATMA_logo.png").getPath();
            Image logo = (new ImageIcon(rutaImagen)).getImage();
            //Arreglo de parametros que ingresan a la generación del reporte
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
            JasperExportManager.exportReportToPdfStream(jp, response.getOutputStream());
        } catch (Exception ex) {
            ex.printStackTrace();
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
