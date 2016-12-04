/*
 * Created by SharpDevelop.
 * User: Valdelis
 * Date: 26/11/2016
 * Time: 14:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SysDeCompany
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pbImageConfig = new System.Windows.Forms.PictureBox();
			this.grbPrincipal = new System.Windows.Forms.GroupBox();
			this.lblConsulta = new System.Windows.Forms.Label();
			this.lblCadastro = new System.Windows.Forms.Label();
			this.lblCadastroti = new System.Windows.Forms.Label();
			this.lblConsultarti = new System.Windows.Forms.Label();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.pbConsultarPessoa = new System.Windows.Forms.PictureBox();
			this.pbConsultarProduto = new System.Windows.Forms.PictureBox();
			this.pbConsultarServico = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.pbCadastrarPessoa = new System.Windows.Forms.PictureBox();
			this.pbCadastrarProduto = new System.Windows.Forms.PictureBox();
			this.pbCadastrarSevico = new System.Windows.Forms.PictureBox();
			this.pbConfiguracao = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblNomeEmpresa = new System.Windows.Forms.Label();
			this.pbLogoEmpresa = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbImageConfig)).BeginInit();
			this.grbPrincipal.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbConsultarPessoa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbConsultarProduto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbConsultarServico)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCadastrarPessoa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCadastrarProduto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCadastrarSevico)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbConfiguracao)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoEmpresa)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 209);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(84, 209);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// pbImageConfig
			// 
			this.pbImageConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbImageConfig.BackgroundImage")));
			this.pbImageConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbImageConfig.Location = new System.Drawing.Point(487, 3);
			this.pbImageConfig.Name = "pbImageConfig";
			this.pbImageConfig.Size = new System.Drawing.Size(75, 101);
			this.pbImageConfig.TabIndex = 8;
			this.pbImageConfig.TabStop = false;
			this.pbImageConfig.Visible = false;
			// 
			// grbPrincipal
			// 
			this.grbPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.grbPrincipal.Controls.Add(this.label2);
			this.grbPrincipal.Controls.Add(this.lblConsulta);
			this.grbPrincipal.Controls.Add(this.lblCadastro);
			this.grbPrincipal.Controls.Add(this.lblCadastroti);
			this.grbPrincipal.Controls.Add(this.pbConfiguracao);
			this.grbPrincipal.Controls.Add(this.lblConsultarti);
			this.grbPrincipal.Controls.Add(this.flowLayoutPanel2);
			this.grbPrincipal.Controls.Add(this.flowLayoutPanel1);
			this.grbPrincipal.Location = new System.Drawing.Point(12, 138);
			this.grbPrincipal.Name = "grbPrincipal";
			this.grbPrincipal.Size = new System.Drawing.Size(756, 794);
			this.grbPrincipal.TabIndex = 9;
			this.grbPrincipal.TabStop = false;
			// 
			// lblConsulta
			// 
			this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConsulta.Location = new System.Drawing.Point(318, 288);
			this.lblConsulta.Name = "lblConsulta";
			this.lblConsulta.Size = new System.Drawing.Size(424, 63);
			this.lblConsulta.TabIndex = 10;
			this.lblConsulta.Text = "...";
			// 
			// lblCadastro
			// 
			this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCadastro.Location = new System.Drawing.Point(318, 12);
			this.lblCadastro.Name = "lblCadastro";
			this.lblCadastro.Size = new System.Drawing.Size(424, 64);
			this.lblCadastro.TabIndex = 9;
			this.lblCadastro.Text = "...";
			// 
			// lblCadastroti
			// 
			this.lblCadastroti.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCadastroti.Location = new System.Drawing.Point(19, 16);
			this.lblCadastroti.Name = "lblCadastroti";
			this.lblCadastroti.Size = new System.Drawing.Size(718, 60);
			this.lblCadastroti.TabIndex = 8;
			this.lblCadastroti.Text = "Cadastrar :";
			// 
			// lblConsultarti
			// 
			this.lblConsultarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConsultarti.Location = new System.Drawing.Point(13, 288);
			this.lblConsultarti.Name = "lblConsultarti";
			this.lblConsultarti.Size = new System.Drawing.Size(718, 60);
			this.lblConsultarti.TabIndex = 7;
			this.lblConsultarti.Text = "Consultar :";
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.pbConsultarPessoa);
			this.flowLayoutPanel2.Controls.Add(this.pbConsultarProduto);
			this.flowLayoutPanel2.Controls.Add(this.pbConsultarServico);
			this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(16, 351);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(576, 208);
			this.flowLayoutPanel2.TabIndex = 6;
			// 
			// pbConsultarPessoa
			// 
			this.pbConsultarPessoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbConsultarPessoa.BackgroundImage")));
			this.pbConsultarPessoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbConsultarPessoa.Location = new System.Drawing.Point(3, 3);
			this.pbConsultarPessoa.Name = "pbConsultarPessoa";
			this.pbConsultarPessoa.Size = new System.Drawing.Size(150, 150);
			this.pbConsultarPessoa.TabIndex = 5;
			this.pbConsultarPessoa.TabStop = false;
			this.pbConsultarPessoa.Click += new System.EventHandler(this.PbConsultarPessoaClick);
			this.pbConsultarPessoa.MouseLeave += new System.EventHandler(this.PbConsultarPessoaMouseLeave);
			this.pbConsultarPessoa.MouseHover += new System.EventHandler(this.PbConsultarPessoaMouseHover);
			// 
			// pbConsultarProduto
			// 
			this.pbConsultarProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbConsultarProduto.BackgroundImage")));
			this.pbConsultarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbConsultarProduto.Location = new System.Drawing.Point(159, 3);
			this.pbConsultarProduto.Name = "pbConsultarProduto";
			this.pbConsultarProduto.Size = new System.Drawing.Size(150, 150);
			this.pbConsultarProduto.TabIndex = 6;
			this.pbConsultarProduto.TabStop = false;
			this.pbConsultarProduto.Click += new System.EventHandler(this.PbConsultarProdutoClick);
			this.pbConsultarProduto.MouseLeave += new System.EventHandler(this.PbConsultarProdutoMouseLeave);
			this.pbConsultarProduto.MouseHover += new System.EventHandler(this.PbConsultarProdutoMouseHover);
			// 
			// pbConsultarServico
			// 
			this.pbConsultarServico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbConsultarServico.BackgroundImage")));
			this.pbConsultarServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbConsultarServico.Location = new System.Drawing.Point(315, 3);
			this.pbConsultarServico.Name = "pbConsultarServico";
			this.pbConsultarServico.Size = new System.Drawing.Size(150, 150);
			this.pbConsultarServico.TabIndex = 7;
			this.pbConsultarServico.TabStop = false;
			this.pbConsultarServico.Click += new System.EventHandler(this.PbConsultarServicoClick);
			this.pbConsultarServico.MouseLeave += new System.EventHandler(this.PbConsultarServicoMouseLeave);
			this.pbConsultarServico.MouseHover += new System.EventHandler(this.PbConsultarServicoMouseHover);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(471, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(10, 200);
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.pbCadastrarPessoa);
			this.flowLayoutPanel1.Controls.Add(this.pbCadastrarProduto);
			this.flowLayoutPanel1.Controls.Add(this.pbCadastrarSevico);
			this.flowLayoutPanel1.Controls.Add(this.pictureBox4);
			this.flowLayoutPanel1.Controls.Add(this.pbImageConfig);
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Controls.Add(this.button2);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 79);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(576, 206);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// pbCadastrarPessoa
			// 
			this.pbCadastrarPessoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCadastrarPessoa.BackgroundImage")));
			this.pbCadastrarPessoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbCadastrarPessoa.Location = new System.Drawing.Point(3, 3);
			this.pbCadastrarPessoa.Name = "pbCadastrarPessoa";
			this.pbCadastrarPessoa.Size = new System.Drawing.Size(150, 150);
			this.pbCadastrarPessoa.TabIndex = 0;
			this.pbCadastrarPessoa.TabStop = false;
			this.pbCadastrarPessoa.Click += new System.EventHandler(this.PbCadastrarPessoaClick);
			this.pbCadastrarPessoa.MouseLeave += new System.EventHandler(this.PbCadastrarPessoaMouseLeave);
			this.pbCadastrarPessoa.MouseHover += new System.EventHandler(this.PbCadastrarPessoaMouseHover);
			// 
			// pbCadastrarProduto
			// 
			this.pbCadastrarProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCadastrarProduto.BackgroundImage")));
			this.pbCadastrarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbCadastrarProduto.Location = new System.Drawing.Point(159, 3);
			this.pbCadastrarProduto.Name = "pbCadastrarProduto";
			this.pbCadastrarProduto.Size = new System.Drawing.Size(150, 150);
			this.pbCadastrarProduto.TabIndex = 1;
			this.pbCadastrarProduto.TabStop = false;
			this.pbCadastrarProduto.Click += new System.EventHandler(this.PbCadastrarProdutoClick);
			this.pbCadastrarProduto.MouseLeave += new System.EventHandler(this.PbCadastrarProdutoMouseLeave);
			this.pbCadastrarProduto.MouseHover += new System.EventHandler(this.PbCadastrarProdutoMouseHover);
			// 
			// pbCadastrarSevico
			// 
			this.pbCadastrarSevico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCadastrarSevico.BackgroundImage")));
			this.pbCadastrarSevico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbCadastrarSevico.Location = new System.Drawing.Point(315, 3);
			this.pbCadastrarSevico.Name = "pbCadastrarSevico";
			this.pbCadastrarSevico.Size = new System.Drawing.Size(150, 150);
			this.pbCadastrarSevico.TabIndex = 2;
			this.pbCadastrarSevico.TabStop = false;
			this.pbCadastrarSevico.Click += new System.EventHandler(this.PbCadastrarSevicoClick);
			this.pbCadastrarSevico.MouseLeave += new System.EventHandler(this.PbCadastrarSevicoMouseLeave);
			this.pbCadastrarSevico.MouseHover += new System.EventHandler(this.PbCadastrarSevicoMouseHover);
			// 
			// pbConfiguracao
			// 
			this.pbConfiguracao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbConfiguracao.BackgroundImage")));
			this.pbConfiguracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbConfiguracao.Location = new System.Drawing.Point(19, 600);
			this.pbConfiguracao.Name = "pbConfiguracao";
			this.pbConfiguracao.Size = new System.Drawing.Size(150, 150);
			this.pbConfiguracao.TabIndex = 3;
			this.pbConfiguracao.TabStop = false;
			this.pbConfiguracao.Click += new System.EventHandler(this.PbConfiguracaoClick);
			this.pbConfiguracao.MouseLeave += new System.EventHandler(this.PbConfiguracaoMouseLeave);
			this.pbConfiguracao.MouseHover += new System.EventHandler(this.PbConfiguracaoMouseHover);
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox4.Location = new System.Drawing.Point(471, 3);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(10, 200);
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Location = new System.Drawing.Point(771, 89);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(501, 843);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 16);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(495, 824);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(771, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(501, 42);
			this.label1.TabIndex = 11;
			this.label1.Text = "...";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// lblNomeEmpresa
			// 
			this.lblNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeEmpresa.Location = new System.Drawing.Point(164, 44);
			this.lblNomeEmpresa.Name = "lblNomeEmpresa";
			this.lblNomeEmpresa.Size = new System.Drawing.Size(601, 68);
			this.lblNomeEmpresa.TabIndex = 13;
			this.lblNomeEmpresa.Text = "Nome Empresa";
			// 
			// pbLogoEmpresa
			// 
			this.pbLogoEmpresa.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pbLogoEmpresa.Location = new System.Drawing.Point(12, 12);
			this.pbLogoEmpresa.Name = "pbLogoEmpresa";
			this.pbLogoEmpresa.Size = new System.Drawing.Size(133, 120);
			this.pbLogoEmpresa.TabIndex = 12;
			this.pbLogoEmpresa.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 562);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(715, 35);
			this.label2.TabIndex = 11;
			this.label2.Text = "Configuração :";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1284, 937);
			this.Controls.Add(this.lblNomeEmpresa);
			this.Controls.Add(this.pbLogoEmpresa);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grbPrincipal);
			this.Name = "MainForm";
			this.Text = "SysDeCompany";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pbImageConfig)).EndInit();
			this.grbPrincipal.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbConsultarPessoa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbConsultarProduto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbConsultarServico)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbCadastrarPessoa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCadastrarProduto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCadastrarSevico)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbConfiguracao)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoEmpresa)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblCadastro;
		private System.Windows.Forms.Label lblConsultarti;
		private System.Windows.Forms.Label lblCadastroti;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.PictureBox pbLogoEmpresa;
		private System.Windows.Forms.Label lblNomeEmpresa;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox grbPrincipal;
		private System.Windows.Forms.PictureBox pbImageConfig;
		private System.Windows.Forms.PictureBox pbConsultarServico;
		private System.Windows.Forms.PictureBox pbConsultarProduto;
		private System.Windows.Forms.PictureBox pbConsultarPessoa;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pbConfiguracao;
		private System.Windows.Forms.PictureBox pbCadastrarSevico;
		private System.Windows.Forms.PictureBox pbCadastrarProduto;
		private System.Windows.Forms.PictureBox pbCadastrarPessoa;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label lblConsulta;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}
