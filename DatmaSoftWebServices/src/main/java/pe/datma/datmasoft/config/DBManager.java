/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.datma.datmasoft.config;

import java.sql.Connection;
import java.sql.DriverManager;

/**
 *
 * @author JLHP
 */
public class DBManager {
    private Connection con;
    private static DBManager dbManager=new DBManager();
    private String url = "jdbc:mysql:"
            + "//dbexplosioniquitos.csnhgoov3jct.us-east-1.rds.amazonaws.com:3306/lp2";
    private String user = "admin";
    private String password = "GuaniraGOD";
    
    public Connection getConnection(){
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con=DriverManager.getConnection(this.url,this.user,this.password);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return con;
    }
    public static DBManager getInstance(){
        return dbManager;
    }
}
