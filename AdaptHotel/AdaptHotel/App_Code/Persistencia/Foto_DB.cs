using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


public class Foto_DB
{
    public static int Insert(Foto foto, SqlConnection objConnection)
    {
        int retorno = 0;
        try
        {
            SqlCommand objCommand = Mapped.Command("Insert into fotos (endereco_foto) output Inserted.cod_foto values (@endereco_foto);", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@endereco_foto", foto.Endereco_foto));
            retorno = Convert.ToInt32(objCommand.ExecuteScalar());
        }
        catch (Exception)
        {
            retorno = -2;
        }
        return retorno;
    }

    public static int Update(Foto foto, SqlConnection objConnection)
    {
        int retorno = 0;
        try
        {
            SqlCommand objCommand = Mapped.Command("Update fotos set endereco_foto = @endereco_foto where cod_foto = @cod_foto;", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@endereco_foto", foto.Endereco_foto));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_foto", foto.Cod_fotos));
            objCommand.ExecuteNonQuery();
        }
        catch (Exception)
        {
            retorno = -2;
        }
        return retorno;
    }
}