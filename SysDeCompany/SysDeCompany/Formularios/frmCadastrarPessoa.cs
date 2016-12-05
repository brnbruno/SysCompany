/*
 * Criado por SharpDevelop.
 * Usuário: Bruno
 * Data: 09/11/2016
 * Hora: 14:11
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
	/// Description of frmCadastrarPessoa.
	/// </summary>
	public partial class frmCadastrarPessoa : Form
	{
		public frmCadastrarPessoa()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private int _control;
		private string _tipopessoa;
		
		public int Control{get{return _control;}set{_control = value;}}
		public string TipoPessoa{get{return _tipopessoa;}set{_tipopessoa = value;}}
		
		void RbPessoaJuridicaClick(object sender, EventArgs e)
		{
			lblNomeOuRazao.Text = "Razão:";
			lblCpfOuCNPJ.Text = "CNPJ :";
			mtxtCnpj.Visible = true;
			txtIE.Visible = true;
			lblIE.Visible = true;
			mtxtCpf.Text = "";
			
		}
		void RbPessoaFisicaClick(object sender, EventArgs e)
		{
			lblNomeOuRazao.Text = "Nome :";
			lblCpfOuCNPJ.Text = "CPF :";
			mtxtCnpj.Visible = false;
			txtIE.Visible = false;
			lblIE.Visible = false;
			mtxtCnpj.Text = "";
			txtIE.Text = "";
		}
		void BtnSairClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnIncluirClick(object sender, EventArgs e)
		{
			Validacao(1);
		}
		
		private void Validacao(int controle)
		{
			clnValida objValida = new clnValida();
			clnPessoa objPessoa = new clnPessoa();
			objValida.txtNomeValidacao(ref txtNomeOuRazao);
			objValida.txtEndereco(ref txtEndereco);
			objValida.txtBairro(ref txtBairro);
			objValida.txtCidade(ref txtCidade);
			objValida.txtNr(ref txtNumero);
			objValida.maskedCepfvalidacao(ref mtxtCep);
			objValida.maskedTelValidacao(ref mtxtTelefone,mtxtTelefone2,mtxtCelular);			
			if(cbUF.Text.Length < 2)
			{
				objValida.msn += " Selecione um Estado\n";
				objValida.aux++;
			}
			string cpf = mtxtCpf.Text;
			string cnpj = mtxtCnpj.Text;
			string tipopessoa =string.Empty;
			if(rbPessoaFisica.Checked)
			{
				tipopessoa = "PF";
				if(!clValidacao.isCpf(cpf)&&_control!=0)
				{
					objValida.msn += "CPF Inválido\n";
					objValida.aux++;
				}
			}
			else
			{
				tipopessoa = "PJ";
				if (!clValidacao.isCnpj (cnpj) &&_control!=0)
				{
					objValida.msn += "CNPJ Inválido\n";
					objValida.aux++;					
				} 
			}			
			if (objValida.aux < 1)
                {
					objPessoa.Nome = txtNomeOuRazao.Text.ToUpper();
					objPessoa.Cpf  = cpf.Replace(".","").Replace("-","");
					objPessoa.Telefone = mtxtTelefone.Text.Replace("(", "").Replace("-", "").Replace(")", "").Replace(" ",""); 
					objPessoa.Telefone2 = mtxtTelefone2.Text.Replace("(", "").Replace("-", "").Replace(")", "").Replace(" ","");
                    objPessoa.Celular = mtxtCelular.Text.Replace("(", "").Replace("-", "").Replace(")", "").Replace(" ",""); 
                    objPessoa.Cep = mtxtCep.Text.Replace(".","").Replace("-","");
                    objPessoa.Endereco = txtEndereco.Text.ToUpper();
                    objPessoa.Cidade = txtCidade.Text.ToUpper();
                    objPessoa.Bairro = txtBairro.Text.ToUpper();
                    objPessoa.Nr = txtNumero.Text;
                    objPessoa.Uf = cbUF.Text;
                    objPessoa.Tipopessoa = tipopessoa;
                    objPessoa.Ie = txtIE.Text;
                    objPessoa.Cnpj = mtxtCnpj.Text.Replace(".","").Replace("/","").Replace("-","");
                    objPessoa.Complemeto = txtComplemento.Text.ToUpper();
                    
                  
                   	if (controle == 1) 
                   	{
                   		objPessoa.Gravar();
                   		MessageBox.Show("Salvado com Sucesso","Salvado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   		
                   	} 
                   	else if(controle == 2)
                   	{
                   		objPessoa.Cod =Convert.ToInt16(txtCodigo.Text);
                   		objPessoa.Alterar();
                   		MessageBox.Show("Alterado com Sucesso","Alterado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   	} else{
                   		objPessoa.Cod =Convert.ToInt16(txtCodigo.Text);
                   		objPessoa.ExcluirLogicamente();
                   		MessageBox.Show("Excluido com Sucesso","Excluido",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   	}
                    foreach (TextBox txt in grbDadosPessoais.Controls.OfType<TextBox>())
                    {
                     	txt.Clear();
                    }
                    foreach (MaskedTextBox mtxt in grbDadosPessoais.Controls.OfType<MaskedTextBox>())
                    {
                     	mtxt.Clear();
                    }
					foreach (MaskedTextBox mtxt in grbDocumentoTelefone.Controls.OfType<MaskedTextBox>())
                    {
                     	mtxt.Clear();
                    } 
					txtIE.Clear();
					cbUF.SelectedIndex = -1;
			}else
			{
				MessageBox.Show (objValida.msn,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			this.Close();
			
		}
		
		
		void FrmCadastrarPessoaLoad(object sender, EventArgs e)
		{
			clnConfig clnConfig = new clnConfig();
			if(Directory.Exists("Config")&&Directory.Exists("Data")) 
			{
				pbLogoEmpresa.BackgroundImage = clnConfig.BuscaImage();
				pbLogoEmpresa.BackgroundImageLayout = ImageLayout.Stretch;
				lblNomeEmpresa.UseMnemonic = false;
				lblNomeEmpresa.Text = clnConfig.BuscaNomeEmpresa();
			}
			if (_tipopessoa =="PF") {
				rbPessoaFisica.Checked = true;
			}
			else{
				rbPessoaJuridica.Checked = true;
			}
			
			if (_control==1) {
				btnAlterar.Visible = false;
				btnExcluir.Visible = false;
				btnIncluir.Visible = true;
			}
			if (_control==2) {
				btnAlterar.Visible = true;
				btnExcluir.Visible = true;
				btnIncluir.Visible = false;
			}
			if (txtCodigo.Text != "")
			{
				clBancoDados clBancoDados = new clBancoDados();
				SQLiteConnection conn = clBancoDados.conectar();
				string stm = "SELECT * FROM TB_PESSOA WHERE CODIGO ='"+txtCodigo.Text+"'";
				//string stm = "SELECT * FROM TB_PESSOA WHERE CODIGO ='1'";
        		SQLiteCommand cmd = new SQLiteCommand(stm, conn);
        		SQLiteDataReader rdr = cmd.ExecuteReader();
        		while(rdr.Read())
        		{
        			txtNomeOuRazao.Text = rdr["Nome"].ToString();
        			mtxtTelefone.Text = rdr["Telefone"].ToString();
                    mtxtTelefone2.Text = rdr["Telefone2"].ToString();
                    mtxtCelular.Text = rdr["Celular"].ToString();
                    mtxtCep.Text = rdr["CPE"].ToString();
                    txtEndereco.Text = rdr["Endereco"].ToString();
                    txtCidade.Text = rdr["Cidade"].ToString();
                    txtBairro.Text = rdr["bairro"].ToString();
                    txtNumero.Text = rdr["numero"].ToString();
                    cbUF.Text = rdr["uf"].ToString();
                    txtComplemento.Text = rdr["Complemento"].ToString();
                    string tipoPesso = rdr["Tipo_pessoa"].ToString();
                    
                    if (tipoPesso == "PF") {
                    	rbPessoaFisica.PerformClick();
                    	grbTipoPessoa.Enabled = true;
                    	mtxtCpf.Text = rdr["CPF"].ToString();
                    }else{
                    	mtxtCnpj.Text = rdr["Cnpj"].ToString();
                    	txtIE.Text = rdr["IncricaoEstadual"].ToString();
                    }
                   
        		}
        		clBancoDados.desconectar(conn);
        	}
        		
		}
		

		void BtnExcluirClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Você deseja excluir este registro","Atenção...",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes) {
				Validacao(0);
			}
			
		}
		
		void BtnAlterarClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Você deseja Alterar este registro","Atenção...",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes) {
				Validacao(2);
			}
		}
	}
}

