/*
 * Created by SharpDevelop.
 * User: CC2_PC28
 * Date: 29/10/2026
 * Time: 07:34 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ejercicio_git_en_equipo
{
	/// <summary>
	/// Description of MenuPrincipal.
	/// </summary>
	public partial class MenuPrincipal : Form
	{
		public MenuPrincipal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Conversor C = new Conversor();
			C.Show();
			this.Hide();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Distancia_entre_dos_puntos D = new Distancia_entre_dos_puntos();
			D.Show();
			this.Hide();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			cuadrante U = new cuadrante();
			U.Show();
			this.Hide();
		}
	}
}
