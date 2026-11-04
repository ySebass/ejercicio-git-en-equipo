/*
 * Created by SharpDevelop.
 * User: CC2_PC28
 * Date: 04/11/2026
 * Time: 07:21 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ejercicio_git_en_equipo
{
	/// <summary>
	/// Description of Distancia_entre_dos_puntos.
	/// </summary>
	public partial class Distancia_entre_dos_puntos : Form
	{
		public Distancia_entre_dos_puntos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void RegresarToolStripMenuItemClick(object sender, EventArgs e)
		{
			MenuPrincipal M=new MenuPrincipal();
			M.Show();
			this.Hide();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double x1,x2,y1,y2,d;
			x1=Convert.ToDouble(txt1.Text);
			y1=Convert.ToDouble(txt2.Text);
			x2=Convert.ToDouble(txt3.Text);
			y2=Convert.ToDouble(txt4.Text);
			d=Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
			lblResultado.Text=String.Format("{0:F2}",d);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			txt1.Text=("");
			txt3.Text=("");
			txt2.Text=("");
			txt4.Text=("");
			lblResultado.Text=("");
		}
		
		void Distancia_entre_dos_puntosLoad(object sender, EventArgs e)
		{
			
		}
	}
}
