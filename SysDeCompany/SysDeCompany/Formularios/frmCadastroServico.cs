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
			frmPesquisar.ShowDialog();
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
		}
	}
}
