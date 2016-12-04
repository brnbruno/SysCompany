﻿/*
 * Criado por SharpDevelop.
 * Usuário: Bruno
 * Data: 12/11/2016
 * Hora: 21:04
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using SysDeCompany.Classes;
using System.IO;

namespace DcompanySys
{
	/// <summary>
	/// Description of frmCadastrarProduto.
	/// </summary>
	public partial class frmCadastrarProduto : Form 
	{
		public frmCadastrarProduto()
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
		
		void BtnSairClick(object sender, EventArgs e)
		{
			this.Close();
		}	
		void BtnBuscaImagemClick(object sender, EventArgs e)
		{
			buscaArquivo.Title = "Procurar Imagem...";
			buscaArquivo.CheckFileExists = true;
			buscaArquivo.CheckPathExists = true;
			buscaArquivo.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
			if (buscaArquivo.ShowDialog()==DialogResult.OK)
			{
				pbImagem.BackgroundImageLayout = ImageLayout.Stretch;
			    pbImagem.BackgroundImage = Image.FromFile(buscaArquivo.FileName);
			}
			
			
		}
		
		void BtnBuscarManualClick(object sender, EventArgs e)
		{
			buscaArquivo.Title = "Procurar Manual...";
			buscaArquivo.CheckFileExists = true;
			buscaArquivo.CheckPathExists = true;
			buscaArquivo.Filter = "Manual (*.PDF;*.DOC;*.DOCX)|*.PDF;*.DOC;*.DOCX|" + "All files (*.*)|*.*";
			buscaArquivo.ShowDialog();
		}
		
		void FrmCadastrarProdutoLoad(object sender, EventArgs e)
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
		
		void BtnLimparImagemClick(object sender, EventArgs e)
		{
			pbImagem.Image = null;
		}			
		void TxtValorVendaTextChanged(object sender, EventArgs e)
		{
			clnValida objValida = new clnValida();
			objValida.moeda(ref txtValorVenda);
		}
		
		void TxtValorCompraTextChanged(object sender, EventArgs e)
		{
			clnValida objValida = new clnValida();
			objValida.moeda(ref txtValorCompra);
		}
	}
}