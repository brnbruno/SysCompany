/*
 * Criado por SharpDevelop.
 * Usuário: Valdelis
 * Data: 05/12/2016
 * Hora: 07:54
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using DcompanySys;

namespace SysDeCompany.Formularios
{
	/// <summary>
	/// Description of frmQuantidade.
	/// </summary>
	public partial class frmQuantidade : Form
	{
		public frmQuantidade()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSairClick(object sender, EventArgs e)
		{
			((frmPesquisar)this.Owner).Quantidade =1;
			this.Close();
		}
		
		void BtnIncluirClick(object sender, EventArgs e)
		{
			try 
			{
				if(Convert.ToInt32(txtQtd.Text) > 1)
				{
					((frmPesquisar)this.Owner).Quantidade = Convert.ToInt32(txtQtd.Text);
					this.Close();
				}
			} 
			catch (Exception) 
			{
				MessageBox.Show("Coloque um Valor para quantidade");
			}
			
		}
	}
}
