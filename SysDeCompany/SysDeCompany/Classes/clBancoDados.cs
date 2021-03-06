﻿/*
 * Created by SharpDevelop.
 * User: Bruno
 * Date: 23/11/2016
 * Time: 14:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;


namespace DcompanySys
{
	/// <summary>
	/// Description of clBancoDados.
	/// </summary>
	public class clBancoDados
	{
	public bool existe()  
     {  
       if(!File.Exists("Data\\Dados.s3db")) {  
             criaDb();
          return true;  
        } else return false;  
      }  
      private static void criaDb(){  
        try {  
          if(!Directory.Exists("Data")) {  
           Directory.CreateDirectory("Data");  
          }  
          SQLiteConnection.CreateFile("Data\\Dados.s3db");  
          SQLiteConnection conn = new SQLiteConnection("Data Source=Data\\Dados.s3db;Version=3;New=True;Compress=True;");
          SQLiteCommand command = new SQLiteCommand(conn);  
          string caminho = conn.DataSource;  
          conn.Open();
          command.CommandText = "CREATE TABLE [TB_CONFIG] " +
          						"([NOME_EMPRESA] VARCHAR(20) NOT NULL," +
          						" [IMAGEM] VARCHAR(50" +") NULL," +
          						" [Cor_Fundo] INTEGER NULL," +
          						" [Cor_Fonte] INTEGER NULL);" +
          	
          	                    "CREATE TABLE [TB_Pessoa] " +
          						"([Codigo] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,"+
								" [Nome] VARCHAR(50)  NOT NULL,"+
          						" [Endereco] VARCHAR(100)  NOT NULL," +
								" [bairro] VARCHAR(50)  NOT NULL,"+
          						" [Cidade] VARCHAR(50)  NOT NULL,"+
          						" [Complemento] VARCHAR(50)  NULL,"+
								" [CEP] VARCHAR(10)  NOT NULL,"+
								" [numero] VARCHAR(5)  NOT NULL,"+
								" [uf] VARCHAR(2) NOT NULL, "+
								" [CPF] VARCHAR(14)  NOT NULL,"+
								" [Telefone] VARCHAR(11)  NULL,"+
								" [Telefone2] VARCHAR(11)  NULL,"+
								" [Celular] VARCHAR(12)  NULL,"+
								" [Cnpj] VARCHAR(18)  NULL,"+
								" [IncricaoEstadual] VARCHAR(15)  NULL,"+
  								" [Tipo_pessoa] VARCHAR(2)  NOT NULL,"+
								" [Ativo] INTEGER  NOT NULL);" +
          	
          						"CREATE TABLE [TB_PRODUTO]" + 
          						"([CODIGO] INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL,"+
								" [NOME] VARCHAR(50)  NOT NULL," +
								" [QTD] INTEGER  NOT NULL," +
								" [FORNECEDOR] VARCHAR(20)  NOT NULL," +
								" [MARCA] VARCHAR(20)  NOT NULL," +
          						" [VALOR_COMPRA] VARCHAR(10)  NOT NULL,"+
								" [VALOR_VENDA] VARCHAR(10)  NOT NULL,"+
								" [IMAGEM] VARCHAR(50)  NULL," +
								" [ATIVO] INTEGER  NULL);";
          command.ExecuteNonQuery(); 
          conn.Close();
          Inserir();
          
        } catch(Exception e) {  
          throw new Exception("Erro ao criar o Banco de Dados:"+e.Message);  
       }  
      }  
     
	public static SQLiteConnection conectar()
	{	
		try 
		{
  			SQLiteConnection conn = new SQLiteConnection("Data Source="+Application.StartupPath+"\\Data\\Dados.s3db;Version=3;New=True;Compress=True;");  
        	conn.Open();  
        	return conn;  
		}
		catch (Exception e) 
		{
 			throw e;
		}

      }  
      public  void desconectar(SQLiteConnection conn)  
      {  
        conn.Close();  
      }  
      public int Query(String Comando) {  
        SQLiteConnection conn = conectar();  
        SQLiteCommand command = new SQLiteCommand(conn);  
        command.CommandText = Comando;  
        int result = command.ExecuteNonQuery();  
        desconectar(conn);  
        return result;  
        }  
      public  DataSet carregar(String tabela)  
      {  
        if (string.IsNullOrEmpty(tabela)) throw new Exception("Não foi informado a tabela a ser consultada.");  
       		DataSet dtset = new DataSet();  
        	SQLiteConnection conn = conectar();  
        	SQLiteCommand command = conn.CreateCommand();  
        	command.CommandText = "SELECT * FROM ["+tabela+"]";  
        	SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, conn);  
      		DB.Fill(dtset);  
        	conn.Close();  
        return dtset;  
      }  
      public  static void Inserir(){
      	
      	 SQLiteCommand command = new SQLiteCommand(conectar());
      	 command.CommandText = "Insert into TB_CONFIG (NOME_EMPRESA) VALUES ('Nome da Empresa');";
      	 command.ExecuteNonQuery();
    try {
        
    }
    catch (Exception ex) {
        throw new Exception(ex.Message);
    }    
      }
      
	}
    
}
