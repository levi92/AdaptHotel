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

    public static int Update(Funcionario funcionario)
    {
        int retorno = 0;
        try
        {
            SqlConnection objConnection = Mapped.Connection();
            Pessoa_DB.Update(funcionario, objConnection);

            SqlCommand objCommand = Mapped.Command("Insert into funcionarios cargo = @cargo, salario = @salario, " +
                "data_admissao = @data_admissao, numero_cnt = @numero_cnt" +
                "where cod_funcionario = @cod_funcionario;", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@cargo", funcionario.Cargo));
            objCommand.Parameters.Add(Mapped.Parameter("@salario", funcionario.Salario));
            objCommand.Parameters.Add(Mapped.Parameter("@data_admissao", funcionario.DataAdmissao));
            objCommand.Parameters.Add(Mapped.Parameter("@numero_cnt", funcionario.NumeroCnt));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_funcionario", funcionario.CodFuncionario));
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
        objCommand = Mapped.Command("select p.nome, e.cidade,  e.cidade, f.cod_funcionario from enderecos e inner join pessoas p on e.cod_endereco = p.cod_endereco " +
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
        objCommand = Mapped.Command("select pes.nome, e.cidade, e.estado, f.cod_funcionario from funcionarios f " +
        "inner join pessoas pes on pes.cod_pessoa = f.cod_pessoa " +
        "inner join enderecos e on e.cod_endereco = pes.cod_endereco order by pes.nome; ", objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }

    public static Funcionario SelectByID(int cod_funcionario)
    {
        SqlConnection objconexao = Mapped.Connection();
        SqlCommand objCommand = Mapped.Command("select * from funcionarios fu " +
            "left join pessoas pes on pes.cod_pessoa = fu.cod_pessoa " +
            "left join fotos f on f.cod_foto = pes.cod_foto " +
            "left join enderecos e on e.cod_endereco = pes.cod_endereco where fu.cod_funcionario = @cod_funcionario; ", objconexao);
        objCommand.Parameters.Add(Mapped.Parameter("@cod_funcionario", cod_funcionario));
        SqlDataReader objDataReader = objCommand.ExecuteReader();

        Funcionario funcioario = null;

        while (objDataReader.Read())
        {
            int nulo;

            Perfil perfil = new Perfil();
            Foto foto = new Foto(objDataReader["endereco_foto"].ToString(), int.TryParse(objDataReader["endereco_foto"].ToString(), out nulo) ? (int?)nulo : null);
            Endereco endereco = new Endereco(objDataReader["rua"].ToString(), objDataReader["numero"].ToString(),
                objDataReader["complemento"].ToString(), objDataReader["bairro"].ToString(), objDataReader["cep"].ToString(),
                objDataReader["cidade"].ToString(), objDataReader["estado"].ToString());

            funcioario = new Funcionario(objDataReader["nome"].ToString(), objDataReader["telefone"].ToString(),
                 objDataReader["email"].ToString(), objDataReader["cpf"].ToString(), Convert.ToChar(objDataReader["sexo"]),
                 Convert.ToDateTime(objDataReader["data_nasc"]), perfil, endereco, objDataReader["cargo"].ToString(),
                 objDataReader["numero_cnt"].ToString(), Convert.ToDouble(objDataReader["salario"]), Convert.ToDateTime(objDataReader["data_admissao"]),
                 Convert.ToInt32(objDataReader["cod_pessoa"]), Convert.ToInt32(objDataReader["cod_funcionario"]), foto, null);

            objDataReader.Close();
            objconexao.Close();
            objconexao.Dispose();
            objCommand.Dispose();
            objDataReader.Dispose();

            return funcioario;
        }

        objDataReader.Close();
        objconexao.Close();
        objconexao.Dispose();
        objCommand.Dispose();
        objDataReader.Dispose();

        return funcioario;
    }
}
