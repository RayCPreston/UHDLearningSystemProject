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
import javax.swing.SwingConstants;


public class AdminLogin {

	private JFrame frame;
	private JTextField txtUsername;
	private JTextField txtPass;
	private JTextField txtName;
	private JTextField txtCourse;
	private JTextField txtDelete;
	private JButton btnClose;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					AdminLogin window = new AdminLogin();
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
	public AdminLogin() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JLabel lblAdminPortal = new JLabel("Admin Portal");
		lblAdminPortal.setHorizontalAlignment(SwingConstants.CENTER);
		lblAdminPortal.setBounds(150, 11, 116, 14);
		frame.getContentPane().add(lblAdminPortal);
		
		JSeparator separator = new JSeparator();
		separator.setBounds(10, 36, 414, 2);
		frame.getContentPane().add(separator);
		
		txtUsername = new JTextField();
		txtUsername.setText("NewUsername");
		txtUsername.setBounds(51, 49, 86, 20);
		frame.getContentPane().add(txtUsername);
		txtUsername.setColumns(10);
		
		txtPass = new JTextField();
		txtPass.setText("NewPass");
		txtPass.setBounds(51, 111, 86, 20);
		frame.getContentPane().add(txtPass);
		txtPass.setColumns(10);
		
		txtName = new JTextField();
		txtName.setText("NewName");
		txtName.setBounds(51, 80, 86, 20);
		frame.getContentPane().add(txtName);
		txtName.setColumns(10);
		
		txtCourse = new JTextField();
		txtCourse.setText("CourseEnrolled");
		txtCourse.setBounds(51, 142, 86, 20);
		frame.getContentPane().add(txtCourse);
		txtCourse.setColumns(10);
		
		JButton btnAdd = new JButton("Add Student");
		btnAdd.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String user = txtUsername.getText();
				String pass = txtPass.getText();
				String name = txtName.getText();
				String course = txtCourse.getText();
				Connector c = new Connector();
				c.getConnection();
				c.insertStudent(user, name, pass, course);				
			}
		});
		btnAdd.setBounds(31, 194, 128, 23);
		frame.getContentPane().add(btnAdd);
		
		txtDelete = new JTextField();
		txtDelete.setText("DeleteUsername");
		txtDelete.setBounds(266, 111, 86, 20);
		frame.getContentPane().add(txtDelete);
		txtDelete.setColumns(10);
		
		JButton btnDelete = new JButton("Delete Username");
		btnDelete.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String user = txtDelete.getText();
				Connector c = new Connector();
				c.getConnection();
				c.deleteStudent(user);
			}
		});
		btnDelete.setBounds(250, 194, 121, 23);
		frame.getContentPane().add(btnDelete);
		
		btnClose = new JButton("Close");
		btnClose.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				System.exit(0);
			}
		});
		btnClose.setBounds(31, 228, 340, 23);
		frame.getContentPane().add(btnClose);
	}

}
