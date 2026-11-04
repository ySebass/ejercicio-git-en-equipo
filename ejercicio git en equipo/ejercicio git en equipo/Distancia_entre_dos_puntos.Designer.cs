/*
 * Created by SharpDevelop.
 * User: CC2_PC28
 * Date: 04/11/2026
 * Time: 07:21 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ejercicio_git_en_equipo
{
	partial class Distancia_entre_dos_puntos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.x1 = new System.Windows.Forms.Label();
			this.x2 = new System.Windows.Forms.Label();
			this.y1 = new System.Windows.Forms.Label();
			this.y2 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt4 = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// x1
			// 
			this.x1.Location = new System.Drawing.Point(85, 66);
			this.x1.Name = "x1";
			this.x1.Size = new System.Drawing.Size(100, 23);
			this.x1.TabIndex = 0;
			this.x1.Text = "x1";
			// 
			// x2
			// 
			this.x2.Location = new System.Drawing.Point(84, 118);
			this.x2.Name = "x2";
			this.x2.Size = new System.Drawing.Size(100, 23);
			this.x2.TabIndex = 1;
			this.x2.Text = "x2";
			// 
			// y1
			// 
			this.y1.Location = new System.Drawing.Point(84, 92);
			this.y1.Name = "y1";
			this.y1.Size = new System.Drawing.Size(100, 23);
			this.y1.TabIndex = 2;
			this.y1.Text = "y1";
			// 
			// y2
			// 
			this.y2.Location = new System.Drawing.Point(85, 144);
			this.y2.Name = "y2";
			this.y2.Size = new System.Drawing.Size(100, 23);
			this.y2.TabIndex = 3;
			this.y2.Text = "y2";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(114, 63);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(100, 20);
			this.txt1.TabIndex = 4;
			// 
			// txt3
			// 
			this.txt3.Location = new System.Drawing.Point(114, 115);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(100, 20);
			this.txt3.TabIndex = 5;
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(114, 89);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(100, 20);
			this.txt2.TabIndex = 6;
			// 
			// txt4
			// 
			this.txt4.Location = new System.Drawing.Point(114, 141);
			this.txt4.Name = "txt4";
			this.txt4.Size = new System.Drawing.Size(100, 20);
			this.txt4.TabIndex = 7;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.regresarToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// regresarToolStripMenuItem
			// 
			this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
			this.regresarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.regresarToolStripMenuItem.Text = "Regresar";
			this.regresarToolStripMenuItem.Click += new System.EventHandler(this.RegresarToolStripMenuItemClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(45, 214);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 35);
			this.button1.TabIndex = 9;
			this.button1.Text = "Calcular";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(146, 214);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(95, 35);
			this.button2.TabIndex = 10;
			this.button2.Text = "Limpiar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(45, 177);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(196, 23);
			this.lblResultado.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(272, 23);
			this.label1.TabIndex = 12;
			this.label1.Text = "DISTANCIA ENTRE DOS PUNTOS";
			// 
			// Distancia_entre_dos_puntos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txt4);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt3);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.y2);
			this.Controls.Add(this.y1);
			this.Controls.Add(this.x2);
			this.Controls.Add(this.x1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Distancia_entre_dos_puntos";
			this.Text = "Distancia_entre_dos_puntos";
			this.Load += new System.EventHandler(this.Distancia_entre_dos_puntosLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.TextBox txt4;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label y2;
		private System.Windows.Forms.Label y1;
		private System.Windows.Forms.Label x2;
		private System.Windows.Forms.Label x1;
	}
}
