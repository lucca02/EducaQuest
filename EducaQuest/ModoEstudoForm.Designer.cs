/*
 * Created by SharpDevelop.
 * User: Amanda
 * Date: 04/12/2025
 * Time: 19:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EducaQuest
{
	partial class ModoEstudoForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModoEstudoForm));
			this.picVoltar = new System.Windows.Forms.PictureBox();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.picPerfil = new System.Windows.Forms.PictureBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblMatematica = new System.Windows.Forms.Label();
			this.lblPortugues = new System.Windows.Forms.Label();
			this.lblCiencias = new System.Windows.Forms.Label();
			this.lblEmBreve = new System.Windows.Forms.Label();
			this.btnMatFacil = new System.Windows.Forms.Button();
			this.btnPortFacil = new System.Windows.Forms.Button();
			this.btnCienFacil = new System.Windows.Forms.Button();
			this.btnMatMedio = new System.Windows.Forms.Button();
			this.btnPortMedio = new System.Windows.Forms.Button();
			this.btnCienMedio = new System.Windows.Forms.Button();
			this.btnMatDificil = new System.Windows.Forms.Button();
			this.btnPortDificil = new System.Windows.Forms.Button();
			this.btnCienDificil = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.btnExtraHard = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPerfil)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// picVoltar
			// 
			this.picVoltar.Image = ((System.Drawing.Image)(resources.GetObject("picVoltar.Image")));
			this.picVoltar.Location = new System.Drawing.Point(3, -3);
			this.picVoltar.Name = "picVoltar";
			this.picVoltar.Size = new System.Drawing.Size(100, 50);
			this.picVoltar.TabIndex = 18;
			this.picVoltar.TabStop = false;
			this.picVoltar.Click += new System.EventHandler(this.PicVoltarClick);
			// 
			// picLogo
			// 
			this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
			this.picLogo.Location = new System.Drawing.Point(12, 53);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(236, 50);
			this.picLogo.TabIndex = 17;
			this.picLogo.TabStop = false;
			// 
			// picPerfil
			// 
			this.picPerfil.Image = ((System.Drawing.Image)(resources.GetObject("picPerfil.Image")));
			this.picPerfil.Location = new System.Drawing.Point(790, 54);
			this.picPerfil.Name = "picPerfil";
			this.picPerfil.Size = new System.Drawing.Size(40, 40);
			this.picPerfil.TabIndex = 53;
			this.picPerfil.TabStop = false;
			this.picPerfil.Click += new System.EventHandler(this.PicPerfilClick);
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(347, 131);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(201, 23);
			this.lblTitulo.TabIndex = 54;
			this.lblTitulo.Text = "Modo de Estudo Rápido";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMatematica
			// 
			this.lblMatematica.Location = new System.Drawing.Point(82, 201);
			this.lblMatematica.Name = "lblMatematica";
			this.lblMatematica.Size = new System.Drawing.Size(129, 23);
			this.lblMatematica.TabIndex = 55;
			this.lblMatematica.Text = "Matemática";
			// 
			// lblPortugues
			// 
			this.lblPortugues.Location = new System.Drawing.Point(82, 281);
			this.lblPortugues.Name = "lblPortugues";
			this.lblPortugues.Size = new System.Drawing.Size(129, 23);
			this.lblPortugues.TabIndex = 56;
			this.lblPortugues.Text = "Português";
			// 
			// lblCiencias
			// 
			this.lblCiencias.Location = new System.Drawing.Point(82, 358);
			this.lblCiencias.Name = "lblCiencias";
			this.lblCiencias.Size = new System.Drawing.Size(129, 23);
			this.lblCiencias.TabIndex = 57;
			this.lblCiencias.Text = "Ciências";
			// 
			// lblEmBreve
			// 
			this.lblEmBreve.Location = new System.Drawing.Point(47, 450);
			this.lblEmBreve.Name = "lblEmBreve";
			this.lblEmBreve.Size = new System.Drawing.Size(129, 23);
			this.lblEmBreve.TabIndex = 58;
			this.lblEmBreve.Text = "Em breve mais matérias!";
			// 
			// btnMatFacil
			// 
			this.btnMatFacil.Location = new System.Drawing.Point(47, 227);
			this.btnMatFacil.Name = "btnMatFacil";
			this.btnMatFacil.Size = new System.Drawing.Size(153, 42);
			this.btnMatFacil.TabIndex = 59;
			this.btnMatFacil.Text = "FÁCIL";
			this.btnMatFacil.UseVisualStyleBackColor = true;
			this.btnMatFacil.Click += new System.EventHandler(this.BtnMatFacilClick);
			// 
			// btnPortFacil
			// 
			this.btnPortFacil.Location = new System.Drawing.Point(47, 307);
			this.btnPortFacil.Name = "btnPortFacil";
			this.btnPortFacil.Size = new System.Drawing.Size(153, 42);
			this.btnPortFacil.TabIndex = 60;
			this.btnPortFacil.Text = "FÁCIL";
			this.btnPortFacil.UseVisualStyleBackColor = true;
			this.btnPortFacil.Click += new System.EventHandler(this.BtnPortFacilClick);
			// 
			// btnCienFacil
			// 
			this.btnCienFacil.Location = new System.Drawing.Point(47, 384);
			this.btnCienFacil.Name = "btnCienFacil";
			this.btnCienFacil.Size = new System.Drawing.Size(153, 42);
			this.btnCienFacil.TabIndex = 61;
			this.btnCienFacil.Text = "FÁCIL";
			this.btnCienFacil.UseVisualStyleBackColor = true;
			this.btnCienFacil.Click += new System.EventHandler(this.BtnCienFacilClick);
			// 
			// btnMatMedio
			// 
			this.btnMatMedio.Location = new System.Drawing.Point(224, 227);
			this.btnMatMedio.Name = "btnMatMedio";
			this.btnMatMedio.Size = new System.Drawing.Size(153, 42);
			this.btnMatMedio.TabIndex = 62;
			this.btnMatMedio.Text = "MÉDIO";
			this.btnMatMedio.UseVisualStyleBackColor = true;
			this.btnMatMedio.Click += new System.EventHandler(this.BtnMatMedioClick);
			// 
			// btnPortMedio
			// 
			this.btnPortMedio.Location = new System.Drawing.Point(224, 307);
			this.btnPortMedio.Name = "btnPortMedio";
			this.btnPortMedio.Size = new System.Drawing.Size(153, 42);
			this.btnPortMedio.TabIndex = 63;
			this.btnPortMedio.Text = "MÉDIO";
			this.btnPortMedio.UseVisualStyleBackColor = true;
			this.btnPortMedio.Click += new System.EventHandler(this.BtnPortMedioClick);
			// 
			// btnCienMedio
			// 
			this.btnCienMedio.Location = new System.Drawing.Point(224, 384);
			this.btnCienMedio.Name = "btnCienMedio";
			this.btnCienMedio.Size = new System.Drawing.Size(153, 42);
			this.btnCienMedio.TabIndex = 64;
			this.btnCienMedio.Text = "MÉDIO";
			this.btnCienMedio.UseVisualStyleBackColor = true;
			this.btnCienMedio.Click += new System.EventHandler(this.BtnCienMedioClick);
			// 
			// btnMatDificil
			// 
			this.btnMatDificil.Location = new System.Drawing.Point(405, 227);
			this.btnMatDificil.Name = "btnMatDificil";
			this.btnMatDificil.Size = new System.Drawing.Size(153, 42);
			this.btnMatDificil.TabIndex = 65;
			this.btnMatDificil.Text = "DIFÍCIL";
			this.btnMatDificil.UseVisualStyleBackColor = true;
			this.btnMatDificil.Click += new System.EventHandler(this.BtnMatDificilClick);
			// 
			// btnPortDificil
			// 
			this.btnPortDificil.Location = new System.Drawing.Point(405, 307);
			this.btnPortDificil.Name = "btnPortDificil";
			this.btnPortDificil.Size = new System.Drawing.Size(153, 42);
			this.btnPortDificil.TabIndex = 66;
			this.btnPortDificil.Text = "DIFÍCIL";
			this.btnPortDificil.UseVisualStyleBackColor = true;
			this.btnPortDificil.Click += new System.EventHandler(this.BtnPortDificilClick);
			// 
			// btnCienDificil
			// 
			this.btnCienDificil.Location = new System.Drawing.Point(405, 384);
			this.btnCienDificil.Name = "btnCienDificil";
			this.btnCienDificil.Size = new System.Drawing.Size(153, 42);
			this.btnCienDificil.TabIndex = 67;
			this.btnCienDificil.Text = "DIFÍCIL";
			this.btnCienDificil.UseVisualStyleBackColor = true;
			this.btnCienDificil.Click += new System.EventHandler(this.BtnCienDificilClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(47, 186);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(31, 38);
			this.pictureBox1.TabIndex = 68;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(45, 348);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(31, 33);
			this.pictureBox2.TabIndex = 69;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(47, 275);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(31, 29);
			this.pictureBox3.TabIndex = 69;
			this.pictureBox3.TabStop = false;
			// 
			// btnExtraHard
			// 
			this.btnExtraHard.BackColor = System.Drawing.Color.Maroon;
			this.btnExtraHard.ForeColor = System.Drawing.SystemColors.Control;
			this.btnExtraHard.Location = new System.Drawing.Point(614, 307);
			this.btnExtraHard.Name = "btnExtraHard";
			this.btnExtraHard.Size = new System.Drawing.Size(153, 42);
			this.btnExtraHard.TabIndex = 70;
			this.btnExtraHard.Text = "EXTRA HARD";
			this.btnExtraHard.UseVisualStyleBackColor = false;
			this.btnExtraHard.Visible = false;
			// 
			// ModoEstudoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(867, 512);
			this.Controls.Add(this.btnExtraHard);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnCienDificil);
			this.Controls.Add(this.btnPortDificil);
			this.Controls.Add(this.btnMatDificil);
			this.Controls.Add(this.btnCienMedio);
			this.Controls.Add(this.btnPortMedio);
			this.Controls.Add(this.btnMatMedio);
			this.Controls.Add(this.btnCienFacil);
			this.Controls.Add(this.btnPortFacil);
			this.Controls.Add(this.btnMatFacil);
			this.Controls.Add(this.lblEmBreve);
			this.Controls.Add(this.lblCiencias);
			this.Controls.Add(this.lblPortugues);
			this.Controls.Add(this.lblMatematica);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.picPerfil);
			this.Controls.Add(this.picVoltar);
			this.Controls.Add(this.picLogo);
			this.Name = "ModoEstudoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ModoEstudoForm";
			((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPerfil)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnCienDificil;
		private System.Windows.Forms.Button btnPortDificil;
		private System.Windows.Forms.Button btnMatDificil;
		private System.Windows.Forms.Button btnCienMedio;
		private System.Windows.Forms.Button btnPortMedio;
		private System.Windows.Forms.Button btnMatMedio;
		private System.Windows.Forms.Button btnCienFacil;
		private System.Windows.Forms.Button btnPortFacil;
		private System.Windows.Forms.Button btnMatFacil;
		private System.Windows.Forms.Label lblEmBreve;
		private System.Windows.Forms.Label lblCiencias;
		private System.Windows.Forms.Label lblPortugues;
		private System.Windows.Forms.Label lblMatematica;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.PictureBox picPerfil;
		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.PictureBox picVoltar;
	}
}
