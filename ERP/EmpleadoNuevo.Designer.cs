/*
 * Created by SharpDevelop.
 * User: Pablo
 * Date: 09/08/2015
 * Time: 08:53 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ERP
{
	partial class EmpleadoNuevo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.TextBox txtpass;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button cmdguardar;
		private System.Windows.Forms.Button cmdnuevo;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtpass2;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.txtpass = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmdguardar = new System.Windows.Forms.Button();
			this.cmdnuevo = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtpass2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(381, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Paletería Loma Bonita";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(190, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtnombre
			// 
			this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtnombre.Location = new System.Drawing.Point(220, 49);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(286, 31);
			this.txtnombre.TabIndex = 2;
			// 
			// txtpass
			// 
			this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtpass.Location = new System.Drawing.Point(220, 86);
			this.txtpass.Name = "txtpass";
			this.txtpass.PasswordChar = '*';
			this.txtpass.Size = new System.Drawing.Size(286, 31);
			this.txtpass.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(190, 29);
			this.label3.TabIndex = 3;
			this.label3.Text = "Password:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmdguardar
			// 
			this.cmdguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdguardar.Location = new System.Drawing.Point(356, 215);
			this.cmdguardar.Name = "cmdguardar";
			this.cmdguardar.Size = new System.Drawing.Size(150, 48);
			this.cmdguardar.TabIndex = 5;
			this.cmdguardar.Text = "Guardar";
			this.cmdguardar.UseVisualStyleBackColor = true;
			this.cmdguardar.Click += new System.EventHandler(this.CmdguardarClick);
			// 
			// cmdnuevo
			// 
			this.cmdnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdnuevo.Location = new System.Drawing.Point(188, 215);
			this.cmdnuevo.Name = "cmdnuevo";
			this.cmdnuevo.Size = new System.Drawing.Size(150, 48);
			this.cmdnuevo.TabIndex = 6;
			this.cmdnuevo.Text = "Nuevo";
			this.cmdnuevo.UseVisualStyleBackColor = true;
			this.cmdnuevo.Click += new System.EventHandler(this.CmdnuevoClick);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(12, 215);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 48);
			this.button1.TabIndex = 7;
			this.button1.Text = "Regresar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(190, 29);
			this.label4.TabIndex = 8;
			this.label4.Text = "Repetir password:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtpass2
			// 
			this.txtpass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtpass2.Location = new System.Drawing.Point(220, 126);
			this.txtpass2.Name = "txtpass2";
			this.txtpass2.PasswordChar = '*';
			this.txtpass2.Size = new System.Drawing.Size(286, 31);
			this.txtpass2.TabIndex = 9;
			// 
			// EmpleadoNuevo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(518, 275);
			this.Controls.Add(this.txtpass2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cmdnuevo);
			this.Controls.Add(this.cmdguardar);
			this.Controls.Add(this.txtpass);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtnombre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "EmpleadoNuevo";
			this.Text = "Empleado Nuevo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
