using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for subTipoQuartos_DB
/// </summary>
public class subTipoQuartos_DB
{
    public static void Insert()
    {
        SqlConnection objConnection;
        SqlCommand objCommand;
        SqlDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("Insert into subtipo_quartos (subTipo, descricao, qtd_adultos, qtd_criancas, valor, codTipoQuarto) values @subTipo, @descricao, @qtd_adultos, @qtd_criancas, @valor, @codTipoQuarto", objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();

    }
}