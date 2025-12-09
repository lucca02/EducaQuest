/*
 * Created by SharpDevelop.
 * User: Amanda
 * Date: 04/12/2025
 * Time: 18:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace EducaQuest
{
	/// <summary>
	/// Description of AlterarSenhaForm.
	/// </summary>
	public partial class AlterarSenhaForm : Form
	{
		string usuarioAtual;
		public AlterarSenhaForm(string nomeUsuario)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			usuarioAtual = nomeUsuario;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private string CalcularHash(string texto)
		{
    		using (SHA256 sha256 = SHA256.Create())
    		{
        		byte[] bytes = Encoding.UTF8.GetBytes(texto);
        		byte[] hashBytes = sha256.ComputeHash(bytes);
        		return Convert.ToBase64String(hashBytes);
    		}
		}
		
		void PicVoltarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
    		txtSenhaAtual.Clear();
    		txtNovaSenha.Clear();
    		txtConfirmarSenha.Clear();
    		this.Close();
		}
		
		void BtnAlterarClick(object sender, EventArgs e)
		{
    		if (txtSenhaAtual.Text == "" || txtNovaSenha.Text == "" || txtConfirmarSenha.Text == "")
    		{
        		MessageBox.Show("Preencha todos os campos.");
        		return;
    		}

    		string senhaAtual = txtSenhaAtual.Text;
    		string novaSenha = txtNovaSenha.Text;
    		string confirmarSenha = txtConfirmarSenha.Text;
    		string arquivo = "usuarios.txt";

    		bool senhaCorreta = false;
    		List<string> linhas = new List<string>();
    
    		if (File.Exists(arquivo))
    		{
        		foreach (string linha in File.ReadAllLines(arquivo))
        		{
            		string[] dados = linha.Split(';');
            		if (dados.Length >= 3 && dados[0] == usuarioAtual)
            		{
                // 🔥 CORREÇÃO: Calcula HASH da senha digitada
                		string senhaAtualHash = CalcularHash(senhaAtual);
                
                		if (dados[2] == senhaAtualHash) // ← Compara HASH com HASH
                		{
                    		senhaCorreta = true;
                    
                    // Verifica se nova senha é diferente da atual
                    		string novaSenhaHash = CalcularHash(novaSenha);
                    		if (dados[2] == novaSenhaHash)
                    		{
                        		MessageBox.Show("A nova senha deve ser diferente da atual.");
                        		return;
                    		}
                    
                    		if (novaSenha != confirmarSenha)
                    		{
                        		MessageBox.Show("As senhas não coincidem.");
                        		return;
                    		}
                    
                    // 🔥 CORREÇÃO: Salva a NOVA senha criptografada
                    		linhas.Add(dados[0] + ";" + dados[1] + ";" + novaSenhaHash);
                		}
                		else
                		{
                    		linhas.Add(linha);
                		}
            		}
            		else
            		{
            	    	linhas.Add(linha);
            		}
        		}
    		}

    		if (!senhaCorreta)
    		{
        		MessageBox.Show("Senha atual incorreta.");
        		return;
    		}

    		File.WriteAllLines(arquivo, linhas);

    		MessageBox.Show("Senha alterada com sucesso!");
    		this.Close();
		}
	}
}
