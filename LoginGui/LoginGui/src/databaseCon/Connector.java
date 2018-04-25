package databaseCon;

import java.sql.*;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Arrays;




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
    
    public boolean verifyCreds(String user, String pass) {
    	try {
    		String SQLPass = "SELECT pass FROM LMS.dbo.People WHERE username = " + "'" + user + "'";
    		stmt = con.createStatement();
    		rs = stmt.executeQuery(SQLPass);
    		while(rs.next()) {
    			//if passed password equals db password for passed username
    			if(rs.getString(1).contains(pass)) {
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
   /* public ArrayList<String> userInfo(String user){
    	ArrayList result = new ArrayList<String>();
    	ArrayList columns = new ArrayList<String>();
    	columns.addAll(Arrays.asList("username", "name", "job", "courseID", "exam1", "exam2", "exam3", "exam4", "exam5", "exam6"));
    	try {
	    	String SQLPass = "SELECT username, name, job, courseID, exam1, exam2, exam3, "
	    			+ "exam4, exam5, exam6 FROM LMS.dbo.People WHERE username = " + "'" + user + "'";
			stmt = con.createStatement();
			rs = stmt.executeQuery(SQLPass);
			while(rs.next()) {
				result.add(rs.getString(1));
				result.add(rs.getString(2));
				result.add(rs.getString(3));
				result.add(rs.getString(4));
				result.add(rs.getString(5));
				result.add(rs.getString(6));
				result.add(rs.getString(7));
				result.add(rs.getString(8));
				result.add(rs.getString(9));
				result.add(rs.getString(10));
			}
			return result;
		} 
    	catch(Exception e) {
    		e.printStackTrace();
    		return result;
    	}

    }*/
    /*public //String[] cacheRow(String user){
    	try {
	    	String SQLPass = "SELECT username, name, job, courseID, exam1, exam2, exam3, "
	    			+ "exam4, exam5, exam6 FROM LMS.dbo.People WHERE username = " + "'" + user + "'";
			stmt = con.createStatement();
			rs = stmt.executeQuery(SQLPass);
			while(rs.next()) {
				
			}
		} 
    	catch(Exception e) {
    		e.printStackTrace();
    	}

    }*/
    public String getJob(String user) {
    	try {
	    	String SQLPass = "SELECT job FROM LMS.dbo.People WHERE username = " + "'" + user + "'";
			stmt = con.createStatement();
			rs = stmt.executeQuery(SQLPass);
			while(rs.next()) {
				//job = rs.getString(1);
				return rs.getString(1);
			}
			return "";
		} 
    	catch(Exception e) {
    		e.printStackTrace();
    		return "";
    	}  	
    }
    public void insertStudent(String username, String name, String password, String course) {
    	try {
	    	String SQL = "INSERT INTO LMS.dbo.People (username, name, pass, job, courseID)"
	    			+ "VALUES ('" + username + "', '" + name + "', '" + password + "', 'student', '" + course + "');";
			stmt = con.createStatement();
			stmt.executeUpdate(SQL);
			} 
    	catch(Exception e) {
    		e.printStackTrace();
    	}  	
    }
    public void deleteStudent(String username) {
    	try {
    		String SQL = "DELETE FROM LMS.dbo.People WHERE username = '" + username + "'";
    		stmt = con.createStatement();
    		stmt.executeUpdate(SQL);
    	}
    	catch(Exception e) {
    		e.printStackTrace();
    	}
    }
    public int[] getGrades(String username) {
    	int[] grades = new int[6];
    	//String temp;
    	try {
	    	String SQLPass = "SELECT exam1, exam2, exam3, "
	    			+ "exam4, exam5, exam6 FROM LMS.dbo.People WHERE username = " + "'" + username + "'";
			stmt = con.createStatement();
			rs = stmt.executeQuery(SQLPass);
			int i = 1;
			while(rs.next()) {
				for(i = 1; i <= 6; i++) {
					if(rs.getString(i) != null ) {
						//temp = rs.getString(i);
						if(Integer.parseInt(rs.getString(i)) != 0)
							grades[i - 1] = Integer.parseInt(rs.getString(i));
					}
				}
			}
			return grades;
		} 
    	catch(Exception e) {
    		e.printStackTrace();
    		return grades;
    	}
    }
    public int getGPA(int[] grades) {
    	int i;
    	int count = 0;
    	int sum = 0;
    	
    	for (i = 0; i < grades.length; i++) {
    		if(grades[i] != 0) {
    			sum += grades[i];
    			count++;
    		}
    	}
    	return (sum / count);
    }
//playground area
   /* public static void main (String[] args) {
	
    	Connector c = new Connector();
    	c.getConnection();
    	if(c.verifyCreds("wilcoxj", "pass123")) {
    		//String[] result = c.userInfo("wilcoxj");
    		//System.out.println(Arrays.toString(result));
    		System.out.println(c.getJob("wilcoxj"));
    	}
    	//c.insertStudent("jaynusH", "Hugh Jaynus", "pass789", "002");
    	//c.deleteStudent("jaynusH");
    	int[] grades = new int[10];
    	grades = c.getGrades("wilcoxj");
    	int i = 0;
    	for(i = 0; i < grades.length; i++) {
    		System.out.println(grades[i]);
    	}
    	System.out.println(c.getGPA(grades));
    }  */
}