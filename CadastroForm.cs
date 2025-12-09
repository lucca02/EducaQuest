/*
 * Created by SharpDevelop.
 * User: Amanda
 * Date: 24/11/2025
 * Time: 19:30
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
	/// Description of CadastroForm.
	/// </summary>
	public partial class CadastroForm : Form
	{
		
		public CadastroForm()
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
    		using (SHA256 sha256 = SHA256.Create())
    		{
        		byte[] bytes = Encoding.UTF8.GetBytes(texto);
        		byte[] hashBytes = sha256.ComputeHash(bytes);
        		return Convert.ToBase64String(hashBytes);
    		}
		}
		
		void BtnCadastrarClick(object sender, EventArgs e)
		{
    		string nome = txtNome.Text.Trim();
    		string email = txtEmail.Text.Trim(); 
    		string senha = txtSenha.Text.Trim();

    // VALIDAÇÃO BÁSICA
    		if (nome == "" || email == "" || senha == "")
    		{
        		MessageBox.Show("Preencha todos os campos.");
        		return;
    		}

    		if (!email.Contains("@") || !email.Contains("."))
    		{
        		MessageBox.Show("Digite um e-mail válido.");
        		return;
    		}
    
    // VALIDAR TAMANHO MÍNIMO DA SENHA (opcional, mas recomendado)
    		if (senha.Length < 4)
    		{
        		MessageBox.Show("A senha deve ter pelo menos 4 caracteres.");
        		return;
    		}
    
    		string arquivo = "usuarios.txt";
    		bool cadastrado = false;

    // VERIFICA SE O ARQUIVO EXISTE E TEM CONTEÚDO
    		if (File.Exists(arquivo))
    		{
        		string[] linhas = File.ReadAllLines(arquivo);
        
        		foreach(string linha in linhas)
        		{
            // PULA LINHAS VAZIAS
            		if (string.IsNullOrWhiteSpace(linha))
                		continue;
                
            		string[] dados = linha.Split(';');
            
            // 🔥 CORREÇÃO PRINCIPAL: VERIFICA SE TEM CAMPOS SUFICIENTES
            			if (dados.Length >= 2) // Precisa ter pelo menos 2 campos
            		{
                		string emailExistente = dados[1].Trim();
                
                		if (emailExistente == email)
                		{
                    		MessageBox.Show("E-mail já cadastrado.");
                    		cadastrado = true;
                    		break;
                		}
            		}
            		else
            		{
                // Linha mal formatada - ignore ou registre erro
                		Console.WriteLine("Linha mal formatada: " + linha);
                		continue;
            		}
        		}
    		}

    		if (!cadastrado)
    		{
        		try
        		{
            		using (StreamWriter sw = File.AppendText(arquivo))
            		{
                		string senhaHash = CalcularHash(senha);
                		sw.WriteLine(nome + ";" + email + ";" + senhaHash); 
            		}
            
            // 🔥 ADICIONAR ESTATÍSTICAS INICIAIS PARA O NOVO USUÁRIO
            		CriarEstatisticasIniciais(nome);
            
            		MessageBox.Show("Cadastro realizado com sucesso!");
    
            		txtNome.Clear();
            		txtEmail.Clear();
            		txtSenha.Clear();
        		}
        		catch (Exception ex)
        		{
            		MessageBox.Show("Erro ao salvar cadastro: " + ex.Message);
        		}
    		}
		}
		
		void CriarEstatisticasIniciais(string usuario)
		{
    		string arquivoEstatisticas = "estatisticas.txt";
    
    // Formato: usuario;XP;MOEDAS;QUIZZES;NIVEL;STREAK;DATA
    		string hoje = DateTime.Today.ToString("dd/MM/yyyy");
    		string novaEstatistica = usuario + ";0;0;0;1;0;" + hoje;
    
    		using (StreamWriter sw = File.AppendText(arquivoEstatisticas))
    		{
        		sw.WriteLine(novaEstatistica);
    		}
		}
		
		void LinkLoginLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			LoginForm login = new LoginForm();
    		login.Show();
    		this.Hide();
		}
	}
}
