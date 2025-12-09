/*
 * Created by SharpDevelop.
 * User: Amanda
 * Date: 24/11/2025
 * Time: 20:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace EducaQuest
{
	/// <summary>
	/// Description of LoginForm.
	/// </summary>
	public partial class LoginForm : Form
	{
		string arquivo = "usuarios.txt";
		
		public LoginForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private string CalcularHash(string texto)
		{
    		using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
    		{
        		byte[] bytes = System.Text.Encoding.UTF8.GetBytes(texto);
        		byte[] hashBytes = sha256.ComputeHash(bytes);
        		return Convert.ToBase64String(hashBytes);
    		}
		}
		
		void BtnEntrarClick(object sender, EventArgs e)
		{
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();
            string senhaHash = CalcularHash(senha);

            if (email == "" || senha == "")
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (!File.Exists(arquivo))
            {
                MessageBox.Show("Nenhum usuário cadastrado.");
                return;
            }

            bool encontrado = false;
            string nomeUsuario = "";
            
            foreach (string linha in File.ReadAllLines(arquivo))
            {
                string[] dados = linha.Split(';');
                if (dados.Length >= 3)
                {
                    if (dados[1] == email && dados[2] == senhaHash) 
                    {
                        encontrado = true;
                        nomeUsuario = dados[0];
                        break;
                    }
                }
            }

            if (encontrado)
            {
                MessageBox.Show("Login realizado com sucesso!\nBem-vindo(a), " + nomeUsuario + "!");
                
                MainForm main = new MainForm(nomeUsuario);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("E-mail ou senha incorretos.");
            }
		}
		
		void LinkCadastroLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
            CadastroForm cadastro = new CadastroForm();
            cadastro.Show();
            this.Hide();
		}
	}
}
