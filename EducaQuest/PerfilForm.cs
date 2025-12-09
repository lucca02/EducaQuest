using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace EducaQuest
{
    public partial class PerfilForm : Form
    {
        string nomeUsuario;
        
        public PerfilForm(string usuario)
        {
            InitializeComponent();
            nomeUsuario = usuario;
            lblNome.Text = "Nome: " + nomeUsuario;
            CarregarDadosUsuario();
            CarregarEstatisticasPerfil();
        }
        
        void CarregarDadosUsuario()
        {
            string arquivo = "usuarios.txt";
            
            if (File.Exists(arquivo))
            {
                foreach (string linha in File.ReadAllLines(arquivo))
                {
                    string[] dados = linha.Split(';');
                    if (dados.Length >= 3 && dados[0] == nomeUsuario) // nome;email;senha
                    {
                        lblNome.Text = "Nome: " + dados[0];
                        lblEmail.Text = "Email: " + dados[1];
                        break;
                    }
                }
            }
            else
            {
                lblEmail.Text = "Email: Não encontrado";
            }
            
            if (JaResgatouRecompensa("nivel_3"))
    		{
        		lblNome.ForeColor = Color.Gold;
        		lblNome.Font = new Font(lblNome.Font, FontStyle.Bold);
        		lblEmail.ForeColor = Color.Goldenrod;
        // Opcional: this.BackColor = Color.FromArgb(255, 248, 220); (fundo bege claro)
    		}
    
    // 🔥 TÍTULO LENDÁRIO (nível 10)  
    		if (JaResgatouRecompensa("nivel_10"))
    		{
        		lblNome.Text = "Nome: " + nomeUsuario + " [LENDÁRIO]";
        		lblNome.ForeColor = Color.Blue;
    		}
        }
        
        void PicVoltarClick(object sender, EventArgs e)
        {
            MainForm main = new MainForm(nomeUsuario);
            main.Show();
            this.Hide();
        }
        
        void BtnAlterarSenhaClick(object sender, EventArgs e)
        {
            AlterarSenhaForm alterarSenha = new AlterarSenhaForm(nomeUsuario);
            alterarSenha.ShowDialog();
        }
        
        void CarregarEstatisticasPerfil()
        {
            string arquivo = "estatisticas.txt";
            
            if (File.Exists(arquivo))
            {
                foreach (string linha in File.ReadAllLines(arquivo))
                {
                    string[] dados = linha.Split(';');
                    // 🔥 CORREÇÃO: Mudou de 6 para 7 campos
                    if (dados.Length >= 7 && dados[0] == nomeUsuario)
                    {
                        // 🔥 CORREÇÃO DOS ÍNDICES (igual MainForm)
                        int xp = int.Parse(dados[1]);          // XP
                        int moedas = int.Parse(dados[2]);      // MOEDAS
                        int quizzes = int.Parse(dados[3]);     // QUIZZES
                        int nivel = int.Parse(dados[4]);       // NÍVEL
                        int streak = int.Parse(dados[5]);      // STREAK
                        
                        // 🔥 USAR MESMO CÁLCULO DA MAINFORM
                        int nivelCorreto = CalcularNivel(xp);
                        
                        // 🔥 ATUALIZAR TODAS AS LABELS
                        lblNivel.Text = "Nível: " + nivelCorreto;
                        lblPontuacaoTotal.Text = "XP Total: " + xp;  // Mudei de "Pontuação" para "XP"
                        lblMoedas.Text = "Moedas: " + moedas;  // Adicionei esta label!
                        lblStreak.Text = "Streak: " + streak + " dias";
                        lblQuizzesCompletos.Text = "Questões Respondidas: " + quizzes;
                        
                        // 🔥 CALCULAR PROGRESSO (opcional - se tiver barra no perfil)
                        // AtualizarProgressoPerfil(xp, nivelCorreto);
                        
                        break;
                    }
                }
            }
            else
            {
                // Valores padrão
                lblNivel.Text = "Nível: 1";
                lblPontuacaoTotal.Text = "XP Total: 0";
                lblMoedas.Text = "Moedas: 0";
                lblStreak.Text = "Streak: 0 dias";
                lblQuizzesCompletos.Text = "Questões Respondidas: 0";
            }
            
            if (JaResgatouRecompensa("nivel_3"))
    		{
        		lblNome.ForeColor = Color.Gold;
        		lblNome.Font = new Font(lblNome.Font, FontStyle.Bold);
        		lblEmail.ForeColor = Color.Goldenrod;
        // Ou aplicar a toda a tela: this.BackColor = Color.FromArgb(255, 248, 220);
    		}
        }
        
        bool JaResgatouRecompensa(string tipo)
		{
    		string arquivo = "recompensas_adquiridas.txt";
    		if (!File.Exists(arquivo)) return false;
    
    		foreach (string linha in File.ReadAllLines(arquivo))
    		{
        		string[] dados = linha.Split(';');
        		if (dados.Length >= 3 && dados[0] == nomeUsuario && dados[1] == tipo)
            		return true;
    		}
    		return false;
		}
        
        // 🔥 ADICIONE ESTA FUNÇÃO (IGUAL À MAINFORM)
        int CalcularNivel(int xp)
        {
            if (xp < 100) return 1;
            else if (xp < 200) return 2;
            else if (xp < 300) return 3;
            else if (xp < 400) return 4;
            else if (xp < 500) return 5;
            else if (xp < 600) return 6;
            else if (xp < 700) return 7;
            else if (xp < 800) return 8;
            else if (xp < 900) return 9;
            else return 10;
        }
        
        void BtnResetarClick(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Tem certeza que deseja resetar todo seu progresso?\n" +
                "XP, moedas, quizzes e streak serão perdidos!",
                "Confirmar Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            
            if (confirm == DialogResult.Yes)
            {
                ResetarEstatisticasUsuario();
                MessageBox.Show("Progresso resetado com sucesso!");
                
                // Recarrega os dados
                CarregarEstatisticasPerfil();
            }
        }
        
        void ResetarEstatisticasUsuario()
        {
            string hoje = DateTime.Today.ToString("dd/MM/yyyy");
            
            // 1. Resetar estatisticas.txt
            string arquivoEstatisticas = "estatisticas.txt";
            if (File.Exists(arquivoEstatisticas))
            {
                List<string> linhas = new List<string>();
                foreach (string linha in File.ReadAllLines(arquivoEstatisticas))
                {
                    string[] dados = linha.Split(';');
                    // 🔥 CORREÇÃO: Formato completo com 7 campos
                    if (dados.Length >= 7 && dados[0] == nomeUsuario)
                    {
                        // 🔥 CORREÇÃO: Reseta TODOS os campos corretamente
                        // Formato: usuario;XP;MOEDAS;QUIZZES;NIVEL;STREAK;DATA
                        string novaLinha = nomeUsuario + ";0;0;0;1;0;" + hoje;
						linhas.Add(novaLinha);
                    }
                    else
                    {
                        linhas.Add(linha);
                    }
                }
                File.WriteAllLines(arquivoEstatisticas, linhas);
            }
            
            // 2. Limpar quizzes_respondidos.txt (remover só deste usuário)
            string arquivoQuizzes = "quizzes_respondidos.txt";
            if (File.Exists(arquivoQuizzes))
            {
                List<string> linhas = new List<string>();
                foreach (string linha in File.ReadAllLines(arquivoQuizzes))
                {
                    string[] dados = linha.Split(';');
                    if (dados.Length >= 5 && dados[0] != nomeUsuario) // Mantém só outros usuários
                    {
                        linhas.Add(linha);
                    }
                }
                File.WriteAllLines(arquivoQuizzes, linhas);
            }
            
            // 3. Limpar questoes_respondidas.txt (se existir)
            string arquivoQuestoes = "questoes_respondidas.txt";
            if (File.Exists(arquivoQuestoes))
            {
                List<string> linhas = new List<string>();
                foreach (string linha in File.ReadAllLines(arquivoQuestoes))
                {
                    string[] dados = linha.Split(';');
                    if (dados.Length >= 4 && dados[0] != nomeUsuario) // Mantém só outros usuários
                    {
                        linhas.Add(linha);
                    }
                }
                File.WriteAllLines(arquivoQuestoes, linhas);
            }
        }
    }
}