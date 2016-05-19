using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;


public class Mapped
{
    public static SqlConnection Connection()
    {
        SqlConnection conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["strConexao"].ConnectionString);
        conexao.Open();
        return conexao;
    }

    // Comandos SQL - Cria o objeto e valida o comando a ser executado

    public static SqlCommand Command(string query, SqlConnection conexao)
    {
        SqlCommand command = conexao.CreateCommand();
        command.CommandText = query;
        return command;
    }

    // Executa o comando

    public static SqlDataAdapter Adapter(SqlCommand command)
    {
        SqlDataAdapter adap = new SqlDataAdapter();
        adap.SelectCommand = command;
        return adap;
    }

    //  Parametrização

    public static SqlParameter Parameter(string nomeDoParametro, object valor)
    {
        return new SqlParameter(nomeDoParametro, valor);
    }
}
