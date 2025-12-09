using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace EducaQuest
{
    public partial class ModoEstudoForm : Form
    {
        string nomeUsuario;
        Button btnExtraHard; // 🔥 NOVO BOTÃO
        
        public ModoEstudoForm(string usuario)
        {
            InitializeComponent();
            nomeUsuario = usuario;
            
            // 🔥 CRIAR BOTÃO EXTRA HARD (inicialmente invisível)
            CriarBotaoExtraHard();
            
            // 🔥 VERIFICAR SE DESBLOQUEOU EXTRA HARD
            CarregarEstadoUsuario();
        }
        
        // 🔥 CRIAR BOTÃO EXTRA HARD DINAMICAMENTE
        void CriarBotaoExtraHard()
        {
            btnExtraHard = new Button();
            btnExtraHard.Text = "EXTRA HARD 🚀";
            btnExtraHard.BackColor = Color.Purple;
            btnExtraHard.ForeColor = Color.White;
            btnExtraHard.Font = new Font("Arial", 12, FontStyle.Bold);
            btnExtraHard.Size = new Size(180, 50);
            
            // Posicionar abaixo dos botões de Ciências
            btnExtraHard.Location = new Point(btnCienDificil.Left, btnCienDificil.Bottom + 30);
            
            // Adicionar evento de clique
            btnExtraHard.Click += new EventHandler(BtnExtraHardClick);
            
            // Adicionar ao formulário
            this.Controls.Add(btnExtraHard);
            btnExtraHard.Visible = false; // Inicialmente invisível
        }
        
        // 🔥 VERIFICAR SE USUÁRIO DESBLOQUEOU EXTRA HARD
        void CarregarEstadoUsuario()
        {
            if (JaResgatouRecompensa("nivel_5"))
            {
                btnExtraHard.Visible = true;
                
                // Adicionar label explicativa
                Label lblExtraHard = new Label();
                lblExtraHard.Text = "Modo Extra Hard Desbloqueado!";
                lblExtraHard.ForeColor = Color.Purple;
                lblExtraHard.Font = new Font("Arial", 10, FontStyle.Bold);
                lblExtraHard.Location = new Point(btnExtraHard.Left, btnExtraHard.Top - 25);
                lblExtraHard.Size = new Size(200, 20);
                this.Controls.Add(lblExtraHard);
            }
        }
        
        // 🔥 VERIFICAR SE RESGATOU RECOMPENSA
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
        
        // 🔥 BOTÃO EXTRA HARD - ABRIR SELEÇÃO DE MATÉRIA
        void BtnExtraHardClick(object sender, EventArgs e)
        {
            // Criar form de seleção de matéria para Extra Hard
            using (Form selecaoForm = new Form())
            {
                selecaoForm.Text = "Extra Hard - Escolha a Matéria";
                selecaoForm.Size = new Size(300, 250);
                selecaoForm.StartPosition = FormStartPosition.CenterScreen;
                selecaoForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                selecaoForm.MaximizeBox = false;
                
                Label lblInstrucao = new Label();
                lblInstrucao.Text = "Cada questão vale 50 pontos!\nTotal: 150 pontos possíveis";
                lblInstrucao.Font = new Font("Arial", 10, FontStyle.Bold);
                lblInstrucao.ForeColor = Color.Purple;
                lblInstrucao.Location = new Point(20, 20);
                lblInstrucao.Size = new Size(250, 40);
                selecaoForm.Controls.Add(lblInstrucao);
                
                // Botão Matemática Extra Hard
                Button btnMatExtra = new Button();
                btnMatExtra.Text = "🧮 Matemática Extra Hard";
                btnMatExtra.BackColor = Color.DarkViolet;
                btnMatExtra.ForeColor = Color.White;
                btnMatExtra.Font = new Font("Arial", 11, FontStyle.Bold);
                btnMatExtra.Size = new Size(240, 40);
                btnMatExtra.Location = new Point(20, 70);
                btnMatExtra.Click += (s, ev) => {
                    selecaoForm.DialogResult = DialogResult.OK;
                    AbrirQuizExtra("matematica");
                };
                selecaoForm.Controls.Add(btnMatExtra);
                
                // Botão Português Extra Hard
                Button btnPortExtra = new Button();
                btnPortExtra.Text = "📚 Português Extra Hard";
                btnPortExtra.BackColor = Color.DarkViolet;
                btnPortExtra.ForeColor = Color.White;
                btnPortExtra.Font = new Font("Arial", 11, FontStyle.Bold);
                btnPortExtra.Size = new Size(240, 40);
                btnPortExtra.Location = new Point(20, 120);
                btnPortExtra.Click += (s, ev) => {
                    selecaoForm.DialogResult = DialogResult.OK;
                    AbrirQuizExtra("portugues");
                };
                selecaoForm.Controls.Add(btnPortExtra);
                
                // Botão Ciências Extra Hard
                Button btnCienExtra = new Button();
                btnCienExtra.Text = "🔬 Ciências Extra Hard";
                btnCienExtra.BackColor = Color.DarkViolet;
                btnCienExtra.ForeColor = Color.White;
                btnCienExtra.Font = new Font("Arial", 11, FontStyle.Bold);
                btnCienExtra.Size = new Size(240, 40);
                btnCienExtra.Location = new Point(20, 170);
                btnCienExtra.Click += (s, ev) => {
                    selecaoForm.DialogResult = DialogResult.OK;
                    AbrirQuizExtra("ciencias");
                };
                selecaoForm.Controls.Add(btnCienExtra);
                
                selecaoForm.ShowDialog();
            }
        }
        
        // 🔥 ABRIR QUIZ EXTRA HARD (50 pontos por questão)
        void AbrirQuizExtra(string materia)
        {
            // Criar form personalizado para Extra Hard
            QuestionarioForm quiz = new QuestionarioForm(materia, "extra_hard", nomeUsuario);
            quiz.Show();
            this.Hide();
        }
        
        // =========== CÓDIGO EXISTENTE (MANTIDO) ===========
        
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
        
        void AbrirQuiz(string materia, string dificuldade)
        {
            QuestionarioForm quiz = new QuestionarioForm(materia, dificuldade, nomeUsuario);
            quiz.Show();
            this.Hide();
        }
        
        void BtnMatFacilClick(object sender, EventArgs e) { AbrirQuiz("matematica", "facil"); }
        void BtnMatMedioClick(object sender, EventArgs e) { AbrirQuiz("matematica", "medio"); }
        void BtnMatDificilClick(object sender, EventArgs e) { AbrirQuiz("matematica", "dificil"); }
        void BtnPortFacilClick(object sender, EventArgs e) { AbrirQuiz("portugues", "facil"); }
        void BtnPortMedioClick(object sender, EventArgs e) { AbrirQuiz("portugues", "medio"); }
        void BtnPortDificilClick(object sender, EventArgs e) { AbrirQuiz("portugues", "dificil"); }
        void BtnCienFacilClick(object sender, EventArgs e) { AbrirQuiz("ciencias", "facil"); }
        void BtnCienMedioClick(object sender, EventArgs e) { AbrirQuiz("ciencias", "medio"); }
        void BtnCienDificilClick(object sender, EventArgs e) { AbrirQuiz("ciencias", "dificil"); }
    }
}