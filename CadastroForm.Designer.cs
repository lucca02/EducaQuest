/*
 * Created by SharpDevelop.
 * User: Amanda
 * Date: 24/11/2025
 * Time: 19:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EducaQuest
{
	partial class CadastroForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroForm));
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.linkLogin = new System.Windows.Forms.LinkLabel();
			this.lblConta = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblCadastro = new System.Windows.Forms.Label();
			this.picLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Location = new System.Drawing.Point(391, 308);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
			this.btnCadastrar.TabIndex = 31;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrarClick);
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(408, 266);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(162, 20);
			this.txtSenha.TabIndex = 30;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(408, 225);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(162, 20);
			this.txtEmail.TabIndex = 29;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(408, 182);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(162, 20);
			this.txtNome.TabIndex = 28;
			// 
			// linkLogin
			// 
			this.linkLogin.Location = new System.Drawing.Point(448, 352);
			this.linkLogin.Name = "linkLogin";
			this.linkLogin.Size = new System.Drawing.Size(100, 23);
			this.linkLogin.TabIndex = 27;
			this.linkLogin.TabStop = true;
			this.linkLogin.Text = "Fazer log-in";
			this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLoginLinkClicked);
			// 
			// lblConta
			// 
			this.lblConta.Location = new System.Drawing.Point(350, 352);
			this.lblConta.Name = "lblConta";
			this.lblConta.Size = new System.Drawing.Size(144, 23);
			this.lblConta.TabIndex = 26;
			this.lblConta.Text = "Já tem uma conta?";
			// 
			// lblSenha
			// 
			this.lblSenha.Location = new System.Drawing.Point(296, 269);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(100, 23);
			this.lblSenha.TabIndex = 25;
			this.lblSenha.Text = "Digite sua senha:";
			// 
			// lblEmail
			// 
			this.lblEmail.Location = new System.Drawing.Point(296, 228);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(100, 23);
			this.lblEmail.TabIndex = 24;
			this.lblEmail.Text = "Digite seu e-mail:";
			// 
			// lblNome
			// 
			this.lblNome.Location = new System.Drawing.Point(296, 185);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(100, 23);
			this.lblNome.TabIndex = 23;
			this.lblNome.Text = "Digite seu nome:";
			// 
			// lblCadastro
			// 
			this.lblCadastro.Location = new System.Drawing.Point(378, 136);
			this.lblCadastro.Name = "lblCadastro";
			this.lblCadastro.Size = new System.Drawing.Size(100, 23);
			this.lblCadastro.TabIndex = 22;
			this.lblCadastro.Text = "CADASTRO";
			this.lblCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picLogo
			// 
			this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
			this.picLogo.Location = new System.Drawing.Point(12, 53);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(236, 50);
			this.picLogo.TabIndex = 32;
			this.picLogo.TabStop = false;
			// 
			// CadastroForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(867, 512);
			this.Controls.Add(this.picLogo);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.linkLogin);
			this.Controls.Add(this.lblConta);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.lblCadastro);
			this.Name = "CadastroForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CadastroForm";
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.Label lblCadastro;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Label lblConta;
		private System.Windows.Forms.LinkLabel linkLogin;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Button btnCadastrar;
	}
}
