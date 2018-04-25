package loginSystem;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JButton;
import javax.swing.JTable;
import javax.swing.JScrollPane;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.*;

import java.sql.*;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Arrays;
import databaseCon.*;
import net.proteanit.sql.DbUtils;



public class studentLogin extends JFrame {

	private JPanel contentPane;
	private JTable table;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					studentLogin frame = new studentLogin();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	Connection con = null;
	private JTextField txtUsername;
	private JScrollPane scrollPane;
	private JButton btnClose;
	public studentLogin() {
		con = Connector.getConnection();
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JButton btnShowInfo = new JButton("Show Student Info");
		btnShowInfo.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				String username = txtUsername.getText();
				try {
					String SQL = "SELECT username, name, job, courseID, exam1, exam2, exam3, "
			    			+ "exam4, exam5, exam6 FROM LMS.dbo.People WHERE username = " + "'" + username + "'";
					PreparedStatement pstmt = con.prepareStatement(SQL);
					ResultSet rs = pstmt.executeQuery();
					
					table.setModel(DbUtils.resultSetToTableModel(rs));
				}
				catch(Exception e) {
					e.printStackTrace();
				}
			}
		});
		btnShowInfo.setBounds(81, 24, 123, 23);
		contentPane.add(btnShowInfo);
		
		scrollPane = new JScrollPane();
		scrollPane.setBounds(36, 77, 368, 68);
		contentPane.add(scrollPane);
		
		table = new JTable();
		scrollPane.setViewportView(table);
		
		txtUsername = new JTextField();
		txtUsername.setText("Enter Username");
		txtUsername.setBounds(243, 25, 123, 20);
		contentPane.add(txtUsername);
		txtUsername.setColumns(10);
		
		btnClose = new JButton("Close");
		btnClose.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				System.exit(0);
			}
		});
		btnClose.setBounds(36, 209, 368, 23);
		contentPane.add(btnClose);
	}
}
