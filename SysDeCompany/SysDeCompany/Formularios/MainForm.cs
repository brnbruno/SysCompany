/*
 * Created by SharpDevelop.
 * User: Bruno
 * Date: 26/11/2016
 * Time: 14:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SysDeCompany.Classes;
using DcompanySys;
using System.Linq;
using System.Data;
using System.Data.SQLite;

namespace SysDeCompany
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			if(!Directory.Exists("Config")) {  
          			Directory.CreateDirectory("Config");  
          		}			
				clBancoDados clBancoDados = new clBancoDados();			   	
				clBancoDados.existe();
				if(pictureBox1.Image != null&&Directory.Exists("Data")){
			   		frmConfigura frmConfigura = new frmConfigura();
			   		frmConfigura.ShowDialog();}
			   	clnConfig clnConfig = new clnConfig();
			   	
			if(Directory.Exists("Config")&&Directory.Exists("Data")) 
			{
				Atualizar();
			}
			if (!Directory.Exists("Produto")){
				Directory.CreateDirectory("Produto");
			}
			LerbancoClick();
			
		}
		void PbCadastrarPessoaClick(object sender, EventArgs e)
		{
			frmCadastrarPessoa frmPessoa = new frmCadastrarPessoa();
			frmPessoa.Control = 1;
			frmPessoa.TipoPessoa = "PF";
			frmPessoa.BackColor = this.BackColor;
			frmPessoa.ForeColor = this.ForeColor;
			frmPessoa.ShowDialog();
			LerbancoClick();
		}
		void PbCadastrarProdutoClick(object sender, EventArgs e)
		{
			frmCadastrarProduto frmProduto = new frmCadastrarProduto();
			frmProduto.Controle = 1;
			frmProduto.BackColor = this.BackColor;
			frmProduto.ForeColor = this.ForeColor;
			frmProduto.ShowDialog();
		}		
		

		void PbCadastrarPessoaMouseHover(object sender, EventArgs e)
		{
			pbCadastrarPessoa.Size = new Size(200,200);
			lblCadastro.Text = "Cliente";
		}
		void PbCadastrarProdutoMouseHover(object sender, EventArgs e)
		{
			pbCadastrarProduto.Size = new Size(200,200);
			lblCadastro.Text = "Produto";
		}
		void PbCadastrarSevicoMouseHover(object sender, EventArgs e)
		{
			pbCadastrarSevico.Size = new Size(200,200);
			lblCadastro.Text = "Serviço";
		}
		//void PbCadastroFornecedoMouseHover(object sender, EventArgs e)
		//{
			//pbCadastroFornecedor.Size = new Size(200,200);
			//lblMenu.Text = "Cadastrar Fornecedor";
		//}
		void PbConsultarPessoaMouseHover(object sender, System.EventArgs e)
		{
			pbConsultarPessoa.Size = new Size(200,200);
			lblConsulta.Text = "Clientes";
		}
		void PbConsultarProdutoMouseHover(object sender, EventArgs e)
		{
			pbConsultarProduto.Size = new Size(200,200);
			lblConsulta.Text = "Produto";
		}
		void PbConsultarServicoMouseHover(object sender, EventArgs e)
		{
			pbConsultarServico.Size = new Size(200,200);
			lblConsulta.Text = "Serviço";
		}
		void PbConfiguracaoMouseHover(object sender, EventArgs e)
		{
			Image img = pbConfiguracao.BackgroundImage;
			pbConfiguracao.BackgroundImage = pbImageConfig.BackgroundImage;
			pbImageConfig.BackgroundImage = img;
			pbConfiguracao.Size = new Size(200,200);
		}
		
		
		
		
		void PbCadastrarPessoaMouseLeave(object sender, EventArgs e)
		{	
			pbCadastrarPessoa.Size = new Size(150,150);
			lblCadastro.Text = "...";
		}
		void PbCadastrarProdutoMouseLeave(object sender, EventArgs e)
		{
			pbCadastrarProduto.Size = new Size(150,150);
			lblCadastro.Text = "...";
		}
		void PbCadastrarSevicoMouseLeave(object sender, EventArgs e)
		{
			pbCadastrarSevico.Size = new Size(150,150);
			lblCadastro.Text = "...";
		}
		//void PbCadastroFornecedoMouseLeave(object sender, EventArgs e)
		//{
			//pbCadastroFornecedor.Size = new Size(150,150);
			//lblMenu.Text = "";
		//}
		void  PbConsultarPessoaMouseLeave(object sender, EventArgs e)
		{
			pbConsultarPessoa.Size = new Size(150,150);
			lblConsulta.Text ="...";
		}
		void PbConsultarProdutoMouseLeave(object sender, EventArgs e)
		{
			pbConsultarProduto.Size = new Size(150,150);
			lblConsulta.Text ="...";
		}
		void PbConsultarServicoMouseLeave(object sender, EventArgs e)
		{
			pbConsultarServico.Size = new Size(150,150);
			lblConsulta.Text = "...";
		}
		void PbConfiguracaoMouseLeave(object sender, EventArgs e)
		{
			Image img = pbConfiguracao.BackgroundImage;
			pbConfiguracao.BackgroundImage = pbImageConfig.BackgroundImage;
			pbImageConfig.BackgroundImage = img;
			pbConfiguracao.Size = new Size(150,150);
		}
		
		
		void PbCadastroFornecedorClick(object sender, EventArgs e)
		{
			frmCadastroFornecedor frmCadastroFornecedor = new frmCadastroFornecedor();
			frmCadastroFornecedor.ShowDialog();
		}
		
		
		
		
		void PbConfiguracaoClick(object sender, EventArgs e)
		{
			frmConfigura frmConfigura = new frmConfigura();
			frmConfigura.Owner = this;
			frmConfigura.lbfontform.ForeColor = this.ForeColor;
			frmConfigura.pbCordoFormulario.BackColor = this.BackColor;
			frmConfigura.lbfontform.BackColor = this.BackColor;
			frmConfigura.ShowDialog(this);
		}
		public void Atualizar()
		{
			clnConfig objConfig = new clnConfig();
			pbLogoEmpresa.BackgroundImage = objConfig.BuscaImage();
			pbLogoEmpresa.BackgroundImageLayout = ImageLayout.Stretch;
			lblNomeEmpresa.UseMnemonic = false;
			lblNomeEmpresa.Text = objConfig.BuscaNomeEmpresa();
			this.BackColor = Color.FromArgb(objConfig.BuscaCorFundo());
			this.ForeColor = Color.FromArgb(objConfig.BuscaCorFonte());
			LerbancoClick();
		}		
		
		
		void PbConsultarPessoaClick(object sender, EventArgs e)
		{
			frmPesquisar objPesquisar = new frmPesquisar();
			objPesquisar.BackColor = this.BackColor;
			objPesquisar.ForeColor = this.ForeColor;
			objPesquisar.Control = 1;
			objPesquisar.ShowDialog();
			LerbancoClick();
		}
		
		void PbConsultarProdutoClick(object sender, EventArgs e)
		{
			frmPesquisar objPesquisar = new frmPesquisar();
			objPesquisar.BackColor = this.BackColor;
			objPesquisar.ForeColor = this.ForeColor;
			objPesquisar.Control = 2;
			objPesquisar.ShowDialog();
		}
		
		void PbConsultarServicoClick(object sender, EventArgs e)
		{
			frmPesquisar objPesquisar = new frmPesquisar();
			objPesquisar.BackColor = this.BackColor;
			objPesquisar.ForeColor = this.ForeColor;
			objPesquisar.Control = 3;
			objPesquisar.txtDescricao.Visible = false;
			objPesquisar.mtxtdata.Visible = true;
			objPesquisar.btnAddServico.Visible =false;
			objPesquisar.ShowDialog();
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			lblHora.Text = String.Format("Data: {0:dd/MM/yyyy} Hora: {1:HH:mm:ss}", DateTime.Now, DateTime.Now);
		}
		
		void PbCadastrarSevicoClick(object sender, EventArgs e)
		{
			frmCadastroServico frmServico = new frmCadastroServico();
			frmServico.Control = 1;
			frmServico.BackColor = this.BackColor;
			frmServico.ForeColor = this.ForeColor;
			frmServico.ShowDialog();
			LerbancoClick();
		}
		public void Btn_Click(Control control)
        {
            control.Click += delegate(object sender, EventArgs e)
            {
            	frmCadastroServico 	frmServico = new frmCadastroServico();
            	frmServico.txtCodigo.Text = control.Name;
            	frmServico.BackColor = this.BackColor;
				frmServico.ForeColor = this.ForeColor;
				frmServico.btnIncluir.Text = "Concluído";
				frmServico.btnExcluirPro.Visible =false;
				frmServico.btnAdd.Visible = false;
            	frmServico.ShowDialog();
            	LerbancoClick();
            };
		}
				
		
		void LerbancoClick()
		{
			flpservico.Controls.Clear();
			string data = DateTime.Now.ToString("ddMMyyyy");
			clBancoDados clBancoDados = new clBancoDados();
		 	SQLiteConnection conn = clBancoDados.conectar();
			string nome = string.Empty;
			string stm = "SELECT * FROM TB_SERVICO Where status = 1 and data_cod like '%" + data.ToString()+"'";
			SQLiteCommand cmd = new SQLiteCommand(stm, conn);
        	SQLiteDataReader rdr = cmd.ExecuteReader();
        	Panel pnl;
        	while(rdr.Read()){
        		pnl = new Panel();
				Label lblnome = new Label();
				Button btn = new Button();
				pnl.ForeColor = this.BackColor;
				pnl.BackColor = this.ForeColor;
				pnl.Size = new System.Drawing.Size(flpservico.Width-10, 98);
				lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				lblnome.Location = new System.Drawing.Point(7, 16);
				lblnome.Size = new System.Drawing.Size(264, 38);
				lblnome.Text = "Código : "+ rdr["codigo"].ToString();
				btn.Location = new System.Drawing.Point(flpservico.Width -150 , 64);
				btn.Name = rdr["codigo"].ToString();
				btn.Size = new System.Drawing.Size(120, 28);
				btn.Text = "Click para ver mais...";
				btn.UseVisualStyleBackColor = true;
				Btn_Click(btn);
				pnl.Controls.Add(lblnome);
				pnl.Controls.Add(btn);
				flpservico.Controls.Add(pnl);
        	}
        	clBancoDados.desconectar(conn);	
		}
	}

}
