using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for tipoQuarto
/// </summary>
public class tipoQuarto_DB
{
    public static void  Insert()
    {
        SqlConnection objConnection;
        SqlCommand objCommand;
        SqlDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("Insert into tipo_quartos (tipo) values @tipo", objConnection);
        objCommand.ExecuteNonQuery(); // isso aqui deve mesmo ficar ???
        objDataAdapter = Mapped.Adapter(objCommand);
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();  

    }
}
