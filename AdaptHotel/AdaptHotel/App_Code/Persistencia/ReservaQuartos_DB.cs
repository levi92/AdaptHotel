using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;

/// <summary>
/// Summary description for reservaQuartos_DB
/// </summary>
public class reservaQuartos_DB
{
    public static void Insert()
    {
        SqlConnection objConnection;
        SqlCommand objCommand;
        SqlDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
       // objCommand = Mapped.Command("Insert into avaliacoes (codReservaQuartos, codReserva, codNumeroQuarto) values @codReservaQuartos, @codReserva, @codNumeroQuarto");
        objDataAdapter = Mapped.Adapter(objCommand);
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();

    }

}