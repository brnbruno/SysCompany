/*
 * Created by SharpDevelop.
 * User: Valdelis
 * Date: 20/11/2016
 * Time: 02:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DcompanySys
{
	partial class frmPesquisar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisar));
			this.btnSair = new System.Windows.Forms.Button();
			this.btnPequisar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.mtxtdata = new System.Windows.Forms.MaskedTextBox();
			this.txtInvisivel = new System.Windows.Forms.TextBox();
			this.btnAddServico = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnPesquiInativo = new System.Windows.Forms.Button();
			this.lblFiltros = new System.Windows.Forms.Label();
			this.txtDescricao = new System.Windows.Forms.TextBox();
			this.lbDescricao = new System.Windows.Forms.Label();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSair
			// 
			this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
			this.btnSair.Location = new System.Drawing.Point(884, 414);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(90, 101);
			this.btnSair.TabIndex = 7;
			this.btnSair.Text = "Sair";
			this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSair.UseVisualStyleBackColor = true;
			// 
			// btnPequisar
			// 
			this.btnPequisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPequisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPequisar.BackgroundImage")));
			this.btnPequisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPequisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPequisar.Location = new System.Drawing.Point(884, 16);
			this.btnPequisar.Name = "btnPequisar";
			this.btnPequisar.Size = new System.Drawing.Size(90, 101);
			this.btnPequisar.TabIndex = 1;
			this.btnPequisar.Text = "Pesquisar";
			this.btnPequisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnPequisar.UseVisualStyleBackColor = true;
			this.btnPequisar.Click += new System.EventHandler(this.BtnPequisarClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.mtxtdata);
			this.groupBox1.Controls.Add(this.txtInvisivel);
			this.groupBox1.Controls.Add(this.btnAddServico);
			this.groupBox1.Controls.Add(this.btnExcluir);
			this.groupBox1.Controls.Add(this.btnPequisar);
			this.groupBox1.Controls.Add(this.btnAlterar);
			this.groupBox1.Controls.Add(this.btnConsultar);
			this.groupBox1.Controls.Add(this.btnNovo);
			this.groupBox1.Controls.Add(this.btnPesquiInativo);
			this.groupBox1.Controls.Add(this.lblFiltros);
			this.groupBox1.Controls.Add(this.txtDescricao);
			this.groupBox1.Controls.Add(this.lbDescricao);
			this.groupBox1.Controls.Add(this.dgv);
			this.groupBox1.Controls.Add(this.btnSair);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1030, 530);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// mtxtdata
			// 
			this.mtxtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtdata.Location = new System.Drawing.Point(205, 79);
			this.mtxtdata.Mask = "00/00/0000";
			this.mtxtdata.Name = "mtxtdata";
			this.mtxtdata.Size = new System.Drawing.Size(157, 38);
			this.mtxtdata.TabIndex = 23;
			this.mtxtdata.ValidatingType = typeof(System.DateTime);
			this.mtxtdata.Visible = false;
			// 
			// txtInvisivel
			// 
			this.txtInvisivel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtInvisivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInvisivel.Location = new System.Drawing.Point(455, 477);
			this.txtInvisivel.Name = "txtInvisivel";
			this.txtInvisivel.Size = new System.Drawing.Size(22, 38);
			this.txtInvisivel.TabIndex = 22;
			this.txtInvisivel.Visible = false;
			// 
			// btnAddServico
			// 
			this.btnAddServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddServico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddServico.BackgroundImage")));
			this.btnAddServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAddServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddServico.Location = new System.Drawing.Point(716, 415);
			this.btnAddServico.Name = "btnAddServico";
			this.btnAddServico.Size = new System.Drawing.Size(90, 101);
			this.btnAddServico.TabIndex = 21;
			this.btnAddServico.UseVisualStyleBackColor = true;
			this.btnAddServico.Click += new System.EventHandler(this.BtnAddServicoClick);
			this.btnAddServico.MouseLeave += new System.EventHandler(this.BtnAddServicoMouseLeave);
			this.btnAddServico.MouseHover += new System.EventHandler(this.BtnAddServicoMouseHover);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
			this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Location = new System.Drawing.Point(359, 415);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(90, 101);
			this.btnExcluir.TabIndex = 16;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.BtnExcluirClick);
			// 
			// btnAlterar
			// 
			this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
			this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.Location = new System.Drawing.Point(256, 415);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(90, 101);
			this.btnAlterar.TabIndex = 15;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAlterar.UseVisualStyleBackColor = true;
			this.btnAlterar.Click += new System.EventHandler(this.BtnAlterarClick);
			// 
			// btnConsultar
			// 
			this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
			this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultar.Location = new System.Drawing.Point(160, 415);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(90, 101);
			this.btnConsultar.TabIndex = 14;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
			// 
			// btnNovo
			// 
			this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovo.BackgroundImage")));
			this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNovo.Location = new System.Drawing.Point(64, 415);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(90, 101);
			this.btnNovo.TabIndex = 13;
			this.btnNovo.Text = "Novo";
			this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnNovo.UseVisualStyleBackColor = true;
			this.btnNovo.Click += new System.EventHandler(this.BtnNovoClick);
			// 
			// btnPesquiInativo
			// 
			this.btnPesquiInativo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPesquiInativo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPesquiInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPesquiInativo.Location = new System.Drawing.Point(553, 415);
			this.btnPesquiInativo.Name = "btnPesquiInativo";
			this.btnPesquiInativo.Size = new System.Drawing.Size(90, 101);
			this.btnPesquiInativo.TabIndex = 17;
			this.btnPesquiInativo.Text = "Pesquisar Excluido";
			this.btnPesquiInativo.UseVisualStyleBackColor = true;
			this.btnPesquiInativo.Click += new System.EventHandler(this.BtnPesquiInativoClick);
			// 
			// lblFiltros
			// 
			this.lblFiltros.AutoSize = true;
			this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFiltros.Location = new System.Drawing.Point(24, 28);
			this.lblFiltros.Name = "lblFiltros";
			this.lblFiltros.Size = new System.Drawing.Size(130, 31);
			this.lblFiltros.TabIndex = 20;
			this.lblFiltros.Text = "FILTROS";
			// 
			// txtDescricao
			// 
			this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescricao.Location = new System.Drawing.Point(205, 79);
			this.txtDescricao.MaxLength = 20;
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(660, 38);
			this.txtDescricao.TabIndex = 12;
			// 
			// lbDescricao
			// 
			this.lbDescricao.AutoSize = true;
			this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDescricao.Location = new System.Drawing.Point(64, 82);
			this.lbDescricao.Name = "lbDescricao";
			this.lbDescricao.Size = new System.Drawing.Size(144, 31);
			this.lbDescricao.TabIndex = 18;
			this.lbDescricao.Text = "Descrição:";
			// 
			// dgv
			// 
			this.dgv.AllowUserToAddRows = false;
			this.dgv.AllowUserToDeleteRows = false;
			this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.GridColor = System.Drawing.Color.Black;
			this.dgv.Location = new System.Drawing.Point(68, 123);
			this.dgv.Name = "dgv";
			this.dgv.ReadOnly = true;
			this.dgv.Size = new System.Drawing.Size(906, 285);
			this.dgv.TabIndex = 19;
			this.dgv.DoubleClick += new System.EventHandler(this.DgvDoubleClick);
			// 
			// frmPesquisar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnSair;
			this.ClientSize = new System.Drawing.Size(1050, 560);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmPesquisar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pesquisar";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmPesquisarLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ResumeLayout(false);
        }
		public System.Windows.Forms.MaskedTextBox mtxtdata;
		public System.Windows.Forms.TextBox txtInvisivel;
		public System.Windows.Forms.Button btnAddServico;
		private System.Windows.Forms.GroupBox groupBox1;



        private System.Windows.Forms.Label lbDescricao;
		public System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblFiltros;
		public System.Windows.Forms.DataGridView dgv;
		public System.Windows.Forms.Button btnPesquiInativo;
		public System.Windows.Forms.Button btnNovo;
		public System.Windows.Forms.Button btnConsultar;
		public System.Windows.Forms.Button btnAlterar;
		public System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPequisar;
	}
}
