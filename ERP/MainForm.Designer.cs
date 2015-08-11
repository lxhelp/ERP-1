/*
 * Created by SharpDevelop.
 * User: Pablo
 * Date: 6/8/2015
 * Time: 20:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ERP
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtusuario;
		private System.Windows.Forms.TextBox txtpass;
		private System.Windows.Forms.Button cmdiniciar;
		private System.Windows.Forms.Button btn_cancel;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label2 = new System.Windows.Forms.Label();
			this.txtusuario = new System.Windows.Forms.TextBox();
			this.txtpass = new System.Windows.Forms.TextBox();
			this.cmdiniciar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 27);
			this.label2.TabIndex = 1;
			this.label2.Text = "Pass";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtusuario
			// 
			this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtusuario.Location = new System.Drawing.Point(132, 55);
			this.txtusuario.Name = "txtusuario";
			this.txtusuario.Size = new System.Drawing.Size(185, 31);
			this.txtusuario.TabIndex = 2;
			// 
			// txtpass
			// 
			this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtpass.Location = new System.Drawing.Point(132, 102);
			this.txtpass.Name = "txtpass";
			this.txtpass.PasswordChar = '*';
			this.txtpass.Size = new System.Drawing.Size(185, 31);
			this.txtpass.TabIndex = 3;
			this.txtpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtpassKeyPress);
			// 
			// cmdiniciar
			// 
			this.cmdiniciar.Location = new System.Drawing.Point(195, 171);
			this.cmdiniciar.Name = "cmdiniciar";
			this.cmdiniciar.Size = new System.Drawing.Size(122, 38);
			this.cmdiniciar.TabIndex = 4;
			this.cmdiniciar.Text = "Iniciar Sesión";
			this.cmdiniciar.UseVisualStyleBackColor = true;
			this.cmdiniciar.Click += new System.EventHandler(this.CmdiniciarClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuario";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_cancel
			// 
			this.btn_cancel.Location = new System.Drawing.Point(41, 171);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(122, 38);
			this.btn_cancel.TabIndex = 5;
			this.btn_cancel.Text = "Cerrar";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.Btn_cancelClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(359, 246);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.cmdiniciar);
			this.Controls.Add(this.txtpass);
			this.Controls.Add(this.txtusuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(375, 285);
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "ERP";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
