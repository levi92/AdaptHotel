﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for fotoSubTipoQuarto_DB
/// </summary>
public class fotoSubTipoQuarto_DB
{
    public static void Insert()
    {
        SqlConnection objConnection;
        SqlCommand objCommand;
        SqlDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("Insert into fotos (endereco_foto, codSubTipoQuartos) values (@endereco_foto, @codSubTipoQuartos)", objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();

    }
}