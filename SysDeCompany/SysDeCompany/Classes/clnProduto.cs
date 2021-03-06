﻿/*
 * Criado por SharpDevelop.
 * Usuário: Valdelis
 * Data: 04/12/2016
 * Hora: 19:32
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using DcompanySys;
using System.Data;
using System.Data.SQLite;

namespace SysDeCompany.Classes
{
	/// <summary>
	/// Description of clnProduto.
	/// </summary>
	public class clnProduto
	{
		private string _nome;
		private int _qtd;
		private string _fornecedor;
		private string _marca;
		private string _valor_compra;
		private string _valor_venda;
		private string _img;
		private int _cod;
		
		public string Nome{	get{return _nome;}set{_nome = value;}}
		public int QTD{get{return _qtd;}set{_qtd = value;}}
		public string Fornecedor{get{return _fornecedor;}set{_fornecedor = value;}}
		public string Marca{get{return _marca;}set{_marca= value;}}
		public string Img{get{return _img;}set{_img = value;}}
		public string Valor_Compra{get{return _valor_compra;}set{_valor_compra = value;}}	
		public string Valor_Venda{get{return _valor_venda;}set{_valor_venda = value;}}
		public int Cod{get{return _cod;}set{_cod = value;}}
		
		public void Gravar()
        {	
			string strQuery = "INSERT INTO TB_PRODUTO(";
			strQuery += ("NOME, QTD, FORNECEDOR, MARCA, VALOR_COMPRA, VALOR_VENDA, IMAGEM, ATIVO)");
			strQuery += (" VALUES(");
			strQuery += ("'"+ _nome +"',");
			strQuery += ("'"+ _qtd +"',");
			strQuery += ("'"+ _fornecedor +"',");
			strQuery += ("'"+ _marca +"',");
			strQuery += ("'"+ _valor_compra +"',");
			strQuery += ("'"+ _valor_venda +"',");
			strQuery += ("'"+ _img +"',");
			strQuery += ("'1' )");
			clBancoDados clBancoDados = new clBancoDados();
		 	SQLiteConnection conn = clBancoDados.conectar();
			SQLiteCommand command = new SQLiteCommand(conn);
         	command.CommandText = strQuery;
      	 	command.ExecuteNonQuery();
      	 	clBancoDados.desconectar(conn);
            
        }
		public void Alterar()
		{
			string strQuery = "UPDATE TB_PRODUTO SET ";
			strQuery += ("  NOME = '" +    _nome + "' ");
			strQuery += (", QTD ='"+_qtd +"'");
			strQuery += (", FORNECEDOR ='" + _fornecedor +"'");
			strQuery += (", MARCA ='"+  _marca +"'");
			strQuery += (",	VALOR_COMPRA ='" + _valor_compra +"'");
			strQuery += (", VALOR_VENDA ='"+ _valor_venda +"'");
			if (_img != string.Empty) {
				strQuery += (", IMAGEM ='"+ _img+"'");
			}
			strQuery += (", ATIVO = '1'");
			strQuery += (" WHERE ");
			strQuery += ("Codigo = '" + _cod + "' ");
			
			clBancoDados clBancoDados = new clBancoDados();
		 	SQLiteConnection conn = clBancoDados.conectar();
			SQLiteCommand command = new SQLiteCommand(conn);
         	command.CommandText = strQuery;
      	 	command.ExecuteNonQuery();
      	 	clBancoDados.desconectar(conn);
		}
		public void ExcluirLogicamente()
        {
            string strQuery;
            strQuery = (" UPDATE TB_PRODUTO ");
            strQuery += (" SET ");
            strQuery += (" Ativo = '" + 0 + "' ");
            strQuery += (" WHERE ");
            strQuery += (" Codigo = '" + _cod + "' ");
            
           	clBancoDados clBancoDados = new clBancoDados();
		 	SQLiteConnection conn = clBancoDados.conectar();
			SQLiteCommand command = new SQLiteCommand(conn);
         	command.CommandText = strQuery;
      	 	command.ExecuteNonQuery();
      	 	clBancoDados.desconectar(conn);
        }
		
		public DataSet BuscarProduto(string strDescricao)
        {
			clBancoDados clBancoDados = new clBancoDados();
			if (string.IsNullOrEmpty(strDescricao)) throw new Exception("Não foi informado a Descrição a ser consultada.");
			DataSet dtset = new DataSet();  
        	SQLiteConnection conn = clBancoDados.conectar();  
        	SQLiteCommand command = conn.CreateCommand();  
            command.CommandText = "SELECT * FROM TB_PRODUTO Where ativo = 1 and NOME like '%" + strDescricao+ "%' order by CODIGO";
          	SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, conn);  
      		DB.Fill(dtset);  
        	conn.Close();  
        	return dtset;  
		}
		public DataSet BuscarProdutoin(string strDescricao)
        {
			clBancoDados clBancoDados = new clBancoDados();
			DataSet dtset = new DataSet();  
        	SQLiteConnection conn = clBancoDados.conectar();  
        	SQLiteCommand command = conn.CreateCommand();  
            command.CommandText = "SELECT * FROM TB_PRODUTO Where ativo = 0 and NOME like '%" + strDescricao+ "%' order by CODIGO";
          	SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, conn);  
      		DB.Fill(dtset);  
        	conn.Close();  
        	return dtset;  
		}
	
	}
}
