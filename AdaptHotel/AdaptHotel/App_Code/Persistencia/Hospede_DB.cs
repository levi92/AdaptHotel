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

    public static int Update(Hospede hospede)
    {
        int retorno = 0;
        try
        {
            SqlConnection objConnection = Mapped.Connection();
            Pessoa_DB.Update(hospede, objConnection);

            SqlCommand objCommand = Mapped.Command("Update hospedes set placa_carro = @placa_carro, cidade_origem = @cidade_origem where cod_hospede = @cod_hospede;", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@placa_carro", hospede.PlacaCarro));
            objCommand.Parameters.Add(Mapped.Parameter("@cidade_origem", hospede.CidadeOrigem));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_hospede", hospede.CodHospede));
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
        objCommand = Mapped.Command("select pes.nome, e.cidade, e.estado, h.cod_hospede from hospedes h " +
        "inner join pessoas pes on pes.cod_pessoa = h.cod_pessoa " +
        "inner join enderecos e on e.cod_endereco = pes.cod_endereco order by pes.cod_pessoa desc offset 0 rows fetch next 10 rows only; ", objConnection);
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
        objCommand = Mapped.Command("select pes.nome, e.cidade, e.estado, h.cod_hospede from hospedes h " +
        "inner join pessoas pes on pes.cod_pessoa = h.cod_pessoa " +
        "inner join enderecos e on e.cod_endereco = pes.cod_endereco order by pes.nome; ", objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static Hospede SelectByID(int cod_hospede)
    {
        SqlConnection objconexao = Mapped.Connection();
        SqlCommand objCommand = Mapped.Command("select * from hospedes h " +
            "left join pessoas pes on pes.cod_pessoa = h.cod_pessoa " +
            "left join fotos f on f.cod_foto = pes.cod_foto " +
            "left join enderecos e on e.cod_endereco = pes.cod_endereco where h.cod_hospede = @cod_hospede; ", objconexao);
        objCommand.Parameters.Add(Mapped.Parameter("@cod_hospede", cod_hospede));
        SqlDataReader objDataReader = objCommand.ExecuteReader();

        Hospede hospede = null;

        while (objDataReader.Read())
        {
            int nulo;

            Perfil perfil = new Perfil();
            Foto foto = new Foto(objDataReader["endereco_foto"].ToString(), int.TryParse(objDataReader["endereco_foto"].ToString(), out nulo) ? (int?)nulo : null);
            Endereco endereco = new Endereco(objDataReader["rua"].ToString(), objDataReader["numero"].ToString(),
                objDataReader["complemento"].ToString(), objDataReader["bairro"].ToString(), objDataReader["cep"].ToString(),
                objDataReader["cidade"].ToString(), objDataReader["estado"].ToString(), Convert.ToInt32(objDataReader["cod_endereco"]));
            string codigo = objDataReader["cod_pessoa"].ToString();
            hospede = new Hospede(objDataReader["nome"].ToString(), objDataReader["telefone"].ToString(),
                objDataReader["email"].ToString(), objDataReader["cpf"].ToString(), Convert.ToChar(objDataReader["sexo"]),
                Convert.ToDateTime(objDataReader["data_nasc"]), perfil, endereco, objDataReader["placa_carro"].ToString(),
                objDataReader["cidade_origem"].ToString(), Convert.ToInt32(objDataReader["cod_pessoa"]), foto, null, Convert.ToInt32(objDataReader["cod_hospede"]));

            objDataReader.Close();
            objconexao.Close();
            objconexao.Dispose();
            objCommand.Dispose();
            objDataReader.Dispose();

            return hospede;
        }

        objDataReader.Close();
        objconexao.Close();
        objconexao.Dispose();
        objCommand.Dispose();
        objDataReader.Dispose();

        return hospede;
    }
}
