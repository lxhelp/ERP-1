/*
 * Created by SharpDevelop.
 * User: Pablo
 * Date: 6/8/2015
 * Time: 20:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ERP
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CmdiniciarClick(object sender, EventArgs e)
		{
			if(ChecarSesion())
			{
				PantallaPrincipal x=new PantallaPrincipal();
				this.Hide();
				x.Show();
			}
			else
			{
				MessageBox.Show("Usuario o contraseña incorrecto.");
			}
		}
		
		bool ChecarSesion()
		{
			String str = @"server=localhost;database=erpbd;userid=root;password=;";
			MySqlConnection con = null;
			MySqlDataReader reader = null;
			try
			{
				con = new MySqlConnection(str);
				con.Open(); //open the connection
				String cmdText = "SELECT * FROM usuario WHERE nombre = '" + txtusuario.Text + "' AND pass = '" + txtpass.Text + "';";
				MySqlCommand cmd = new MySqlCommand(cmdText,con);
				reader = cmd.ExecuteReader();
				if(reader.Read())
				{
					int idrecibido = reader.GetInt32("ID");
					string usuariorecibido = reader.GetString("NOMBRE");
					string passrecibido = reader.GetString("PASS");
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (MySqlException err) //We will capture and display any MySql errors that will occur
			{
				MessageBox.Show(err.ToString());
				return false;
			}
		}//Funcion CerrarSesion
	}
}
