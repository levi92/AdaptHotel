using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class Hospede_DB
{
    public static int Insert(Hospede hospede)
    {
        int retorno = 0;

        try
        {
            SqlConnection objConnection = Mapped.Connection();
            hospede.CodPessoa = Pessoa_DB.Insert(hospede, objConnection);
            SqlCommand objCommand = Mapped.Command("Insert into hospedes (placa_carro, cidade_origem, cod_pessoa) values (@placa_carro, @cidade_origem, @cod_pessoa);", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@placa_carro", hospede.PlacaCarro));
            objCommand.Parameters.Add(Mapped.Parameter("@cidade_origem", hospede.CidadeOrigem));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_pessoa", hospede.CodPessoa));
            objCommand.ExecuteNonQuery();
            objConnection.Close();
            objCommand.Dispose();
            objConnection.Dispose();
        }
        catch (Exception)
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
        "inner join hospedes h on h.cod_pessoa = p.cod_pessoa order by p.cod_pessoa desc offset 0 rows fetch next 10 rows only;", objConnection);
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
        "inner join hospedes h on h.cod_pessoa = p.cod_pessoa order by p.cod_pessoa desc;", objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }
}
