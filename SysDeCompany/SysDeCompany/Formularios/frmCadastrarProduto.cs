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
using System.Data;
using System.Data.SQLite;

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
		
		private byte _controle;
		string nomeDoArquivo = string.Empty;
		
		public byte Controle{get{return _controle;}set{_controle = value;}}
		
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
			    string Arquivo = buscaArquivo.FileName;
			 	nomeDoArquivo= Arquivo.Split(new char[] { '\\' })[Arquivo.Split(new char[] { '\\' }).Length - 1];

   				CopyFileTo(buscaArquivo.FileName,Application.StartupPath+@"\Produto\"+nomeDoArquivo);
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
			if (_controle == 1) {
				btnAlterar.Visible = false;
				btnExcluir.Visible = false;
				btnIncluir.Visible = true;
			}
			else if (_controle == 2) 
			{
				btnAlterar.Visible = true;
				btnExcluir.Visible = true;
				btnIncluir.Visible = false;
			}
			if (txtCodigo.Text != "")
			{
				clBancoDados clBancoDados = new clBancoDados();
				SQLiteConnection conn = clBancoDados.conectar();
				string stm = "SELECT * FROM TB_PRODUTO WHERE CODIGO ='"+txtCodigo.Text+"'";
				//string stm = "SELECT * FROM TB_PESSOA WHERE CODIGO ='1'";
        		SQLiteCommand cmd = new SQLiteCommand(stm, conn);
        		SQLiteDataReader rdr = cmd.ExecuteReader();
        		while(rdr.Read())
        		{
        			txtNome.Text = rdr["Nome"].ToString();
        			txtMarca.Text = rdr["MARCA"].ToString();
                    txtFornecedor.Text = rdr["FORNECEDOR"].ToString();
                    txtQuantidade.Text = rdr["QTD"].ToString();
                    txtValorCompra.Text = rdr["VALOR_COMPRA"].ToString();
                    txtValorVenda.Text = rdr["VALOR_VENDA"].ToString();
                    string nomeArquivo= rdr["IMAGEM"].ToString();
                    if (nomeArquivo != string.Empty||pbImagem.Image == null) {
                    	 pbImagem.BackgroundImage = Image.FromFile(Application.StartupPath+@"\Produto\"+nomeArquivo);
                    }
                   
        		}
        		
        		clBancoDados.desconectar(conn);
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
			Validacao(1);
		}
		public bool CopyFileTo(string filepath, string topath)
    	{
        	try   
        	{
        		File.Copy(filepath, topath,true);
        		return true;
        	}
       		catch (IOException E){
        		MessageBox.Show("Não foi possivel copia a imagem para pasta da aplicação\n" +E.Message);
       			return false;
       		}
    	}
		void Validacao(int controle){
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
					objProduto.Valor_Compra = txtValorCompra.Text;
					objProduto.Valor_Venda = txtValorVenda.Text;
					if (!nomeDoArquivo.Equals(string.Empty)){
                   		objProduto.Img = nomeDoArquivo;
                   	} 
                    
                    
                  
                   	if (controle == 1) 
                   	{
                   		objProduto.Gravar();
                   		MessageBox.Show("Salvado com Sucesso","Salvado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   		
                   	} 
                   	else if(controle == 2)
                   	{
                   		objProduto.Cod = Convert.ToInt32(txtCodigo.Text);
                   		objProduto.Alterar();
                   		MessageBox.Show("Alterado com Sucesso","Alterado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   	} 
                   	else
                   	{
                   		objProduto.Cod = Convert.ToInt32(txtCodigo.Text);
                   		objProduto.ExcluirLogicamente();
                   		MessageBox.Show("Excluido com Sucesso","Excluido",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   	}
                    foreach (TextBox txt in grbInfoProduto.Controls.OfType<TextBox>())
                    {
                     	txt.Clear();
                    }
                    this.Close();
                    
			}else
			{
				MessageBox.Show (msn,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		void BtnAlterarClick(object sender, EventArgs e)
		{
			Validacao(2);
		}
		
		void BtnExcluirClick(object sender, EventArgs e)
		{
			Validacao(0);
		}
		
		void TxtQuantidadeKeyPress(object sender, KeyPressEventArgs e)
		{
			clnValida objvalida = new clnValida();
			objvalida.soNumero(ref txtQuantidade,e);
		}
	}
}
