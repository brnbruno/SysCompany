﻿/*
 * Created by SharpDevelop.
 * User: Bruno
 * Date: 23/11/2016
 * Time: 14:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Data.SqlClient;
using SysDeCompany.Classes;

namespace DcompanySys
{
	/// <summary>
	/// Description of frmConfigura.
	/// </summary>
	public partial class frmConfigura : Form
	{
		public frmConfigura()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		/*void Button1Click(object sender, EventArgs e)
		{
			JaneladeCor.ShowDialog();
			textBox2.Text = JaneladeCor.Color.ToArgb().ToString();
			this.BackColor = Color.FromArgb(Convert.ToInt32(textBox2.Text));
		}
		*/
		string nomeDoArquivo = string.Empty;
		
		public bool CopyFileTo(string filepath, string topath)
    	{
        	try   
        	{
        		File.Copy(filepath, topath,true);
        		return true;
        	}
       		catch (IOException E){
        		MessageBox.Show("Não foi possivel copia a imagem para pasta da aplicação\n" +E.Message);
       			return false;
       		}
    	}
		
		
		void FrmConfiguraLoad(object sender, EventArgs e)
		{
			clnConfig objConfig = new clnConfig();
			if(Directory.Exists("Data")&&Directory.Exists("Config"))
			{
			   	pbLogoEmpresa.BackgroundImage = objConfig.BuscaImage();
			   	txtNomedaEmpresa.Text = objConfig.BuscaNomeEmpresa();
			}
		}
		
		void BtnBuscaImagemClick(object sender, EventArgs e)
		{
			buscaArquivo.Title = "Procurar Imagem...";
			buscaArquivo.CheckFileExists = true;
			buscaArquivo.CheckPathExists = true;
			buscaArquivo.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
			if (buscaArquivo.ShowDialog() == DialogResult.OK)
    		{  
				pbLogoEmpresa.BackgroundImage = Image.FromFile(buscaArquivo.FileName);
				pbLogoEmpresa.BackgroundImageLayout = ImageLayout.Stretch;
				Image image = pbLogoEmpresa.BackgroundImage;
				string Arquivo = buscaArquivo.FileName;
			 	nomeDoArquivo= Arquivo.Split(new char[] { '\\' })[Arquivo.Split(new char[] { '\\' }).Length - 1];

   				CopyFileTo(buscaArquivo.FileName,Application.StartupPath+@"\Config\"+nomeDoArquivo);
    		}
		}
		
		void BtnSalvarClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja salvar","...",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				clnUpInsetDelet cln = new clnUpInsetDelet();
				cln.Nome = txtNomedaEmpresa.Text;
				cln.Img = nomeDoArquivo;
				cln.CorFundo = pbCordoFormulario.BackColor.ToArgb();
				cln.CorFonte = lbfontform.ForeColor.ToArgb();
				cln.UpdateBd();
				MessageBox.Show("Salvado com sucesso");
				((SysDeCompany.MainForm)this.Owner).Atualizar();
				this.Close();
			}
				
			
		}
		
		void BtnFecharClick(object sender, EventArgs e)
		{
			
				this.Close();
			
		}
		
		void BtnCorDoFormularioClick(object sender, EventArgs e)
		{
			JaneladeCor.ShowDialog();
			pbCordoFormulario.BackColor = JaneladeCor.Color;
			lbfontform.BackColor = JaneladeCor.Color;
		}
		
		void BtnCorFonteFormClick(object sender, EventArgs e)
		{
			JaneladeCor.ShowDialog();
			lbfontform.ForeColor = JaneladeCor.Color;
		}
		
		void BtnRestarCorClick(object sender, EventArgs e)
		{
			pbCordoFormulario.BackColor= Color.FromArgb(-2830136);
			lbfontform.BackColor = pbCordoFormulario.BackColor;
			lbfontform.ForeColor = Color.FromArgb(-16777216);
		}
		
		void TxtNomedaEmpresaKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
		}
	}
}      

   
	

