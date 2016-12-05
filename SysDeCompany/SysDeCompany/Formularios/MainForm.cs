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
			
		}
		void PbCadastrarPessoaClick(object sender, EventArgs e)
		{
			frmCadastrarPessoa frmPessoa = new frmCadastrarPessoa();
			frmPessoa.Control = 1;
			frmPessoa.TipoPessoa = "PF";
			frmPessoa.BackColor = this.BackColor;
			frmPessoa.ForeColor = this.ForeColor;
			frmPessoa.ShowDialog();			
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
		}		
		
		
		void PbConsultarPessoaClick(object sender, EventArgs e)
		{
			frmPesquisar objPesquisar = new frmPesquisar();
			objPesquisar.BackColor = this.BackColor;
			objPesquisar.ForeColor = this.ForeColor;
			objPesquisar.Control = 1;
			objPesquisar.ShowDialog();
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
		}
		
		
		
		void Button3Click(object sender, EventArgs e)
		{
			frmConfigura c = new frmConfigura();
			c.Owner = this;
			c.ShowDialog(this);
		}
	}
}
