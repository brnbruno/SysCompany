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
using System.Linq;

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
			Desabilitatudo();
			btnConsultar.Enabled = true;
			txtCodigoCliente.Enabled = true;
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
   			if (txtCodigo.Text !=string.Empty) 
			{
				clBancoDados clBancoDados = new clBancoDados();
				SQLiteConnection conn = clBancoDados.conectar();
				string stm = "SELECT * FROM TB_SERVICO WHERE CODIGO ='"+txtCodigo.Text+"'";
				//string stm = "SELECT * FROM TB_PESSOA WHERE CODIGO ='1'";
        		SQLiteCommand cmd = new SQLiteCommand(stm, conn);
        		SQLiteDataReader rdr = cmd.ExecuteReader();
        		while(rdr.Read())
        		{
        			txtCodigoCliente.Text = rdr["cod_cliente"].ToString();
        			lblValorResult.Text = rdr["Valor_total"].ToString();
        			mtxtdate.Text = rdr["data_cod"].ToString();
        		}
        		clBancoDados.desconectar(conn);
        		LerBanco();
        		dgv2.DataSource = BuscarProdutos(txtCodigo.Text).Tables[0];
			    dgv2.Columns[1].HeaderText ="Nome";
				dgv2.Columns[0].HeaderText ="Quantidade";
				dgv2.Columns[2].HeaderText ="Valor Un";
				dgv2.Columns[3].HeaderText ="Valor Total";
				dgv2.BackgroundColor = this.BackColor;
				dgv2.GridColor = this.BackColor;
				dgv2.DefaultCellStyle.BackColor = this.BackColor;
				dgv2.DefaultCellStyle.SelectionForeColor = this.BackColor;
   				dgv2.DefaultCellStyle.SelectionBackColor = this.ForeColor;
        		dgv2.Visible = true;
			}
			
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
        		Desabilitatudo();
			}
		}
		void Desabilitatudo()
		{
			foreach (var txt in grbInfoProduto.Controls.OfType<TextBox>()) {
				txt.Enabled = false;
			}
			foreach (var txt in grbInfoProduto.Controls.OfType<MaskedTextBox>()) {
				txt.Enabled = false;
			}
			btnConsultar.Enabled = false;
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
			frmpesquisar.btnPesquiInativo.Visible=false;
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
		
		void BtnIncluirClick(object sender, EventArgs e)
		{
			if (btnIncluir.Text=="Incluir") 
			{
				if (txtCodigoCliente.Text!=string.Empty&&dgvServico.RowCount >= 1) 
				{
					clnServico objservico = new clnServico();
					objservico.Cod_cliente = txtCodigoCliente.Text;
					objservico.Data_cod = mtxtdate.Text.Replace("/","").ToString();
					objservico.Valor_total_servico = lblValorResult.Text;
					objservico.Status = 1;
					objservico.GravarServico();
					int row = 0;
					for (int cont = 1; cont <= dgvServico.RowCount; cont++)
					{	
						objservico.Quantidade = Convert.ToInt32(dgvServico.Rows[row].Cells[0].Value);
						objservico.Nome = dgvServico.Rows[row].Cells[1].Value.ToString();
						objservico.Valor_produto = dgvServico.Rows[row].Cells[2].Value.ToString();
						objservico.Valor_total = dgvServico.Rows[row].Cells[3].Value.ToString();                   
                		row++;
                		objservico.GravarProduto();
           			}
					MessageBox.Show("Dados Gravados com sucesso","Salvando",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					this.Close();
				}
				else
				{
					MessageBox.Show("Cliente ou produto não preenchido","erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			else
			{
				clnServico objservico = new clnServico();
				objservico.Alterar(txtCodigo.Text);
			}
			
						
		}
		public DataSet BuscarProdutos(string strDescricao)
        {
			clBancoDados clBancoDados = new clBancoDados();
			if (string.IsNullOrEmpty(strDescricao)) throw new Exception("Não foi informado a Descrição a ser consultada.");
			DataSet dtset = new DataSet();  
        	SQLiteConnection conn = clBancoDados.conectar();  
        	SQLiteCommand command = conn.CreateCommand();  
            command.CommandText = "SELECT Quantidade, Nome,Valor_produto,valor_total FROM TB_produto_servico Where  cod_servico = '" + strDescricao+ "'";
          	SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, conn);  
      		DB.Fill(dtset);  
        	conn.Close();  
        	return dtset;  
		}
	}
}
