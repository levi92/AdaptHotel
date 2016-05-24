using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class Funcoes_DB
{
    public static Pessoa ValidarLogin(string email, string senha)
    {
        SqlConnection objconexao;
        SqlCommand objCommand;
        SqlDataReader objDataReader;
        string sql = "select pes.cod_pessoa, pes.nome, per.tipo from perfis per inner join pessoas pes " +
                     "on per.cod_perfil = pes.cod_perfil where pes.email like @email and " +
                     "pes.senha like @senha;";
        objconexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objconexao);
        objCommand.Parameters.Add(Mapped.Parameter("email", email));
        objCommand.Parameters.Add(Mapped.Parameter("senha", senha));
        objDataReader = objCommand.ExecuteReader();

        Perfil perfil = new Perfil();
        Pessoa pessoa = new Pessoa();

        while (objDataReader.Read())
        {
            pessoa.CodPessoa = Convert.ToInt32(objDataReader["cod_pessoa"]);
            pessoa.Nome = objDataReader["nome"].ToString();
            perfil.setTipo(objDataReader["tipo"].ToString());
            pessoa.Perfil = perfil;
        }

        objDataReader.Close();
        objconexao.Close();
        objconexao.Dispose();
        objCommand.Dispose();
        objDataReader.Dispose();

        return pessoa;
    }
}
