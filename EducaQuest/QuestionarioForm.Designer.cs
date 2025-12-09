/*
 * Created by SharpDevelop.
 * User: Amanda
 * Date: 06/12/2025
 * Time: 12:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EducaQuest
{
	partial class QuestionarioForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionarioForm));
			this.picVoltar = new System.Windows.Forms.PictureBox();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.lblTema = new System.Windows.Forms.Label();
			this.lblMateria = new System.Windows.Forms.Label();
			this.lblProgresso = new System.Windows.Forms.Label();
			this.lblPergunta = new System.Windows.Forms.Label();
			this.radioA = new System.Windows.Forms.RadioButton();
			this.radioB = new System.Windows.Forms.RadioButton();
			this.radioC = new System.Windows.Forms.RadioButton();
			this.radioD = new System.Windows.Forms.RadioButton();
			this.radioE = new System.Windows.Forms.RadioButton();
			this.btnConfirmar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// picVoltar
			// 
			this.picVoltar.Image = ((System.Drawing.Image)(resources.GetObject("picVoltar.Image")));
			this.picVoltar.Location = new System.Drawing.Point(3, -3);
			this.picVoltar.Name = "picVoltar";
			this.picVoltar.Size = new System.Drawing.Size(100, 50);
			this.picVoltar.TabIndex = 20;
			this.picVoltar.TabStop = false;
			this.picVoltar.Click += new System.EventHandler(this.PicVoltarClick);
			// 
			// picLogo
			// 
			this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
			this.picLogo.Location = new System.Drawing.Point(12, 53);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(236, 50);
			this.picLogo.TabIndex = 19;
			this.picLogo.TabStop = false;
			// 
			// lblTema
			// 
			this.lblTema.Location = new System.Drawing.Point(12, 124);
			this.lblTema.Name = "lblTema";
			this.lblTema.Size = new System.Drawing.Size(100, 23);
			this.lblTema.TabIndex = 21;
			this.lblTema.Text = "Tema:";
			// 
			// lblMateria
			// 
			this.lblMateria.Location = new System.Drawing.Point(12, 147);
			this.lblMateria.Name = "lblMateria";
			this.lblMateria.Size = new System.Drawing.Size(100, 23);
			this.lblMateria.TabIndex = 22;
			this.lblMateria.Text = "Materia";
			// 
			// lblProgresso
			// 
			this.lblProgresso.Location = new System.Drawing.Point(739, 147);
			this.lblProgresso.Name = "lblProgresso";
			this.lblProgresso.Size = new System.Drawing.Size(100, 23);
			this.lblProgresso.TabIndex = 23;
			this.lblProgresso.Text = "Questão: 1/5";
			// 
			// lblPergunta
			// 
			this.lblPergunta.Location = new System.Drawing.Point(12, 195);
			this.lblPergunta.Name = "lblPergunta";
			this.lblPergunta.Size = new System.Drawing.Size(843, 77);
			this.lblPergunta.TabIndex = 24;
			this.lblPergunta.Text = "Texto da pergunta...";
			// 
			// radioA
			// 
			this.radioA.Location = new System.Drawing.Point(62, 248);
			this.radioA.Name = "radioA";
			this.radioA.Size = new System.Drawing.Size(755, 24);
			this.radioA.TabIndex = 25;
			this.radioA.TabStop = true;
			this.radioA.Text = "A";
			this.radioA.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.radioA.UseVisualStyleBackColor = true;
			// 
			// radioB
			// 
			this.radioB.Location = new System.Drawing.Point(62, 295);
			this.radioB.Name = "radioB";
			this.radioB.Size = new System.Drawing.Size(755, 24);
			this.radioB.TabIndex = 26;
			this.radioB.TabStop = true;
			this.radioB.Text = "B";
			this.radioB.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.radioB.UseVisualStyleBackColor = true;
			// 
			// radioC
			// 
			this.radioC.Location = new System.Drawing.Point(62, 344);
			this.radioC.Name = "radioC";
			this.radioC.Size = new System.Drawing.Size(755, 24);
			this.radioC.TabIndex = 27;
			this.radioC.TabStop = true;
			this.radioC.Text = "C";
			this.radioC.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.radioC.UseVisualStyleBackColor = true;
			// 
			// radioD
			// 
			this.radioD.Location = new System.Drawing.Point(62, 394);
			this.radioD.Name = "radioD";
			this.radioD.Size = new System.Drawing.Size(755, 24);
			this.radioD.TabIndex = 28;
			this.radioD.TabStop = true;
			this.radioD.Text = "D";
			this.radioD.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.radioD.UseVisualStyleBackColor = true;
			// 
			// radioE
			// 
			this.radioE.Location = new System.Drawing.Point(62, 446);
			this.radioE.Name = "radioE";
			this.radioE.Size = new System.Drawing.Size(755, 24);
			this.radioE.TabIndex = 29;
			this.radioE.TabStop = true;
			this.radioE.Text = "E";
			this.radioE.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.radioE.UseVisualStyleBackColor = true;
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.Location = new System.Drawing.Point(717, 53);
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Size = new System.Drawing.Size(100, 50);
			this.btnConfirmar.TabIndex = 30;
			this.btnConfirmar.Text = "CONFIRMAR";
			this.btnConfirmar.UseVisualStyleBackColor = true;
			this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmarClick);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(592, 53);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(100, 50);
			this.btnSair.TabIndex = 31;
			this.btnSair.Text = "SAIR";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// QuizForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(867, 512);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnConfirmar);
			this.Controls.Add(this.radioE);
			this.Controls.Add(this.radioD);
			this.Controls.Add(this.radioC);
			this.Controls.Add(this.radioB);
			this.Controls.Add(this.radioA);
			this.Controls.Add(this.lblPergunta);
			this.Controls.Add(this.lblProgresso);
			this.Controls.Add(this.lblMateria);
			this.Controls.Add(this.lblTema);
			this.Controls.Add(this.picVoltar);
			this.Controls.Add(this.picLogo);
			this.Name = "QuestionarioForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QuestionarioForm";
			((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnConfirmar;
		private System.Windows.Forms.RadioButton radioE;
		private System.Windows.Forms.RadioButton radioD;
		private System.Windows.Forms.RadioButton radioC;
		private System.Windows.Forms.RadioButton radioB;
		private System.Windows.Forms.RadioButton radioA;
		private System.Windows.Forms.Label lblPergunta;
		private System.Windows.Forms.Label lblProgresso;
		private System.Windows.Forms.Label lblMateria;
		private System.Windows.Forms.Label lblTema;
		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.PictureBox picVoltar;
	}
}
