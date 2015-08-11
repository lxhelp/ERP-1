/*
 * Creado por SharpDevelop.
 * Usuario: Pablo
 * Fecha: 10/8/2015
 * Hora: 19:18
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
	
namespace ERP
{
	/// <summary>
	/// Description of VentaNueva.
	/// </summary>
	public partial class VentaNueva : Form
	{
		public VentaNueva()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void VentaNuevaLoad(object sender, EventArgs e)
		{
			DateTime estedia = DateTime.Today;
			txtfecha.Text = estedia.ToString("d");
			txthora.Text = DateTime.Now.ToString("hh:mm:ss");
		}
	}
}
