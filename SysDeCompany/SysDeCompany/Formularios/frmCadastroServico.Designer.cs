﻿/*
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
			this.dgv2 = new System.Windows.Forms.DataGridView();
			this.mtxtdate = new System.Windows.Forms.MaskedTextBox();
			this.lblValorResult = new System.Windows.Forms.Label();
			this.lblValor = new System.Windows.Forms.Label();
			this.btnExcluirPro = new System.Windows.Forms.Button();
			this.dgvServico = new System.Windows.Forms.DataGridView();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.grbInfoProduto = new System.Windows.Forms.GroupBox();
			this.txtUF = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.mtxtTelefone2 = new System.Windows.Forms.MaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
			this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
			this.txtComplemento = new System.Windows.Forms.TextBox();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.mtxtCep = new System.Windows.Forms.MaskedTextBox();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.txtCodigoCliente = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.lblComplemento = new System.Windows.Forms.Label();
			this.lblTelefone = new System.Windows.Forms.Label();
			this.lblCelular = new System.Windows.Forms.Label();
			this.lblCidade = new System.Windows.Forms.Label();
			this.lblBairro = new System.Windows.Forms.Label();
			this.lblCep = new System.Windows.Forms.Label();
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
			this.grbPrincipal.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
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
			this.groupBox1.Controls.Add(this.dgv2);
			this.groupBox1.Controls.Add(this.mtxtdate);
			this.groupBox1.Controls.Add(this.lblValorResult);
			this.groupBox1.Controls.Add(this.lblValor);
			this.groupBox1.Controls.Add(this.btnExcluirPro);
			this.groupBox1.Controls.Add(this.dgvServico);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Location = new System.Drawing.Point(60, 330);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1075, 332);
			this.groupBox1.TabIndex = 47;
			this.groupBox1.TabStop = false;
			// 
			// dgv2
			// 
			this.dgv2.AllowUserToAddRows = false;
			this.dgv2.AllowUserToDeleteRows = false;
			this.dgv2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv2.Location = new System.Drawing.Point(397, 9);
			this.dgv2.Name = "dgv2";
			this.dgv2.ReadOnly = true;
			this.dgv2.Size = new System.Drawing.Size(554, 267);
			this.dgv2.TabIndex = 75;
			this.dgv2.Visible = false;
			// 
			// mtxtdate
			// 
			this.mtxtdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mtxtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtdate.Location = new System.Drawing.Point(244, 16);
			this.mtxtdate.Mask = "00/00/0000";
			this.mtxtdate.Name = "mtxtdate";
			this.mtxtdate.Size = new System.Drawing.Size(96, 29);
			this.mtxtdate.TabIndex = 74;
			this.mtxtdate.ValidatingType = typeof(System.DateTime);
			// 
			// lblValorResult
			// 
			this.lblValorResult.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lblValorResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValorResult.Location = new System.Drawing.Point(653, 279);
			this.lblValorResult.Name = "lblValorResult";
			this.lblValorResult.Size = new System.Drawing.Size(307, 50);
			this.lblValorResult.TabIndex = 54;
			this.lblValorResult.Text = "...";
			// 
			// lblValor
			// 
			this.lblValor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValor.Location = new System.Drawing.Point(397, 279);
			this.lblValor.Name = "lblValor";
			this.lblValor.Size = new System.Drawing.Size(346, 50);
			this.lblValor.TabIndex = 53;
			this.lblValor.Text = "Valor Total:";
			// 
			// btnExcluirPro
			// 
			this.btnExcluirPro.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnExcluirPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluirPro.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirPro.Image")));
			this.btnExcluirPro.Location = new System.Drawing.Point(303, 87);
			this.btnExcluirPro.Name = "btnExcluirPro";
			this.btnExcluirPro.Size = new System.Drawing.Size(82, 96);
			this.btnExcluirPro.TabIndex = 1;
			this.btnExcluirPro.Text = "Excluir";
			this.btnExcluirPro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnExcluirPro.UseVisualStyleBackColor = true;
			this.btnExcluirPro.Click += new System.EventHandler(this.BtnExcluirProClick);
			// 
			// dgvServico
			// 
			this.dgvServico.AllowUserToAddRows = false;
			this.dgvServico.AllowUserToDeleteRows = false;
			this.dgvServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column4,
									this.Column5,
									this.Column3,
									this.Column1});
			this.dgvServico.Location = new System.Drawing.Point(397, 9);
			this.dgvServico.Name = "dgvServico";
			this.dgvServico.ReadOnly = true;
			this.dgvServico.Size = new System.Drawing.Size(554, 267);
			this.dgvServico.TabIndex = 51;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Quantidade";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Descrição";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Valor Uni";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Valor Total";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.Location = new System.Drawing.Point(215, 87);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(82, 96);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "ADD ";
			this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
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
			this.grbInfoProduto.Controls.Add(this.txtUF);
			this.grbInfoProduto.Controls.Add(this.label7);
			this.grbInfoProduto.Controls.Add(this.mtxtTelefone2);
			this.grbInfoProduto.Controls.Add(this.label6);
			this.grbInfoProduto.Controls.Add(this.btnConsultar);
			this.grbInfoProduto.Controls.Add(this.mtxtCelular);
			this.grbInfoProduto.Controls.Add(this.mtxtTelefone);
			this.grbInfoProduto.Controls.Add(this.txtComplemento);
			this.grbInfoProduto.Controls.Add(this.txtCidade);
			this.grbInfoProduto.Controls.Add(this.mtxtCep);
			this.grbInfoProduto.Controls.Add(this.txtNumero);
			this.grbInfoProduto.Controls.Add(this.txtCodigoCliente);
			this.grbInfoProduto.Controls.Add(this.label3);
			this.grbInfoProduto.Controls.Add(this.txtBairro);
			this.grbInfoProduto.Controls.Add(this.txtEndereco);
			this.grbInfoProduto.Controls.Add(this.lblComplemento);
			this.grbInfoProduto.Controls.Add(this.lblTelefone);
			this.grbInfoProduto.Controls.Add(this.lblCelular);
			this.grbInfoProduto.Controls.Add(this.lblCidade);
			this.grbInfoProduto.Controls.Add(this.lblBairro);
			this.grbInfoProduto.Controls.Add(this.lblCep);
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
			// txtUF
			// 
			this.txtUF.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUF.Location = new System.Drawing.Point(880, 101);
			this.txtUF.Name = "txtUF";
			this.txtUF.Size = new System.Drawing.Size(67, 26);
			this.txtUF.TabIndex = 73;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(836, 101);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(109, 26);
			this.label7.TabIndex = 72;
			this.label7.Text = "UF:";
			// 
			// mtxtTelefone2
			// 
			this.mtxtTelefone2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.mtxtTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtTelefone2.Location = new System.Drawing.Point(544, 132);
			this.mtxtTelefone2.Mask = "(99) 0000-0000";
			this.mtxtTelefone2.Name = "mtxtTelefone2";
			this.mtxtTelefone2.Size = new System.Drawing.Size(141, 29);
			this.mtxtTelefone2.TabIndex = 71;
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
			// btnConsultar
			// 
			this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultar.Location = new System.Drawing.Point(622, 9);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(326, 27);
			this.btnConsultar.TabIndex = 2;
			this.btnConsultar.Text = "Consultar Código Cliente";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
			// 
			// mtxtCelular
			// 
			this.mtxtCelular.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.mtxtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtCelular.Location = new System.Drawing.Point(806, 132);
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
			// txtComplemento
			// 
			this.txtComplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComplemento.Location = new System.Drawing.Point(696, 102);
			this.txtComplemento.Name = "txtComplemento";
			this.txtComplemento.Size = new System.Drawing.Size(134, 26);
			this.txtComplemento.TabIndex = 66;
			// 
			// txtCidade
			// 
			this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCidade.Location = new System.Drawing.Point(242, 103);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(284, 26);
			this.txtCidade.TabIndex = 65;
			// 
			// mtxtCep
			// 
			this.mtxtCep.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.mtxtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtCep.Location = new System.Drawing.Point(696, 39);
			this.mtxtCep.Mask = "00000-000";
			this.mtxtCep.Name = "mtxtCep";
			this.mtxtCep.Size = new System.Drawing.Size(105, 29);
			this.mtxtCep.TabIndex = 64;
			// 
			// txtNumero
			// 
			this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(865, 42);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(83, 26);
			this.txtNumero.TabIndex = 63;
			// 
			// txtCodigoCliente
			// 
			this.txtCodigoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigoCliente.Location = new System.Drawing.Point(511, 10);
			this.txtCodigoCliente.Name = "txtCodigoCliente";
			this.txtCodigoCliente.Size = new System.Drawing.Size(105, 26);
			this.txtCodigoCliente.TabIndex = 1;
			this.txtCodigoCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigoClienteKeyDown);
			this.txtCodigoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoClienteKeyPress);
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
			// txtBairro
			// 
			this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBairro.Location = new System.Drawing.Point(696, 73);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(252, 26);
			this.txtBairro.TabIndex = 60;
			// 
			// txtEndereco
			// 
			this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEndereco.Location = new System.Drawing.Point(241, 73);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(375, 26);
			this.txtEndereco.TabIndex = 59;
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
			// lblCep
			// 
			this.lblCep.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCep.Location = new System.Drawing.Point(622, 41);
			this.lblCep.Name = "lblCep";
			this.lblCep.Size = new System.Drawing.Size(84, 22);
			this.lblCep.TabIndex = 53;
			this.lblCep.Text = "CEP :";
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
			this.txtCodigo.TabIndex = 0;
			this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigoKeyDown);
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
			this.btnSair.TabIndex = 1;
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
			this.btnAlterar.TabIndex = 2;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Visible = false;
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
			this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Location = new System.Drawing.Point(110, 3);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(100, 96);
			this.btnExcluir.TabIndex = 3;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Visible = false;
			// 
			// btnIncluir
			// 
			this.btnIncluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncluir.BackgroundImage")));
			this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIncluir.Location = new System.Drawing.Point(4, 3);
			this.btnIncluir.Name = "btnIncluir";
			this.btnIncluir.Size = new System.Drawing.Size(100, 96);
			this.btnIncluir.TabIndex = 0;
			this.btnIncluir.Text = "Incluir";
			this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnIncluir.UseVisualStyleBackColor = true;
			this.btnIncluir.Click += new System.EventHandler(this.BtnIncluirClick);
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
			// frmCadastroServico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnSair;
			this.ClientSize = new System.Drawing.Size(1198, 823);
			this.Controls.Add(this.grbPrincipal);
			this.Name = "frmCadastroServico";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastrar Serviço";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmCadastroServicoLoad);
			this.grbPrincipal.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
			this.grbInfoProduto.ResumeLayout(false);
			this.grbInfoProduto.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbLogoEmpresa)).EndInit();
			this.ResumeLayout(false);
		}
		public System.Windows.Forms.DataGridView dgv2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.MaskedTextBox mtxtdate;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtUF;
		private System.Windows.Forms.Label lblValor;
		private System.Windows.Forms.Label lblValorResult;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MaskedTextBox mtxtTelefone2;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.Button btnExcluirPro;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		public System.Windows.Forms.DataGridView dgvServico;
		private System.Windows.Forms.Label label14;
		public System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MaskedTextBox mtxtTelefone;
		private System.Windows.Forms.MaskedTextBox mtxtCelular;
		public System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.MaskedTextBox mtxtCep;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.TextBox txtComplemento;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.Label lblCep;
		private System.Windows.Forms.Label lblBairro;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.Label lblCelular;
		private System.Windows.Forms.Label lblTelefone;
		private System.Windows.Forms.Label lblComplemento;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox txtCodigoCliente;
		private System.Windows.Forms.Label lblCodigo;
		public System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblNomeOuRazao;
		private System.Windows.Forms.TextBox txtNomeOuRazao;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox grbInfoProduto;
		public System.Windows.Forms.Button btnIncluir;
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
