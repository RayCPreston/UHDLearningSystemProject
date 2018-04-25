package loginSystem;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JPasswordField;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JSeparator;

import java.sql.*;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Arrays;


import databaseCon.*;


public class Login {
	/*Connection con = null;
	ResultSet rs = null,
	PreparedStatement = null;*/

	private JFrame frame;
	private JTextField txtUsername;
	private JPasswordField txtPassword;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Login window = new Login();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Login() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(200, 200, 500, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JLabel lblLogin = new JLabel("Login");
		lblLogin.setBounds(232, 11, 46, 14);
		frame.getContentPane().add(lblLogin);
		
		JLabel lblUsername = new JLabel("Username");
		lblUsername.setBounds(77, 72, 66, 14);
		frame.getContentPane().add(lblUsername);
		
		JLabel lblPassword = new JLabel("Password");
		lblPassword.setBounds(77, 128, 66, 14);
		frame.getContentPane().add(lblPassword);
		
		txtUsername = new JTextField();
		txtUsername.setBounds(181, 69, 196, 20);
		frame.getContentPane().add(txtUsername);
		txtUsername.setColumns(10);
		
		txtPassword = new JPasswordField();
		txtPassword.setBounds(181, 125, 196, 20);
		frame.getContentPane().add(txtPassword);
		
		JButton btnLogin = new JButton("Login");
		btnLogin.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				String username = txtUsername.getText();
				@SuppressWarnings("deprecation")
				String password = txtPassword.getText();
				
				//if(password.contains("test") && username.contains("test")) 
				Connector c = new Connector();
				c.getConnection();
				//if(c.verifyCreds(username, password)){
				/*try {
					Connector c = new Connector();
					if(c.verifyCreds(username, password)) {
						txtPassword.setText(null);
						txtUsername.setText(null);
						JOptionPane.showMessageDialog(null,  "Good job, buddy!", "Great Success", JOptionPane.ERROR_MESSAGE);
					}*/
				if(c.verifyCreds(username, password) && c.getJob(username).contains("student")) {
					txtPassword.setText(null);
					txtUsername.setText(null);
					
					studentLogin stuLog = new studentLogin();
					stuLog.main(null);
					
				}
				else if(c.verifyCreds(username, password) && c.getJob(username).contains("admin")) {
					txtPassword.setText(null);
					txtUsername.setText(null);
					AdminLogin adLog = new AdminLogin();
					adLog.main(null);
				}
				
				else {
						JOptionPane.showMessageDialog(null, "Invalid Credentials, please try again", "Login Error", JOptionPane.ERROR_MESSAGE);
						txtPassword.setText(null);
						txtUsername.setText(null);
				}
			}
		});
		btnLogin.setBounds(67, 206, 89, 23);
		frame.getContentPane().add(btnLogin);
		
		JButton btnClear = new JButton("Clear");
		btnClear.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				txtUsername.setText(null);
				txtPassword.setText(null);
			}
		});
		btnClear.setBounds(203, 206, 89, 23);
		frame.getContentPane().add(btnClear);
		
		JButton btnClose = new JButton("Close");
		btnClose.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				System.exit(0);
			}
		});
		btnClose.setBounds(332, 206, 89, 23);
		frame.getContentPane().add(btnClose);
		
		JSeparator separator = new JSeparator();
		separator.setBounds(26, 181, 427, -5);
		frame.getContentPane().add(separator);
		
		JSeparator separator_1 = new JSeparator();
		separator_1.setBounds(26, 43, 429, 18);
		frame.getContentPane().add(separator_1);
		
		JSeparator separator_2 = new JSeparator();
		separator_2.setBounds(26, 181, 429, 18);
		frame.getContentPane().add(separator_2);
	}
}
