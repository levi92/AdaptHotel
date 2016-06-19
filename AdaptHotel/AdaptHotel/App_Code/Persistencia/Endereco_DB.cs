using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


public class Endereco_DB
{
    public static int Insert(Endereco endereco, SqlConnection objConnection)
    {
        int retorno = 0;
        //try
        //{
        //    
            SqlCommand objCommand = Mapped.Command("Insert into enderecos (rua, numero, complemento, bairro, cidade, estado, cep) output Inserted.cod_endereco values (@rua, @numero, @complemento, @bairro, @cidade, @estado, @cep);", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@rua", endereco.Rua));
            objCommand.Parameters.Add(Mapped.Parameter("@numero", endereco.Numero));
            objCommand.Parameters.Add(Mapped.Parameter("@complemento", endereco.Complemento));
            objCommand.Parameters.Add(Mapped.Parameter("@bairro", endereco.Bairro));
            objCommand.Parameters.Add(Mapped.Parameter("@cidade", endereco.Cidade));
            objCommand.Parameters.Add(Mapped.Parameter("@estado", endereco.Estado));
            objCommand.Parameters.Add(Mapped.Parameter("@cep", endereco.Cep));
            retorno = Convert.ToInt32(objCommand.ExecuteScalar());
        //}
        //catch (Exception)
        //{
        //    retorno = -2;
        //}
        return retorno;
    }

}
