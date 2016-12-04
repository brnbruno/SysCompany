/*
 * Created by SharpDevelop.
 * User: Valdelis
 * Date: 27/11/2016
 * Time: 01:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Data.SQLite;
using DcompanySys;

namespace SysDeCompany.Classes
{
	/// <summary>
	/// Description of clnPessoa.
	/// </summary>
	public class clnPessoa
	{
		private string _nome;
		private string _endereco;
		private string _bairro;
		private string _cidade;
		private string _complemeto;
		private string _cep;
		private string _cpf;
		private string _telefone;
		private string _telefone2;
		private string _celular;
		private string _nr;
		private string _email;
		private string _cnpj;
		private string _site;
		private string _ie;
		private string _uf;
		private string _tipopessoa;
		private int _cod;
		
		public string Nome{	get{return _nome;}set{_nome = value;}}
		public string Endereco{get{return _endereco;}set{_endereco = value;}}
		public string Bairro{get{return _bairro;}set{_bairro = value;}}
		public string Cidade{get{return _cidade;}set{_cidade= value;}}
		public string Complemeto{get{return _complemeto;}set{_complemeto = value;}}
		public string Cep{get{return _cep;}set{_cep = value;}}	
		public string Cpf{get{return _cpf;}set{_cpf = value;}}
		public string Telefone{get{return _telefone;}set{_telefone = value;}}
		public string Telefone2{get{return _telefone2;}set{_telefone2 = value;}}
		public string Celular{get{return _celular;}set{_celular = value;}}
		public string Nr{get{return _nr;}set{_nr = value;}}		
		public string Email{get{return _email;}set{_email =value;}}
		public string Cnpj{get{return _cnpj;}set{_cnpj = value;}}
		public string Site{get{return _site;}set{_site = value;}}
		public string Ie{get{return _ie;}set{_ie = value;}}
		public string Uf{get{return _uf;}set{_uf = value;}}
		public string Tipopessoa{get{return _tipopessoa;}set{_tipopessoa = value;}}
		public int Cod{get{return _cod;}set{_cod = value;}}
		
		public void Gravar()
        {	
			string strQuery = "INSERT INTO TB_PESSOA(";
			strQuery += ("Nome, Endereco,bairro, Cidade, Complemento, CPE, numero, uf, CPF,");
			strQuery += ("Telefone,Telefone2, Celular, Cnpj, IncricaoEstadual,");
			strQuery += ("Tipo_pessoa, Ativo)");
			strQuery += (" VALUES(");
			strQuery += ("'"+ _nome +"',");
			strQuery += ("'"+ _endereco +"',");
			strQuery += ("'"+ _bairro +"',");
			strQuery += ("'"+ _cidade +"',");
			strQuery += ("'"+ _complemeto +"',");
			strQuery += ("'"+ _cep +"',");
			strQuery += ("'"+ _nr +"',");
			strQuery += ("'"+ _uf +"',");
			strQuery += ("'"+ _cpf +"',");
			strQuery += ("'"+ _telefone +"',");
			strQuery += ("'"+ _telefone2 +"',");
			strQuery += ("'"+ _celular +"',");
			strQuery += ("'"+ _cnpj +"',");
			strQuery += ("'"+ _ie +"',");
			strQuery += ("'"+ _tipopessoa+"',");
			strQuery += (" 1 )");
			clBancoDados clBancoDados = new clBancoDados();
		 	SQLiteConnection conn = clBancoDados.conectar();
			SQLiteCommand command = new SQLiteCommand(conn);
         	command.CommandText = strQuery;
      	 	command.ExecuteNonQuery();
      	 	clBancoDados.desconectar(conn);
            
        }
		public void Alterar()
		{
			string strQuery = "UPDATE TB_PESSOA SET ";
			strQuery += ("nome = '" +    _nome + "' ");
			strQuery += (", Endereco ='"+_endereco +"'");
			strQuery += (", bairro ='" + _bairro +"'");
			strQuery += (", Cidade ='"+  _cidade +"'");
			strQuery += (",	Complemento ='" + _complemeto +"'");
			strQuery += (", CPE ='"+ _cep +"'");
			strQuery += (", numero ='"+ _nr+"'");
			strQuery += (", uf ='" + _uf + "'");
			strQuery += (", CPF ='"+ _cpf +"'");
			strQuery += (", Telefone ='" + _telefone +"'");
			strQuery += (", Telefone2 ='" + _telefone2 +"'");
			strQuery += (", Celular ='" + _celular +"'");
			strQuery += (", Cnpj ='" + _cnpj +"'");
			strQuery += (", IncricaoEstadual ='" +_ie+"'");
			strQuery += (", Tipo_pessoa ='"+_tipopessoa+"'");
			strQuery += (", Ativo = '1'");
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
            strQuery = (" UPDATE TB_PESSOA ");
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
	
	}
}
