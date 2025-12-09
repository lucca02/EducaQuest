/*
 * Created by SharpDevelop.
 * User: Amanda
 * Date: 24/11/2025
 * Time: 19:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace EducaQuest
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        string nomeUsuario;
        
        public MainForm(string usuario)
        {
            InitializeComponent();
            nomeUsuario = usuario;
            lblBemVindo.Text = "Bem-vindo, " + nomeUsuario;
            CarregarEstatisticas();
        }
        
        void LinkSobreLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string caminhoSobre = Path.Combine(Application.StartupPath, "sobre.html");
    
    		if (File.Exists(caminhoSobre))
    		{
        		Process.Start(caminhoSobre);
    		}
    		else
    		{
        		MessageBox.Show("Arquivo 'sobre.html' não encontrado!\nColoque o arquivo na pasta do programa.");
    		}
        }
        
        void LinkAjudaLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string caminhoAjuda = Path.Combine(Application.StartupPath, "ajuda.html");
    
    		if (File.Exists(caminhoAjuda))
    		{
        		Process.Start(caminhoAjuda);
    		}
    		else
    		{
        		MessageBox.Show("Arquivo 'ajuda.html' não encontrado!");
    		}
        }
        
        void LinkContatoLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string caminhoContato = Path.Combine(Application.StartupPath, "contato.html");
    
    		if (File.Exists(caminhoContato))
    		{
        		Process.Start(caminhoContato);
    		}
    		else
    		{
        		MessageBox.Show("Arquivo 'contato.html' não encontrado!");
    		}
        }
        
        void PicPerfilClick(object sender, System.EventArgs e)
        {
            PerfilForm perfil = new PerfilForm(nomeUsuario);
            perfil.Show();
            this.Hide();
        }
        
        void BtnModoEstudoClick(object sender, EventArgs e)
        {
            ModoEstudoForm modoEstudo = new ModoEstudoForm(nomeUsuario);
            modoEstudo.Show();
            this.Hide();
        }
        
        void CarregarEstatisticas()
		{
    		string arquivo = "estatisticas.txt";
    
    		if (File.Exists(arquivo))
    		{
        		foreach (string linha in File.ReadAllLines(arquivo))
        		{
            		string[] dados = linha.Split(';');
            		if (dados.Length >= 7 && dados[0] == nomeUsuario) // ← Mudou para 7 campos
            		{
                // CORREÇÃO DOS ÍNDICES:
                		int xp = int.Parse(dados[1]);          // XP
                		int moedas = int.Parse(dados[2]);      // MOEDAS
                		int quizzes = int.Parse(dados[3]);     // QUIZZES (total respondidos)
                		int nivel = int.Parse(dados[4]);       // NÍVEL (já calculado)
                		int streak = int.Parse(dados[5]);      // STREAK
                
                // USANDO A FUNÇÃO CORRETA PARA CALCULAR NÍVEL (opcional - pode usar o já salvo)
                		int nivelCorreto = CalcularNivel(xp);
                
                // ATUALIZA LABELS CORRETAMENTE:
                		lblPontos.Text = "XP: " + xp;  // Mostra XP, não "pontos"
                		lblQuizzesRespondidos.Text = "Questões respondidas: " + quizzes;  // Corrigido
                		lblPontosProximaRec.Text = "Faltam: " + CalcularXPProximoNivel(xp, nivelCorreto) + " XP";
                		lblMoedas.Text = "Moedas: " + moedas;
                
                		AtualizarProgressBar(xp, nivelCorreto);  // Usa nível calculado
                
                		lblStreak.Text = streak.ToString();
                		lblNivelAtual.Text = nivelCorreto.ToString();
                		lblProximoNivel.Text = (nivelCorreto + 1).ToString();
                
                		break;
            		}
        		}
    		}
    		else
    		{
        // Valores padrão para novo usuário
        		lblPontos.Text = "XP: 0";
        		lblQuizzesRespondidos.Text = "Questões respondidas: 0";
        		lblPontosProximaRec.Text = "Próximo nível em: 100 XP";
        		lblNivelAtual.Text = "1";
        		lblProximoNivel.Text = "2";
        		lblStreak.Text = "0";
    		}
    		
    		if (JaResgatouRecompensa("nivel_10"))
    		{
        		lblBemVindo.Text = "Bem-vindo, " + nomeUsuario + " ⭐LENDÁRIO⭐";
        		lblBemVindo.ForeColor = Color.Blue;
        		lblBemVindo.Font = new Font(lblBemVindo.Font, FontStyle.Bold);
    		}
		}
        
        // ADICIONE ESTA FUNÇÃO (igual ao QuestionarioForm)
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

// CORRIJA OU CRIE ESTA FUNÇÃO:
		int CalcularXPProximoNivel(int xpAtuais, int nivelAtual)
		{
    // XP necessário para o próximo nível
    		int xpProximoNivel = nivelAtual * 100; // Se nível 3, precisa de 300 XP
    
    // XP que faltam
    		int xpFaltantes = xpProximoNivel - xpAtuais;
    		
    // Garante valor positivo
    		if (xpFaltantes < 0) xpFaltantes = 0;
    
    		return xpFaltantes;
		}
        
        int CalcularPontosProximoNivel(int pontosAtuais)
        {
            int nivelAtual = pontosAtuais / 100 + 1;
            int pontosProximoNivel = nivelAtual * 100;
            int pontosFaltantes = pontosProximoNivel - pontosAtuais;
            
            return pontosFaltantes;
        }
        
        void AtualizarProgressBar(int pontosAtuais, int nivelAtual)
        {
            int pontosPorNivel = 100;
            
            int pontosNecessariosNivel = (nivelAtual - 1) * pontosPorNivel;
            
            int pontosDentroNivel = pontosAtuais - pontosNecessariosNivel;
            
            int progresso = 0;
            if (pontosPorNivel > 0)
            {
                progresso = (pontosDentroNivel * 100) / pontosPorNivel;
            }
            
            if (progresso > 100) progresso = 100;
            if (progresso < 0) progresso = 0;
            
            progressBarNivel.Value = progresso;
        }
        
        void BtnQuestaoDiariaClick(object sender, EventArgs e)
        {
            QuestaoDiariaForm questaoDiaria = new QuestaoDiariaForm(nomeUsuario);
            questaoDiaria.Show();
            this.Hide();
        }
        
        void BtnRecompensasClick(object sender, EventArgs e)
		{
    		RecompensasForm recompensas = new RecompensasForm(nomeUsuario);
    		recompensas.Show();
    		this.Hide();
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
    }
}