/*
 * Created by SharpDevelop.
 * User: Amanda
 * Date: 08/12/2025
 * Time: 21:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EducaQuest
{
	partial class RecompensasForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecompensasForm));
			this.picVoltar = new System.Windows.Forms.PictureBox();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.picPerfil = new System.Windows.Forms.PictureBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblSuasMoedas = new System.Windows.Forms.Label();
			this.lblRecompensasDisponiveis = new System.Windows.Forms.Label();
			this.picRec1 = new System.Windows.Forms.PictureBox();
			this.lblKitPDF = new System.Windows.Forms.Label();
			this.btnComprarKitPDF = new System.Windows.Forms.Button();
			this.btnComprarVideo = new System.Windows.Forms.Button();
			this.lblVideoAula = new System.Windows.Forms.Label();
			this.picRec2 = new System.Windows.Forms.PictureBox();
			this.btnComprarCertificado = new System.Windows.Forms.Button();
			this.lblCertificado = new System.Windows.Forms.Label();
			this.picRec3 = new System.Windows.Forms.PictureBox();
			this.lblNivel3 = new System.Windows.Forms.Label();
			this.lblNivel5 = new System.Windows.Forms.Label();
			this.lblNivel10 = new System.Windows.Forms.Label();
			this.lblRecompensa3 = new System.Windows.Forms.Label();
			this.lblRecompensa5 = new System.Windows.Forms.Label();
			this.lblRecompensa10 = new System.Windows.Forms.Label();
			this.btnResgatarNivel3 = new System.Windows.Forms.Button();
			this.btnResgatarNivel5 = new System.Windows.Forms.Button();
			this.btnResgatarNivel10 = new System.Windows.Forms.Button();
			this.panelNivel3 = new System.Windows.Forms.Panel();
			this.panelNivel5 = new System.Windows.Forms.Panel();
			this.panelNivel10 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picRec1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picRec2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picRec3)).BeginInit();
			this.SuspendLayout();
			// 
			// picVoltar
			// 
			this.picVoltar.Image = ((System.Drawing.Image)(resources.GetObject("picVoltar.Image")));
			this.picVoltar.Location = new System.Drawing.Point(3, -3);
			this.picVoltar.Name = "picVoltar";
			this.picVoltar.Size = new System.Drawing.Size(100, 50);
			this.picVoltar.TabIndex = 22;
			this.picVoltar.TabStop = false;
			this.picVoltar.Click += new System.EventHandler(this.PicVoltarClick);
			// 
			// picLogo
			// 
			this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
			this.picLogo.Location = new System.Drawing.Point(12, 53);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(236, 50);
			this.picLogo.TabIndex = 21;
			this.picLogo.TabStop = false;
			// 
			// picPerfil
			// 
			this.picPerfil.Image = ((System.Drawing.Image)(resources.GetObject("picPerfil.Image")));
			this.picPerfil.Location = new System.Drawing.Point(790, 54);
			this.picPerfil.Name = "picPerfil";
			this.picPerfil.Size = new System.Drawing.Size(40, 40);
			this.picPerfil.TabIndex = 55;
			this.picPerfil.TabStop = false;
			this.picPerfil.Click += new System.EventHandler(this.PicPerfilClick);
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(363, 106);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(139, 42);
			this.lblTitulo.TabIndex = 57;
			this.lblTitulo.Text = "Loja de Recompensas";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSuasMoedas
			// 
			this.lblSuasMoedas.Location = new System.Drawing.Point(13, 140);
			this.lblSuasMoedas.Name = "lblSuasMoedas";
			this.lblSuasMoedas.Size = new System.Drawing.Size(111, 23);
			this.lblSuasMoedas.TabIndex = 58;
			this.lblSuasMoedas.Text = "Suas Moedas: 0";
			// 
			// lblRecompensasDisponiveis
			// 
			this.lblRecompensasDisponiveis.Location = new System.Drawing.Point(13, 163);
			this.lblRecompensasDisponiveis.Name = "lblRecompensasDisponiveis";
			this.lblRecompensasDisponiveis.Size = new System.Drawing.Size(142, 23);
			this.lblRecompensasDisponiveis.TabIndex = 59;
			this.lblRecompensasDisponiveis.Text = "Recompensas Disponíveis:";
			// 
			// picRec1
			// 
			this.picRec1.Image = ((System.Drawing.Image)(resources.GetObject("picRec1.Image")));
			this.picRec1.Location = new System.Drawing.Point(13, 205);
			this.picRec1.Name = "picRec1";
			this.picRec1.Size = new System.Drawing.Size(40, 39);
			this.picRec1.TabIndex = 60;
			this.picRec1.TabStop = false;
			// 
			// lblKitPDF
			// 
			this.lblKitPDF.Location = new System.Drawing.Point(70, 205);
			this.lblKitPDF.Name = "lblKitPDF";
			this.lblKitPDF.Size = new System.Drawing.Size(176, 39);
			this.lblKitPDF.TabIndex = 61;
			this.lblKitPDF.Text = "Kit Estudo com PDF - 50 moedas";
			this.lblKitPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnComprarKitPDF
			// 
			this.btnComprarKitPDF.Location = new System.Drawing.Point(13, 260);
			this.btnComprarKitPDF.Name = "btnComprarKitPDF";
			this.btnComprarKitPDF.Size = new System.Drawing.Size(216, 39);
			this.btnComprarKitPDF.TabIndex = 62;
			this.btnComprarKitPDF.Text = "COMPRAR";
			this.btnComprarKitPDF.UseVisualStyleBackColor = true;
			this.btnComprarKitPDF.Click += new System.EventHandler(this.BtnComprarKitPDFClick);
			// 
			// btnComprarVideo
			// 
			this.btnComprarVideo.Location = new System.Drawing.Point(13, 360);
			this.btnComprarVideo.Name = "btnComprarVideo";
			this.btnComprarVideo.Size = new System.Drawing.Size(216, 39);
			this.btnComprarVideo.TabIndex = 65;
			this.btnComprarVideo.Text = "COMPRAR";
			this.btnComprarVideo.UseVisualStyleBackColor = true;
			this.btnComprarVideo.Click += new System.EventHandler(this.BtnComprarVideoClick);
			// 
			// lblVideoAula
			// 
			this.lblVideoAula.Location = new System.Drawing.Point(70, 305);
			this.lblVideoAula.Name = "lblVideoAula";
			this.lblVideoAula.Size = new System.Drawing.Size(176, 39);
			this.lblVideoAula.TabIndex = 64;
			this.lblVideoAula.Text = "Vídeo Aula Bônus - 100 moedas";
			this.lblVideoAula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picRec2
			// 
			this.picRec2.Image = ((System.Drawing.Image)(resources.GetObject("picRec2.Image")));
			this.picRec2.Location = new System.Drawing.Point(13, 305);
			this.picRec2.Name = "picRec2";
			this.picRec2.Size = new System.Drawing.Size(40, 39);
			this.picRec2.TabIndex = 63;
			this.picRec2.TabStop = false;
			// 
			// btnComprarCertificado
			// 
			this.btnComprarCertificado.Location = new System.Drawing.Point(13, 460);
			this.btnComprarCertificado.Name = "btnComprarCertificado";
			this.btnComprarCertificado.Size = new System.Drawing.Size(216, 39);
			this.btnComprarCertificado.TabIndex = 68;
			this.btnComprarCertificado.Text = "COMPRAR";
			this.btnComprarCertificado.UseVisualStyleBackColor = true;
			this.btnComprarCertificado.Click += new System.EventHandler(this.BtnComprarCertificadoClick);
			// 
			// lblCertificado
			// 
			this.lblCertificado.Location = new System.Drawing.Point(70, 405);
			this.lblCertificado.Name = "lblCertificado";
			this.lblCertificado.Size = new System.Drawing.Size(176, 39);
			this.lblCertificado.TabIndex = 67;
			this.lblCertificado.Text = "Certificado Digital - 200 moedas";
			this.lblCertificado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picRec3
			// 
			this.picRec3.Image = ((System.Drawing.Image)(resources.GetObject("picRec3.Image")));
			this.picRec3.Location = new System.Drawing.Point(13, 405);
			this.picRec3.Name = "picRec3";
			this.picRec3.Size = new System.Drawing.Size(40, 39);
			this.picRec3.TabIndex = 66;
			this.picRec3.TabStop = false;
			// 
			// lblNivel3
			// 
			this.lblNivel3.Location = new System.Drawing.Point(601, 274);
			this.lblNivel3.Name = "lblNivel3";
			this.lblNivel3.Size = new System.Drawing.Size(100, 23);
			this.lblNivel3.TabIndex = 69;
			this.lblNivel3.Text = "Nível 3";
			this.lblNivel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblNivel5
			// 
			this.lblNivel5.Location = new System.Drawing.Point(601, 336);
			this.lblNivel5.Name = "lblNivel5";
			this.lblNivel5.Size = new System.Drawing.Size(100, 23);
			this.lblNivel5.TabIndex = 70;
			this.lblNivel5.Text = "Nível 5";
			this.lblNivel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblNivel10
			// 
			this.lblNivel10.Location = new System.Drawing.Point(601, 405);
			this.lblNivel10.Name = "lblNivel10";
			this.lblNivel10.Size = new System.Drawing.Size(100, 23);
			this.lblNivel10.TabIndex = 71;
			this.lblNivel10.Text = "Nível 10";
			this.lblNivel10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblRecompensa3
			// 
			this.lblRecompensa3.Location = new System.Drawing.Point(601, 297);
			this.lblRecompensa3.Name = "lblRecompensa3";
			this.lblRecompensa3.Size = new System.Drawing.Size(100, 23);
			this.lblRecompensa3.TabIndex = 72;
			this.lblRecompensa3.Text = "Cor Dourada";
			this.lblRecompensa3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblRecompensa5
			// 
			this.lblRecompensa5.Location = new System.Drawing.Point(560, 359);
			this.lblRecompensa5.Name = "lblRecompensa5";
			this.lblRecompensa5.Size = new System.Drawing.Size(141, 23);
			this.lblRecompensa5.TabIndex = 73;
			this.lblRecompensa5.Text = "Questões Extra Hard";
			this.lblRecompensa5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblRecompensa10
			// 
			this.lblRecompensa10.Location = new System.Drawing.Point(570, 427);
			this.lblRecompensa10.Name = "lblRecompensa10";
			this.lblRecompensa10.Size = new System.Drawing.Size(131, 23);
			this.lblRecompensa10.TabIndex = 74;
			this.lblRecompensa10.Text = "Título Lendário";
			this.lblRecompensa10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnResgatarNivel3
			// 
			this.btnResgatarNivel3.Location = new System.Drawing.Point(453, 274);
			this.btnResgatarNivel3.Name = "btnResgatarNivel3";
			this.btnResgatarNivel3.Size = new System.Drawing.Size(114, 46);
			this.btnResgatarNivel3.TabIndex = 75;
			this.btnResgatarNivel3.Text = "RESGATAR";
			this.btnResgatarNivel3.UseVisualStyleBackColor = true;
			this.btnResgatarNivel3.Click += new System.EventHandler(this.BtnResgatarNivel3Click);
			// 
			// btnResgatarNivel5
			// 
			this.btnResgatarNivel5.Location = new System.Drawing.Point(453, 336);
			this.btnResgatarNivel5.Name = "btnResgatarNivel5";
			this.btnResgatarNivel5.Size = new System.Drawing.Size(114, 46);
			this.btnResgatarNivel5.TabIndex = 76;
			this.btnResgatarNivel5.Text = "RESGATAR";
			this.btnResgatarNivel5.UseVisualStyleBackColor = true;
			this.btnResgatarNivel5.Click += new System.EventHandler(this.BtnResgatarNivel5Click);
			// 
			// btnResgatarNivel10
			// 
			this.btnResgatarNivel10.Location = new System.Drawing.Point(453, 401);
			this.btnResgatarNivel10.Name = "btnResgatarNivel10";
			this.btnResgatarNivel10.Size = new System.Drawing.Size(114, 46);
			this.btnResgatarNivel10.TabIndex = 77;
			this.btnResgatarNivel10.Text = "RESGATAR";
			this.btnResgatarNivel10.UseVisualStyleBackColor = true;
			this.btnResgatarNivel10.Click += new System.EventHandler(this.BtnResgatarNivel10Click);
			// 
			// panelNivel3
			// 
			this.panelNivel3.BackColor = System.Drawing.Color.DarkGray;
			this.panelNivel3.Location = new System.Drawing.Point(722, 274);
			this.panelNivel3.Name = "panelNivel3";
			this.panelNivel3.Size = new System.Drawing.Size(50, 50);
			this.panelNivel3.TabIndex = 78;
			// 
			// panelNivel5
			// 
			this.panelNivel5.BackColor = System.Drawing.Color.DarkGray;
			this.panelNivel5.Location = new System.Drawing.Point(722, 336);
			this.panelNivel5.Name = "panelNivel5";
			this.panelNivel5.Size = new System.Drawing.Size(50, 50);
			this.panelNivel5.TabIndex = 79;
			// 
			// panelNivel10
			// 
			this.panelNivel10.BackColor = System.Drawing.Color.DarkGray;
			this.panelNivel10.Location = new System.Drawing.Point(722, 401);
			this.panelNivel10.Name = "panelNivel10";
			this.panelNivel10.Size = new System.Drawing.Size(50, 50);
			this.panelNivel10.TabIndex = 79;
			// 
			// RecompensasForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(867, 512);
			this.Controls.Add(this.panelNivel10);
			this.Controls.Add(this.panelNivel5);
			this.Controls.Add(this.panelNivel3);
			this.Controls.Add(this.btnResgatarNivel10);
			this.Controls.Add(this.btnResgatarNivel5);
			this.Controls.Add(this.btnResgatarNivel3);
			this.Controls.Add(this.lblRecompensa10);
			this.Controls.Add(this.lblRecompensa5);
			this.Controls.Add(this.lblRecompensa3);
			this.Controls.Add(this.lblNivel10);
			this.Controls.Add(this.lblNivel5);
			this.Controls.Add(this.lblNivel3);
			this.Controls.Add(this.btnComprarCertificado);
			this.Controls.Add(this.lblCertificado);
			this.Controls.Add(this.picRec3);
			this.Controls.Add(this.btnComprarVideo);
			this.Controls.Add(this.lblVideoAula);
			this.Controls.Add(this.picRec2);
			this.Controls.Add(this.btnComprarKitPDF);
			this.Controls.Add(this.lblKitPDF);
			this.Controls.Add(this.picRec1);
			this.Controls.Add(this.lblRecompensasDisponiveis);
			this.Controls.Add(this.lblSuasMoedas);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.picPerfil);
			this.Controls.Add(this.picVoltar);
			this.Controls.Add(this.picLogo);
			this.Name = "RecompensasForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RecompensasForm";
			((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picRec1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picRec2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picRec3)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panelNivel10;
		private System.Windows.Forms.Panel panelNivel5;
		private System.Windows.Forms.Panel panelNivel3;
		private System.Windows.Forms.Button btnResgatarNivel10;
		private System.Windows.Forms.Button btnResgatarNivel5;
		private System.Windows.Forms.Button btnResgatarNivel3;
		private System.Windows.Forms.Label lblRecompensa10;
		private System.Windows.Forms.Label lblRecompensa5;
		private System.Windows.Forms.Label lblRecompensa3;
		private System.Windows.Forms.Label lblNivel10;
		private System.Windows.Forms.Label lblNivel5;
		private System.Windows.Forms.Label lblNivel3;
		private System.Windows.Forms.PictureBox picRec3;
		private System.Windows.Forms.Label lblCertificado;
		private System.Windows.Forms.Button btnComprarCertificado;
		private System.Windows.Forms.PictureBox picRec2;
		private System.Windows.Forms.Label lblVideoAula;
		private System.Windows.Forms.Button btnComprarVideo;
		private System.Windows.Forms.Button btnComprarKitPDF;
		private System.Windows.Forms.Label lblKitPDF;
		private System.Windows.Forms.PictureBox picRec1;
		private System.Windows.Forms.Label lblRecompensasDisponiveis;
		private System.Windows.Forms.Label lblSuasMoedas;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.PictureBox picPerfil;
		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.PictureBox picVoltar;
	}
}
