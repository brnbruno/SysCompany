/*
 * Created by SharpDevelop.
 * User: Bruno
 * Date: 17/11/2016
 * Time: 07:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using SysDeCompany.Classes;
using System.IO;
using System.Data;
using System.Data.SQLite;
using System.Globalization;

namespace DcompanySys
{
	/// <summary>
	/// Description of frmCadastroServico.
	/// </summary>
	public partial class frmCadastroServico : Form
	{
		public frmCadastroServico()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private byte _control;
		private int _cod_produto;
		private int _quantidade;
		
		public byte Control{get{return _control;}set{_control = value;}}
		public int CodProduto{get{return _cod_produto;}set{_cod_produto = value;}}
		public int Quantidade{get{return +_quantidade;}set{_quantidade = value;}}
		
		
		void BtnSairClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnConsultarClick(object sender, EventArgs e)
		{
			frmPesquisar frmPesquisar = new frmPesquisar();
			frmPesquisar.Owner = this;
			frmPesquisar.BackColor = this.BackColor;
			frmPesquisar.ForeColor = this.ForeColor;
			frmPesquisar.btnNovo.Visible=false;
			frmPesquisar.btnAlterar.Visible =false;
			frmPesquisar.btnExcluir.Visible = false;
			frmPesquisar.btnConsultar.Visible=false;
			frmPesquisar.Control = 1;
			frmPesquisar.btnAddServico.Location = frmPesquisar.btnNovo.Location;
			frmPesquisar.ShowDialog(this);
			LerBanco();
		}
		
		void FrmCadastroServicoLoad(object sender, EventArgs e)
		{
			clnConfig clnConfig = new clnConfig();
			if(Directory.Exists("Config")&&Directory.Exists("Data")) 
			{
				pbLogoEmpresa.BackgroundImage = clnConfig.BuscaImage();
				pbLogoEmpresa.BackgroundImageLayout = ImageLayout.Stretch;
				lblNomeEmpresa.UseMnemonic = false;
				lblNomeEmpresa.Text = clnConfig.BuscaNomeEmpresa();				
			}
			if (_control==1) {
				btnAlterar.Visible = false;
				btnExcluir.Visible = false;
			}
			LerBanco();
			mtxtdate.Text = DateTime.Now.ToString();
			dgvServico.BackgroundColor = this.BackColor;
			dgvServico.GridColor = this.BackColor;
			dgvServico.DefaultCellStyle.BackColor = this.BackColor;
			dgvServico.DefaultCellStyle.SelectionForeColor = this.BackColor;
   			dgvServico.DefaultCellStyle.SelectionBackColor = this.ForeColor;
			
		}
		
		void TxtCodigoClienteKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
            {
				LerBanco();
            }
		}
		void LerBanco()
		{
			if (txtCodigoCliente.Text !="")
			{
				clBancoDados clBancoDados = new clBancoDados();
				SQLiteConnection conn = clBancoDados.conectar();
				string stm = "SELECT * FROM TB_PESSOA WHERE CODIGO ='"+txtCodigoCliente.Text+"'";
				//string stm = "SELECT * FROM TB_PESSOA WHERE CODIGO ='1'";
        		SQLiteCommand cmd = new SQLiteCommand(stm, conn);
        		SQLiteDataReader rdr = cmd.ExecuteReader();
        		while(rdr.Read())
        		{
        			txtNomeOuRazao.Text = rdr["Nome"].ToString();
        			mtxtTelefone.Text = rdr["Telefone"].ToString();
                    mtxtTelefone2.Text = rdr["Telefone2"].ToString();
                    mtxtCelular.Text = rdr["Celular"].ToString();
                    mtxtCep.Text = rdr["CEP"].ToString();
                    txtEndereco.Text = rdr["Endereco"].ToString();
                    txtCidade.Text = rdr["Cidade"].ToString();
                    txtBairro.Text = rdr["bairro"].ToString();
                    txtNumero.Text = rdr["numero"].ToString();
                    txtUF.Text = rdr["uf"].ToString();
                    txtComplemento.Text = rdr["Complemento"].ToString();                   
        		}
        		clBancoDados.desconectar(conn);
			}
		}
		
		void BtnAddClick(object sender, EventArgs e)
		{
			float ValoraPagar = 0;
			frmPesquisar frmpesquisar = new frmPesquisar();
			frmpesquisar.Owner = this;
			frmpesquisar.Control = 2;
			frmpesquisar.btnNovo.Visible=false;
			frmpesquisar.btnAlterar.Visible =false;
			frmpesquisar.btnExcluir.Visible = false;
			frmpesquisar.btnConsultar.Visible=false;
			frmpesquisar.btnAddServico.Location = frmpesquisar.btnNovo.Location;
			frmpesquisar.BackColor = this.BackColor;
			frmpesquisar.ForeColor = this.ForeColor;
			frmpesquisar.ShowDialog(this);
			clBancoDados clBancoDados = new clBancoDados();
			SQLiteConnection conn = clBancoDados.conectar();
			string stm = "SELECT * FROM TB_PRODUTO WHERE CODIGO ='"+_cod_produto+"'";
			//string stm = "SELECT * FROM TB_PESSOA WHERE CODIGO ='1'";
        	SQLiteCommand cmd = new SQLiteCommand(stm, conn);
        	SQLiteDataReader rdr = cmd.ExecuteReader();
        	while(rdr.Read())
        	{
        		float valorTotal = Convert.ToSingle(rdr["VALOR_VENDA"]);
        		dgvServico.Rows.Add(_quantidade,rdr["NOME"].ToString(),valorTotal.ToString("#,0.00", new CultureInfo("pt-BR")), (_quantidade*valorTotal).ToString("#,0.00", new CultureInfo("pt-BR")));
        	}
        	foreach (DataGridViewRow item in dgvServico.Rows)
            {
                ValoraPagar += Convert.ToSingle(item.Cells[3].Value);
            }
        	lblValorResult.Text = ValoraPagar.ToString("#,0.00", new CultureInfo("pt-BR"));
		}
		
		void BtnExcluirProClick(object sender, EventArgs e)
		{
			float ValoraPagar = 0;
			try 
			{
				int index = dgvServico.CurrentRow.Index;
				dgvServico.Rows.RemoveAt(index);
				foreach (DataGridViewRow item in dgvServico.Rows)
            	{
               		ValoraPagar += Convert.ToSingle(item.Cells[3].Value);
            	}
        		lblValorResult.Text = ValoraPagar.ToString("#,0.00", new CultureInfo("pt-BR"));
			} 
			catch (Exception ex)
			{
				MessageBox.Show("Selecione uma linha " + ex.ToString());
			}   
		}
	}
}
