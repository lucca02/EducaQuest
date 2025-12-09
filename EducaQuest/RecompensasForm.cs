using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace EducaQuest
{
    public partial class RecompensasForm : Form
    {
        string nomeUsuario;
        int moedasUsuario;
        int nivelUsuario;
        
        public RecompensasForm(string usuario)
        {
            InitializeComponent();
            nomeUsuario = usuario;
            CarregarDadosUsuario();
            VerificarComprasFeitas();
            AtualizarBotoesComprar();
        }
        
        // =========== NAVEGAÇÃO ===========
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
        
        // =========== CARREGAR DADOS ===========
        void CarregarDadosUsuario()
        {
            string arquivo = "estatisticas.txt";
            
            if (File.Exists(arquivo))
            {
                foreach (string linha in File.ReadAllLines(arquivo))
                {
                    string[] dados = linha.Split(';');
                    if (dados.Length >= 7 && dados[0] == nomeUsuario)
                    {
                        moedasUsuario = int.Parse(dados[2]);  // Índice 2 = moedas
                        nivelUsuario = int.Parse(dados[4]);   // Índice 4 = nível
                        
                        lblSuasMoedas.Text = "Suas Moedas: " + moedasUsuario;
                        AtualizarRecompensasNivel();
                        
                        break;
                    }
                }
            }
        }
        
        // =========== RECOMPENSAS POR NÍVEL ===========
        void AtualizarRecompensasNivel()
        {
            // Nível 3 - Cor Dourada
            if (nivelUsuario >= 3)
            {
                panelNivel3.BackColor = Color.Blue;
                btnResgatarNivel3.Enabled = true;
                // lblStatusNivel3.Text = "Disponível!";
            }
            else
            {
                panelNivel3.BackColor = Color.Gray;
                btnResgatarNivel3.Enabled = false;
                // lblStatusNivel3.Text = "Nível 3 necessário";
            }
            
            // Nível 5 - Questões Extra Hard
            if (nivelUsuario >= 5)
            {
                panelNivel5.BackColor = Color.Blue;
                btnResgatarNivel5.Enabled = true;
                // lblStatusNivel5.Text = "Disponível!";
            }
            else
            {
                panelNivel5.BackColor = Color.Gray;
                btnResgatarNivel5.Enabled = false;
                // lblStatusNivel5.Text = "Nível 5 necessário";
            }
            
            // Nível 10 - Título Lendário
            if (nivelUsuario >= 10)
            {
                panelNivel10.BackColor = Color.Blue;
                btnResgatarNivel10.Enabled = true;
                // lblStatusNivel10.Text = "Disponível!";
            }
            else
            {
                panelNivel10.BackColor = Color.Gray;
                btnResgatarNivel10.Enabled = false;
                // lblStatusNivel10.Text = "Nível 10 necessário";
            }
        }
        
        // =========== RECOMPENSAS POR MOEDAS ===========
        void AtualizarBotoesComprar()
        {
            // Kit PDF - 50 moedas
            if (moedasUsuario >= 50)
            {
                btnComprarKitPDF.Enabled = true;
                btnComprarKitPDF.BackColor = Color.Blue;
                btnComprarKitPDF.Text = "Comprar (50 moedas)";
            }
            else
            {
                btnComprarKitPDF.Enabled = false;
                btnComprarKitPDF.BackColor = Color.Gray;
                btnComprarKitPDF.Text = "Moedas insuficientes";
            }
            
            // Vídeo Aula - 100 moedas
            if (moedasUsuario >= 100)
            {
                btnComprarVideo.Enabled = true;
                btnComprarVideo.BackColor = Color.Blue;
                btnComprarVideo.Text = "Comprar (100 moedas)";
            }
            else
            {
                btnComprarVideo.Enabled = false;
                btnComprarVideo.BackColor = Color.Gray;
                btnComprarVideo.Text = "Moedas insuficientes";
            }
            
            // Certificado - 200 moedas
            if (moedasUsuario >= 200)
            {
                btnComprarCertificado.Enabled = true;
                btnComprarCertificado.BackColor = Color.Blue;
                btnComprarCertificado.Text = "Comprar (200 moedas)";
            }
            else
            {
                btnComprarCertificado.Enabled = false;
                btnComprarCertificado.BackColor = Color.Gray;
                btnComprarCertificado.Text = "Moedas insuficientes";
            }
        }
        
        // =========== VERIFICAR COMPRAS JÁ FEITAS ===========
        void VerificarComprasFeitas()
        {
            string arquivo = "recompensas_adquiridas.txt";
            
            if (!File.Exists(arquivo))
                return;
                
            foreach (string linha in File.ReadAllLines(arquivo))
            {
                string[] dados = linha.Split(';');
                if (dados.Length >= 3 && dados[0] == nomeUsuario)
                {
                    string tipo = dados[1];
                    
                    switch (tipo)
                    {
                        case "pdf_kit":
                            btnComprarKitPDF.Enabled = false;
                            btnComprarKitPDF.Text = "✓ Já adquirido";
                            btnComprarKitPDF.BackColor = Color.Green;
                            break;
                            
                        case "video_aula":
                            btnComprarVideo.Enabled = false;
                            btnComprarVideo.Text = "✓ Já adquirido";
                            btnComprarVideo.BackColor = Color.Green;
                            break;
                            
                        case "certificado":
                            btnComprarCertificado.Enabled = false;
                            btnComprarCertificado.Text = "✓ Já adquirido";
                            btnComprarCertificado.BackColor = Color.Green;
                            break;
                            
                        case "nivel_3":
                            btnResgatarNivel3.Enabled = false;
                            btnResgatarNivel3.Text = "✓ Resgatado";
                            btnResgatarNivel3.BackColor = Color.Green;
                            break;
                            
                        case "nivel_5":
                            btnResgatarNivel5.Enabled = false;
                            btnResgatarNivel5.Text = "✓ Resgatado";
                            btnResgatarNivel5.BackColor = Color.Green;
                            break;
                            
                        case "nivel_10":
                            btnResgatarNivel10.Enabled = false;
                            btnResgatarNivel10.Text = "✓ Resgatado";
                            btnResgatarNivel10.BackColor = Color.Green;
                            break;
                    }
                }
            }
        }
        
        // =========== REGISTRAR RECOMPENSA ===========
        void RegistrarRecompensa(string tipo)
        {
            string arquivo = "recompensas_adquiridas.txt";
            string data = DateTime.Today.ToString("dd/MM/yyyy");
            string linha = nomeUsuario + ";" + tipo + ";" + data;
            
            File.AppendAllText(arquivo, linha + Environment.NewLine);
        }
        
        // =========== ATUALIZAR MOEDAS ===========
        void AtualizarMoedas(int novaQuantidade)
        {
            moedasUsuario = novaQuantidade;
            lblSuasMoedas.Text = "Suas Moedas: " + moedasUsuario;
            
            // Atualizar arquivo estatisticas.txt
            string arquivo = "estatisticas.txt";
            List<string> linhas = new List<string>();
            
            if (File.Exists(arquivo))
            {
                foreach (string linha in File.ReadAllLines(arquivo))
                {
                    string[] dados = linha.Split(';');
                    if (dados.Length >= 7 && dados[0] == nomeUsuario)
                    {
                        // Atualiza só as moedas (índice 2)
                        string novaLinha = dados[0] + ";" + dados[1] + ";" + moedasUsuario + ";" + 
                                         dados[3] + ";" + dados[4] + ";" + dados[5] + ";" + dados[6];
                        linhas.Add(novaLinha);
                    }
                    else
                    {
                        linhas.Add(linha);
                    }
                }
                
                File.WriteAllLines(arquivo, linhas);
            }
        }
        
        // =========== BOTÕES DE COMPRA ===========
        void BtnComprarKitPDFClick(object sender, EventArgs e)
        {
            if (moedasUsuario < 50)
            {
                MessageBox.Show("Moedas insuficientes!");
                return;
            }
            
            DialogResult confirmar = MessageBox.Show(
                "Deseja comprar o Kit Estudo com PDF por 50 moedas?",
                "Confirmar Compra",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                
            if (confirmar == DialogResult.Yes)
            {
                AtualizarMoedas(moedasUsuario - 50);
                RegistrarRecompensa("pdf_kit");
                
                btnComprarKitPDF.Enabled = false;
                btnComprarKitPDF.Text = "✓ Já adquirido";
                btnComprarKitPDF.BackColor = Color.Green;
                
                MessageBox.Show("Kit adquirido com sucesso!\nO PDF será aberto em seu navegador.");
                
                // Abrir PDF (substitua pelo seu link)
                Process.Start("https://download.inep.gov.br/educacao_basica/encceja/material_estudo/livro_estudante/ciencias_naturais_em_br.pdf");
                
                AtualizarBotoesComprar();
            }
        }
        
        void BtnComprarVideoClick(object sender, EventArgs e)
        {
            if (moedasUsuario < 100)
            {
                MessageBox.Show("Moedas insuficientes!");
                return;
            }
            
            DialogResult confirmar = MessageBox.Show(
                "Deseja comprar a Vídeo Aula Bônus por 100 moedas?",
                "Confirmar Compra",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                
            if (confirmar == DialogResult.Yes)
            {
                AtualizarMoedas(moedasUsuario - 100);
                RegistrarRecompensa("video_aula");
                
                btnComprarVideo.Enabled = false;
                btnComprarVideo.Text = "✓ Já adquirido";
                btnComprarVideo.BackColor = Color.Green;
                
                MessageBox.Show("Vídeo aula adquirida com sucesso!\nO vídeo será aberto em seu navegador.");
                
                // Abrir YouTube (substitua pelo seu link)
                Process.Start("https://www.youtube.com/watch?v=7YeYeL2MjB4");
                
                AtualizarBotoesComprar();
            }
        }
        
        void BtnComprarCertificadoClick(object sender, EventArgs e)
        {
            if (moedasUsuario < 200)
            {
                MessageBox.Show("Moedas insuficientes!");
                return;
            }
            
            DialogResult confirmar = MessageBox.Show(
                "Deseja comprar o Certificado Digital por 200 moedas?",
                "Confirmar Compra",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                
            if (confirmar == DialogResult.Yes)
            {
                AtualizarMoedas(moedasUsuario - 200);
                RegistrarRecompensa("certificado");
                
                btnComprarCertificado.Enabled = false;
                btnComprarCertificado.Text = "✓ Já adquirido";
                btnComprarCertificado.BackColor = Color.Green;
                
                MessageBox.Show("Certificado adquirido com sucesso!");
                
                // Mostrar certificado (você pode criar um form separado)
                MostrarCertificado();
                
                AtualizarBotoesComprar();
            }
        }
        
        // =========== BOTÕES DE RESGATE POR NÍVEL ===========
        void BtnResgatarNivel3Click(object sender, EventArgs e)
        {
            if (nivelUsuario < 3)
            {
                MessageBox.Show("Você precisa atingir o nível 3!");
                return;
            }
            
            RegistrarRecompensa("nivel_3");
            btnResgatarNivel3.Enabled = false;
            btnResgatarNivel3.Text = "✓ Resgatado";
            btnResgatarNivel3.BackColor = Color.Green;
            
            MessageBox.Show("Cor Dourada ativada!\nSeu perfil agora tem destaque especial.");
            
            // TODO: Implementar cor dourada no perfil
        }
        
        void BtnResgatarNivel5Click(object sender, EventArgs e)
        {
            if (nivelUsuario < 5)
            {
                MessageBox.Show("Você precisa atingir o nível 5!");
                return;
            }
            
            RegistrarRecompensa("nivel_5");
            btnResgatarNivel5.Enabled = false;
            btnResgatarNivel5.Text = "✓ Resgatado";
            btnResgatarNivel5.BackColor = Color.Green;
            
            MessageBox.Show("Questões Extra Hard desbloqueadas!\nAgora você pode acessar questões mais difíceis no Modo Estudo.");
            
            // TODO: Adicionar botão "Extra Hard" no ModoEstudoForm
        }
        
        void BtnResgatarNivel10Click(object sender, EventArgs e)
        {
            if (nivelUsuario < 10)
            {
                MessageBox.Show("Você precisa atingir o nível 10!");
                return;
            }
            
            RegistrarRecompensa("nivel_10");
            btnResgatarNivel10.Enabled = false;
            btnResgatarNivel10.Text = "✓ Resgatado";
            btnResgatarNivel10.BackColor = Color.Green;
            
            MessageBox.Show("Título Lendário concedido!\nAgora você é uma lenda no EducaQuest!");
            
            // TODO: Adicionar título "Lendário" no PerfilForm
        }
        
        // =========== MOSTRAR CERTIFICADO ===========
        void MostrarCertificado()
        {
            // Form simples para mostrar certificado
            Form certificadoForm = new Form();
            certificadoForm.Text = "Certificado Digital";
            certificadoForm.Size = new Size(600, 400);
            certificadoForm.StartPosition = FormStartPosition.CenterScreen;
            
            Label lblCertificado = new Label();
            lblCertificado.Text = "CERTIFICADO DE EXCELÊNCIA\n\n" +
                                 "Concedido a: " + nomeUsuario + "\n\n" +
                                 "Por demonstrar dedicação e excelência nos estudos\n" +
                                 "no EducaQuest - Provão Paulista\n\n" +
                                 "Data: " + DateTime.Today.ToString("dd/MM/yyyy");
            lblCertificado.Font = new Font("Arial", 14, FontStyle.Bold);
            lblCertificado.TextAlign = ContentAlignment.MiddleCenter;
            lblCertificado.Dock = DockStyle.Fill;
            
            certificadoForm.Controls.Add(lblCertificado);
            certificadoForm.ShowDialog();
        }
    }
}