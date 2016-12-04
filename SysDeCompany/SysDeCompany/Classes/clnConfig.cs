/*
 * Created by SharpDevelop.
 * User: Bruno
 * Date: 27/11/2016
 * Time: 00:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SQLite;
using DcompanySys;

namespace SysDeCompany.Classes
{
	/// <summary>
	/// Description of clnConfig.
	/// </summary>
	public class clnConfig
	{
		 public System.Drawing.Image BuscaImage()
		 {
		 	System.Drawing.Image img = null;
		 	try 
		 	{
		 		clBancoDados clBancoDados = new clBancoDados();
		 		SQLiteConnection conn = clBancoDados.conectar();
				string stm = "SELECT * FROM TB_CONFIG";
        		SQLiteCommand cmd = new SQLiteCommand(stm, conn);
        		SQLiteDataReader rdr = cmd.ExecuteReader();
        		while(rdr.Read())
        		{
        			if (rdr["IMAGEM"].ToString()!=System.Windows.Forms.Application.StartupPath+"\\Config\\") {
        				img  = System.Drawing.Image.FromFile(rdr["IMAGEM"].ToString());
        			}
        		
        		}
        		clBancoDados.desconectar(conn);
        		
        		
		 	} catch (Exception e) {
		 		
		 		System.Windows.Forms.MessageBox.Show("A imagem não foi encontrada\n " +e.Message);
		 	}
		 	return img;	
		 	
		}
		
		public string BuscaNomeEmpresa()
		{
			clBancoDados clBancoDados = new clBancoDados();
		 	SQLiteConnection conn = clBancoDados.conectar();
			string nome = string.Empty;
			string stm = "SELECT * FROM TB_CONFIG";
			SQLiteCommand cmd = new SQLiteCommand(stm, conn);
        	SQLiteDataReader rdr = cmd.ExecuteReader();
        	while(rdr.Read()){
        		nome  = rdr["NOME_EMPRESA"].ToString();
        	}
        	clBancoDados.desconectar(conn);
        	return nome;   		
		}
	}
}
