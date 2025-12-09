/*
 * Created by SharpDevelop.
 * User: Amanda
 * Date: 04/12/2025
 * Time: 18:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EducaQuest
{
	partial class AlterarSenhaForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarSenhaForm));
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblSenhaAtual = new System.Windows.Forms.Label();
			this.lblNovaSenha = new System.Windows.Forms.Label();
			this.lblConfirmarSenha = new System.Windows.Forms.Label();
			this.txtSenhaAtual = new System.Windows.Forms.TextBox();
			this.txtNovaSenha = new System.Windows.Forms.TextBox();
			this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.picVoltar = new System.Windows.Forms.PictureBox();
			this.picLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(396, 94);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(100, 23);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Alterar Senha";
			// 
			// lblSenhaAtual
			// 
			this.lblSenhaAtual.Location = new System.Drawing.Point(315, 173);
			this.lblSenhaAtual.Name = "lblSenhaAtual";
			this.lblSenhaAtual.Size = new System.Drawing.Size(100, 23);
			this.lblSenhaAtual.TabIndex = 1;
			this.lblSenhaAtual.Text = "Senha Atual:";
			// 
			// lblNovaSenha
			// 
			this.lblNovaSenha.Location = new System.Drawing.Point(315, 221);
			this.lblNovaSenha.Name = "lblNovaSenha";
			this.lblNovaSenha.Size = new System.Drawing.Size(100, 23);
			this.lblNovaSenha.TabIndex = 2;
			this.lblNovaSenha.Text = "Nova Senha:";
			// 
			// lblConfirmarSenha
			// 
			this.lblConfirmarSenha.Location = new System.Drawing.Point(269, 266);
			this.lblConfirmarSenha.Name = "lblConfirmarSenha";
			this.lblConfirmarSenha.Size = new System.Drawing.Size(134, 23);
			this.lblConfirmarSenha.TabIndex = 3;
			this.lblConfirmarSenha.Text = "Confirmar Nova Senha:";
			// 
			// txtSenhaAtual
			// 
			this.txtSenhaAtual.Location = new System.Drawing.Point(396, 170);
			this.txtSenhaAtual.Name = "txtSenhaAtual";
			this.txtSenhaAtual.PasswordChar = '*';
			this.txtSenhaAtual.Size = new System.Drawing.Size(136, 20);
			this.txtSenhaAtual.TabIndex = 4;
			// 
			// txtNovaSenha
			// 
			this.txtNovaSenha.Location = new System.Drawing.Point(396, 218);
			this.txtNovaSenha.Name = "txtNovaSenha";
			this.txtNovaSenha.PasswordChar = '*';
			this.txtNovaSenha.Size = new System.Drawing.Size(136, 20);
			this.txtNovaSenha.TabIndex = 5;
			// 
			// txtConfirmarSenha
			// 
			this.txtConfirmarSenha.Location = new System.Drawing.Point(396, 263);
			this.txtConfirmarSenha.Name = "txtConfirmarSenha";
			this.txtConfirmarSenha.PasswordChar = '*';
			this.txtConfirmarSenha.Size = new System.Drawing.Size(136, 20);
			this.txtConfirmarSenha.TabIndex = 6;
			// 
			// btnAlterar
			// 
			this.btnAlterar.Location = new System.Drawing.Point(269, 331);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(107, 43);
			this.btnAlterar.TabIndex = 7;
			this.btnAlterar.Text = "ALTERAR";
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.BtnAlterarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(425, 331);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(107, 43);
			this.btnCancelar.TabIndex = 8;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// picVoltar
			// 
			this.picVoltar.Image = ((System.Drawing.Image)(resources.GetObject("picVoltar.Image")));
			this.picVoltar.Location = new System.Drawing.Point(3, -3);
			this.picVoltar.Name = "picVoltar";
			this.picVoltar.Size = new System.Drawing.Size(100, 50);
			this.picVoltar.TabIndex = 16;
			this.picVoltar.TabStop = false;
			this.picVoltar.Click += new System.EventHandler(this.PicVoltarClick);
			// 
			// picLogo
			// 
			this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
			this.picLogo.Location = new System.Drawing.Point(12, 53);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(236, 50);
			this.picLogo.TabIndex = 15;
			this.picLogo.TabStop = false;
			// 
			// AlterarSenhaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(867, 512);
			this.Controls.Add(this.picVoltar);
			this.Controls.Add(this.picLogo);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.txtConfirmarSenha);
			this.Controls.Add(this.txtNovaSenha);
			this.Controls.Add(this.txtSenhaAtual);
			this.Controls.Add(this.lblConfirmarSenha);
			this.Controls.Add(this.lblNovaSenha);
			this.Controls.Add(this.lblSenhaAtual);
			this.Controls.Add(this.lblTitulo);
			this.Name = "AlterarSenhaForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AlterarSenhaForm";
			((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.PictureBox picVoltar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.TextBox txtConfirmarSenha;
		private System.Windows.Forms.TextBox txtNovaSenha;
		private System.Windows.Forms.TextBox txtSenhaAtual;
		private System.Windows.Forms.Label lblConfirmarSenha;
		private System.Windows.Forms.Label lblNovaSenha;
		private System.Windows.Forms.Label lblSenhaAtual;
		private System.Windows.Forms.Label lblTitulo;
	}
}
