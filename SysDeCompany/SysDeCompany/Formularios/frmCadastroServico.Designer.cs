/*
 * Created by SharpDevelop.
 * User: Valdelis
 * Date: 17/11/2016
 * Time: 07:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DcompanySys
{
	partial class frmCadastroServico
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroServico));
			this.grbPrincipal = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnExcluirPro = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.grbInfoProduto = new System.Windows.Forms.GroupBox();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
			this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.mtxtCpe = new System.Windows.Forms.MaskedTextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblComplemento = new System.Windows.Forms.Label();
			this.lblTelefone = new System.Windows.Forms.Label();
			this.lblCelular = new System.Windows.Forms.Label();
			this.lblCidade = new System.Windows.Forms.Label();
			this.lblBairro = new System.Windows.Forms.Label();
			this.lblCpe = new System.Windows.Forms.Label();
			this.lblNumero = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNomeOuRazao = new System.Windows.Forms.TextBox();
			this.lblNomeOuRazao = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnIncluir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblNomeEmpresa = new System.Windows.Forms.Label();
			this.pbLogoEmpresa = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.grbPrincipal.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.grbInfoProduto.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoEmpresa)).BeginInit();
			this.SuspendLayout();
			// 
			// grbPrincipal
			// 
			this.grbPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.grbPrincipal.Controls.Add(this.label5);
			this.grbPrincipal.Controls.Add(this.groupBox1);
			this.grbPrincipal.Controls.Add(this.grbInfoProduto);
			this.grbPrincipal.Controls.Add(this.flowLayoutPanel1);
			this.grbPrincipal.Controls.Add(this.label1);
			this.grbPrincipal.Controls.Add(this.lblNomeEmpresa);
			this.grbPrincipal.Controls.Add(this.pbLogoEmpresa);
			this.grbPrincipal.Location = new System.Drawing.Point(12, 12);
			this.grbPrincipal.Name = "grbPrincipal";
			this.grbPrincipal.Size = new System.Drawing.Size(1174, 799);
			this.grbPrincipal.TabIndex = 0;
			this.grbPrincipal.TabStop = false;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.Location = new System.Drawing.Point(63, 665);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(327, 32);
			this.label5.TabIndex = 49;
			this.label5.Text = "Os campos em NEGRITO são de preenchimento obrigatório\r\n* deve ser preenchida pelo" +
			" menos um dos Campos\r\n";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnExcluirPro);
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox14);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Location = new System.Drawing.Point(60, 330);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1075, 332);
			this.groupBox1.TabIndex = 47;
			this.groupBox1.TabStop = false;
			// 
			// btnExcluirPro
			// 
			this.btnExcluirPro.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnExcluirPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluirPro.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirPro.Image")));
			this.btnExcluirPro.Location = new System.Drawing.Point(303, 87);
			this.btnExcluirPro.Name = "btnExcluirPro";
			this.btnExcluirPro.Size = new System.Drawing.Size(82, 96);
			this.btnExcluirPro.TabIndex = 52;
			this.btnExcluirPro.Text = "Excluir";
			this.btnExcluirPro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnExcluirPro.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column5,
									this.Column4,
									this.Column3});
			this.dataGridView1.Location = new System.Drawing.Point(397, 9);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(554, 314);
			this.dataGridView1.TabIndex = 51;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Código";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Tipo";
			this.Column2.Name = "Column2";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Descrição";
			this.Column5.Name = "Column5";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Quantidade";
			this.Column4.Name = "Column4";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Valor";
			this.Column3.Name = "Column3";
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.Location = new System.Drawing.Point(215, 87);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(82, 96);
			this.btnAdd.TabIndex = 50;
			this.btnAdd.Text = "ADD ";
			this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(125, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(346, 26);
			this.label4.TabIndex = 49;
			this.label4.Text = "Adicionar Produto/Serviço :";
			// 
			// textBox14
			// 
			this.textBox14.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox14.Location = new System.Drawing.Point(244, 19);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(105, 26);
			this.textBox14.TabIndex = 24;
			// 
			// label14
			// 
			this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(125, 18);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 26);
			this.label14.TabIndex = 23;
			this.label14.Text = "Data :";
			// 
			// grbInfoProduto
			// 
			this.grbInfoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.grbInfoProduto.Controls.Add(this.maskedTextBox1);
			this.grbInfoProduto.Controls.Add(this.label6);
			this.grbInfoProduto.Controls.Add(this.btnConsultar);
			this.grbInfoProduto.Controls.Add(this.mtxtCelular);
			this.grbInfoProduto.Controls.Add(this.mtxtTelefone);
			this.grbInfoProduto.Controls.Add(this.textBox6);
			this.grbInfoProduto.Controls.Add(this.textBox5);
			this.grbInfoProduto.Controls.Add(this.mtxtCpe);
			this.grbInfoProduto.Controls.Add(this.textBox4);
			this.grbInfoProduto.Controls.Add(this.textBox3);
			this.grbInfoProduto.Controls.Add(this.label3);
			this.grbInfoProduto.Controls.Add(this.textBox2);
			this.grbInfoProduto.Controls.Add(this.textBox1);
			this.grbInfoProduto.Controls.Add(this.lblComplemento);
			this.grbInfoProduto.Controls.Add(this.lblTelefone);
			this.grbInfoProduto.Controls.Add(this.lblCelular);
			this.grbInfoProduto.Controls.Add(this.lblCidade);
			this.grbInfoProduto.Controls.Add(this.lblBairro);
			this.grbInfoProduto.Controls.Add(this.lblCpe);
			this.grbInfoProduto.Controls.Add(this.lblNumero);
			this.grbInfoProduto.Controls.Add(this.label2);
			this.grbInfoProduto.Controls.Add(this.txtNomeOuRazao);
			this.grbInfoProduto.Controls.Add(this.lblNomeOuRazao);
			this.grbInfoProduto.Controls.Add(this.txtCodigo);
			this.grbInfoProduto.Controls.Add(this.lblCodigo);
			this.grbInfoProduto.Location = new System.Drawing.Point(63, 145);
			this.grbInfoProduto.Name = "grbInfoProduto";
			this.grbInfoProduto.Size = new System.Drawing.Size(1075, 179);
			this.grbInfoProduto.TabIndex = 8;
			this.grbInfoProduto.TabStop = false;
			// 
			// btnConsultar
			// 
			this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultar.Location = new System.Drawing.Point(622, 9);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(326, 27);
			this.btnConsultar.TabIndex = 69;
			this.btnConsultar.Text = "Consultar Código Cliente";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
			// 
			// mtxtCelular
			// 
			this.mtxtCelular.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.mtxtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtCelular.Location = new System.Drawing.Point(804, 132);
			this.mtxtCelular.Mask = "(99) 0 0000-0000";
			this.mtxtCelular.Name = "mtxtCelular";
			this.mtxtCelular.Size = new System.Drawing.Size(141, 29);
			this.mtxtCelular.TabIndex = 68;
			// 
			// mtxtTelefone
			// 
			this.mtxtTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.mtxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtTelefone.Location = new System.Drawing.Point(241, 132);
			this.mtxtTelefone.Mask = "(99) 0000-0000";
			this.mtxtTelefone.Name = "mtxtTelefone";
			this.mtxtTelefone.Size = new System.Drawing.Size(141, 29);
			this.mtxtTelefone.TabIndex = 67;
			// 
			// textBox6
			// 
			this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox6.Location = new System.Drawing.Point(696, 102);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(252, 26);
			this.textBox6.TabIndex = 66;
			// 
			// textBox5
			// 
			this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox5.Location = new System.Drawing.Point(242, 103);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(284, 26);
			this.textBox5.TabIndex = 65;
			// 
			// mtxtCpe
			// 
			this.mtxtCpe.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.mtxtCpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtCpe.Location = new System.Drawing.Point(696, 39);
			this.mtxtCpe.Mask = "0000-000";
			this.mtxtCpe.Name = "mtxtCpe";
			this.mtxtCpe.Size = new System.Drawing.Size(105, 29);
			this.mtxtCpe.TabIndex = 64;
			// 
			// textBox4
			// 
			this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox4.Enabled = false;
			this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(865, 42);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(83, 26);
			this.textBox4.TabIndex = 63;
			// 
			// textBox3
			// 
			this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox3.Enabled = false;
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(511, 10);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(105, 26);
			this.textBox3.TabIndex = 62;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(351, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(174, 30);
			this.label3.TabIndex = 61;
			this.label3.Text = "Código Cliente :";
			// 
			// textBox2
			// 
			this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(696, 73);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(252, 26);
			this.textBox2.TabIndex = 60;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(241, 73);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(375, 26);
			this.textBox1.TabIndex = 59;
			// 
			// lblComplemento
			// 
			this.lblComplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblComplemento.Location = new System.Drawing.Point(531, 102);
			this.lblComplemento.Name = "lblComplemento";
			this.lblComplemento.Size = new System.Drawing.Size(175, 32);
			this.lblComplemento.TabIndex = 56;
			this.lblComplemento.Text = "Complemento :";
			// 
			// lblTelefone
			// 
			this.lblTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefone.Location = new System.Drawing.Point(128, 130);
			this.lblTelefone.Name = "lblTelefone";
			this.lblTelefone.Size = new System.Drawing.Size(119, 35);
			this.lblTelefone.TabIndex = 57;
			this.lblTelefone.Text = "Telefone :*";
			// 
			// lblCelular
			// 
			this.lblCelular.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCelular.Location = new System.Drawing.Point(703, 134);
			this.lblCelular.Name = "lblCelular";
			this.lblCelular.Size = new System.Drawing.Size(127, 35);
			this.lblCelular.TabIndex = 58;
			this.lblCelular.Text = "Celular :*";
			// 
			// lblCidade
			// 
			this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCidade.Location = new System.Drawing.Point(127, 101);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(145, 32);
			this.lblCidade.TabIndex = 54;
			this.lblCidade.Text = "Cidade :";
			// 
			// lblBairro
			// 
			this.lblBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBairro.Location = new System.Drawing.Point(621, 72);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(100, 23);
			this.lblBairro.TabIndex = 55;
			this.lblBairro.Text = "Bairro :";
			// 
			// lblCpe
			// 
			this.lblCpe.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCpe.Location = new System.Drawing.Point(622, 41);
			this.lblCpe.Name = "lblCpe";
			this.lblCpe.Size = new System.Drawing.Size(84, 22);
			this.lblCpe.TabIndex = 53;
			this.lblCpe.Text = "CPE :";
			// 
			// lblNumero
			// 
			this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero.Location = new System.Drawing.Point(804, 41);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(55, 32);
			this.lblNumero.TabIndex = 52;
			this.lblNumero.Text = "N° :";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(127, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 27);
			this.label2.TabIndex = 51;
			this.label2.Text = "Endereço :";
			// 
			// txtNomeOuRazao
			// 
			this.txtNomeOuRazao.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNomeOuRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNomeOuRazao.Location = new System.Drawing.Point(241, 42);
			this.txtNomeOuRazao.Name = "txtNomeOuRazao";
			this.txtNomeOuRazao.Size = new System.Drawing.Size(375, 26);
			this.txtNomeOuRazao.TabIndex = 50;
			// 
			// lblNomeOuRazao
			// 
			this.lblNomeOuRazao.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNomeOuRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeOuRazao.Location = new System.Drawing.Point(127, 41);
			this.lblNomeOuRazao.Name = "lblNomeOuRazao";
			this.lblNomeOuRazao.Size = new System.Drawing.Size(100, 27);
			this.lblNomeOuRazao.TabIndex = 49;
			this.lblNomeOuRazao.Text = "Cliente :";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCodigo.Enabled = false;
			this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(241, 10);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(105, 26);
			this.txtCodigo.TabIndex = 48;
			// 
			// lblCodigo
			// 
			this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCodigo.Location = new System.Drawing.Point(127, 9);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(100, 39);
			this.lblCodigo.TabIndex = 47;
			this.lblCodigo.Text = "Código :";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.Controls.Add(this.btnSair);
			this.flowLayoutPanel1.Controls.Add(this.btnAlterar);
			this.flowLayoutPanel1.Controls.Add(this.btnExcluir);
			this.flowLayoutPanel1.Controls.Add(this.btnIncluir);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(713, 683);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(425, 100);
			this.flowLayoutPanel1.TabIndex = 7;
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
			this.btnSair.TabIndex = 0;
			this.btnSair.Text = "Sair";
			this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// btnAlterar
			// 
			this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
			this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAlterar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.Location = new System.Drawing.Point(216, 3);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(100, 96);
			this.btnAlterar.TabIndex = 1;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAlterar.UseVisualStyleBackColor = true;
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
			this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Location = new System.Drawing.Point(110, 3);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(100, 96);
			this.btnExcluir.TabIndex = 2;
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
			this.btnIncluir.TabIndex = 3;
			this.btnIncluir.Text = "Incluir";
			this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnIncluir.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(225, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(319, 45);
			this.label1.TabIndex = 5;
			this.label1.Text = "Cadastrar  Serviços";
			// 
			// lblNomeEmpresa
			// 
			this.lblNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeEmpresa.Location = new System.Drawing.Point(168, 19);
			this.lblNomeEmpresa.Name = "lblNomeEmpresa";
			this.lblNomeEmpresa.Size = new System.Drawing.Size(509, 52);
			this.lblNomeEmpresa.TabIndex = 4;
			this.lblNomeEmpresa.Text = "Nome Empresa";
			// 
			// pbLogoEmpresa
			// 
			this.pbLogoEmpresa.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pbLogoEmpresa.Location = new System.Drawing.Point(20, 19);
			this.pbLogoEmpresa.Name = "pbLogoEmpresa";
			this.pbLogoEmpresa.Size = new System.Drawing.Size(133, 120);
			this.pbLogoEmpresa.TabIndex = 3;
			this.pbLogoEmpresa.TabStop = false;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(410, 134);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(153, 35);
			this.label6.TabIndex = 70;
			this.label6.Text = "Telefone2 :*";
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maskedTextBox1.Location = new System.Drawing.Point(544, 132);
			this.maskedTextBox1.Mask = "(99) 0000-0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(141, 29);
			this.maskedTextBox1.TabIndex = 71;
			// 
			// frmCadastroServico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnSair;
			this.ClientSize = new System.Drawing.Size(1198, 823);
			this.Controls.Add(this.grbPrincipal);
			this.Name = "frmCadastroServico";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmCadastroServico";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmCadastroServicoLoad);
			this.grbPrincipal.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.grbInfoProduto.ResumeLayout(false);
			this.grbInfoProduto.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbLogoEmpresa)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnExcluirPro;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MaskedTextBox mtxtTelefone;
		private System.Windows.Forms.MaskedTextBox mtxtCelular;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.MaskedTextBox mtxtCpe;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.Label lblCpe;
		private System.Windows.Forms.Label lblBairro;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.Label lblCelular;
		private System.Windows.Forms.Label lblTelefone;
		private System.Windows.Forms.Label lblComplemento;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblNomeOuRazao;
		private System.Windows.Forms.TextBox txtNomeOuRazao;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox grbInfoProduto;
		private System.Windows.Forms.Button btnIncluir;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.PictureBox pbLogoEmpresa;
		private System.Windows.Forms.Label lblNomeEmpresa;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox grbPrincipal;
	}
}
