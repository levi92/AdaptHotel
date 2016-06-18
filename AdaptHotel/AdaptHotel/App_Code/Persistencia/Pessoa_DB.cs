using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;


public class Pessoa_DB
{
    public static int Insert(Pessoa pessoa)
    {
        int retorno = 0;
        try
        {
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("Insert into pessoas (nome, sexo, data_nasc, telefone, cpf, email, senha, codEndereco, codPerfil, codFoto) values (@nome, @sexo, @data_nasc, @telefone, @cpf, @email, @senha);", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@nome", pessoa.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("@sexo", pessoa.Sexo));
            objCommand.Parameters.Add(Mapped.Parameter("@data_nasc", pessoa.DataNascimento));
            objCommand.Parameters.Add(Mapped.Parameter("@telefone", pessoa.Telefone));
            objCommand.Parameters.Add(Mapped.Parameter("@cpf", pessoa.Cpf));
            objCommand.Parameters.Add(Mapped.Parameter("@email", pessoa.Email));
            objCommand.Parameters.Add(Mapped.Parameter("@senha", pessoa.Senha));
            int cod_tipo_quarto = Convert.ToInt32(objCommand.ExecuteScalar());

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

}