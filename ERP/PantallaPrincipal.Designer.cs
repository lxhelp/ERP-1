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
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mostrarTodosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mostrarTodosToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem mostrarTodosToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem3;
		
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mostrarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.buscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.mostrarTodosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.buscarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.mostrarTodosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.eliminarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buscarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdregresar
			// 
			this.cmdregresar.Location = new System.Drawing.Point(351, 461);
			this.cmdregresar.Name = "cmdregresar";
			this.cmdregresar.Size = new System.Drawing.Size(75, 23);
			this.cmdregresar.TabIndex = 0;
			this.cmdregresar.Text = "Regresar";
			this.cmdregresar.UseVisualStyleBackColor = true;
			this.cmdregresar.Click += new System.EventHandler(this.CmdregresarClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.clientesToolStripMenuItem,
			this.proveedoresToolStripMenuItem,
			this.inventarioToolStripMenuItem,
			this.ventasToolStripMenuItem,
			this.empleadosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(426, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.nuevoToolStripMenuItem,
			this.buscarToolStripMenuItem,
			this.mostrarTodosToolStripMenuItem,
			this.modificarToolStripMenuItem1,
			this.eliminarToolStripMenuItem1});
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.clientesToolStripMenuItem.Text = "Clientes";
			// 
			// nuevoToolStripMenuItem
			// 
			this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
			this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.nuevoToolStripMenuItem.Text = "Nuevo";
			// 
			// buscarToolStripMenuItem
			// 
			this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
			this.buscarToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.buscarToolStripMenuItem.Text = "Buscar";
			// 
			// mostrarTodosToolStripMenuItem
			// 
			this.mostrarTodosToolStripMenuItem.Name = "mostrarTodosToolStripMenuItem";
			this.mostrarTodosToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.mostrarTodosToolStripMenuItem.Text = "Mostrar todos";
			// 
			// modificarToolStripMenuItem1
			// 
			this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
			this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
			this.modificarToolStripMenuItem1.Text = "Modificar";
			// 
			// eliminarToolStripMenuItem1
			// 
			this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
			this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
			this.eliminarToolStripMenuItem1.Text = "Eliminar";
			// 
			// proveedoresToolStripMenuItem
			// 
			this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.nuevoToolStripMenuItem1,
			this.buscarToolStripMenuItem1,
			this.mostrarTodosToolStripMenuItem1,
			this.modificarToolStripMenuItem,
			this.eliminarToolStripMenuItem});
			this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
			this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
			this.proveedoresToolStripMenuItem.Text = "Proveedores";
			// 
			// nuevoToolStripMenuItem1
			// 
			this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
			this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
			this.nuevoToolStripMenuItem1.Text = "Nuevo";
			// 
			// buscarToolStripMenuItem1
			// 
			this.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
			this.buscarToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
			this.buscarToolStripMenuItem1.Text = "Buscar";
			// 
			// mostrarTodosToolStripMenuItem1
			// 
			this.mostrarTodosToolStripMenuItem1.Name = "mostrarTodosToolStripMenuItem1";
			this.mostrarTodosToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
			this.mostrarTodosToolStripMenuItem1.Text = "Mostrar Todos";
			// 
			// modificarToolStripMenuItem
			// 
			this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
			this.modificarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.modificarToolStripMenuItem.Text = "Modificar";
			// 
			// eliminarToolStripMenuItem
			// 
			this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
			this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.eliminarToolStripMenuItem.Text = "Eliminar";
			// 
			// inventarioToolStripMenuItem
			// 
			this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
			this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.inventarioToolStripMenuItem.Text = "Inventario";
			// 
			// ventasToolStripMenuItem
			// 
			this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.nuevaToolStripMenuItem,
			this.buscarToolStripMenuItem3});
			this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
			this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ventasToolStripMenuItem.Text = "Ventas";
			// 
			// empleadosToolStripMenuItem
			// 
			this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.nuevoToolStripMenuItem2,
			this.buscarToolStripMenuItem2,
			this.mostrarTodosToolStripMenuItem2,
			this.modificarToolStripMenuItem2,
			this.eliminarToolStripMenuItem2});
			this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
			this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.empleadosToolStripMenuItem.Text = "Empleados";
			// 
			// nuevoToolStripMenuItem2
			// 
			this.nuevoToolStripMenuItem2.Name = "nuevoToolStripMenuItem2";
			this.nuevoToolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
			this.nuevoToolStripMenuItem2.Text = "Nuevo";
			// 
			// buscarToolStripMenuItem2
			// 
			this.buscarToolStripMenuItem2.Name = "buscarToolStripMenuItem2";
			this.buscarToolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
			this.buscarToolStripMenuItem2.Text = "Buscar";
			// 
			// mostrarTodosToolStripMenuItem2
			// 
			this.mostrarTodosToolStripMenuItem2.Name = "mostrarTodosToolStripMenuItem2";
			this.mostrarTodosToolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
			this.mostrarTodosToolStripMenuItem2.Text = "Mostrar todos";
			// 
			// modificarToolStripMenuItem2
			// 
			this.modificarToolStripMenuItem2.Name = "modificarToolStripMenuItem2";
			this.modificarToolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
			this.modificarToolStripMenuItem2.Text = "Modificar";
			// 
			// eliminarToolStripMenuItem2
			// 
			this.eliminarToolStripMenuItem2.Name = "eliminarToolStripMenuItem2";
			this.eliminarToolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
			this.eliminarToolStripMenuItem2.Text = "Eliminar";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(426, 428);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// nuevaToolStripMenuItem
			// 
			this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
			this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.nuevaToolStripMenuItem.Text = "Nueva";
			// 
			// buscarToolStripMenuItem3
			// 
			this.buscarToolStripMenuItem3.Name = "buscarToolStripMenuItem3";
			this.buscarToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
			this.buscarToolStripMenuItem3.Text = "Buscar";
			// 
			// PantallaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(426, 496);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.cmdregresar);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "PantallaPrincipal";
			this.Text = "Paletería Loma Bonita";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
