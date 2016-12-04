/*
 * Criado por SharpDevelop.
 * Usuário: Valdelis
 * Data: 04/12/2016
 * Hora: 16:49
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Data;
using System.Data.SQLite;
using DcompanySys;

namespace SysDeCompany.Classes
{
	/// <summary>
	/// Description of clnPesquisa.
	/// </summary>
	public class clnPesquisa
	{
		public  DataSet carregar(String tabela)  
      {  
			clBancoDados objBancoDados =new clBancoDados();
        	if (string.IsNullOrEmpty(tabela)) throw new Exception("Não foi informado a tabela a ser consultada.");  
       			DataSet dtset = new DataSet();  
       			SQLiteConnection conn = DcompanySys.clBancoDados.conectar();
        		SQLiteCommand command = conn.CreateCommand();  
        		command.CommandText = "SELECT * FROM ["+tabela+"] where Ativo = 1";  
        		SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, conn);  
      			DB.Fill(dtset);  
        		conn.Close();  
        	return dtset;  
      }  
	}
}
