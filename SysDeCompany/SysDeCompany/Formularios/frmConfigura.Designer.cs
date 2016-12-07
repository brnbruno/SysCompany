/*
 * Created by SharpDevelop.
 * User: MAQLAB
 * Date: 23/11/2016
 * Time: 14:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DcompanySys
{
	partial class frmConfigura
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigura));
			this.grbPrincipal = new System.Windows.Forms.GroupBox();
			this.btnRestarCor = new System.Windows.Forms.Button();
			this.grbCorFormulario = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbfontform = new System.Windows.Forms.Label();
			this.btnCorFonteForm = new System.Windows.Forms.Button();
			this.pbCordoFormulario = new System.Windows.Forms.PictureBox();
			this.btnCorDoFormulario = new System.Windows.Forms.Button();
			this.pbLogoEmpresa = new System.Windows.Forms.PictureBox();
			this.btnFechar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.btnBuscaImagem = new System.Windows.Forms.Button();
			this.txtNomedaEmpresa = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.JaneladeCor = new System.Windows.Forms.ColorDialog();
			this.buscaArquivo = new System.Windows.Forms.OpenFileDialog();
			this.grbPrincipal.SuspendLayout();
			this.grbCorFormulario.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCordoFormulario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoEmpresa)).BeginInit();
			this.SuspendLayout();
			// 
			// grbPrincipal
			// 
			this.grbPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.grbPrincipal.Controls.Add(this.btnRestarCor);
			this.grbPrincipal.Controls.Add(this.grbCorFormulario);
			this.grbPrincipal.Controls.Add(this.pbLogoEmpresa);
			this.grbPrincipal.Controls.Add(this.btnFechar);
			this.grbPrincipal.Controls.Add(this.btnSalvar);
			this.grbPrincipal.Controls.Add(this.textBox2);
			this.grbPrincipal.Controls.Add(this.btnBuscaImagem);
			this.grbPrincipal.Controls.Add(this.txtNomedaEmpresa);
			this.grbPrincipal.Controls.Add(this.label1);
			this.grbPrincipal.Location = new System.Drawing.Point(12, 12);
			this.grbPrincipal.Name = "grbPrincipal";
			this.grbPrincipal.Size = new System.Drawing.Size(377, 437);
			this.grbPrincipal.TabIndex = 0;
			this.grbPrincipal.TabStop = false;
			// 
			// btnRestarCor
			// 
			this.btnRestarCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRestarCor.Location = new System.Drawing.Point(29, 318);
			this.btnRestarCor.Name = "btnRestarCor";
			this.btnRestarCor.Size = new System.Drawing.Size(85, 39);
			this.btnRestarCor.TabIndex = 3;
			this.btnRestarCor.Text = "Cor Padrão";
			this.btnRestarCor.UseVisualStyleBackColor = true;
			this.btnRestarCor.Click += new System.EventHandler(this.BtnRestarCorClick);
			// 
			// grbCorFormulario
			// 
			this.grbCorFormulario.Controls.Add(this.label6);
			this.grbCorFormulario.Controls.Add(this.label5);
			this.grbCorFormulario.Controls.Add(this.lbfontform);
			this.grbCorFormulario.Controls.Add(this.btnCorFonteForm);
			this.grbCorFormulario.Controls.Add(this.pbCordoFormulario);
			this.grbCorFormulario.Controls.Add(this.btnCorDoFormulario);
			this.grbCorFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbCorFormulario.Location = new System.Drawing.Point(23, 204);
			this.grbCorFormulario.Name = "grbCorFormulario";
			this.grbCorFormulario.Size = new System.Drawing.Size(337, 108);
			this.grbCorFormulario.TabIndex = 12;
			this.grbCorFormulario.TabStop = false;
			this.grbCorFormulario.Text = "Cor do formulário";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(221, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Cor Fonte Formulário";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(221, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Cor fundo Formulário";
			// 
			// lbfontform
			// 
			this.lbfontform.AutoSize = true;
			this.lbfontform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lbfontform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbfontform.ForeColor = System.Drawing.Color.White;
			this.lbfontform.Location = new System.Drawing.Point(197, 54);
			this.lbfontform.Name = "lbfontform";
			this.lbfontform.Size = new System.Drawing.Size(21, 20);
			this.lbfontform.TabIndex = 9;
			this.lbfontform.Text = "A";
			// 
			// btnCorFonteForm
			// 
			this.btnCorFonteForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCorFonteForm.Location = new System.Drawing.Point(97, 19);
			this.btnCorFonteForm.Name = "btnCorFonteForm";
			this.btnCorFonteForm.Size = new System.Drawing.Size(85, 83);
			this.btnCorFonteForm.TabIndex = 1;
			this.btnCorFonteForm.Text = "Cor Fonte do Formulário";
			this.btnCorFonteForm.UseVisualStyleBackColor = true;
			this.btnCorFonteForm.Click += new System.EventHandler(this.BtnCorFonteFormClick);
			// 
			// pbCordoFormulario
			// 
			this.pbCordoFormulario.BackColor = System.Drawing.Color.White;
			this.pbCordoFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbCordoFormulario.Location = new System.Drawing.Point(197, 22);
			this.pbCordoFormulario.Name = "pbCordoFormulario";
			this.pbCordoFormulario.Size = new System.Drawing.Size(21, 21);
			this.pbCordoFormulario.TabIndex = 5;
			this.pbCordoFormulario.TabStop = false;
			// 
			// btnCorDoFormulario
			// 
			this.btnCorDoFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCorDoFormulario.Location = new System.Drawing.Point(6, 19);
			this.btnCorDoFormulario.Name = "btnCorDoFormulario";
			this.btnCorDoFormulario.Size = new System.Drawing.Size(85, 83);
			this.btnCorDoFormulario.TabIndex = 0;
			this.btnCorDoFormulario.Text = "Cor Do Formulário";
			this.btnCorDoFormulario.UseVisualStyleBackColor = true;
			this.btnCorDoFormulario.Click += new System.EventHandler(this.BtnCorDoFormularioClick);
			// 
			// pbLogoEmpresa
			// 
			this.pbLogoEmpresa.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pbLogoEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbLogoEmpresa.Location = new System.Drawing.Point(18, 19);
			this.pbLogoEmpresa.Name = "pbLogoEmpresa";
			this.pbLogoEmpresa.Size = new System.Drawing.Size(133, 120);
			this.pbLogoEmpresa.TabIndex = 10;
			this.pbLogoEmpresa.TabStop = false;
			// 
			// btnFechar
			// 
			this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
			this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechar.Location = new System.Drawing.Point(271, 335);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(100, 96);
			this.btnFechar.TabIndex = 5;
			this.btnFechar.Text = "Fechar";
			this.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.BtnFecharClick);
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
			this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Location = new System.Drawing.Point(168, 335);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(100, 96);
			this.btnSalvar.TabIndex = 4;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.BtnSalvarClick);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(23, 452);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 6;
			this.textBox2.Visible = false;
			// 
			// btnBuscaImagem
			// 
			this.btnBuscaImagem.Location = new System.Drawing.Point(157, 64);
			this.btnBuscaImagem.Name = "btnBuscaImagem";
			this.btnBuscaImagem.Size = new System.Drawing.Size(75, 75);
			this.btnBuscaImagem.TabIndex = 0;
			this.btnBuscaImagem.Text = "Procurar Logo ";
			this.btnBuscaImagem.UseVisualStyleBackColor = true;
			this.btnBuscaImagem.Click += new System.EventHandler(this.BtnBuscaImagemClick);
			// 
			// txtNomedaEmpresa
			// 
			this.txtNomedaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNomedaEmpresa.Location = new System.Drawing.Point(23, 168);
			this.txtNomedaEmpresa.Name = "txtNomedaEmpresa";
			this.txtNomedaEmpresa.Size = new System.Drawing.Size(306, 30);
			this.txtNomedaEmpresa.TabIndex = 1;
			this.txtNomedaEmpresa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNomedaEmpresaKeyDown);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(17, 142);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome da Empresa:";
			// 
			// frmConfigura
			// 
			this.AcceptButton = this.btnSalvar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnFechar;
			this.ClientSize = new System.Drawing.Size(401, 461);
			this.ControlBox = false;
			this.Controls.Add(this.grbPrincipal);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmConfigura";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Configuração";
			this.Load += new System.EventHandler(this.FrmConfiguraLoad);
			this.grbPrincipal.ResumeLayout(false);
			this.grbPrincipal.PerformLayout();
			this.grbCorFormulario.ResumeLayout(false);
			this.grbCorFormulario.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCordoFormulario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoEmpresa)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnRestarCor;
		private System.Windows.Forms.Button btnCorDoFormulario;
		public System.Windows.Forms.PictureBox pbCordoFormulario;
		private System.Windows.Forms.Button btnCorFonteForm;
		public System.Windows.Forms.Label lbfontform;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox grbCorFormulario;
		private System.Windows.Forms.PictureBox pbLogoEmpresa;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.OpenFileDialog buscaArquivo;
		private System.Windows.Forms.Button btnBuscaImagem;
		private System.Windows.Forms.ColorDialog JaneladeCor;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txtNomedaEmpresa;
		private System.Windows.Forms.GroupBox grbPrincipal;
		
		
	}
}
