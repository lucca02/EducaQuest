/*
 * Created by SharpDevelop.
 * User: Amanda
 * Date: 24/11/2025
 * Time: 19:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace EducaQuest
{
	/// <summary>
	/// Description of Splash.
	/// </summary>
	public partial class Splash : Form
	{
		public Splash()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			LoginForm TelaLogin = new LoginForm();
			TelaLogin.Show();
			this.Hide();
		}
	}
}
