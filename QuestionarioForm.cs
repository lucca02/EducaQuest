/*
 * Created by SharpDevelop.
 * User: Amanda
 * Date: 06/12/2025
 * Time: 12:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace EducaQuest
{
    /// <summary>
    /// Description of QuizForm.
    /// </summary>
    public partial class QuestionarioForm : Form
    {
        string nomeUsuario;
        string materiaAtual;
        string dificuldadeAtual;
        
        List<string[]> perguntas = new List<string[]>();
        int perguntaAtual = 0;
        int acertos = 0;
        
        public QuestionarioForm(string materia, string dificuldade, string usuario)
        {
            InitializeComponent();
            
            nomeUsuario = usuario;
            materiaAtual = materia;
            dificuldadeAtual = dificuldade;
            
            lblMateria.Text = materia;
            
            if (JaRespondeuEsteQuiz())
            {
                lblPergunta.Text = "Você já respondeu este quiz! Tente outro.";
                
                radioA.Enabled = false;
                radioB.Enabled = false;
                radioC.Enabled = false;
                radioD.Enabled = false;
                radioE.Enabled = false;
                btnConfirmar.Enabled = false;
                btnConfirmar.Text = "JÁ RESPONDIDO";
                
                return;
            }
            
            CarregarPerguntas();
            MostrarPergunta();
        }
        
        void CarregarPerguntas()
        {
            string arquivo = Path.Combine(Application.StartupPath, "perguntas.txt");
            
            if (File.Exists(arquivo))
            {
                perguntas.Clear();
                
                foreach (string linha in File.ReadAllLines(arquivo))
                {
                    string[] dados = linha.Split(';');
                    if (dados.Length >= 9)
                    {
                        if (dados[0].Trim().ToLower() == materiaAtual.ToLower() && 
                            dados[1].Trim().ToLower() == dificuldadeAtual.ToLower())
                        {
                            perguntas.Add(dados);
                        }
                    }
                }
                
                if (perguntas.Count > 0)
                {
                    MessageBox.Show("Carregadas " + perguntas.Count + " perguntas de " + 
                                  materiaAtual + " - " + dificuldadeAtual);
                }
                else
                {
                    MessageBox.Show("Nenhuma pergunta encontrada para " + 
                                  materiaAtual + " - " + dificuldadeAtual);
                }
            }
            else
            {
                MessageBox.Show("Arquivo de perguntas não encontrado!\n" +
                              "Contate o administrador do sistema.");
            }
            MessageBox.Show("Procurando perguntas em: " + arquivo);
        }
        
        void MostrarPergunta()
        {
            if (perguntaAtual < perguntas.Count && perguntas.Count > 0)
            {
                string[] pergunta = perguntas[perguntaAtual];
                lblPergunta.Text = pergunta[2]; 
                radioA.Text = pergunta[3]; 
                radioB.Text = pergunta[4]; 
                radioC.Text = pergunta[5]; 
                radioD.Text = pergunta[6]; 
                radioE.Text = pergunta[7]; 
                
                lblProgresso.Text = "Questão: " + (perguntaAtual + 1) + "/" + perguntas.Count;
                
                radioA.Enabled = true;
                radioB.Enabled = true;
                radioC.Enabled = true;
                radioD.Enabled = true;
                radioE.Enabled = true;
                btnConfirmar.Enabled = true;
                btnConfirmar.Text = "CONFIRMAR";
                
                radioA.Checked = false;
                radioB.Checked = false;
                radioC.Checked = false;
                radioD.Checked = false;
                radioE.Checked = false;
            }
        }
        
        bool ConfirmarSaida()
        {
            DialogResult resultado = MessageBox.Show(
                "Tem certeza que deseja sair?\nSeu progresso será perdido.",
                "Confirmar Saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            
            return (resultado == DialogResult.Yes);
        }
        
        void BtnSairClick(object sender, EventArgs e)
        {
            if (ConfirmarSaida())
            {
                ModoEstudoForm modoEstudo = new ModoEstudoForm(nomeUsuario);
                modoEstudo.Show();
                this.Hide();
            }
        }
        
        void PicVoltarClick(object sender, EventArgs e)
        {
            if (ConfirmarSaida())
            {
                ModoEstudoForm modoEstudo = new ModoEstudoForm(nomeUsuario);
                modoEstudo.Show();
                this.Hide();
            }
        }
        
        void BtnConfirmarClick(object sender, EventArgs e)
        {
            if (perguntas == null || perguntas.Count == 0)
            {
                MessageBox.Show("Erro: Nenhuma pergunta carregada!");
                return;
            }
            
            if (!radioA.Checked && !radioB.Checked && !radioC.Checked && 
                !radioD.Checked && !radioE.Checked)
            {
                MessageBox.Show("Selecione uma alternativa antes de confirmar!");
                return;
            }
            
            DialogResult confirmacao = MessageBox.Show(
                "Tem certeza desta alternativa?\nNão poderá alterar após confirmar.",
                "Confirmar Resposta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            
            if (confirmacao != DialogResult.Yes)
            {
                return;
            }
            
            string respostaSelecionada = "";
            
            if (radioA.Checked) respostaSelecionada = "A";
            else if (radioB.Checked) respostaSelecionada = "B";
            else if (radioC.Checked) respostaSelecionada = "C";
            else if (radioD.Checked) respostaSelecionada = "D";
            else if (radioE.Checked) respostaSelecionada = "E";
            
            string respostaCorreta = perguntas[perguntaAtual][8];
            
            if (respostaSelecionada == respostaCorreta)
            {
                acertos++;
                MessageBox.Show("✅ Resposta CORRETA!\nParabéns!");
                int pontosGanhos = CalcularPontuacao();
                SalvarEstatisticas();
            }
            else
            {
                MessageBox.Show("❌ Resposta INCORRETA!\nA resposta correta era: " + respostaCorreta);
                SalvarEstatisticas();
            }
            
            perguntaAtual++;
            
            if (perguntaAtual < perguntas.Count)
            {
                MostrarPergunta();
            }
            else
            {
                int pontosTotais = CalcularPontuacao();
                SalvarQuizRespondido(pontosTotais);
                
                radioA.Enabled = false;
                radioB.Enabled = false;
                radioC.Enabled = false;
                radioD.Enabled = false;
                radioE.Enabled = false;
                btnConfirmar.Enabled = false;
                btnConfirmar.Text = "QUIZ CONCLUÍDO";
                
                MessageBox.Show("🎉 Quiz Concluído!\n\n" +
                      "Acertos: " + acertos + "/" + perguntas.Count + "\n" +
                      "Pontuação: " + pontosTotais);
                
                ModoEstudoForm modoEstudo = new ModoEstudoForm(nomeUsuario);
                modoEstudo.Show();
                this.Hide();
            }
        }
        
        int CalcularPontuacao()
        {
            int pontosPorAcerto = 0;
            
            switch (dificuldadeAtual.ToLower())
            {
                case "facil": pontosPorAcerto = 10; break;
                case "medio": pontosPorAcerto = 20; break;
                case "dificil": pontosPorAcerto = 30; break;
                case "extra_hard": pontosPorAcerto = 50; break;
                default: pontosPorAcerto = 10; break;
            }
            
            return acertos * pontosPorAcerto;
        }
        
        void SalvarEstatisticas()
        {
            string arquivo = "estatisticas.txt";
            int pontuacaoQuiz = CalcularPontuacao();
            DateTime hoje = DateTime.Today;
            
            List<string> linhas = new List<string>();
            bool usuarioEncontrado = false;
            
            // Variáveis que serão usadas em todo o método
            int novoXP = 0;
            int novasMoedas = 0;
            int novosQuizzes = 0;
            int novoNivel = 1;
            int novoStreak = 1;
            
            if (File.Exists(arquivo))
            {
                foreach (string linha in File.ReadAllLines(arquivo))
                {
                    string[] dados = linha.Split(';');
                    if (dados.Length >= 7 && dados[0] == nomeUsuario)
                    {
                        int xpAtual = int.Parse(dados[1]);
                        int moedasAtuais = int.Parse(dados[2]);
                        int quizzesAtuais = int.Parse(dados[3]);
                        int nivelAtual = int.Parse(dados[4]);
                        int streakAtual = int.Parse(dados[5]);
                        DateTime dataUltimoQuiz = DateTime.Parse(dados[6]);
                        
                        // Calcula novos valores
                        novoXP = xpAtual + pontuacaoQuiz;
                        novasMoedas = moedasAtuais + (pontuacaoQuiz / 2);
                        novosQuizzes = quizzesAtuais + 1;
                        
                        // Lógica do streak
                        if (dataUltimoQuiz.Date == hoje.Date)
                        {
                            novoStreak = streakAtual;
                        }
                        else if (dataUltimoQuiz.Date == hoje.Date.AddDays(-1))
                        {
                            novoStreak = streakAtual + 1;
                        }
                        else
                        {
                            novoStreak = 1;
                        }
                        
                        if (novoStreak < 1) novoStreak = 1;
                        
                        // Calcula novo nível baseado no XP
                        novoNivel = CalcularNivel(novoXP);
                        
                        // Atualiza a linha do usuário
                        linhas.Add(nomeUsuario + ";" + novoXP + ";" + novasMoedas + ";" + 
                                   novosQuizzes + ";" + novoNivel + ";" + novoStreak + ";" + 
                                   hoje.ToString("dd/MM/yyyy"));
                        usuarioEncontrado = true;
                    }
                    else
                    {
                        linhas.Add(linha); // Mantém outros usuários
                    }
                }
            }
            
            if (!usuarioEncontrado)
            {
                // Novo usuário - primeira vez fazendo quiz
                novoXP = pontuacaoQuiz;
                novasMoedas = pontuacaoQuiz / 2;
                novosQuizzes = 1;
                novoNivel = CalcularNivel(novoXP);
                novoStreak = 1;
                
                linhas.Add(nomeUsuario + ";" + novoXP + ";" + novasMoedas + ";" + 
                           novosQuizzes + ";" + novoNivel + ";" + novoStreak + ";" + 
                           hoje.ToString("dd/MM/yyyy"));
            }
            
            File.WriteAllLines(arquivo, linhas);
        }
        
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
        
        bool JaRespondeuEsteQuiz()
        {
            string arquivo = "quizzes_respondidos.txt";
            
            if (File.Exists(arquivo))
            {
                foreach (string linha in File.ReadAllLines(arquivo))
                {
                    string[] dados = linha.Split(';');
                    if (dados.Length >= 5 && dados[0] == nomeUsuario && 
                        dados[1] == materiaAtual && dados[2] == dificuldadeAtual)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
        void SalvarQuizRespondido(int pontos)
        {
            string arquivo = "quizzes_respondidos.txt";
            string hoje = DateTime.Today.ToString("dd/MM/yyyy");
            
            using (StreamWriter sw = File.AppendText(arquivo))
            {
                sw.WriteLine(nomeUsuario + ";" + materiaAtual + ";" + dificuldadeAtual + ";" + 
                            hoje + ";" + pontos);
            }
        }
    }
}