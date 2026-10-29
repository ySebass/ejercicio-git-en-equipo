/*
 * Created by SharpDevelop.
 * User: CC2_PC28
 * Date: 29/10/2026
 * Time: 07:25 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ejercicio_git_en_equipo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			string usuario, contraseña;
			usuario="Admin";
			contraseña="1234";
			if(usuario==txtUsuario.Text && contraseña==txtContraseña.Text)
			{
				MenuPrincipal M=new MenuPrincipal();
				M.Show();
				this.Hide();
			}
		}
	}
}
