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
			frmCadastrarPessoa frmCadastro = new frmCadastrarPessoa();
			frmCadastro.Control = 1;
			frmCadastro.ShowDialog();
		}
		
		void BtnConsultarClick(object sender, EventArgs e)
		{
			
		}
		
		void FrmPesquisarLoad(object sender, EventArgs e)
		{
			dgv.BackgroundColor = this.BackColor;
			dgv.GridColor = this.BackColor;
			dgv.DefaultCellStyle.BackColor = this.BackColor;
			dgv.DefaultCellStyle.SelectionForeColor = this.BackColor;
   			dgv.DefaultCellStyle.SelectionBackColor = this.ForeColor;
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
	}
}
