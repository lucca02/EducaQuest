/*
 * Created by SharpDevelop.
 * User: Amanda
 * Date: 07/12/2025
 * Time: 17:16
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
    /// Description of QuestaoDiariaForm.
    /// </summary>
    public partial class QuestaoDiariaForm : Form
    {
        string nomeUsuario;
        DateTime dataAtual;
        List<string[]> questoesDiarias = new List<string[]>();
        
        public QuestaoDiariaForm(string usuario)
		{
    		InitializeComponent();
    		nomeUsuario = usuario;
    
    		dataAtual = DateTime.Today; // Começa com a data de hoje
    		CarregarQuestoesDiarias();
    
    // NÃO verifica se já respondeu aqui - deixa o CarregarQuestaoData fazer isso
    		CarregarQuestaoData(dataAtual);
		}
        
        // VERIFICA SE USUÁRIO JÁ RESPONDEU UMA DATA
        bool JaRespondeuData(DateTime data)
		{
    		string exePath = Application.ExecutablePath;
    		string pastaDebug = Path.GetDirectoryName(exePath);
    		string arquivo = Path.Combine(pastaDebug, "questoes_respondidas.txt");
    
    		string dataFormatada = data.ToString("dd/MM/yyyy");
    
    		if (File.Exists(arquivo))
    		{
        		foreach (string linha in File.ReadAllLines(arquivo))
        		{
            		string[] dados = linha.Split(';');
            		if (dados.Length >= 4 && dados[0] == nomeUsuario && dados[1] == dataFormatada)
            		{
                		return true;
            		}
        		}
    		}
    		return false;
		}

		void SalvarQuestaoRespondida(int pontos, bool acertou)
		{
    		string exePath = Application.ExecutablePath;
    		string pastaDebug = Path.GetDirectoryName(exePath);
    		string arquivo = Path.Combine(pastaDebug, "questoes_respondidas.txt");
    
    		string dataFormatada = dataAtual.ToString("dd/MM/yyyy");
    
    		using (StreamWriter sw = File.AppendText(arquivo))
    		{
        		sw.WriteLine(nomeUsuario + ";" + dataFormatada + ";" + acertou + ";" + pontos);
    		}
		}
        
        void CarregarQuestoesDiarias()
		{
    // Caminho CORRETO para bin\Debug\
    		string exePath = Application.ExecutablePath;
    		string pastaDebug = Path.GetDirectoryName(exePath);
    		string arquivo = Path.Combine(pastaDebug, "questoes_diarias.txt");
    
    // DEBUG - mostra onde está procurando
    		MessageBox.Show("Procurando arquivo em:\n" + arquivo);
    
    		if (File.Exists(arquivo))
    		{
        		questoesDiarias.Clear(); // Limpa antes de carregar
        
        		foreach (string linha in File.ReadAllLines(arquivo))
        		{
            		string linhaLimpa = linha.Trim();
            		if (string.IsNullOrEmpty(linhaLimpa))
                		continue;
            
            		string[] dados = linhaLimpa.Split(';');
            		if (dados.Length >= 10) // 10 campos: data;materia;pergunta;A;B;C;D;E;resposta;pontos
            		{
                // Remove espaços da data
                		dados[0] = dados[0].Trim();
                		questoesDiarias.Add(dados);
                
                // DEBUG - mostra o que carregou
                		Console.WriteLine("Carregado: " + dados[0] + " - " + dados[1]);
            		}
        		}
        
        		MessageBox.Show("Carregadas " + questoesDiarias.Count + " questões diárias!");
    		}
    		else
    		{
        		MessageBox.Show("Arquivo NÃO encontrado em:\n" + arquivo + 
                       "\n\nColoque o arquivo 'questoes_diarias.txt' na pasta:\n" + pastaDebug);
    		}
		}

        void CarregarQuestaoData(DateTime data)
		{
    		dataAtual = data;
    		string dataFormatada = data.ToString("dd/MM/yyyy");
    
    		bool questaoEncontrada = false;
    		bool jaRespondeu = JaRespondeuData(data);
    
    		foreach (string[] questao in questoesDiarias)
    		{
        		if (questao[0] == dataFormatada)
        		{
            		questaoEncontrada = true;
            
            // SEMPRE mostra a questão (igual QuestionarioForm)
            		lblMateria.Text = questao[1];
            		lblPergunta.Text = questao[2];
            		radioA.Text = questao[3];
            		radioB.Text = questao[4];
            		radioC.Text = questao[5];
            		radioD.Text = questao[6];
            		radioE.Text = questao[7];
            		lblPontosQuestao.Text = questao[9] + " pontos";
            
            		lblData.Text = data.ToString("dd MMM yyyy");
            
            // Verifica se já respondeu
            		if (jaRespondeu)
            		{
                // MANTÉM a questão, mas BLOQUEIA (igual QuestionarioForm)
                		lblPergunta.Text = questao[2] + "\n\n✅ (Questão já respondida)";
                		radioA.Enabled = false;
                		radioB.Enabled = false;
                		radioC.Enabled = false;
                		radioD.Enabled = false;
                		radioE.Enabled = false;
                		btnConfirmar.Enabled = false;
                		btnConfirmar.Text = "JÁ RESPONDIDA";
            		}
            		else if (data > DateTime.Today)
            		{
                // Questão futura
                		lblPergunta.Text = questao[2] + "\n\n(Questão futura - disponível em " + data.ToString("dd/MM/yyyy") + ")";
                		radioA.Enabled = false;
                		radioB.Enabled = false;
                		radioC.Enabled = false;
                		radioD.Enabled = false;
                		radioE.Enabled = false;
                		btnConfirmar.Enabled = false;
                		btnConfirmar.Text = "INDISPONÍVEL";
            		}
            		else
            		{
                // Questão disponível para responder
                		radioA.Enabled = true;
                		radioB.Enabled = true;
                		radioC.Enabled = true;
                		radioD.Enabled = true;
                		radioE.Enabled = true;
                		btnConfirmar.Enabled = true;
                		btnConfirmar.Text = "CONFIRMAR";
                
                // Desmarca qualquer seleção anterior
                		radioA.Checked = false;
                		radioB.Checked = false;
                		radioC.Checked = false;
                		radioD.Checked = false;
                		radioE.Checked = false;
            		}
            
            		return;
        		}
    		}
    
    		if (!questaoEncontrada)
    		{
        		MessageBox.Show("Nenhuma questão disponível para " + dataFormatada);
        
        // Se não é hoje, volta para hoje
        			if (data != DateTime.Today)
        		{
            		dataAtual = DateTime.Today;
            		CarregarQuestaoData(dataAtual);
        		}
        		else
        		{
            // Se é hoje e não tem questão, mostra mensagem e bloqueia
            		lblPergunta.Text = "Nenhuma questão disponível para hoje.";
            		radioA.Enabled = false;
            		radioB.Enabled = false;
            		radioC.Enabled = false;
            		radioD.Enabled = false;
            		radioE.Enabled = false;
            		btnConfirmar.Enabled = false;
            		btnConfirmar.Text = "INDISPONÍVEL";
        		}
    		}
		}
        
        void PicVoltarClick(object sender, EventArgs e)
        {
            MainForm main = new MainForm(nomeUsuario);
            main.Show();
            this.Hide();
        }
        
        void PicPerfilClick(object sender, EventArgs e)
        {
            PerfilForm perfil = new PerfilForm(nomeUsuario);
            perfil.Show();
            this.Hide();
        }
        
        void BtnSairClick(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Tem certeza que deseja sair?\nSeu progresso será perdido.",
                "Confirmar Saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            
            if (resultado == DialogResult.Yes)
            {
                MainForm main = new MainForm(nomeUsuario);
                main.Show();
                this.Hide();
            }
        }
        
        void BtnAnteriorClick(object sender, EventArgs e)
		{
    // Verifica se há questões carregadas
    		if (questoesDiarias.Count == 0)
    		{
        		MessageBox.Show("Não há questões diárias carregadas.");
        		return;
    		}
    
    		DateTime dataAnterior = dataAtual.AddDays(-1);
    
    // Limite mínimo (opcional - evita datas muito antigas)
    		if (dataAnterior.Year < 2000)
    		{
        		MessageBox.Show("Não há questões anteriores disponíveis.");
        		return;
    		}
    
    		string dataFormatada = dataAnterior.ToString("dd/MM/yyyy");
    		bool encontrou = false;
    
    		foreach (string[] questao in questoesDiarias)
    		{
        		if (questao[0] == dataFormatada)
        		{
            		dataAtual = dataAnterior;
            		CarregarQuestaoData(dataAtual);
            		encontrou = true;
            		break;
        		}
    		}
    
    		if (!encontrou)
    		{
        		MessageBox.Show("Não há questões anteriores disponíveis.");
    		}
		}
        
        void BtnProximoClick(object sender, EventArgs e)
		{
    // Verifica se há questões carregadas
    		if (questoesDiarias.Count == 0)
    		{
        		MessageBox.Show("Não há questões diárias carregadas.");
        		return;
    		}
    
    		DateTime dataProxima = dataAtual.AddDays(1);
    
    		if (dataProxima > DateTime.Today)
    		{
        		MessageBox.Show("Questões futuras não estão disponíveis ainda!");
        		return;
    		}
    
    		string dataFormatada = dataProxima.ToString("dd/MM/yyyy");
   			bool encontrou = false;
    
    		foreach (string[] questao in questoesDiarias)
    		{
        		if (questao[0] == dataFormatada)
        		{
            		dataAtual = dataProxima;
            		CarregarQuestaoData(dataAtual);
            		encontrou = true;
            		break;
        		}
    		}
    
    		if (!encontrou)
    		{
        		MessageBox.Show("Não há próximas questões disponíveis.");
    		}
		}
        
        void BtnConfirmarClick(object sender, EventArgs e)
		{
    // VERIFICAR SE JÁ RESPONDEU (proteção extra)
    		if (JaRespondeuData(dataAtual))
    		{
        		MessageBox.Show("Esta questão já foi respondida!");
        
        // Atualiza a tela para mostrar questão BLOQUEADA
        		CarregarQuestaoData(dataAtual);
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
    
    		string dataFormatada = dataAtual.ToString("dd/MM/yyyy");
    		string[] questaoAtual = null;
    
    		foreach (string[] questao in questoesDiarias)
    		{
        		if (questao[0] == dataFormatada)
        		{
            		questaoAtual = questao;
            		break;
        		}
    		}
    
    		if (questaoAtual == null)
    		{
        		MessageBox.Show("Erro: Questão não encontrada!");
        		return;
    		}
    
    		string respostaSelecionada = "";
    
    		if (radioA.Checked) respostaSelecionada = "A";
    		else if (radioB.Checked) respostaSelecionada = "B";
    		else if (radioC.Checked) respostaSelecionada = "C";
    		else if (radioD.Checked) respostaSelecionada = "D";
    		else if (radioE.Checked) respostaSelecionada = "E";
    
    		string respostaCorreta = questaoAtual[8];
    		int pontosQuestao = int.Parse(questaoAtual[9]);
    
    		if (respostaSelecionada == respostaCorreta)
    		{
        		MessageBox.Show("✅ Resposta CORRETA!\nVocê ganhou " + pontosQuestao + " pontos!");
        
        // SALVAR QUE RESPONDEU (ANTI-FARMING)
        		SalvarQuestaoRespondida(pontosQuestao, true);
        		SalvarEstatisticasDiarias(pontosQuestao, true);
    		}
    		else
    		{
        		MessageBox.Show("❌ Resposta INCORRETA!\nA resposta correta era: " + respostaCorreta);
        
        // SALVAR QUE RESPONDEU (mesmo errando)
        		SalvarQuestaoRespondida(0, false);
        		SalvarEstatisticasDiarias(0, false);
    		}
    
    // === MUDANÇAS AQUI ===
    // BLOQUEAR TUDO APÓS RESPONDER (igual QuestionarioForm)
    		radioA.Enabled = false;
    		radioB.Enabled = false;
    		radioC.Enabled = false;
    		radioD.Enabled = false;
    		radioE.Enabled = false;
    		btnConfirmar.Enabled = false;
    		btnConfirmar.Text = "RESPONDIDA";
    
    // MANTÉM a questão na tela, mas adiciona indicação de respondida
    		lblPergunta.Text = questaoAtual[2] + "\n\n✅ (Questão já respondida)";
    // ======================
    
    // OPCIONAL: Atualizar streak na tela se quiser mostrar feedback imediato
    // (isso depende de como sua interface mostra o streak)
		}
        
        void SalvarEstatisticasDiarias(int pontos, bool acertou)
        {
        	DateTime hoje = DateTime.Today;
            string exePath = Application.ExecutablePath;
    		string pastaDebug = Path.GetDirectoryName(exePath);
    		string arquivo = Path.Combine(pastaDebug, "estatisticas.txt");
            
            List<string> linhas = new List<string>();
            bool usuarioEncontrado = false;
            
            if (File.Exists(arquivo))
            {
                foreach (string linha in File.ReadAllLines(arquivo))
                {
                    string[] dados = linha.Split(';');
                    if (dados.Length >= 7 && dados[0] == nomeUsuario) // AGORA 7 CAMPOS
                    {
                        // NOVO: XP e Moedas separados
                        int xpAtual = int.Parse(dados[1]);
                        int moedasAtuais = int.Parse(dados[2]);
                        int quizzesAtuais = int.Parse(dados[3]);
                        int streakAtual = int.Parse(dados[5]);
                        DateTime dataUltimoQuiz = DateTime.Parse(dados[6]);
                        
                        // LÓGICA DO STREAK
                        int novoStreak = 1;
                        
                        if (dataUltimoQuiz.Date == hoje.Date)
                        {
                            novoStreak = streakAtual;
                        }
                        else if (dataUltimoQuiz.Date == hoje.Date.AddDays(-1))
                        {
                            novoStreak = streakAtual + 1;
                        }
                        
                        if (novoStreak < 1) novoStreak = 1;
                        
                        // XP sempre aumenta
                        int novoXP = xpAtual + pontos;
                        
                        // Moedas = metade dos pontos (arredondado para baixo)
                        int novasMoedas = moedasAtuais + (pontos / 2);
                        
                        int novosQuizzes = quizzesAtuais + 1;
                        int novoNivel = CalcularNivel(novoXP);
                        
                        // NOVO FORMATO: usuario;xp;moedas;quizzes;nivel;streak;data
                        linhas.Add(nomeUsuario + ";" + novoXP + ";" + novasMoedas + ";" + 
                                  novosQuizzes + ";" + novoNivel + ";" + novoStreak + ";" + hoje.ToString("dd/MM/yyyy"));
                        usuarioEncontrado = true;
                    }
                    else
                    {	
                        linhas.Add(linha);
                    }
                }
            }
            
            if (!usuarioEncontrado)
            {
                // Novo usuário: XP = pontos, Moedas = pontos/2
                int moedasIniciais = pontos / 2;
                if (moedasIniciais < 0) moedasIniciais = 0;
                
                linhas.Add(nomeUsuario + ";" + pontos + ";" + moedasIniciais + ";1;1;1;" + hoje.ToString("dd/MM/yyyy"));
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
    }
}