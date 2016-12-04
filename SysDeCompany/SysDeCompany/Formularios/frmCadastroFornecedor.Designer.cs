/*
 * Created by SharpDevelop.
 * User: MAQLAB
 * Date: 23/11/2016
 * Time: 13:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DcompanySys
{
	partial class frmCadastroFornecedor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFornecedor));
			this.grbPrincipal = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblNomeEmpresa = new System.Windows.Forms.Label();
			this.pbLogoEmpresa = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnIncluir = new System.Windows.Forms.Button();
			this.grbPrincipal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogoEmpresa)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbPrincipal
			// 
			this.grbPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.grbPrincipal.Controls.Add(this.flowLayoutPanel1);
			this.grbPrincipal.Controls.Add(this.groupBox1);
			this.grbPrincipal.Controls.Add(this.label1);
			this.grbPrincipal.Controls.Add(this.lblNomeEmpresa);
			this.grbPrincipal.Controls.Add(this.pbLogoEmpresa);
			this.grbPrincipal.Location = new System.Drawing.Point(12, 12);
			this.grbPrincipal.Name = "grbPrincipal";
			this.grbPrincipal.Size = new System.Drawing.Size(868, 604);
			this.grbPrincipal.TabIndex = 0;
			this.grbPrincipal.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(222, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(319, 45);
			this.label1.TabIndex = 5;
			this.label1.Text = "Cadastrar  Fornecedor";
			// 
			// lblNomeEmpresa
			// 
			this.lblNomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeEmpresa.Location = new System.Drawing.Point(165, 19);
			this.lblNomeEmpresa.Name = "lblNomeEmpresa";
			this.lblNomeEmpresa.Size = new System.Drawing.Size(509, 52);
			this.lblNomeEmpresa.TabIndex = 4;
			this.lblNomeEmpresa.Text = "Nome Empresa";
			// 
			// pbLogoEmpresa
			// 
			this.pbLogoEmpresa.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pbLogoEmpresa.Location = new System.Drawing.Point(17, 19);
			this.pbLogoEmpresa.Name = "pbLogoEmpresa";
			this.pbLogoEmpresa.Size = new System.Drawing.Size(133, 120);
			this.pbLogoEmpresa.TabIndex = 3;
			this.pbLogoEmpresa.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(39, 164);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(779, 219);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.Controls.Add(this.btnSair);
			this.flowLayoutPanel1.Controls.Add(this.btnAlterar);
			this.flowLayoutPanel1.Controls.Add(this.btnExcluir);
			this.flowLayoutPanel1.Controls.Add(this.btnIncluir);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(393, 488);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(425, 100);
			this.flowLayoutPanel1.TabIndex = 7;
			// 
			// btnSair
			// 
			this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
			this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.Location = new System.Drawing.Point(322, 3);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(100, 96);
			this.btnSair.TabIndex = 4;
			this.btnSair.Text = "Sair";
			this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSair.UseVisualStyleBackColor = true;
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
			// 
			// frmCadastroFornecedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(892, 628);
			this.Controls.Add(this.grbPrincipal);
			this.Name = "frmCadastroFornecedor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmCadastroFornecedor";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.grbPrincipal.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbLogoEmpresa)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnIncluir;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pbLogoEmpresa;
		private System.Windows.Forms.Label lblNomeEmpresa;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox grbPrincipal;
	}
}
