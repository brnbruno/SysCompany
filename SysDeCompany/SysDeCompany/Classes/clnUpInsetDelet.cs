/*
 * Created by SharpDevelop.
 * User: Bruno
 * Date: 26/11/2016
 * Time: 15:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;

using DcompanySys;

namespace SysDeCompany.Classes
{
	/// <summary>
	/// Description of clnUpInsetDelet.
	/// </summary>
	public class clnUpInsetDelet
	{	
		private string _nome;
		private string _img;
		
		public String Nome{
			get{return _nome;}
			set{_nome = value;}
		}
		public string Img{
			get{return _img;}
			set{ _img = value;}
		}
		
		public void UpdateBd(){
			clBancoDados clBancoDados = new clBancoDados();
		 	SQLiteConnection conn = clBancoDados.conectar();
			SQLiteCommand command = new SQLiteCommand(conn);
         	command.CommandText = "UPDATE TB_CONFIG SET NOME_EMPRESA = '"+_nome+"'," +
         					   "IMAGEM = '"+_img+"';";
      	 	command.ExecuteNonQuery();
      	 	clBancoDados.desconectar(conn);
        }
		 
		

		
	}
}
