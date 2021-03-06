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
            SqlCommand objCommand = Mapped.Command("Insert into desconto_quarto (valor, data_inicio, data_fim, cod_subtipo_quartos) values (@valor, @data_inicio, @data_fim, @cod_subtipo_quartos);", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@valor", desconto_quarto.Valor));
            objCommand.Parameters.Add(Mapped.Parameter("@data_inicio", desconto_quarto.DataInicio));
            objCommand.Parameters.Add(Mapped.Parameter("@data_fim", desconto_quarto.DataFim));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_subtipo_quartos", desconto_quarto.SubTipoQuarto.Cod_subtipo_quarto));
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

    public static int Update(DescontoQuarto desconto_quarto)
    {
        int retorno = 0;
        try
        {
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("update desconto_quarto set valor = @valor, data_inicio = @data_inicio, data_fim = @data_fim where cod_desconto = @cod_desconto;", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@valor", desconto_quarto.Valor));
            objCommand.Parameters.Add(Mapped.Parameter("@data_inicio", desconto_quarto.DataInicio));
            objCommand.Parameters.Add(Mapped.Parameter("@data_fim", desconto_quarto.DataFim));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_desconto", desconto_quarto.Cod_desconto));
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