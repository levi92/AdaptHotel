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
            int cod_tipo_quarto = Convert.ToInt32(objCommand.ExecuteScalar());

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