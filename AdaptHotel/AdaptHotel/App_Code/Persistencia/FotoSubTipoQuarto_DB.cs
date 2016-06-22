using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

public class FotoSubTipoQuarto_DB
{
    public static int Insert(FotoSubTipoQuarto foto_subtipo_quarto)
    {
        int retorno = 0;
        try
        {
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("Insert into fotos (endereco_foto, codSubTipoQuartos) values (@endereco_foto, @codSubTipoQuartos);", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@endereco_foto", foto_subtipo_quarto.Endereco_foto));
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

    public static int Update (FotoSubTipoQuarto foto_subtipo_quarto)
    {
        int retorno = 0;
        try
        {
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("update fotos set endereco_foto = @endereco_foto where cod_foto_subtipo_quarto = @cod_foto_subtipo_quarto;", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@endereco_foto", foto_subtipo_quarto.Endereco_foto));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_foto_subtipo_quarto", foto_subtipo_quarto.Cod_fotos));
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