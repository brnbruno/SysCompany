/*
 * Criado por SharpDevelop.
 * Usuário: Valdelis
 * Data: 07/12/2016
 * Hora: 00:16
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
	/// Description of clnServico.
	/// </summary>
	public class clnServico
	{
		
		private string _cod_cliente;
		private string _valor_total_servico;
		private int _status;
		private string _data_cod; //cod_servico = _data_cod
		
		private string _nome;
		private int _quantidade;
		private string _valor_produto;
		private string _valor_total;
	
		
		public string Cod_cliente{get{return _cod_cliente;}set{_cod_cliente = value;}}
		public string Valor_total_servico{get{return _valor_total_servico;}set{_valor_total_servico = value;}}
		public int Status{get{return _status;}set{_status = value;}}
		public string Data_cod{get{return _data_cod;}set{_data_cod = value;}}
		
		
		public string Nome{get{return _nome;}set{_nome= value;}}
		public int Quantidade{get{return _quantidade;}set{_quantidade = value;}}
		public string Valor_produto{get{return _valor_produto;}set{_valor_produto = value;}}
		public string Valor_total{get{return _valor_total;}set{_valor_total = value;}}
		
		public void GravarServico()
        {	
			string strQuery = "INSERT INTO TB_SERVICO(";
			strQuery += ("cod_cliente, Valor_total, data_cod, status, Ativo)");
			strQuery += (" VALUES(");
			strQuery += ("'"+ _cod_cliente +"',");
			strQuery += ("'"+ _valor_total_servico +"',");
			strQuery += ("'"+ _data_cod +"',");
			strQuery += ("'"+ _status +"',");
			strQuery += ("'1' )");
			clBancoDados clBancoDados = new clBancoDados();
		 	SQLiteConnection conn = clBancoDados.conectar();
			SQLiteCommand command = new SQLiteCommand(conn);
         	command.CommandText = strQuery;
      	 	command.ExecuteNonQuery();
      	 	clBancoDados.desconectar(conn);    
        }
		public void GravarProduto()
		{
			
			string strQuery = "INSERT INTO TB_produto_servico(";
			strQuery += ("nome, Quantidade, Valor_produto, cod_servico,valor_total)");
			strQuery += (" VALUES(");
			strQuery += ("'"+ _nome +"',");
			strQuery += ("'"+ _quantidade +"',");
			strQuery += ("'"+ _valor_produto +"',");			
			strQuery += ("'"+ BuscaCodigo() +"',");
			strQuery += ("'"+ _valor_total +"'");
			strQuery += (" )");      	 	
      	 	clBancoDados clBancoDados = new clBancoDados();
		 	SQLiteConnection conn = clBancoDados.conectar();
			SQLiteCommand command = new SQLiteCommand(conn);
         	command.CommandText = strQuery;
      	 	command.ExecuteNonQuery();
      	 	clBancoDados.desconectar(conn);
		}
		
		/*public void Alterar()
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
		}*/
		public int BuscaCodigo()
		{
			try {
				clBancoDados clBancoDados = new clBancoDados();
		 		SQLiteConnection conn = clBancoDados.conectar();
				int codigo = 0;
				string stm = "SELECT * FROM [TB_SERVICO] ORDER BY [CODIGO] DESC LIMIT 1";
				SQLiteCommand cmd = new SQLiteCommand(stm, conn);
        		SQLiteDataReader rdr = cmd.ExecuteReader();
        		while(rdr.Read()){
        			codigo  = Convert.ToInt32(rdr["CODIGO"]);
        		}
        		clBancoDados.desconectar(conn);
        		return codigo;   	
			} catch (Exception) {
				
				throw;
			}
					
		}
		
	
	}
}
