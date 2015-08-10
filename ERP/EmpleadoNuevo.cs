/*
 * Created by SharpDevelop.
 * User: Pablo
 * Date: 09/08/2015
 * Time: 08:53 p. m.
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
	/// Description of EmpleadoNuevo.
	/// </summary>
	public partial class EmpleadoNuevo : Form
	{
		public EmpleadoNuevo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CmdnuevoClick(object sender, EventArgs e)
		{
			EmpleadoNuevo x=new EmpleadoNuevo();
			x.Show();
			this.Hide();
		}
		void Button1Click(object sender, EventArgs e)
		{
			PantallaPrincipal x=new PantallaPrincipal();
			this.Hide();
			x.Show();
		}
		void CmdguardarClick(object sender, EventArgs e)
		{
			if(txtpass.Text == txtpass2.Text)
			{
				try
				{
					string MyConnection2 = "datasource=localhost;database=erpbd;username=root;password=";
					string Query = "INSERT INTO usuario VALUES(null,'" + txtnombre.Text + "','" + txtpass.Text +"');";
					MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
					MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            		MyConn2.Open();
            		int resultado = MyCommand2.ExecuteNonQuery();
            		MyConn2.Close();
            		if(resultado > 0)
            		{
            			MessageBox.Show("El usuario ha sido agregado con éxito.");
            		}
            		else
            		{
            			MessageBox.Show("Ocurrió un error, inténtelo de nuevo.");
            		}
				}
				catch (Exception ex)
        		{ 
					MessageBox.Show("Ocurrió un error, inténtelo de nuevo.\n" + ex.ToString());
     	 		}	
			}
			else
			{
				MessageBox.Show("Las contraseñas no son iguales.");
			}
		}
	}
}
