/*
 * Created by SharpDevelop.
 * User: Amanda
 * Date: 24/11/2025
 * Time: 19:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EducaQuest
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.lblBemVindo = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.linkSobre = new System.Windows.Forms.LinkLabel();
			this.linkAjuda = new System.Windows.Forms.LinkLabel();
			this.linkContato = new System.Windows.Forms.LinkLabel();
			this.panelProgresso = new System.Windows.Forms.Panel();
			this.lblMoedas = new System.Windows.Forms.Label();
			this.lblProximoNivel = new System.Windows.Forms.Label();
			this.lblNivelAtual = new System.Windows.Forms.Label();
			this.progressBarNivel = new System.Windows.Forms.ProgressBar();
			this.lblPontosProximaRec = new System.Windows.Forms.Label();
			this.lblQuizzesRespondidos = new System.Windows.Forms.Label();
			this.lblPontos = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblProgresso = new System.Windows.Forms.Label();
			this.lblQuestaoDiaria = new System.Windows.Forms.Label();
			this.picQuestaoDiaria = new System.Windows.Forms.PictureBox();
			this.btnQuestaoDiaria = new System.Windows.Forms.Button();
			this.btnModoEstudo = new System.Windows.Forms.Button();
			this.picEstudo = new System.Windows.Forms.PictureBox();
			this.lblEstudo = new System.Windows.Forms.Label();
			this.btnRecompensas = new System.Windows.Forms.Button();
			this.picRecompensas = new System.Windows.Forms.PictureBox();
			this.lblRecompensas = new System.Windows.Forms.Label();
			this.picStreak = new System.Windows.Forms.PictureBox();
			this.lblStreak = new System.Windows.Forms.Label();
			this.picPerfil = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.panelProgresso.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picQuestaoDiaria)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picEstudo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picRecompensas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picStreak)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
			this.SuspendLayout();
			// 
			// picLogo
			// 
			this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
			this.picLogo.Location = new System.Drawing.Point(12, 53);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(236, 53);
			this.picLogo.TabIndex = 33;
			this.picLogo.TabStop = false;
			// 
			// lblBemVindo
			// 
			this.lblBemVindo.Location = new System.Drawing.Point(12, 110);
			this.lblBemVindo.Name = "lblBemVindo";
			this.lblBemVindo.Size = new System.Drawing.Size(124, 23);
			this.lblBemVindo.TabIndex = 34;
			this.lblBemVindo.Text = "Bem-vindo, (usuario)";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(283, 23);
			this.label2.TabIndex = 35;
			this.label2.Text = "Pronto para se preparar para o Provão Paulista?";
			// 
			// linkSobre
			// 
			this.linkSobre.Location = new System.Drawing.Point(363, 480);
			this.linkSobre.Name = "linkSobre";
			this.linkSobre.Size = new System.Drawing.Size(100, 23);
			this.linkSobre.TabIndex = 36;
			this.linkSobre.TabStop = true;
			this.linkSobre.Text = "Sobre";
			this.linkSobre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSobreLinkClicked);
			// 
			// linkAjuda
			// 
			this.linkAjuda.Location = new System.Drawing.Point(414, 480);
			this.linkAjuda.Name = "linkAjuda";
			this.linkAjuda.Size = new System.Drawing.Size(100, 23);
			this.linkAjuda.TabIndex = 37;
			this.linkAjuda.TabStop = true;
			this.linkAjuda.Text = "Ajuda";
			this.linkAjuda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkAjudaLinkClicked);
			// 
			// linkContato
			// 
			this.linkContato.Location = new System.Drawing.Point(469, 480);
			this.linkContato.Name = "linkContato";
			this.linkContato.Size = new System.Drawing.Size(100, 23);
			this.linkContato.TabIndex = 38;
			this.linkContato.TabStop = true;
			this.linkContato.Text = "Contato";
			this.linkContato.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkContatoLinkClicked);
			// 
			// panelProgresso
			// 
			this.panelProgresso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
			this.panelProgresso.Controls.Add(this.lblMoedas);
			this.panelProgresso.Controls.Add(this.lblProximoNivel);
			this.panelProgresso.Controls.Add(this.lblNivelAtual);
			this.panelProgresso.Controls.Add(this.progressBarNivel);
			this.panelProgresso.Controls.Add(this.lblPontosProximaRec);
			this.panelProgresso.Controls.Add(this.lblQuizzesRespondidos);
			this.panelProgresso.Controls.Add(this.lblPontos);
			this.panelProgresso.Controls.Add(this.pictureBox1);
			this.panelProgresso.Controls.Add(this.lblProgresso);
			this.panelProgresso.Location = new System.Drawing.Point(538, 246);
			this.panelProgresso.Name = "panelProgresso";
			this.panelProgresso.Size = new System.Drawing.Size(317, 231);
			this.panelProgresso.TabIndex = 40;
			// 
			// lblMoedas
			// 
			this.lblMoedas.ForeColor = System.Drawing.Color.White;
			this.lblMoedas.Location = new System.Drawing.Point(16, 152);
			this.lblMoedas.Name = "lblMoedas";
			this.lblMoedas.Size = new System.Drawing.Size(100, 23);
			this.lblMoedas.TabIndex = 42;
			this.lblMoedas.Text = "Moedas Atuais: X";
			// 
			// lblProximoNivel
			// 
			this.lblProximoNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.lblProximoNivel.Location = new System.Drawing.Point(217, 196);
			this.lblProximoNivel.Name = "lblProximoNivel";
			this.lblProximoNivel.Size = new System.Drawing.Size(27, 20);
			this.lblProximoNivel.TabIndex = 41;
			this.lblProximoNivel.Text = "2";
			this.lblProximoNivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNivelAtual
			// 
			this.lblNivelAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.lblNivelAtual.Location = new System.Drawing.Point(48, 196);
			this.lblNivelAtual.Name = "lblNivelAtual";
			this.lblNivelAtual.Size = new System.Drawing.Size(27, 20);
			this.lblNivelAtual.TabIndex = 6;
			this.lblNivelAtual.Text = "1";
			this.lblNivelAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// progressBarNivel
			// 
			this.progressBarNivel.Location = new System.Drawing.Point(72, 196);
			this.progressBarNivel.Name = "progressBarNivel";
			this.progressBarNivel.Size = new System.Drawing.Size(150, 20);
			this.progressBarNivel.TabIndex = 5;
			// 
			// lblPontosProximaRec
			// 
			this.lblPontosProximaRec.ForeColor = System.Drawing.Color.White;
			this.lblPontosProximaRec.Location = new System.Drawing.Point(16, 129);
			this.lblPontosProximaRec.Name = "lblPontosProximaRec";
			this.lblPontosProximaRec.Size = new System.Drawing.Size(138, 23);
			this.lblPontosProximaRec.TabIndex = 4;
			this.lblPontosProximaRec.Text = "Próxima recompensa: XX";
			// 
			// lblQuizzesRespondidos
			// 
			this.lblQuizzesRespondidos.ForeColor = System.Drawing.Color.White;
			this.lblQuizzesRespondidos.Location = new System.Drawing.Point(16, 106);
			this.lblQuizzesRespondidos.Name = "lblQuizzesRespondidos";
			this.lblQuizzesRespondidos.Size = new System.Drawing.Size(138, 23);
			this.lblQuizzesRespondidos.TabIndex = 3;
			this.lblQuizzesRespondidos.Text = "Questões respondidas: X";
			// 
			// lblPontos
			// 
			this.lblPontos.ForeColor = System.Drawing.Color.White;
			this.lblPontos.Location = new System.Drawing.Point(16, 83);
			this.lblPontos.Name = "lblPontos";
			this.lblPontos.Size = new System.Drawing.Size(100, 23);
			this.lblPontos.TabIndex = 2;
			this.lblPontos.Text = "Pontos: XX";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(108, 74);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// lblProgresso
			// 
			this.lblProgresso.ForeColor = System.Drawing.Color.White;
			this.lblProgresso.Location = new System.Drawing.Point(122, 19);
			this.lblProgresso.Name = "lblProgresso";
			this.lblProgresso.Size = new System.Drawing.Size(100, 23);
			this.lblProgresso.TabIndex = 0;
			this.lblProgresso.Text = "PROGRESSO";
			// 
			// lblQuestaoDiaria
			// 
			this.lblQuestaoDiaria.Location = new System.Drawing.Point(52, 185);
			this.lblQuestaoDiaria.Name = "lblQuestaoDiaria";
			this.lblQuestaoDiaria.Size = new System.Drawing.Size(84, 23);
			this.lblQuestaoDiaria.TabIndex = 41;
			this.lblQuestaoDiaria.Text = "Questão diária";
			// 
			// picQuestaoDiaria
			// 
			this.picQuestaoDiaria.Image = ((System.Drawing.Image)(resources.GetObject("picQuestaoDiaria.Image")));
			this.picQuestaoDiaria.Location = new System.Drawing.Point(12, 172);
			this.picQuestaoDiaria.Name = "picQuestaoDiaria";
			this.picQuestaoDiaria.Size = new System.Drawing.Size(34, 36);
			this.picQuestaoDiaria.TabIndex = 42;
			this.picQuestaoDiaria.TabStop = false;
			// 
			// btnQuestaoDiaria
			// 
			this.btnQuestaoDiaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
			this.btnQuestaoDiaria.ForeColor = System.Drawing.SystemColors.Control;
			this.btnQuestaoDiaria.Location = new System.Drawing.Point(12, 214);
			this.btnQuestaoDiaria.Name = "btnQuestaoDiaria";
			this.btnQuestaoDiaria.Size = new System.Drawing.Size(124, 33);
			this.btnQuestaoDiaria.TabIndex = 43;
			this.btnQuestaoDiaria.Text = "RESPONDER";
			this.btnQuestaoDiaria.UseVisualStyleBackColor = false;
			this.btnQuestaoDiaria.Click += new System.EventHandler(this.BtnQuestaoDiariaClick);
			// 
			// btnModoEstudo
			// 
			this.btnModoEstudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
			this.btnModoEstudo.ForeColor = System.Drawing.SystemColors.Control;
			this.btnModoEstudo.Location = new System.Drawing.Point(323, 214);
			this.btnModoEstudo.Name = "btnModoEstudo";
			this.btnModoEstudo.Size = new System.Drawing.Size(124, 33);
			this.btnModoEstudo.TabIndex = 46;
			this.btnModoEstudo.Text = "ACESSAR";
			this.btnModoEstudo.UseVisualStyleBackColor = false;
			this.btnModoEstudo.Click += new System.EventHandler(this.BtnModoEstudoClick);
			// 
			// picEstudo
			// 
			this.picEstudo.Image = ((System.Drawing.Image)(resources.GetObject("picEstudo.Image")));
			this.picEstudo.Location = new System.Drawing.Point(323, 172);
			this.picEstudo.Name = "picEstudo";
			this.picEstudo.Size = new System.Drawing.Size(34, 36);
			this.picEstudo.TabIndex = 45;
			this.picEstudo.TabStop = false;
			// 
			// lblEstudo
			// 
			this.lblEstudo.Location = new System.Drawing.Point(363, 185);
			this.lblEstudo.Name = "lblEstudo";
			this.lblEstudo.Size = new System.Drawing.Size(84, 23);
			this.lblEstudo.TabIndex = 44;
			this.lblEstudo.Text = "Modo de estudo";
			// 
			// btnRecompensas
			// 
			this.btnRecompensas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
			this.btnRecompensas.ForeColor = System.Drawing.SystemColors.Control;
			this.btnRecompensas.Location = new System.Drawing.Point(12, 326);
			this.btnRecompensas.Name = "btnRecompensas";
			this.btnRecompensas.Size = new System.Drawing.Size(124, 33);
			this.btnRecompensas.TabIndex = 49;
			this.btnRecompensas.Text = "VER";
			this.btnRecompensas.UseVisualStyleBackColor = false;
			this.btnRecompensas.Click += new System.EventHandler(this.BtnRecompensasClick);
			// 
			// picRecompensas
			// 
			this.picRecompensas.Image = ((System.Drawing.Image)(resources.GetObject("picRecompensas.Image")));
			this.picRecompensas.Location = new System.Drawing.Point(4, 275);
			this.picRecompensas.Name = "picRecompensas";
			this.picRecompensas.Size = new System.Drawing.Size(42, 45);
			this.picRecompensas.TabIndex = 48;
			this.picRecompensas.TabStop = false;
			// 
			// lblRecompensas
			// 
			this.lblRecompensas.Location = new System.Drawing.Point(52, 297);
			this.lblRecompensas.Name = "lblRecompensas";
			this.lblRecompensas.Size = new System.Drawing.Size(84, 23);
			this.lblRecompensas.TabIndex = 47;
			this.lblRecompensas.Text = "Recompensas";
			// 
			// picStreak
			// 
			this.picStreak.Image = ((System.Drawing.Image)(resources.GetObject("picStreak.Image")));
			this.picStreak.Location = new System.Drawing.Point(142, 202);
			this.picStreak.Name = "picStreak";
			this.picStreak.Size = new System.Drawing.Size(43, 59);
			this.picStreak.TabIndex = 50;
			this.picStreak.TabStop = false;
			// 
			// lblStreak
			// 
			this.lblStreak.Location = new System.Drawing.Point(191, 224);
			this.lblStreak.Name = "lblStreak";
			this.lblStreak.Size = new System.Drawing.Size(100, 23);
			this.lblStreak.TabIndex = 51;
			this.lblStreak.Text = "0";
			// 
			// picPerfil
			// 
			this.picPerfil.Image = ((System.Drawing.Image)(resources.GetObject("picPerfil.Image")));
			this.picPerfil.Location = new System.Drawing.Point(790, 54);
			this.picPerfil.Name = "picPerfil";
			this.picPerfil.Size = new System.Drawing.Size(40, 40);
			this.picPerfil.TabIndex = 52;
			this.picPerfil.TabStop = false;
			this.picPerfil.Click += new System.EventHandler(this.PicPerfilClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(867, 512);
			this.Controls.Add(this.picPerfil);
			this.Controls.Add(this.lblStreak);
			this.Controls.Add(this.picStreak);
			this.Controls.Add(this.btnRecompensas);
			this.Controls.Add(this.picRecompensas);
			this.Controls.Add(this.lblRecompensas);
			this.Controls.Add(this.btnModoEstudo);
			this.Controls.Add(this.picEstudo);
			this.Controls.Add(this.lblEstudo);
			this.Controls.Add(this.btnQuestaoDiaria);
			this.Controls.Add(this.picQuestaoDiaria);
			this.Controls.Add(this.lblQuestaoDiaria);
			this.Controls.Add(this.panelProgresso);
			this.Controls.Add(this.linkContato);
			this.Controls.Add(this.linkAjuda);
			this.Controls.Add(this.linkSobre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblBemVindo);
			this.Controls.Add(this.picLogo);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EducaQuest";
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.panelProgresso.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picQuestaoDiaria)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picEstudo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picRecompensas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picStreak)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblMoedas;
		private System.Windows.Forms.PictureBox picPerfil;
		private System.Windows.Forms.Label lblStreak;
		private System.Windows.Forms.PictureBox picStreak;
		private System.Windows.Forms.Label lblRecompensas;
		private System.Windows.Forms.PictureBox picRecompensas;
		private System.Windows.Forms.Button btnRecompensas;
		private System.Windows.Forms.Label lblEstudo;
		private System.Windows.Forms.PictureBox picEstudo;
		private System.Windows.Forms.Button btnModoEstudo;
		private System.Windows.Forms.Button btnQuestaoDiaria;
		private System.Windows.Forms.PictureBox picQuestaoDiaria;
		private System.Windows.Forms.Label lblQuestaoDiaria;
		private System.Windows.Forms.Label lblPontos;
		private System.Windows.Forms.Label lblQuizzesRespondidos;
		private System.Windows.Forms.Label lblPontosProximaRec;
		private System.Windows.Forms.ProgressBar progressBarNivel;
		private System.Windows.Forms.Label lblNivelAtual;
		private System.Windows.Forms.Label lblProximoNivel;
		private System.Windows.Forms.Label lblProgresso;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panelProgresso;
		private System.Windows.Forms.LinkLabel linkContato;
		private System.Windows.Forms.LinkLabel linkAjuda;
		private System.Windows.Forms.LinkLabel linkSobre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblBemVindo;
		private System.Windows.Forms.PictureBox picLogo;
	}
}
