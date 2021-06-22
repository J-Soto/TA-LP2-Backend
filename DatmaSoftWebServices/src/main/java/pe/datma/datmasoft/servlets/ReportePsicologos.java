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
public class ReportePsicologos extends HttpServlet {

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
            JasperReport reporte=(JasperReport)
                    JRLoader.loadObject(ReportePsicologos.class.getResource(
                    "pe/datma/datmasoft/reportes/ReportePsicologos.jasper"));
            //Cargar imagen
            String rutaImagen=ReportePsicologos.class.getResource(
                    "pe/datma/datmasoft/img/DATMA logo.png").getPath();
            Image logo=(new ImageIcon(rutaImagen)).getImage();
            //Arreglo de Parametros
            HashMap hm=new HashMap();
            hm.put("Logo DATMA", logo);
            //Objeto conexion
            Connection con=DBManager.getInstance().getConnection();
            //Poblar Reporte
            JasperPrint jp=JasperFillManager.fillReport(reporte,hm,con);
            //Cerrar Conexion
            con.close();
            //Mostrarlo via web
            JasperExportManager.exportReportToPdfStream(jp, response.getOutputStream());
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
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
