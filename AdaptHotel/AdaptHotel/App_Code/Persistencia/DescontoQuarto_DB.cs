using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


public class descontoQuarto_DB
{
    public static void Insert()
    {
        SqlConnection objConnection;
        SqlCommand objCommand;
        SqlDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("Insert into desconto_quarto (valor, data_inicio, data_fim, codSubTipoQuartos) values @valor, @data_inicio, @data_fim, @codSubTipoQuartos", objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();

    }
}