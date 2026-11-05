/*
 * Created by SharpDevelop.
 * User: CC2_PC28
 * Date: 04/11/2026
 * Time: 07:23 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ejercicio_git_en_equipo
{
	/// <summary>
	/// Description of cuadrante.
	/// </summary>
	public partial class cuadrante : Form
	{
		public cuadrante()
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
			double x, y;
			x=Convert.ToDouble(txtX.Text);
			y=Convert.ToDouble(txtY.Text);
			if(x > 0 && y > 0)
				lblResultado.Text="Esta en el 1";
			else if(x > 0 && y < 0)
				lblResultado.Text="Esta en el 2";
			else if(x < 0 && y < 0)
				lblResultado.Text="Esta en el 3";
			else if(y > 0 && x < 0)
				lblResultado.Text="Esta en el 4";
		}
		
		void RegresarToolStripMenuItemClick(object sender, EventArgs e)
		{
			MenuPrincipal M=new MenuPrincipal();
			M.Show();
			this.Hide();
		}
	}
}
