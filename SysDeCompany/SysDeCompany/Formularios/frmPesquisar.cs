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
		
		void BtnNovoClick(object sender, EventArgs e)
		{
			frmCadastrarPessoa frmCadastro = new frmCadastrarPessoa();
			frmCadastro.Control = 1;
			frmCadastro.ShowDialog();
		}
		
		void BtnConsultarClick(object sender, EventArgs e)
		{
			
		}
	}
}
