/*
 * Created by SharpDevelop.
 * User: Amanda
 * Date: 24/11/2025
 * Time: 20:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EducaQuest
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.btnEntrar = new System.Windows.Forms.Button();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.linkCadastro = new System.Windows.Forms.LinkLabel();
			this.lblConta = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblLogin = new System.Windows.Forms.Label();
			this.picLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// btnEntrar
			// 
			this.btnEntrar.Location = new System.Drawing.Point(390, 313);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(75, 23);
			this.btnEntrar.TabIndex = 21;
			this.btnEntrar.Text = "Entrar";
			this.btnEntrar.UseVisualStyleBackColor = true;
			this.btnEntrar.Click += new System.EventHandler(this.BtnEntrarClick);
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(407, 271);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(162, 20);
			this.txtSenha.TabIndex = 20;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(407, 230);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(162, 20);
			this.txtEmail.TabIndex = 19;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(407, 187);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(162, 20);
			this.txtNome.TabIndex = 18;
			// 
			// linkCadastro
			// 
			this.linkCadastro.Location = new System.Drawing.Point(469, 358);
			this.linkCadastro.Name = "linkCadastro";
			this.linkCadastro.Size = new System.Drawing.Size(100, 23);
			this.linkCadastro.TabIndex = 17;
			this.linkCadastro.TabStop = true;
			this.linkCadastro.Text = "Cadastre-se";
			this.linkCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCadastroLinkClicked);
			// 
			// lblConta
			// 
			this.lblConta.Location = new System.Drawing.Point(333, 358);
			this.lblConta.Name = "lblConta";
			this.lblConta.Size = new System.Drawing.Size(144, 23);
			this.lblConta.TabIndex = 16;
			this.lblConta.Text = "Ainda não criou uma conta?";
			// 
			// lblSenha
			// 
			this.lblSenha.Location = new System.Drawing.Point(295, 274);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(100, 23);
			this.lblSenha.TabIndex = 15;
			this.lblSenha.Text = "Digite sua senha:";
			// 
			// lblEmail
			// 
			this.lblEmail.Location = new System.Drawing.Point(295, 233);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(100, 23);
			this.lblEmail.TabIndex = 14;
			this.lblEmail.Text = "Digite seu e-mail:";
			// 
			// lblNome
			// 
			this.lblNome.Location = new System.Drawing.Point(295, 190);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(100, 23);
			this.lblNome.TabIndex = 13;
			this.lblNome.Text = "Digite seu nome:";
			// 
			// lblLogin
			// 
			this.lblLogin.Location = new System.Drawing.Point(377, 141);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(100, 23);
			this.lblLogin.TabIndex = 12;
			this.lblLogin.Text = "LOG-IN";
			this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picLogo
			// 
			this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
			this.picLogo.Location = new System.Drawing.Point(12, 53);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(236, 50);
			this.picLogo.TabIndex = 11;
			this.picLogo.TabStop = false;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(867, 512);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.linkCadastro);
			this.Controls.Add(this.lblConta);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.lblLogin);
			this.Controls.Add(this.picLogo);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblLogin;
		private System.Windows.Forms.LinkLabel linkCadastro;
		private System.Windows.Forms.Button btnEntrar;
		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Label lblConta;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtSenha;
	}
}
