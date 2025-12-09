/*
 * Created by SharpDevelop.
 * User: Amanda
 * Date: 07/12/2025
 * Time: 17:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EducaQuest
{
	partial class QuestaoDiariaForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestaoDiariaForm));
			this.picVoltar = new System.Windows.Forms.PictureBox();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.picPerfil = new System.Windows.Forms.PictureBox();
			this.picDiamante = new System.Windows.Forms.PictureBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblMateria = new System.Windows.Forms.Label();
			this.lblTema = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnProximo = new System.Windows.Forms.Button();
			this.btnAnterior = new System.Windows.Forms.Button();
			this.lblData = new System.Windows.Forms.Label();
			this.lblPergunta = new System.Windows.Forms.Label();
			this.radioE = new System.Windows.Forms.RadioButton();
			this.radioD = new System.Windows.Forms.RadioButton();
			this.radioC = new System.Windows.Forms.RadioButton();
			this.radioB = new System.Windows.Forms.RadioButton();
			this.radioA = new System.Windows.Forms.RadioButton();
			this.lblPontosQuestao = new System.Windows.Forms.Label();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnConfirmar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDiamante)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// picVoltar
			// 
			this.picVoltar.Image = ((System.Drawing.Image)(resources.GetObject("picVoltar.Image")));
			this.picVoltar.Location = new System.Drawing.Point(3, -3);
			this.picVoltar.Name = "picVoltar";
			this.picVoltar.Size = new System.Drawing.Size(100, 50);
			this.picVoltar.TabIndex = 23;
			this.picVoltar.TabStop = false;
			this.picVoltar.Click += new System.EventHandler(this.PicVoltarClick);
			// 
			// picLogo
			// 
			this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
			this.picLogo.Location = new System.Drawing.Point(12, 53);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(236, 50);
			this.picLogo.TabIndex = 22;
			this.picLogo.TabStop = false;
			// 
			// picPerfil
			// 
			this.picPerfil.Image = ((System.Drawing.Image)(resources.GetObject("picPerfil.Image")));
			this.picPerfil.Location = new System.Drawing.Point(790, 54);
			this.picPerfil.Name = "picPerfil";
			this.picPerfil.Size = new System.Drawing.Size(40, 40);
			this.picPerfil.TabIndex = 54;
			this.picPerfil.TabStop = false;
			this.picPerfil.Click += new System.EventHandler(this.PicPerfilClick);
			// 
			// picDiamante
			// 
			this.picDiamante.Image = ((System.Drawing.Image)(resources.GetObject("picDiamante.Image")));
			this.picDiamante.Location = new System.Drawing.Point(583, 53);
			this.picDiamante.Name = "picDiamante";
			this.picDiamante.Size = new System.Drawing.Size(23, 27);
			this.picDiamante.TabIndex = 55;
			this.picDiamante.TabStop = false;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(377, 105);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(139, 42);
			this.lblTitulo.TabIndex = 56;
			this.lblTitulo.Text = "Questão Diária";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMateria
			// 
			this.lblMateria.Location = new System.Drawing.Point(12, 147);
			this.lblMateria.Name = "lblMateria";
			this.lblMateria.Size = new System.Drawing.Size(100, 23);
			this.lblMateria.TabIndex = 58;
			this.lblMateria.Text = "Materia";
			// 
			// lblTema
			// 
			this.lblTema.Location = new System.Drawing.Point(12, 124);
			this.lblTema.Name = "lblTema";
			this.lblTema.Size = new System.Drawing.Size(100, 23);
			this.lblTema.TabIndex = 57;
			this.lblTema.Text = "Tema:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
			this.panel1.Controls.Add(this.btnProximo);
			this.panel1.Controls.Add(this.btnAnterior);
			this.panel1.Controls.Add(this.lblData);
			this.panel1.Location = new System.Drawing.Point(219, 150);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(461, 52);
			this.panel1.TabIndex = 59;
			// 
			// btnProximo
			// 
			this.btnProximo.ForeColor = System.Drawing.Color.Black;
			this.btnProximo.Location = new System.Drawing.Point(368, 16);
			this.btnProximo.Name = "btnProximo";
			this.btnProximo.Size = new System.Drawing.Size(64, 23);
			this.btnProximo.TabIndex = 2;
			this.btnProximo.Text = "→";
			this.btnProximo.UseVisualStyleBackColor = true;
			this.btnProximo.Click += new System.EventHandler(this.BtnProximoClick);
			// 
			// btnAnterior
			// 
			this.btnAnterior.ForeColor = System.Drawing.Color.Black;
			this.btnAnterior.Location = new System.Drawing.Point(21, 16);
			this.btnAnterior.Name = "btnAnterior";
			this.btnAnterior.Size = new System.Drawing.Size(64, 23);
			this.btnAnterior.TabIndex = 1;
			this.btnAnterior.Text = "←";
			this.btnAnterior.UseVisualStyleBackColor = true;
			this.btnAnterior.Click += new System.EventHandler(this.BtnAnteriorClick);
			// 
			// lblData
			// 
			this.lblData.Location = new System.Drawing.Point(180, 16);
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(100, 23);
			this.lblData.TabIndex = 0;
			this.lblData.Text = "22 set 2025";
			this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblPergunta
			// 
			this.lblPergunta.Location = new System.Drawing.Point(12, 205);
			this.lblPergunta.Name = "lblPergunta";
			this.lblPergunta.Size = new System.Drawing.Size(843, 61);
			this.lblPergunta.TabIndex = 60;
			this.lblPergunta.Text = "Texto da pergunta...";
			// 
			// radioE
			// 
			this.radioE.Location = new System.Drawing.Point(32, 467);
			this.radioE.Name = "radioE";
			this.radioE.Size = new System.Drawing.Size(755, 24);
			this.radioE.TabIndex = 65;
			this.radioE.TabStop = true;
			this.radioE.Text = "E";
			this.radioE.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.radioE.UseVisualStyleBackColor = true;
			// 
			// radioD
			// 
			this.radioD.Location = new System.Drawing.Point(32, 415);
			this.radioD.Name = "radioD";
			this.radioD.Size = new System.Drawing.Size(755, 24);
			this.radioD.TabIndex = 64;
			this.radioD.TabStop = true;
			this.radioD.Text = "D";
			this.radioD.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.radioD.UseVisualStyleBackColor = true;
			// 
			// radioC
			// 
			this.radioC.Location = new System.Drawing.Point(32, 365);
			this.radioC.Name = "radioC";
			this.radioC.Size = new System.Drawing.Size(755, 24);
			this.radioC.TabIndex = 63;
			this.radioC.TabStop = true;
			this.radioC.Text = "C";
			this.radioC.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.radioC.UseVisualStyleBackColor = true;
			// 
			// radioB
			// 
			this.radioB.Location = new System.Drawing.Point(32, 316);
			this.radioB.Name = "radioB";
			this.radioB.Size = new System.Drawing.Size(755, 24);
			this.radioB.TabIndex = 62;
			this.radioB.TabStop = true;
			this.radioB.Text = "B";
			this.radioB.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.radioB.UseVisualStyleBackColor = true;
			// 
			// radioA
			// 
			this.radioA.Location = new System.Drawing.Point(32, 269);
			this.radioA.Name = "radioA";
			this.radioA.Size = new System.Drawing.Size(755, 24);
			this.radioA.TabIndex = 61;
			this.radioA.TabStop = true;
			this.radioA.Text = "A";
			this.radioA.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.radioA.UseVisualStyleBackColor = true;
			// 
			// lblPontosQuestao
			// 
			this.lblPontosQuestao.Location = new System.Drawing.Point(612, 58);
			this.lblPontosQuestao.Name = "lblPontosQuestao";
			this.lblPontosQuestao.Size = new System.Drawing.Size(100, 23);
			this.lblPontosQuestao.TabIndex = 66;
			this.lblPontosQuestao.Text = "XX pontos";
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(612, 448);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(100, 50);
			this.btnSair.TabIndex = 68;
			this.btnSair.Text = "SAIR";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.Location = new System.Drawing.Point(737, 448);
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Size = new System.Drawing.Size(100, 50);
			this.btnConfirmar.TabIndex = 67;
			this.btnConfirmar.Text = "CONFIRMAR";
			this.btnConfirmar.UseVisualStyleBackColor = true;
			this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmarClick);
			// 
			// QuestaoDiariaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(867, 512);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnConfirmar);
			this.Controls.Add(this.lblPontosQuestao);
			this.Controls.Add(this.radioE);
			this.Controls.Add(this.radioD);
			this.Controls.Add(this.radioC);
			this.Controls.Add(this.radioB);
			this.Controls.Add(this.radioA);
			this.Controls.Add(this.lblPergunta);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblMateria);
			this.Controls.Add(this.lblTema);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.picDiamante);
			this.Controls.Add(this.picPerfil);
			this.Controls.Add(this.picVoltar);
			this.Controls.Add(this.picLogo);
			this.Name = "QuestaoDiariaForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QuestaoDiariaForm";
			((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDiamante)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnConfirmar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnAnterior;
		private System.Windows.Forms.Button btnProximo;
		private System.Windows.Forms.Label lblPontosQuestao;
		private System.Windows.Forms.RadioButton radioA;
		private System.Windows.Forms.RadioButton radioB;
		private System.Windows.Forms.RadioButton radioC;
		private System.Windows.Forms.RadioButton radioD;
		private System.Windows.Forms.RadioButton radioE;
		private System.Windows.Forms.Label lblPergunta;
		private System.Windows.Forms.Label lblData;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblMateria;
		private System.Windows.Forms.Label lblTema;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.PictureBox picDiamante;
		private System.Windows.Forms.PictureBox picPerfil;
		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.PictureBox picVoltar;
	}
}
