/*
 * Criado por SharpDevelop.
 * Usuário: Valdelis
 * Data: 05/12/2016
 * Hora: 07:54
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace SysDeCompany.Formularios
{
	partial class frmQuantidade
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuantidade));
			this.grbPrincipal = new System.Windows.Forms.GroupBox();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnIncluir = new System.Windows.Forms.Button();
			this.txtQtd = new System.Windows.Forms.TextBox();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.grbPrincipal.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbPrincipal
			// 
			this.grbPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.grbPrincipal.Controls.Add(this.btnSair);
			this.grbPrincipal.Controls.Add(this.btnIncluir);
			this.grbPrincipal.Controls.Add(this.txtQtd);
			this.grbPrincipal.Controls.Add(this.lblCodigo);
			this.grbPrincipal.Location = new System.Drawing.Point(3, 1);
			this.grbPrincipal.Name = "grbPrincipal";
			this.grbPrincipal.Size = new System.Drawing.Size(311, 160);
			this.grbPrincipal.TabIndex = 0;
			this.grbPrincipal.TabStop = false;
			// 
			// btnSair
			// 
			this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
			this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.Location = new System.Drawing.Point(173, 58);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(100, 96);
			this.btnSair.TabIndex = 10;
			this.btnSair.Text = "Sair";
			this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// btnIncluir
			// 
			this.btnIncluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncluir.BackgroundImage")));
			this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIncluir.Location = new System.Drawing.Point(25, 58);
			this.btnIncluir.Name = "btnIncluir";
			this.btnIncluir.Size = new System.Drawing.Size(100, 96);
			this.btnIncluir.TabIndex = 9;
			this.btnIncluir.Text = "Incluir";
			this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnIncluir.UseVisualStyleBackColor = true;
			this.btnIncluir.Click += new System.EventHandler(this.BtnIncluirClick);
			// 
			// txtQtd
			// 
			this.txtQtd.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQtd.Location = new System.Drawing.Point(159, 17);
			this.txtQtd.MaxLength = 4;
			this.txtQtd.Name = "txtQtd";
			this.txtQtd.Size = new System.Drawing.Size(114, 29);
			this.txtQtd.TabIndex = 3;
			// 
			// lblCodigo
			// 
			this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCodigo.Location = new System.Drawing.Point(25, 19);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(157, 35);
			this.lblCodigo.TabIndex = 2;
			this.lblCodigo.Text = "Quantidade : ";
			// 
			// frmQuantidade
			// 
			this.AcceptButton = this.btnIncluir;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnSair;
			this.ClientSize = new System.Drawing.Size(320, 164);
			this.Controls.Add(this.grbPrincipal);
			this.Name = "frmQuantidade";
			this.Text = "frmQuantidade";
			this.grbPrincipal.ResumeLayout(false);
			this.grbPrincipal.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnSair;
		public System.Windows.Forms.Button btnIncluir;
		private System.Windows.Forms.Label lblCodigo;
		public System.Windows.Forms.TextBox txtQtd;
		private System.Windows.Forms.GroupBox grbPrincipal;
	}
}
