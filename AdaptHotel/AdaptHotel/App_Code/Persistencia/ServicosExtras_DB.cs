using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for servicosExtras_DB
/// </summary>
public class servicosExtras_DB
{
    public static void Insert()
    {
        SqlConnection objConnection;
        SqlCommand objCommand;
        SqlDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("Insert into avaliacoes (descricao, valor, dataPedido, codReserva) values @descricao, @valor, @dataPedido, @codReserva", objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();

    }

}