/*
 * Created by SharpDevelop.
 * User: Bruno
 * Date: 20/11/2016
 * Time: 02:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using SysDeCompany.Classes;
using SysDeCompany.Formularios;

namespace DcompanySys
{
	/// <summary>
	/// Description of frmPesquisar.
	/// </summary>
	public partial class frmPesquisar : Form
	{
		public frmPesquisar()
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
		private int _quantidade;
		
		
		public byte Control{get{return _control;}set{_control = value;}}
		public int Quantidade{get{return _quantidade;}set{_quantidade = value;}}
		
		void BtnNovoClick(object sender, EventArgs e)
		{
			if (_control==1) {
   				frmCadastrarPessoa frmCadastro = new frmCadastrarPessoa();
				frmCadastro.Control = 1;
				frmCadastro.TipoPessoa = "PF";
				frmCadastro.ShowDialog();
				CarregaDataGridPessoa();
   			}
   			else if (_control==2) {
   				frmCadastrarProduto objProduto = new frmCadastrarProduto();
            	objProduto.Controle = 1;
            	objProduto.ShowDialog();
            	CarregaDataGridProduto();
   			}
			
			
		}
		
		void BtnConsultarClick(object sender, EventArgs e)
		{
			if (_control==1) {
   				frmCadastrarPessoa objfPessoa = new frmCadastrarPessoa();
            	objfPessoa.txtNomeOuRazao.Enabled = false;
            	objfPessoa.mtxtCpf.Enabled = false;
            	objfPessoa.mtxtTelefone.Enabled = false;
            	objfPessoa.mtxtTelefone2.Enabled = false;
            	objfPessoa.mtxtCelular.Enabled = false;
            	objfPessoa.txtEndereco.Enabled = false;
            	objfPessoa.txtBairro.Enabled = false;
            	objfPessoa.txtCidade.Enabled = false;
            	objfPessoa.txtNumero.Enabled = false;
            	objfPessoa.cbUF.Enabled = false;
            	objfPessoa.mtxtCep.Enabled = false;
            	objfPessoa.btnAlterar.Visible = false;
            	objfPessoa.btnIncluir.Visible = false;
            	objfPessoa.txtComplemento.Enabled = false;
            	objfPessoa.mtxtCnpj.Enabled = false;
            	objfPessoa.txtIE.Enabled = false;
            	objfPessoa.rbPessoaFisica.Enabled = false;
            	objfPessoa.rbPessoaJuridica.Enabled = false;
            	objfPessoa.txtCodigo.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            	objfPessoa.TipoPessoa = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
            	objfPessoa.ShowDialog();
   			}
   			else if (_control==2) {
   				frmCadastrarProduto objProduto = new frmCadastrarProduto();
            	objProduto.txtNome.Enabled = false;
            	objProduto.txtMarca.Enabled = false;
            	objProduto.txtQuantidade.Enabled = false;
            	objProduto.txtMarca.Enabled = false;
            	objProduto.txtFornecedor.Enabled = false;
            	objProduto.txtValorCompra.Enabled = false;
            	objProduto.txtValorVenda.Enabled = false;
            	objProduto.btnBuscaImagem.Visible = false;
            	objProduto.btnLimparImagem.Visible = false;
            	objProduto.btnAlterar.Visible = false;
            	objProduto.btnIncluir.Visible = false;
            	objProduto.txtCodigo.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            	objProduto.ShowDialog();
   			}
			
		}
		
		void FrmPesquisarLoad(object sender, EventArgs e)
		{
			dgv.BackgroundColor = this.BackColor;
			dgv.GridColor = this.BackColor;
			dgv.DefaultCellStyle.BackColor = this.BackColor;
			dgv.DefaultCellStyle.SelectionForeColor = this.BackColor;
   			dgv.DefaultCellStyle.SelectionBackColor = this.ForeColor;
   			if (_control==1) {
   				CarregaDataGridPessoa();	
   			}
   			else if (_control==2) {
   				CarregaDataGridProduto();
   			}
			
		}
		
		void DgvDoubleClick(object sender, EventArgs e)
		{
			btnAlterar.PerformClick();
		}
		
		void BtnAlterarClick(object sender, EventArgs e)
		{
			try {
				if (_control==1)
				{
					frmCadastrarPessoa objPessoa = new frmCadastrarPessoa();
            		objPessoa.txtCodigo.Enabled = false;
            		objPessoa.txtCodigo.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            		objPessoa.Control =2;
            		objPessoa.TipoPessoa = dgv.CurrentRow.Cells[15].Value.ToString();
            		objPessoa.ShowDialog();
            		CarregaDataGridPessoa();
				}
				else if (_control==2)
				{
					frmCadastrarProduto objProduto = new frmCadastrarProduto();
					objProduto.txtCodigo.Enabled = false;
            		objProduto.txtCodigo.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            		objProduto.Controle = 2;
            		objProduto.ShowDialog();
            		CarregaDataGridProduto();
				
				}
			} catch (Exception) {
				
				MessageBox.Show("Selecione um Cadastro","erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}
		void CarregaDataGridPessoa()
		{
			clnPesquisa objPesquisa = new clnPesquisa();
			dgv.DataSource = objPesquisa.carregar("TB_PESSOA").Tables[0];
			dgv.Columns[0].HeaderText ="Código";
			dgv.Columns[1].HeaderText ="Nome";
			dgv.Columns[2].HeaderText ="Endereço";
			dgv.Columns[3].HeaderText ="Bairro";
			dgv.Columns[4].HeaderText ="Cidade";
			dgv.Columns[7].HeaderText ="Número";
			dgv.Columns[8].HeaderText ="Endereço";
			dgv.Columns[14].HeaderText = "Inscrição Estadual";
			dgv.Columns[15].HeaderText = "Tipo de Pessoa";
			dgv.Columns[16].Visible = false;
		}
		void CarregaDataGridProduto()
		{
			clnPesquisa objPesquisa = new clnPesquisa();
			dgv.DataSource = objPesquisa.carregar("TB_Produto").Tables[0];
			dgv.Columns[0].HeaderText ="Código";
			dgv.Columns[1].HeaderText ="Nome";
			dgv.Columns[2].HeaderText ="Quantidade";
			dgv.Columns[3].HeaderText ="Fornecedor";
			dgv.Columns[4].HeaderText ="Marca";
			dgv.Columns[5].HeaderText ="Valor Compra";
			dgv.Columns[6].HeaderText ="Valor Venda";
			dgv.Columns[7].Visible = false;
			dgv.Columns[8].Visible = false;
			
		}
		
		void BtnExcluirClick(object sender, EventArgs e)
		{
			if (_control == 1)
			{
				clnPessoa  objPessoa = new clnPessoa();
				if (MessageBox.Show("Você deseja excluir este registro","Atenção...",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes) {
					objPessoa.Cod =Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                	objPessoa.ExcluirLogicamente();
                	MessageBox.Show("Excluido com Sucesso","Excluido",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				CarregaDataGridPessoa();
			}
			else if (_control == 2) 
			{
				clnProduto  objProduto = new clnProduto();
				if (MessageBox.Show("Você deseja excluir este registro","Atenção...",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes) {
					objProduto.Cod =Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                	objProduto.ExcluirLogicamente();
                	MessageBox.Show("Excluido com Sucesso","Excluido",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				CarregaDataGridProduto();
			}
		}
		
		void BtnPequisarClick(object sender, EventArgs e)
		{	
			if (_control == 1)
			{
				clnPessoa objPessoa = new clnPessoa();
				dgv.DataSource = objPessoa.BuscarPessoa(txtDescricao.Text.ToUpper()).Tables[0];
			}
			else if (_control == 2) 
			{
				clnProduto objProduto = new clnProduto();
				dgv.DataSource = objProduto.BuscarProduto(txtDescricao.Text.ToUpper()).Tables[0];
			}
		}
		
		Image imgbtnadd = null;
		void BtnAddServicoMouseHover(object sender, EventArgs e)
		{
			btnAddServico.Text = "Adicionar Serviço";
			imgbtnadd = btnAddServico.BackgroundImage;
			btnAddServico.BackgroundImage = null;
		}
		
		void BtnAddServicoMouseLeave(object sender, EventArgs e)
		{
			btnAddServico.Text = "";
			btnAddServico.BackgroundImage = imgbtnadd;
		}
		
		void BtnAddServicoClick(object sender, EventArgs e)
		{
			if (_control == 1) 
			{
				((frmCadastroServico)this.Owner).txtCodigoCliente.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
			    ((frmCadastroServico)this.Owner).Control = 1;
			    this.Close();
			}
			else if (_control == 2)
			{
				frmQuantidade objQtd = new frmQuantidade();
				objQtd.Owner = this;
				objQtd.ShowDialog(this);
				int index = dgv.CurrentRow.Index;
				((frmCadastroServico)this.Owner).dgvServico.Rows.Add(dgv.CurrentRow.Cells[index].Value,_quantidade,"1");
			}
		}
		
		void BtnPesquiInativoClick(object sender, EventArgs e)
		{
			
		}
	}
}
