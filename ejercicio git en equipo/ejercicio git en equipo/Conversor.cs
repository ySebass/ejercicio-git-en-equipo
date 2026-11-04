/*
 * Created by SharpDevelop.
 * User: CC2_PC28
 * Date: 04/11/2026
 * Time: 07:20 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ejercicio_git_en_equipo
{
	/// <summary>
	/// Description of Conversor.
	/// </summary>
	public partial class Conversor : Form
	{
		public Conversor()
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
			double pesos=Convert.ToDouble(txtPesos.Text);
			double dolares=Convert.ToDouble(txtPesos.Text);
			string conversor=cbPesos.Text;
			switch (conversor) {
				case "Pesos a dolares":
					txtResultado.Text=pesos+" pesos son: "+pesos*0.054+" dolares";
				break;
				case "Dolares a pesos":
					txtResultado.Text=dolares+" dolares son: "+dolares*18.66+" pesos";
				break;
			}
		}
		
		void ConversorLoad(object sender, EventArgs e)
		{
			cbPesos.Items.Add("Pesos a dolares");
			cbPesos.Items.Add("Dolares a pesos");
			cbPesos.SelectedIndex=0;
		}
		
		void RegresarToolStripMenuItemClick(object sender, EventArgs e)
		{
			MenuPrincipal M=new MenuPrincipal();
			M.Show();
			this.Hide();
		}
	}
}
