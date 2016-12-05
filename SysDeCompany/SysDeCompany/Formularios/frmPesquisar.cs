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
		private int _control;
		
		public int Control{get{return _control;}set{_control = value;}}
		
		void BtnNovoClick(object sender, EventArgs e)
		{
			if (_control==1) {
   				frmCadastrarPessoa frmCadastro = new frmCadastrarPessoa();
				frmCadastro.Control = 1;
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
            objfPessoa.ShowDialog();
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
            		objPessoa.TipoPessoa = dgv.CurrentRow.Cells[15].ToString();
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
		}
		void CarregaDataGridProduto()
		{
			clnPesquisa objPesquisa = new clnPesquisa();
			dgv.DataSource = objPesquisa.carregar("TB_Produto").Tables[0];
			dgv.Columns[0].HeaderText ="Código";
			dgv.Columns[1].HeaderText ="Nome";
		}
		
		void BtnExcluirClick(object sender, EventArgs e)
		{
			clnPessoa  objPessoa = new clnPessoa();
			if (MessageBox.Show("Você deseja excluir este registro","Atenção...",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes) {
				objPessoa.Cod =Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                objPessoa.ExcluirLogicamente();
                MessageBox.Show("Excluido com Sucesso","Excluido",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			CarregaDataGridPessoa();
		}
	}
}
