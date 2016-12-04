/*
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
		
		void Button1Click(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog();
			textBox2.Text = colorDialog1.Color.ToArgb().ToString();
			this.BackColor = Color.FromArgb(Convert.ToInt32(textBox2.Text));
		}
		
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
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
    		{  
				pbLogoEmpresa.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
				pbLogoEmpresa.BackgroundImageLayout = ImageLayout.Stretch;
				Image image = pbLogoEmpresa.BackgroundImage;
				string Arquivo = openFileDialog1.FileName;
			 	nomeDoArquivo= Arquivo.Split(new char[] { '\\' })[Arquivo.Split(new char[] { '\\' }).Length - 1];

   				CopyFileTo(openFileDialog1.FileName,Application.StartupPath+@"\Config\"+nomeDoArquivo);
    		}
		}
		
		void BtnSalvarClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja salvar","...",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				clnUpInsetDelet cln = new clnUpInsetDelet();
				cln.Nome = txtNomedaEmpresa.Text;
				cln.Img = Application.StartupPath + @"\Config\" +nomeDoArquivo;
				cln.CorFundo = pbCordoFormulario.BackColor.ToArgb();
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
			colorDialog1.ShowDialog();
			pbCordoFormulario.BackColor = colorDialog1.Color;
			lbfontform.BackColor = colorDialog1.Color;
		}
		
		void BtnCorFonteFormClick(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog();
			lbfontform.ForeColor = colorDialog1.Color;
		}
	}
}      

   
	

