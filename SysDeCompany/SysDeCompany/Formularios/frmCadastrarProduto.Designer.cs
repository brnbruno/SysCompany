/*
 * Criado por SharpDevelop.
 * Usuário: Valdelis
 * Data: 12/11/2016
 * Hora: 21:04
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace DcompanySys
{
	partial class frmCadastrarProduto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarProduto));
			this.pbLogoEmpresa = new System.Windows.Forms.PictureBox();
			this.lblNomeEmpresa = new System.Windows.Forms.Label();
			this.lblProduto = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnIncluir = new System.Windows.Forms.Button();
			this.grbInfoProduto = new System.Windows.Forms.GroupBox();
			this.txtFornecedor = new System.Windows.Forms.TextBox();
			this.btnLimparImagem = new System.Windows.Forms.Button();
			this.btnBuscaImagem = new System.Windows.Forms.Button();
			this.pbImagem = new System.Windows.Forms.PictureBox();
			this.txtValorCompra = new System.Windows.Forms.TextBox();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.txtValorVenda = new System.Windows.Forms.TextBox();
			this.txtQuantidade = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblNomeOuRazao = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.grbPrincipal = new System.Windows.Forms.GroupBox();
			this.lblAviso = new System.Windows.Forms.Label();
			this.buscaArquivo = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoEmpresa)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.grbInfoProduto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
			this.grbPrincipal.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbLogoEmpresa
			// 
			this.pbLogoEmpresa.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pbLogoEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbLogoEmpresa.Location = new System.Drawing.Point(15, 19);
			this.pbLogoEmpresa.Name = "pbLogoEmpresa";
			this.pbLogoEmpresa.Size = new System.Drawing.Size(133, 120);
			this.pbLogoEmpresa.TabIndex = 0;
			this.pbLogoEmpresa.TabStop = false;
			// 
			// lblNomeEmpresa
			// 
			this.lblNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeEmpresa.Location = new System.Drawing.Point(163, 19);
			this.lblNomeEmpresa.Name = "lblNomeEmpresa";
			this.lblNomeEmpresa.Size = new System.Drawing.Size(509, 52);
			this.lblNomeEmpresa.TabIndex = 1;
			this.lblNomeEmpresa.Text = "Nome Empresa";
			// 
			// lblProduto
			// 
			this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProduto.Location = new System.Drawing.Point(220, 94);
			this.lblProduto.Name = "lblProduto";
			this.lblProduto.Size = new System.Drawing.Size(319, 45);
			this.lblProduto.TabIndex = 2;
			this.lblProduto.Text = "Cadastrar Produto";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.Controls.Add(this.btnSair);
			this.flowLayoutPanel1.Controls.Add(this.btnAlterar);
			this.flowLayoutPanel1.Controls.Add(this.btnExcluir);
			this.flowLayoutPanel1.Controls.Add(this.btnIncluir);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(586, 463);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(425, 100);
			this.flowLayoutPanel1.TabIndex = 6;
			// 
			// btnSair
			// 
			this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
			this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.Location = new System.Drawing.Point(322, 3);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(100, 96);
			this.btnSair.TabIndex = 4;
			this.btnSair.Text = "Sair";
			this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// btnAlterar
			// 
			this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
			this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.Location = new System.Drawing.Point(216, 3);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(100, 96);
			this.btnAlterar.TabIndex = 5;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAlterar.UseVisualStyleBackColor = true;
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
			this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Location = new System.Drawing.Point(110, 3);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(100, 96);
			this.btnExcluir.TabIndex = 6;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnExcluir.UseVisualStyleBackColor = true;
			// 
			// btnIncluir
			// 
			this.btnIncluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncluir.BackgroundImage")));
			this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIncluir.Location = new System.Drawing.Point(4, 3);
			this.btnIncluir.Name = "btnIncluir";
			this.btnIncluir.Size = new System.Drawing.Size(100, 96);
			this.btnIncluir.TabIndex = 7;
			this.btnIncluir.Text = "Incluir";
			this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnIncluir.UseVisualStyleBackColor = true;
			this.btnIncluir.Click += new System.EventHandler(this.BtnIncluirClick);
			// 
			// grbInfoProduto
			// 
			this.grbInfoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.grbInfoProduto.Controls.Add(this.txtFornecedor);
			this.grbInfoProduto.Controls.Add(this.btnLimparImagem);
			this.grbInfoProduto.Controls.Add(this.btnBuscaImagem);
			this.grbInfoProduto.Controls.Add(this.pbImagem);
			this.grbInfoProduto.Controls.Add(this.txtValorCompra);
			this.grbInfoProduto.Controls.Add(this.txtMarca);
			this.grbInfoProduto.Controls.Add(this.txtValorVenda);
			this.grbInfoProduto.Controls.Add(this.txtQuantidade);
			this.grbInfoProduto.Controls.Add(this.label5);
			this.grbInfoProduto.Controls.Add(this.label4);
			this.grbInfoProduto.Controls.Add(this.label3);
			this.grbInfoProduto.Controls.Add(this.label2);
			this.grbInfoProduto.Controls.Add(this.label1);
			this.grbInfoProduto.Controls.Add(this.txtNome);
			this.grbInfoProduto.Controls.Add(this.lblNomeOuRazao);
			this.grbInfoProduto.Controls.Add(this.txtCodigo);
			this.grbInfoProduto.Controls.Add(this.lblCodigo);
			this.grbInfoProduto.Location = new System.Drawing.Point(33, 175);
			this.grbInfoProduto.Name = "grbInfoProduto";
			this.grbInfoProduto.Size = new System.Drawing.Size(966, 277);
			this.grbInfoProduto.TabIndex = 7;
			this.grbInfoProduto.TabStop = false;
			// 
			// txtFornecedor
			// 
			this.txtFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFornecedor.Location = new System.Drawing.Point(460, 106);
			this.txtFornecedor.MaxLength = 20;
			this.txtFornecedor.Name = "txtFornecedor";
			this.txtFornecedor.Size = new System.Drawing.Size(246, 26);
			this.txtFornecedor.TabIndex = 43;
			// 
			// btnLimparImagem
			// 
			this.btnLimparImagem.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnLimparImagem.Location = new System.Drawing.Point(725, 192);
			this.btnLimparImagem.Name = "btnLimparImagem";
			this.btnLimparImagem.Size = new System.Drawing.Size(90, 69);
			this.btnLimparImagem.TabIndex = 42;
			this.btnLimparImagem.Text = "Limpar Imagem";
			this.btnLimparImagem.UseVisualStyleBackColor = true;
			this.btnLimparImagem.Click += new System.EventHandler(this.BtnLimparImagemClick);
			// 
			// btnBuscaImagem
			// 
			this.btnBuscaImagem.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnBuscaImagem.Location = new System.Drawing.Point(821, 192);
			this.btnBuscaImagem.Name = "btnBuscaImagem";
			this.btnBuscaImagem.Size = new System.Drawing.Size(90, 69);
			this.btnBuscaImagem.TabIndex = 41;
			this.btnBuscaImagem.Text = "Busca Imagem";
			this.btnBuscaImagem.UseVisualStyleBackColor = true;
			this.btnBuscaImagem.Click += new System.EventHandler(this.BtnBuscaImagemClick);
			// 
			// pbImagem
			// 
			this.pbImagem.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pbImagem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pbImagem.Location = new System.Drawing.Point(725, 17);
			this.pbImagem.Name = "pbImagem";
			this.pbImagem.Size = new System.Drawing.Size(184, 169);
			this.pbImagem.TabIndex = 40;
			this.pbImagem.TabStop = false;
			// 
			// txtValorCompra
			// 
			this.txtValorCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValorCompra.Location = new System.Drawing.Point(237, 170);
			this.txtValorCompra.MaxLength = 10;
			this.txtValorCompra.Name = "txtValorCompra";
			this.txtValorCompra.Size = new System.Drawing.Size(170, 26);
			this.txtValorCompra.TabIndex = 38;
			this.txtValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtValorCompra.TextChanged += new System.EventHandler(this.TxtValorCompraTextChanged);
			// 
			// txtMarca
			// 
			this.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMarca.Location = new System.Drawing.Point(237, 138);
			this.txtMarca.MaxLength = 20;
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(211, 26);
			this.txtMarca.TabIndex = 36;
			// 
			// txtValorVenda
			// 
			this.txtValorVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValorVenda.Location = new System.Drawing.Point(237, 202);
			this.txtValorVenda.MaxLength = 10;
			this.txtValorVenda.Name = "txtValorVenda";
			this.txtValorVenda.Size = new System.Drawing.Size(170, 26);
			this.txtValorVenda.TabIndex = 35;
			this.txtValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtValorVenda.TextChanged += new System.EventHandler(this.TxtValorVendaTextChanged);
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuantidade.Location = new System.Drawing.Point(237, 106);
			this.txtQuantidade.MaxLength = 5;
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.Size = new System.Drawing.Size(74, 26);
			this.txtQuantidade.TabIndex = 34;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(77, 137);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(178, 29);
			this.label5.TabIndex = 31;
			this.label5.Text = "Marca :";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(317, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(196, 39);
			this.label4.TabIndex = 30;
			this.label4.Text = "Fornecedor :";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(77, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 39);
			this.label3.TabIndex = 29;
			this.label3.Text = "Quantidade:";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(77, 202);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(178, 39);
			this.label2.TabIndex = 28;
			this.label2.Text = "Valor de Venda :";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(77, 170);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 41);
			this.label1.TabIndex = 27;
			this.label1.Text = "Valor de Compra :";
			// 
			// txtNome
			// 
			this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(237, 74);
			this.txtNome.MaxLength = 50;
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(469, 26);
			this.txtNome.TabIndex = 26;
			// 
			// lblNomeOuRazao
			// 
			this.lblNomeOuRazao.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNomeOuRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeOuRazao.Location = new System.Drawing.Point(77, 73);
			this.lblNomeOuRazao.Name = "lblNomeOuRazao";
			this.lblNomeOuRazao.Size = new System.Drawing.Size(100, 27);
			this.lblNomeOuRazao.TabIndex = 25;
			this.lblNomeOuRazao.Text = "Nome :";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCodigo.Enabled = false;
			this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(237, 42);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(105, 26);
			this.txtCodigo.TabIndex = 24;
			// 
			// lblCodigo
			// 
			this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCodigo.Location = new System.Drawing.Point(77, 41);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(100, 39);
			this.lblCodigo.TabIndex = 23;
			this.lblCodigo.Text = "Código :";
			// 
			// grbPrincipal
			// 
			this.grbPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.grbPrincipal.Controls.Add(this.lblAviso);
			this.grbPrincipal.Controls.Add(this.grbInfoProduto);
			this.grbPrincipal.Controls.Add(this.flowLayoutPanel1);
			this.grbPrincipal.Controls.Add(this.lblProduto);
			this.grbPrincipal.Controls.Add(this.lblNomeEmpresa);
			this.grbPrincipal.Controls.Add(this.pbLogoEmpresa);
			this.grbPrincipal.Location = new System.Drawing.Point(12, 12);
			this.grbPrincipal.Name = "grbPrincipal";
			this.grbPrincipal.Size = new System.Drawing.Size(1047, 578);
			this.grbPrincipal.TabIndex = 0;
			this.grbPrincipal.TabStop = false;
			// 
			// lblAviso
			// 
			this.lblAviso.Location = new System.Drawing.Point(33, 455);
			this.lblAviso.Name = "lblAviso";
			this.lblAviso.Size = new System.Drawing.Size(327, 24);
			this.lblAviso.TabIndex = 8;
			this.lblAviso.Text = "Os campos em NEGRITO são de preenchimento obrigatório\r\n";
			// 
			// frmCadastrarProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnSair;
			this.ClientSize = new System.Drawing.Size(1071, 602);
			this.Controls.Add(this.grbPrincipal);
			this.Name = "frmCadastrarProduto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmCadastrarProduto";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmCadastrarProdutoLoad);
			((System.ComponentModel.ISupportInitialize)(this.pbLogoEmpresa)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.grbInfoProduto.ResumeLayout(false);
			this.grbInfoProduto.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
			this.grbPrincipal.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblAviso;
		private System.Windows.Forms.TextBox txtFornecedor;
		private System.Windows.Forms.OpenFileDialog buscaArquivo;
		private System.Windows.Forms.PictureBox pbLogoEmpresa;
		private System.Windows.Forms.Label lblNomeEmpresa;
		private System.Windows.Forms.Label lblProduto;
		private System.Windows.Forms.GroupBox grbPrincipal;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnIncluir;
		private System.Windows.Forms.GroupBox grbInfoProduto;
		private System.Windows.Forms.Button btnBuscaImagem;
		private System.Windows.Forms.PictureBox pbImagem;
		private System.Windows.Forms.TextBox txtValorCompra;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.TextBox txtValorVenda;
		private System.Windows.Forms.TextBox txtQuantidade;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblNomeOuRazao;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.Button btnLimparImagem;
	}
}
