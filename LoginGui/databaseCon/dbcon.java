package databaseCon;

import java.sql.ResultSet;
import java.sql.*;

public class dbcon {
	//Hard codes the connection to the database with no ability for functions.
	public static void main(String[] args) {
		String connUrl = "jdbc:sqlserver://localhost:1433;" + 
		"databaseName = LMS;integratedSecurity=true;";
		
		//Declare JDBC objects
		Connection con = null;
		Statement stmt = null;
		ResultSet rs = null;
		
		try {
			//Establish connection
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
			con = DriverManager.getConnection(connUrl);
			System.out.println("Connection Established");
			
			String SQL = "SELECT * FROM LMS.dbo.People";
			stmt = con.createStatement();
			rs = stmt.executeQuery(SQL);
			
			while (rs.next()) {
				System.out.println(rs.getString(1) + " " + rs.getString(2) + " " + rs.getString(3));
			}
			
		}
		catch (Exception e) {
			e.printStackTrace();
		}
	}
}