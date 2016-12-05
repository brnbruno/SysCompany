/*
 * Criado por SharpDevelop.
 * Usuário: Bruno
 * Data: 12/11/2016
 * Hora: 21:04
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using SysDeCompany.Classes;

namespace DcompanySys
{
	/// <summary>
	/// Description of frmCadastrarProduto.
	/// </summary>
	public partial class frmCadastrarProduto : Form 
	{
		public frmCadastrarProduto()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private int _controle;
		
		public int Controle{get{return _controle;}set{_controle = value;}}
		
		void BtnSairClick(object sender, EventArgs e)
		{
			this.Close();
		}	
		void BtnBuscaImagemClick(object sender, EventArgs e)
		{
			buscaArquivo.Title = "Procurar Imagem...";
			buscaArquivo.CheckFileExists = true;
			buscaArquivo.CheckPathExists = true;
			buscaArquivo.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
			if (buscaArquivo.ShowDialog()==DialogResult.OK)
			{
				pbImagem.BackgroundImageLayout = ImageLayout.Stretch;
			    pbImagem.BackgroundImage = Image.FromFile(buscaArquivo.FileName);
			}
			
			
		}
		
		/*void BtnBuscarManualClick(object sender, EventArgs e)
		{
			buscaArquivo.Title = "Procurar Manual...";
			buscaArquivo.CheckFileExists = true;
			buscaArquivo.CheckPathExists = true;
			buscaArquivo.Filter = "Manual (*.PDF;*.DOC;*.DOCX)|*.PDF;*.DOC;*.DOCX|" + "All files (*.*)|*.*";
			buscaArquivo.ShowDialog();
		}*/
		
		void FrmCadastrarProdutoLoad(object sender, EventArgs e)
		{
			txtValorVenda.Text = "0";
			txtValorCompra.Text ="0";
			clnConfig clnConfig = new clnConfig();
			if(Directory.Exists("Config")&&Directory.Exists("Data")) 
			{
				pbLogoEmpresa.BackgroundImage = clnConfig.BuscaImage();
				pbLogoEmpresa.BackgroundImageLayout = ImageLayout.Stretch;
				lblNomeEmpresa.UseMnemonic = false;
				lblNomeEmpresa.Text = clnConfig.BuscaNomeEmpresa();
			}
			if (_controle==1) {
				btnAlterar.Visible = false;
				btnExcluir.Visible = false;
			}
			
			
		}
		
		void BtnLimparImagemClick(object sender, EventArgs e)
		{
			pbImagem.Image = null;
		}			
		void TxtValorVendaTextChanged(object sender, EventArgs e)
		{
			clnValida objValida = new clnValida();
			objValida.moeda(ref txtValorVenda);
		}
		
		void TxtValorCompraTextChanged(object sender, EventArgs e)
		{
			clnValida objValida = new clnValida();
			objValida.moeda(ref txtValorCompra);
		}
		
		void BtnIncluirClick(object sender, EventArgs e)
		{
			int aux = 0;
			string msn = string.Empty;
			clnValida objValida = new clnValida();
			clnProduto objProduto = new clnProduto();
			if (txtNome.Text.Length < 3) {aux++; msn = "Nome Preechido incorretamente\n";}
			if (txtMarca.Text.Length < 2){aux++; msn += "Marca Preechido incorretamente\n";}
			if (txtFornecedor.Text.Length <2){aux++; msn += "Fornecedor Preechido incorretamente\n";}
			if (txtQuantidade.Text.Length <1){aux++; msn += "Quatidade não Preechido\n";}
			if (0>=Convert.ToSingle(txtValorCompra.Text)){aux++; msn +="Valor de compra não pode ser zero\n";}
			if (0>=Convert.ToSingle(txtValorVenda.Text)){aux++; msn +="Valor de venda não pode ser zero";}
			
			if (aux == 0)
                {
					objProduto.Nome  = txtNome.Text.ToUpper();
					objProduto.QTD   = Convert.ToInt32(txtQuantidade.Text);
					objProduto.Marca = txtMarca.Text.ToUpper();
					objProduto.Fornecedor = txtFornecedor.Text.ToUpper();
					objProduto.Valor_Compra = Convert.ToSingle(txtValorCompra.Text);
					objProduto.Valor_Venda = Convert.ToSingle(txtValorVenda.Text);
                   // objProduto.Img = ;
                    
                    
                  
                   	if (_controle == 1) 
                   	{
                   		objProduto.Gravar();
                   		MessageBox.Show("Salvado com Sucesso","Salvado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   		
                   	} 
                   	else if(_controle == 2)
                   	{
                   		objProduto.Cod = Convert.ToInt16(txtCodigo.Text);
                   		objProduto.Alterar();
                   		MessageBox.Show("Alterado com Sucesso","Alterado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   	} 
                   	else
                   	{
                   		objProduto.Cod =Convert.ToInt16(txtCodigo.Text);
                   		objProduto.ExcluirLogicamente();
                   		MessageBox.Show("Excluido com Sucesso","Excluido",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   	}
                    foreach (TextBox txt in grbInfoProduto.Controls.OfType<TextBox>())
                    {
                     	txt.Clear();
                    }
                    
			}else
			{
				MessageBox.Show (msn,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
	}
}
