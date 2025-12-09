/*
 * Created by SharpDevelop.
 * User: Amanda
 * Date: 04/12/2025
 * Time: 17:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EducaQuest
{
	partial class PerfilForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilForm));
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblSubtituloDados = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblSubtituloStats = new System.Windows.Forms.Label();
			this.lblNivel = new System.Windows.Forms.Label();
			this.lblPontuacaoTotal = new System.Windows.Forms.Label();
			this.lblStreak = new System.Windows.Forms.Label();
			this.lblQuizzesCompletos = new System.Windows.Forms.Label();
			this.btnAlterarSenha = new System.Windows.Forms.Button();
			this.btnResetar = new System.Windows.Forms.Button();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.picFotoPerfil = new System.Windows.Forms.PictureBox();
			this.picVoltar = new System.Windows.Forms.PictureBox();
			this.lblMoedas = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFotoPerfil)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(371, 71);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(100, 23);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Meu Perfil";
			// 
			// lblSubtituloDados
			// 
			this.lblSubtituloDados.Location = new System.Drawing.Point(48, 206);
			this.lblSubtituloDados.Name = "lblSubtituloDados";
			this.lblSubtituloDados.Size = new System.Drawing.Size(100, 23);
			this.lblSubtituloDados.TabIndex = 1;
			this.lblSubtituloDados.Text = "Dados Pessoais";
			// 
			// lblNome
			// 
			this.lblNome.Location = new System.Drawing.Point(48, 229);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(141, 23);
			this.lblNome.TabIndex = 2;
			this.lblNome.Text = "Nome: X";
			// 
			// lblEmail
			// 
			this.lblEmail.Location = new System.Drawing.Point(48, 252);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(184, 23);
			this.lblEmail.TabIndex = 3;
			this.lblEmail.Text = "Email: X";
			// 
			// lblSubtituloStats
			// 
			this.lblSubtituloStats.Location = new System.Drawing.Point(48, 290);
			this.lblSubtituloStats.Name = "lblSubtituloStats";
			this.lblSubtituloStats.Size = new System.Drawing.Size(100, 23);
			this.lblSubtituloStats.TabIndex = 4;
			this.lblSubtituloStats.Text = "Estatísticas";
			// 
			// lblNivel
			// 
			this.lblNivel.Location = new System.Drawing.Point(48, 313);
			this.lblNivel.Name = "lblNivel";
			this.lblNivel.Size = new System.Drawing.Size(100, 23);
			this.lblNivel.TabIndex = 5;
			this.lblNivel.Text = "Nível: X";
			// 
			// lblPontuacaoTotal
			// 
			this.lblPontuacaoTotal.Location = new System.Drawing.Point(48, 336);
			this.lblPontuacaoTotal.Name = "lblPontuacaoTotal";
			this.lblPontuacaoTotal.Size = new System.Drawing.Size(112, 23);
			this.lblPontuacaoTotal.TabIndex = 6;
			this.lblPontuacaoTotal.Text = "Pontuação Total: X";
			// 
			// lblStreak
			// 
			this.lblStreak.Location = new System.Drawing.Point(48, 359);
			this.lblStreak.Name = "lblStreak";
			this.lblStreak.Size = new System.Drawing.Size(123, 23);
			this.lblStreak.TabIndex = 7;
			this.lblStreak.Text = "Streak Atual: X dias";
			// 
			// lblQuizzesCompletos
			// 
			this.lblQuizzesCompletos.Location = new System.Drawing.Point(48, 382);
			this.lblQuizzesCompletos.Name = "lblQuizzesCompletos";
			this.lblQuizzesCompletos.Size = new System.Drawing.Size(141, 23);
			this.lblQuizzesCompletos.TabIndex = 8;
			this.lblQuizzesCompletos.Text = "Questões Respondidas: X";
			// 
			// btnAlterarSenha
			// 
			this.btnAlterarSenha.Location = new System.Drawing.Point(625, 252);
			this.btnAlterarSenha.Name = "btnAlterarSenha";
			this.btnAlterarSenha.Size = new System.Drawing.Size(131, 42);
			this.btnAlterarSenha.TabIndex = 9;
			this.btnAlterarSenha.Text = "ALTERAR SENHA";
			this.btnAlterarSenha.UseVisualStyleBackColor = true;
			this.btnAlterarSenha.Click += new System.EventHandler(this.BtnAlterarSenhaClick);
			// 
			// btnResetar
			// 
			this.btnResetar.Location = new System.Drawing.Point(625, 313);
			this.btnResetar.Name = "btnResetar";
			this.btnResetar.Size = new System.Drawing.Size(131, 42);
			this.btnResetar.TabIndex = 10;
			this.btnResetar.Text = "RESETAR";
			this.btnResetar.UseVisualStyleBackColor = true;
			this.btnResetar.Click += new System.EventHandler(this.BtnResetarClick);
			// 
			// picLogo
			// 
			this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
			this.picLogo.Location = new System.Drawing.Point(12, 53);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(236, 50);
			this.picLogo.TabIndex = 12;
			this.picLogo.TabStop = false;
			// 
			// picFotoPerfil
			// 
			this.picFotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("picFotoPerfil.Image")));
			this.picFotoPerfil.Location = new System.Drawing.Point(333, 97);
			this.picFotoPerfil.Name = "picFotoPerfil";
			this.picFotoPerfil.Size = new System.Drawing.Size(138, 117);
			this.picFotoPerfil.TabIndex = 13;
			this.picFotoPerfil.TabStop = false;
			// 
			// picVoltar
			// 
			this.picVoltar.Image = ((System.Drawing.Image)(resources.GetObject("picVoltar.Image")));
			this.picVoltar.Location = new System.Drawing.Point(3, -3);
			this.picVoltar.Name = "picVoltar";
			this.picVoltar.Size = new System.Drawing.Size(100, 50);
			this.picVoltar.TabIndex = 14;
			this.picVoltar.TabStop = false;
			this.picVoltar.Click += new System.EventHandler(this.PicVoltarClick);
			// 
			// lblMoedas
			// 
			this.lblMoedas.Location = new System.Drawing.Point(48, 405);
			this.lblMoedas.Name = "lblMoedas";
			this.lblMoedas.Size = new System.Drawing.Size(141, 23);
			this.lblMoedas.TabIndex = 15;
			this.lblMoedas.Text = "Moedas: X";
			// 
			// PerfilForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(867, 512);
			this.Controls.Add(this.lblMoedas);
			this.Controls.Add(this.picVoltar);
			this.Controls.Add(this.picFotoPerfil);
			this.Controls.Add(this.picLogo);
			this.Controls.Add(this.btnResetar);
			this.Controls.Add(this.btnAlterarSenha);
			this.Controls.Add(this.lblQuizzesCompletos);
			this.Controls.Add(this.lblStreak);
			this.Controls.Add(this.lblPontuacaoTotal);
			this.Controls.Add(this.lblNivel);
			this.Controls.Add(this.lblSubtituloStats);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.lblSubtituloDados);
			this.Controls.Add(this.lblTitulo);
			this.Name = "PerfilForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PerfilForm";
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFotoPerfil)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblMoedas;
		private System.Windows.Forms.PictureBox picVoltar;
		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.PictureBox picFotoPerfil;
		private System.Windows.Forms.Button btnResetar;
		private System.Windows.Forms.Button btnAlterarSenha;
		private System.Windows.Forms.Label lblQuizzesCompletos;
		private System.Windows.Forms.Label lblStreak;
		private System.Windows.Forms.Label lblPontuacaoTotal;
		private System.Windows.Forms.Label lblNivel;
		private System.Windows.Forms.Label lblSubtituloStats;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblSubtituloDados;
		private System.Windows.Forms.Label lblTitulo;
	}
}
