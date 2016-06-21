using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class Funcionario_DB
{
    public static int Insert(Funcionario funcionario)
    {
        int retorno = 0;
        try
        {
            SqlConnection objConnection = Mapped.Connection();
            funcionario.CodPessoa = Pessoa_DB.Insert(funcionario, objConnection);
            SqlCommand objCommand = Mapped.Command("Insert into funcionarios (cargo, salario, data_admissao, numero_cnt, cod_pessoa) values (@cargo, @salario, @data_admissao, @numero_cnt, @cod_pessoa);", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@cargo", funcionario.Cargo));
            objCommand.Parameters.Add(Mapped.Parameter("@salario", funcionario.Salario));
            objCommand.Parameters.Add(Mapped.Parameter("@data_admissao", funcionario.DataAdmissao));
            objCommand.Parameters.Add(Mapped.Parameter("@numero_cnt", funcionario.NumeroCnt));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_pessoa", funcionario.CodPessoa));
            objCommand.ExecuteNonQuery();
            
            objConnection.Close();
            objCommand.Dispose();
            objConnection.Dispose();
        }
        catch (Exception e)
        {
            retorno = -2;
        }
        return retorno;
    }

    public static DataSet Select10Ultimos()
    {
        DataSet ds = new DataSet();
        SqlConnection objConnection;
        SqlCommand objCommand;
        SqlDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("select p.nome, e.cidade, e.estado from enderecos e inner join pessoas p on e.cod_endereco = p.cod_endereco " +
        "inner join funcionarios f on f.cod_pessoa = p.cod_pessoa order by p.cod_pessoa desc offset 0 rows fetch next 10 rows only;", objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static DataSet SelectAll()
    {
        DataSet ds = new DataSet();
        SqlConnection objConnection;
        SqlCommand objCommand;
        SqlDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("select p.nome, e.cidade, e.estado from enderecos e inner join pessoas p on e.cod_endereco = p.cod_endereco " +
        "inner join funcionarios f on f.cod_pessoa = p.cod_pessoa order by p.cod_pessoa desc;", objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }
}
