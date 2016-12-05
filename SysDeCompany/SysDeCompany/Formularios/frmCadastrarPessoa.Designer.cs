/*
 * Criado por SharpDevelop.
 * Usuário: MAQLAB
 * Data: 09/11/2016
 * Hora: 14:11
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace DcompanySys
{
	partial class frmCadastrarPessoa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarPessoa));
			this.grbPrincipal = new System.Windows.Forms.GroupBox();
			this.lblAviso = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnIncluir = new System.Windows.Forms.Button();
			this.grbDocumentoTelefone = new System.Windows.Forms.GroupBox();
			this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
			this.lblCelular = new System.Windows.Forms.Label();
			this.mtxtTelefone2 = new System.Windows.Forms.MaskedTextBox();
			this.lbltelefone2 = new System.Windows.Forms.Label();
			this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
			this.mtxtCnpj = new System.Windows.Forms.MaskedTextBox();
			this.lblTelefone = new System.Windows.Forms.Label();
			this.txtIE = new System.Windows.Forms.TextBox();
			this.lblIE = new System.Windows.Forms.Label();
			this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
			this.lblCpfOuCNPJ = new System.Windows.Forms.Label();
			this.grbDadosPessoais = new System.Windows.Forms.GroupBox();
			this.cbUF = new System.Windows.Forms.ComboBox();
			this.lblUf = new System.Windows.Forms.Label();
			this.txtComplemento = new System.Windows.Forms.TextBox();
			this.lblComplemento = new System.Windows.Forms.Label();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.lblCidade = new System.Windows.Forms.Label();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.lblBairro = new System.Windows.Forms.Label();
			this.mtxtCep = new System.Windows.Forms.MaskedTextBox();
			this.lblCpe = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.lblNumero = new System.Windows.Forms.Label();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.lblEndereco = new System.Windows.Forms.Label();
			this.txtNomeOuRazao = new System.Windows.Forms.TextBox();
			this.lblNomeOuRazao = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.grbTipoPessoa = new System.Windows.Forms.GroupBox();
			this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
			this.rbPessoaFisica = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.lblNomeEmpresa = new System.Windows.Forms.Label();
			this.pbLogoEmpresa = new System.Windows.Forms.PictureBox();
			this.grbPrincipal.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.grbDocumentoTelefone.SuspendLayout();
			this.grbDadosPessoais.SuspendLayout();
			this.grbTipoPessoa.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoEmpresa)).BeginInit();
			this.SuspendLayout();
			// 
			// grbPrincipal
			// 
			this.grbPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.grbPrincipal.Controls.Add(this.lblAviso);
			this.grbPrincipal.Controls.Add(this.flowLayoutPanel1);
			this.grbPrincipal.Controls.Add(this.grbDocumentoTelefone);
			this.grbPrincipal.Controls.Add(this.grbDadosPessoais);
			this.grbPrincipal.Controls.Add(this.grbTipoPessoa);
			this.grbPrincipal.Controls.Add(this.label1);
			this.grbPrincipal.Controls.Add(this.lblNomeEmpresa);
			this.grbPrincipal.Controls.Add(this.pbLogoEmpresa);
			this.grbPrincipal.Location = new System.Drawing.Point(12, 12);
			this.grbPrincipal.Name = "grbPrincipal";
			this.grbPrincipal.Size = new System.Drawing.Size(1023, 622);
			this.grbPrincipal.TabIndex = 0;
			this.grbPrincipal.TabStop = false;
			// 
			// lblAviso
			// 
			this.lblAviso.Location = new System.Drawing.Point(45, 529);
			this.lblAviso.Name = "lblAviso";
			this.lblAviso.Size = new System.Drawing.Size(327, 32);
			this.lblAviso.TabIndex = 7;
			this.lblAviso.Text = "Os campos em NEGRITO são de preenchimento obrigatório\r\n* deve ser preenchida pelo" +
			" menos um dos Campos\r\n";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.Controls.Add(this.btnSair);
			this.flowLayoutPanel1.Controls.Add(this.btnExcluir);
			this.flowLayoutPanel1.Controls.Add(this.btnAlterar);
			this.flowLayoutPanel1.Controls.Add(this.btnIncluir);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(562, 507);
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
			// btnExcluir
			// 
			this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
			this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Location = new System.Drawing.Point(216, 3);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(100, 96);
			this.btnExcluir.TabIndex = 6;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.BtnExcluirClick);
			// 
			// btnAlterar
			// 
			this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
			this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.Location = new System.Drawing.Point(110, 3);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(100, 96);
			this.btnAlterar.TabIndex = 5;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.BtnAlterarClick);
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
			// grbDocumentoTelefone
			// 
			this.grbDocumentoTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.grbDocumentoTelefone.Controls.Add(this.mtxtCelular);
			this.grbDocumentoTelefone.Controls.Add(this.lblCelular);
			this.grbDocumentoTelefone.Controls.Add(this.mtxtTelefone2);
			this.grbDocumentoTelefone.Controls.Add(this.lbltelefone2);
			this.grbDocumentoTelefone.Controls.Add(this.mtxtTelefone);
			this.grbDocumentoTelefone.Controls.Add(this.mtxtCnpj);
			this.grbDocumentoTelefone.Controls.Add(this.lblTelefone);
			this.grbDocumentoTelefone.Controls.Add(this.txtIE);
			this.grbDocumentoTelefone.Controls.Add(this.lblIE);
			this.grbDocumentoTelefone.Controls.Add(this.mtxtCpf);
			this.grbDocumentoTelefone.Controls.Add(this.lblCpfOuCNPJ);
			this.grbDocumentoTelefone.Location = new System.Drawing.Point(33, 398);
			this.grbDocumentoTelefone.Name = "grbDocumentoTelefone";
			this.grbDocumentoTelefone.Size = new System.Drawing.Size(954, 128);
			this.grbDocumentoTelefone.TabIndex = 5;
			this.grbDocumentoTelefone.TabStop = false;
			// 
			// mtxtCelular
			// 
			this.mtxtCelular.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mtxtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtCelular.Location = new System.Drawing.Point(162, 82);
			this.mtxtCelular.Mask = "(00) 0 0000-0000";
			this.mtxtCelular.Name = "mtxtCelular";
			this.mtxtCelular.Size = new System.Drawing.Size(141, 29);
			this.mtxtCelular.TabIndex = 23;
			// 
			// lblCelular
			// 
			this.lblCelular.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCelular.Location = new System.Drawing.Point(46, 84);
			this.lblCelular.Name = "lblCelular";
			this.lblCelular.Size = new System.Drawing.Size(127, 35);
			this.lblCelular.TabIndex = 22;
			this.lblCelular.Text = "Celular :*";
			// 
			// mtxtTelefone2
			// 
			this.mtxtTelefone2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mtxtTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtTelefone2.Location = new System.Drawing.Point(486, 47);
			this.mtxtTelefone2.Mask = "(00) 0000-0000";
			this.mtxtTelefone2.Name = "mtxtTelefone2";
			this.mtxtTelefone2.Size = new System.Drawing.Size(141, 29);
			this.mtxtTelefone2.TabIndex = 21;
			// 
			// lbltelefone2
			// 
			this.lbltelefone2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbltelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltelefone2.Location = new System.Drawing.Point(359, 49);
			this.lbltelefone2.Name = "lbltelefone2";
			this.lbltelefone2.Size = new System.Drawing.Size(141, 35);
			this.lbltelefone2.TabIndex = 20;
			this.lbltelefone2.Text = "Telefone 2:*";
			// 
			// mtxtTelefone
			// 
			this.mtxtTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mtxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtTelefone.Location = new System.Drawing.Point(162, 47);
			this.mtxtTelefone.Mask = "(00) 0000-0000";
			this.mtxtTelefone.Name = "mtxtTelefone";
			this.mtxtTelefone.Size = new System.Drawing.Size(141, 29);
			this.mtxtTelefone.TabIndex = 19;
			// 
			// mtxtCnpj
			// 
			this.mtxtCnpj.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mtxtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtCnpj.Location = new System.Drawing.Point(162, 12);
			this.mtxtCnpj.Mask = "00,000,000/0000-00";
			this.mtxtCnpj.Name = "mtxtCnpj";
			this.mtxtCnpj.Size = new System.Drawing.Size(171, 29);
			this.mtxtCnpj.TabIndex = 18;
			this.mtxtCnpj.Visible = false;
			// 
			// lblTelefone
			// 
			this.lblTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefone.Location = new System.Drawing.Point(46, 49);
			this.lblTelefone.Name = "lblTelefone";
			this.lblTelefone.Size = new System.Drawing.Size(127, 35);
			this.lblTelefone.TabIndex = 17;
			this.lblTelefone.Text = "Telefone:*";
			// 
			// txtIE
			// 
			this.txtIE.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIE.Location = new System.Drawing.Point(486, 12);
			this.txtIE.MaxLength = 15;
			this.txtIE.Name = "txtIE";
			this.txtIE.Size = new System.Drawing.Size(223, 29);
			this.txtIE.TabIndex = 15;
			this.txtIE.Visible = false;
			// 
			// lblIE
			// 
			this.lblIE.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIE.Location = new System.Drawing.Point(359, 14);
			this.lblIE.Name = "lblIE";
			this.lblIE.Size = new System.Drawing.Size(100, 35);
			this.lblIE.TabIndex = 16;
			this.lblIE.Text = "IE :";
			this.lblIE.Visible = false;
			// 
			// mtxtCpf
			// 
			this.mtxtCpf.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mtxtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtCpf.Location = new System.Drawing.Point(162, 12);
			this.mtxtCpf.Mask = "000,000,000-00";
			this.mtxtCpf.Name = "mtxtCpf";
			this.mtxtCpf.Size = new System.Drawing.Size(141, 29);
			this.mtxtCpf.TabIndex = 15;
			// 
			// lblCpfOuCNPJ
			// 
			this.lblCpfOuCNPJ.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCpfOuCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCpfOuCNPJ.Location = new System.Drawing.Point(46, 16);
			this.lblCpfOuCNPJ.Name = "lblCpfOuCNPJ";
			this.lblCpfOuCNPJ.Size = new System.Drawing.Size(100, 35);
			this.lblCpfOuCNPJ.TabIndex = 15;
			this.lblCpfOuCNPJ.Text = "CPF :";
			// 
			// grbDadosPessoais
			// 
			this.grbDadosPessoais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.grbDadosPessoais.Controls.Add(this.cbUF);
			this.grbDadosPessoais.Controls.Add(this.lblUf);
			this.grbDadosPessoais.Controls.Add(this.txtComplemento);
			this.grbDadosPessoais.Controls.Add(this.lblComplemento);
			this.grbDadosPessoais.Controls.Add(this.txtCidade);
			this.grbDadosPessoais.Controls.Add(this.lblCidade);
			this.grbDadosPessoais.Controls.Add(this.txtBairro);
			this.grbDadosPessoais.Controls.Add(this.lblBairro);
			this.grbDadosPessoais.Controls.Add(this.mtxtCep);
			this.grbDadosPessoais.Controls.Add(this.lblCpe);
			this.grbDadosPessoais.Controls.Add(this.txtNumero);
			this.grbDadosPessoais.Controls.Add(this.lblNumero);
			this.grbDadosPessoais.Controls.Add(this.txtEndereco);
			this.grbDadosPessoais.Controls.Add(this.lblEndereco);
			this.grbDadosPessoais.Controls.Add(this.txtNomeOuRazao);
			this.grbDadosPessoais.Controls.Add(this.lblNomeOuRazao);
			this.grbDadosPessoais.Controls.Add(this.txtCodigo);
			this.grbDadosPessoais.Controls.Add(this.lblCodigo);
			this.grbDadosPessoais.Location = new System.Drawing.Point(33, 240);
			this.grbDadosPessoais.Name = "grbDadosPessoais";
			this.grbDadosPessoais.Size = new System.Drawing.Size(954, 152);
			this.grbDadosPessoais.TabIndex = 4;
			this.grbDadosPessoais.TabStop = false;
			// 
			// cbUF
			// 
			this.cbUF.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbUF.FormattingEnabled = true;
			this.cbUF.Items.AddRange(new object[] {
									"AC",
									"AL",
									"AP",
									"AM",
									"BA",
									"CE",
									"DF",
									"ES",
									"GO",
									"MA    ",
									"MT",
									"MS",
									"MG",
									"PA",
									"PB",
									"PR",
									"PE",
									"PI",
									"RJ",
									"RN",
									"RS",
									"RO",
									"RR",
									"SC",
									"SP",
									"SE",
									"TO"});
			this.cbUF.Location = new System.Drawing.Point(838, 74);
			this.cbUF.Name = "cbUF";
			this.cbUF.Size = new System.Drawing.Size(55, 32);
			this.cbUF.TabIndex = 17;
			// 
			// lblUf
			// 
			this.lblUf.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUf.Location = new System.Drawing.Point(786, 76);
			this.lblUf.Name = "lblUf";
			this.lblUf.Size = new System.Drawing.Size(55, 32);
			this.lblUf.TabIndex = 15;
			this.lblUf.Text = "UF:";
			// 
			// txtComplemento
			// 
			this.txtComplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComplemento.Location = new System.Drawing.Point(594, 108);
			this.txtComplemento.MaxLength = 50;
			this.txtComplemento.Name = "txtComplemento";
			this.txtComplemento.Size = new System.Drawing.Size(299, 29);
			this.txtComplemento.TabIndex = 14;
			// 
			// lblComplemento
			// 
			this.lblComplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblComplemento.Location = new System.Drawing.Point(436, 110);
			this.lblComplemento.Name = "lblComplemento";
			this.lblComplemento.Size = new System.Drawing.Size(175, 32);
			this.lblComplemento.TabIndex = 13;
			this.lblComplemento.Text = "Complemento :";
			// 
			// txtCidade
			// 
			this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCidade.Location = new System.Drawing.Point(162, 108);
			this.txtCidade.MaxLength = 50;
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(268, 29);
			this.txtCidade.TabIndex = 12;
			// 
			// lblCidade
			// 
			this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCidade.Location = new System.Drawing.Point(46, 110);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(145, 32);
			this.lblCidade.TabIndex = 9;
			this.lblCidade.Text = "Cidade :";
			// 
			// txtBairro
			// 
			this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBairro.Location = new System.Drawing.Point(359, 76);
			this.txtBairro.MaxLength = 50;
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(433, 29);
			this.txtBairro.TabIndex = 11;
			// 
			// lblBairro
			// 
			this.lblBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBairro.Location = new System.Drawing.Point(273, 78);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(100, 23);
			this.lblBairro.TabIndex = 10;
			this.lblBairro.Text = "Bairro :";
			// 
			// mtxtCep
			// 
			this.mtxtCep.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.mtxtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtCep.Location = new System.Drawing.Point(162, 76);
			this.mtxtCep.Mask = "00000-000";
			this.mtxtCep.Name = "mtxtCep";
			this.mtxtCep.Size = new System.Drawing.Size(105, 29);
			this.mtxtCep.TabIndex = 9;
			// 
			// lblCpe
			// 
			this.lblCpe.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCpe.Location = new System.Drawing.Point(46, 78);
			this.lblCpe.Name = "lblCpe";
			this.lblCpe.Size = new System.Drawing.Size(85, 32);
			this.lblCpe.TabIndex = 8;
			this.lblCpe.Text = "CPE :";
			// 
			// txtNumero
			// 
			this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(786, 43);
			this.txtNumero.MaxLength = 5;
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(107, 29);
			this.txtNumero.TabIndex = 7;
			// 
			// lblNumero
			// 
			this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero.Location = new System.Drawing.Point(737, 43);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(55, 32);
			this.lblNumero.TabIndex = 6;
			this.lblNumero.Text = "N° :";
			// 
			// txtEndereco
			// 
			this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEndereco.Location = new System.Drawing.Point(162, 43);
			this.txtEndereco.MaxLength = 100;
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(569, 29);
			this.txtEndereco.TabIndex = 5;
			// 
			// lblEndereco
			// 
			this.lblEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEndereco.Location = new System.Drawing.Point(46, 43);
			this.lblEndereco.Name = "lblEndereco";
			this.lblEndereco.Size = new System.Drawing.Size(145, 32);
			this.lblEndereco.TabIndex = 4;
			this.lblEndereco.Text = "Endereço:";
			// 
			// txtNomeOuRazao
			// 
			this.txtNomeOuRazao.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNomeOuRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNomeOuRazao.Location = new System.Drawing.Point(359, 11);
			this.txtNomeOuRazao.MaxLength = 50;
			this.txtNomeOuRazao.Name = "txtNomeOuRazao";
			this.txtNomeOuRazao.Size = new System.Drawing.Size(534, 29);
			this.txtNomeOuRazao.TabIndex = 3;
			// 
			// lblNomeOuRazao
			// 
			this.lblNomeOuRazao.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNomeOuRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeOuRazao.Location = new System.Drawing.Point(273, 13);
			this.lblNomeOuRazao.Name = "lblNomeOuRazao";
			this.lblNomeOuRazao.Size = new System.Drawing.Size(100, 23);
			this.lblNomeOuRazao.TabIndex = 2;
			this.lblNomeOuRazao.Text = "Nome :";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCodigo.Enabled = false;
			this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(162, 11);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(105, 29);
			this.txtCodigo.TabIndex = 1;
			// 
			// lblCodigo
			// 
			this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCodigo.Location = new System.Drawing.Point(46, 13);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(100, 35);
			this.lblCodigo.TabIndex = 0;
			this.lblCodigo.Text = "Código : ";
			// 
			// grbTipoPessoa
			// 
			this.grbTipoPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.grbTipoPessoa.Controls.Add(this.rbPessoaJuridica);
			this.grbTipoPessoa.Controls.Add(this.rbPessoaFisica);
			this.grbTipoPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbTipoPessoa.Location = new System.Drawing.Point(33, 154);
			this.grbTipoPessoa.Name = "grbTipoPessoa";
			this.grbTipoPessoa.Size = new System.Drawing.Size(954, 80);
			this.grbTipoPessoa.TabIndex = 3;
			this.grbTipoPessoa.TabStop = false;
			this.grbTipoPessoa.Text = "Tipo de Pessoa";
			// 
			// rbPessoaJuridica
			// 
			this.rbPessoaJuridica.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.rbPessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbPessoaJuridica.Location = new System.Drawing.Point(325, 34);
			this.rbPessoaJuridica.Name = "rbPessoaJuridica";
			this.rbPessoaJuridica.Size = new System.Drawing.Size(217, 33);
			this.rbPessoaJuridica.TabIndex = 1;
			this.rbPessoaJuridica.TabStop = true;
			this.rbPessoaJuridica.Text = "Pessoa Jurídica (PJ)";
			this.rbPessoaJuridica.UseVisualStyleBackColor = true;
			this.rbPessoaJuridica.Click += new System.EventHandler(this.RbPessoaJuridicaClick);
			// 
			// rbPessoaFisica
			// 
			this.rbPessoaFisica.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.rbPessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbPessoaFisica.Location = new System.Drawing.Point(69, 34);
			this.rbPessoaFisica.Name = "rbPessoaFisica";
			this.rbPessoaFisica.Size = new System.Drawing.Size(229, 33);
			this.rbPessoaFisica.TabIndex = 0;
			this.rbPessoaFisica.TabStop = true;
			this.rbPessoaFisica.Text = "Pessoa Física (PF)";
			this.rbPessoaFisica.UseVisualStyleBackColor = true;
			this.rbPessoaFisica.Click += new System.EventHandler(this.RbPessoaFisicaClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(220, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(319, 45);
			this.label1.TabIndex = 2;
			this.label1.Text = "Cadastrar  Pessoa";
			// 
			// lblNomeEmpresa
			// 
			this.lblNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeEmpresa.Location = new System.Drawing.Point(163, 19);
			this.lblNomeEmpresa.Name = "lblNomeEmpresa";
			this.lblNomeEmpresa.Size = new System.Drawing.Size(515, 52);
			this.lblNomeEmpresa.TabIndex = 1;
			this.lblNomeEmpresa.Text = "Nome Empresa";
			// 
			// pbLogoEmpresa
			// 
			this.pbLogoEmpresa.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pbLogoEmpresa.Location = new System.Drawing.Point(15, 19);
			this.pbLogoEmpresa.Name = "pbLogoEmpresa";
			this.pbLogoEmpresa.Size = new System.Drawing.Size(133, 120);
			this.pbLogoEmpresa.TabIndex = 0;
			this.pbLogoEmpresa.TabStop = false;
			// 
			// frmCadastrarPessoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnSair;
			this.ClientSize = new System.Drawing.Size(1059, 646);
			this.Controls.Add(this.grbPrincipal);
			this.Name = "frmCadastrarPessoa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastrar Pessoa";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmCadastrarPessoaLoad);
			this.grbPrincipal.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.grbDocumentoTelefone.ResumeLayout(false);
			this.grbDocumentoTelefone.PerformLayout();
			this.grbDadosPessoais.ResumeLayout(false);
			this.grbDadosPessoais.PerformLayout();
			this.grbTipoPessoa.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbLogoEmpresa)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblAviso;
		public System.Windows.Forms.ComboBox cbUF;
		private System.Windows.Forms.Label lblUf;
		private System.Windows.Forms.Label lblNomeOuRazao;
		public System.Windows.Forms.TextBox txtNomeOuRazao;
		private System.Windows.Forms.Label lblEndereco;
		public System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.Label lblNumero;
		public System.Windows.Forms.TextBox txtNumero;
		public System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.GroupBox grbDadosPessoais;
		private System.Windows.Forms.PictureBox pbLogoEmpresa;
		private System.Windows.Forms.Label lblNomeEmpresa;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.RadioButton rbPessoaFisica;
		public System.Windows.Forms.RadioButton rbPessoaJuridica;
		private System.Windows.Forms.GroupBox grbTipoPessoa;
		private System.Windows.Forms.GroupBox grbPrincipal;
		public System.Windows.Forms.TextBox txtComplemento;
		private System.Windows.Forms.Label lblComplemento;
		public System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.Label lblCidade;
		public System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.Label lblBairro;
		public System.Windows.Forms.MaskedTextBox mtxtCep;
		private System.Windows.Forms.Label lblCpe;
		private System.Windows.Forms.GroupBox grbDocumentoTelefone;
		public System.Windows.Forms.MaskedTextBox mtxtCpf;
		private System.Windows.Forms.Label lblCpfOuCNPJ;
		public System.Windows.Forms.MaskedTextBox mtxtCelular;
		private System.Windows.Forms.Label lblCelular;
		public System.Windows.Forms.MaskedTextBox mtxtTelefone2;
		private System.Windows.Forms.Label lbltelefone2;
		public System.Windows.Forms.MaskedTextBox mtxtTelefone;
		public System.Windows.Forms.MaskedTextBox mtxtCnpj;
		private System.Windows.Forms.Label lblTelefone;
		public System.Windows.Forms.TextBox txtIE;
		private System.Windows.Forms.Label lblIE;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button btnSair;
		public System.Windows.Forms.Button btnAlterar;
		public System.Windows.Forms.Button btnExcluir;
		public System.Windows.Forms.Button btnIncluir;
	}
}
