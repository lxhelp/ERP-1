/*
 * Created by SharpDevelop.
 * User: Pablo
 * Date: 6/8/2015
 * Time: 20:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ERP
{
	partial class PantallaPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button cmdregresar;
		private System.Windows.Forms.Label lblpaleteria;
		private System.Windows.Forms.Label lblicepro;
		private System.Windows.Forms.Button btn_clientes;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
			this.cmdregresar = new System.Windows.Forms.Button();
			this.lblpaleteria = new System.Windows.Forms.Label();
			this.lblicepro = new System.Windows.Forms.Label();
			this.btn_clientes = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdregresar
			// 
			this.cmdregresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdregresar.Location = new System.Drawing.Point(658, 505);
			this.cmdregresar.Name = "cmdregresar";
			this.cmdregresar.Size = new System.Drawing.Size(90, 28);
			this.cmdregresar.TabIndex = 0;
			this.cmdregresar.Text = "Sign Out";
			this.cmdregresar.UseVisualStyleBackColor = true;
			this.cmdregresar.Click += new System.EventHandler(this.CmdregresarClick);
			// 
			// lblpaleteria
			// 
			this.lblpaleteria.BackColor = System.Drawing.Color.Transparent;
			this.lblpaleteria.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblpaleteria.ForeColor = System.Drawing.Color.Chocolate;
			this.lblpaleteria.Location = new System.Drawing.Point(172, 9);
			this.lblpaleteria.Name = "lblpaleteria";
			this.lblpaleteria.Size = new System.Drawing.Size(409, 47);
			this.lblpaleteria.TabIndex = 1;
			this.lblpaleteria.Text = "Paleteria Loma Bonita";
			this.lblpaleteria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblicepro
			// 
			this.lblicepro.BackColor = System.Drawing.Color.Transparent;
			this.lblicepro.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblicepro.ForeColor = System.Drawing.Color.Sienna;
			this.lblicepro.Location = new System.Drawing.Point(658, 227);
			this.lblicepro.Name = "lblicepro";
			this.lblicepro.Size = new System.Drawing.Size(114, 64);
			this.lblicepro.TabIndex = 2;
			this.lblicepro.Text = "ICEPRO v1.0";
			this.lblicepro.UseCompatibleTextRendering = true;
			// 
			// btn_clientes
			// 
			this.btn_clientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_clientes.Location = new System.Drawing.Point(25, 70);
			this.btn_clientes.Name = "btn_clientes";
			this.btn_clientes.Size = new System.Drawing.Size(154, 61);
			this.btn_clientes.TabIndex = 3;
			this.btn_clientes.Text = "EMPLEADOS";
			this.btn_clientes.UseVisualStyleBackColor = true;
			this.btn_clientes.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(25, 227);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(166, 135);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// PantallaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FloralWhite;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(784, 583);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_clientes);
			this.Controls.Add(this.lblicepro);
			this.Controls.Add(this.lblpaleteria);
			this.Controls.Add(this.cmdregresar);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(800, 599);
			this.Name = "PantallaPrincipal";
			this.Text = "PantallaPrincipal";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
