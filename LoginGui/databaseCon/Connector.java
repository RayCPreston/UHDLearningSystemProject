package databaseCon;

import java.sql.*;
import java.sql.ResultSet;



public class Connector {
	
	
    private static String url = "jdbc:sqlserver://localhost:1433;" + 
		"databaseName = LMS;integratedSecurity=true;";    
    private static String driverName = "com.microsoft.sqlserver.jdbc.SQLServerDriver";   
    private static Connection con;
    Statement stmt = null;
    ResultSet rs = null;

    public static Connection getConnection() {
        try {
            Class.forName(driverName);
            try {
                con = DriverManager.getConnection(url);
                System.out.println("Connection Established.");
            } catch (SQLException ex) {
                // log an exception
                System.out.println("Failed to create the database connection."); 
            }
        } catch (ClassNotFoundException ex) {
            // log an exception. for example:
            System.out.println("Driver not found."); 
        }
        return con;
    }
    
    public boolean outputUserInfo(String pass, String user) {
    	try {
    		String SQLPass = "SELECT pass FROM LMS.dbo.People WHERE username = " + "'" + user + "'";
    		stmt = con.createStatement();
    		rs = stmt.executeQuery(SQLPass);
    		while(rs.next()) {
    			//if passed password equals db password for passed username
    			if(rs.getString(1).equals(pass)) {
    				return true;
    				/*String SQL = "SELECT * FROM LMS.dbo.People WHERE username = " + "'" + user + "'";
    				stmt = con.createStatement();
    				rs = stmt.executeQuery(SQL);
    				while (rs.next()) {
    					System.out.println(rs.getString("username") + ", " + rs.getString("name") + ", " + rs.getString("job"));
    				}*/	
    			}
    			else {
    				System.out.println("Password is incorrect.");
    				return false;
    			}
    		}
    		return false;
    	}
    	catch (Exception e) {
    		e.printStackTrace();
    		return false;
    	}
    }

    public static void main (String[] args) {
	
    	Connector c = new Connector();
    	c.getConnection();
    	System.out.println(c.outputUserInfo("pass1123", "wilcoxj"));
    }
}