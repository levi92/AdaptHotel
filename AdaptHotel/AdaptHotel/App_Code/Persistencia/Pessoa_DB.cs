using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;


public class Pessoa_DB
{
    public static int Insert(Pessoa pessoa, SqlConnection objConnection)
    {
        int retorno = 0;
        try
        {
            pessoa.Endereco.CodEnd = Endereco_DB.Insert(pessoa.Endereco, objConnection);

            if (pessoa.Foto.Endereco_foto != null)
            {
                pessoa.Foto.Cod_fotos = Foto_DB.Insert(pessoa.Foto, objConnection);
            } else
            {
                pessoa.Foto.Cod_fotos = null;
            }

            SqlCommand objCommand = Mapped.Command("Insert into pessoas (nome, sexo, data_nasc, telefone, cpf, email, cod_endereco, cod_perfil) output Inserted.cod_pessoa values (@nome, @sexo, @data_nasc, @telefone, @cpf, @email, @cod_endereco, @cod_perfil);", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@nome", pessoa.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("@sexo", pessoa.Sexo));
            objCommand.Parameters.Add(Mapped.Parameter("@data_nasc", pessoa.DataNascimento.ToString("yyyy-MM-dd HH:mm:ss")));
            objCommand.Parameters.Add(Mapped.Parameter("@telefone", pessoa.Telefone));
            objCommand.Parameters.Add(Mapped.Parameter("@cpf", pessoa.Cpf));
            objCommand.Parameters.Add(Mapped.Parameter("@email", pessoa.Email));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_endereco", pessoa.Endereco.CodEnd));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_perfil", pessoa.Perfil.Cod_perfil));
            retorno = Convert.ToInt32(objCommand.ExecuteScalar());
        }
        catch (Exception)
        {
            retorno = -2;
        }
        return retorno;
    }

}