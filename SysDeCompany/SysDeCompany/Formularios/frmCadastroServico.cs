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
		
		public byte Control{get{return _control;}set{_control = value;}}
		
		
		
		void BtnSairClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnConsultarClick(object sender, EventArgs e)
		{
			frmPesquisar frmPesquisar = new frmPesquisar();
			frmPesquisar.Owner = this;
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
			frmPesquisar frmpesquisar = new frmPesquisar();
			frmpesquisar.Owner = this;
			frmpesquisar.Control = 2;
			frmpesquisar.ShowDialog(this);
		}
		
		void BtnExcluirProClick(object sender, EventArgs e)
		{
			try 
			{
				int index = dgvServico.CurrentRow.Index;
				dgvServico.Rows.RemoveAt(index);
			} 
			catch (Exception ex)
			{
				MessageBox.Show("Selecione uma linha " + ex.ToString());
			}   
		}
	}
}
