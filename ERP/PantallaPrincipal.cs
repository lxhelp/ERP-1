/*
 * Created by SharpDevelop.
 * User: Pablo
 * Date: 6/8/2015
 * Time: 20:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ERP
{
	/// <summary>
	/// Description of PantallaPrincipal.
	/// </summary>
	public partial class PantallaPrincipal : Form
	{
		public PantallaPrincipal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		void CmdregresarClick(object sender, EventArgs e)
		{
			MainForm x=new MainForm();
			this.Hide();
			x.Show();
		}
		void Button1Click(object sender, EventArgs e)
		{
			EmpleadoNuevo x=new EmpleadoNuevo();
			this.Hide();
			x.Show();
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			MainForm x=new MainForm();
			this.Hide();
			x.Show();
		}
		
	}
}
