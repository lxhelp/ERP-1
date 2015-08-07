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
			this.cmdregresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmdregresar
			// 
			this.cmdregresar.Location = new System.Drawing.Point(72, 227);
			this.cmdregresar.Name = "cmdregresar";
			this.cmdregresar.Size = new System.Drawing.Size(75, 23);
			this.cmdregresar.TabIndex = 0;
			this.cmdregresar.Text = "Regresar";
			this.cmdregresar.UseVisualStyleBackColor = true;
			this.cmdregresar.Click += new System.EventHandler(this.CmdregresarClick);
			// 
			// PantallaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.cmdregresar);
			this.Name = "PantallaPrincipal";
			this.Text = "PantallaPrincipal";
			this.ResumeLayout(false);

		}
	}
}
