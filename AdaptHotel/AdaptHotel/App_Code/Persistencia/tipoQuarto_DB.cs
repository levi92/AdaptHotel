using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class tipoQuarto_DB
{
    public static int Insert(TipoQuarto tipo_quartos)
    {
        int retorno = 0;
        try
        {
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("Insert into tipo_quartos (tipo) values (@tipo);", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@tipo", tipo_quartos.Tipo));
            objCommand.ExecuteNonQuery();
            objConnection.Close();
            objCommand.Dispose();
            objConnection.Dispose();
        }
        catch(Exception)
        {
            retorno = -2;
        }
        return retorno;
    }

    public static int Update(TipoQuarto tipo_quarto)
    {
        int retorno = 0;
        try
        {
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("update tipo_quarto set tipo = @tipo where cod_tipo_quarto = @cod_tipo_quarto;", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@tipo", tipo_quarto.Tipo));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_tipo_quarto", tipo_quarto.Cod_tipo_quarto));
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
}
