﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


public class DescontoQuarto_DB
{
    public static int Insert(DescontoQuarto desconto_quarto)
    {
        int retorno = 0;
        try
        {
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("Insert into desconto_quarto (valor, data_inicio, data_fim, codSubTipoQuartos) values (@valor, @data_inicio, @data_fim, @codSubTipoQuartos);", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@valor", desconto_quarto.Valor));
            objCommand.Parameters.Add(Mapped.Parameter("@data_inicio", desconto_quarto.DataInicio));
            objCommand.Parameters.Add(Mapped.Parameter("@data_fim", desconto_quarto.DataFim));
            retorno = Convert.ToInt32(objCommand.ExecuteScalar());

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