﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class subTipoQuartos_DB
{
    public static int Insert(SubTipoQuarto sub_tipo_quarto)
    {
        int retorno = 0;

        try
        {         
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("Insert into subtipo_quartos (subtipo, descricao, qtd_adultos, qtd_criancas, valor, cod_tipo_quarto) output inserted.cod_subtipo_quarto values (@subtipo, @descricao, @qtd_adultos, @qtd_criancas, @valor, @cod_tipo_quarto);", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@subTipo", sub_tipo_quarto.SubTipo));
            objCommand.Parameters.Add(Mapped.Parameter("@descricao", sub_tipo_quarto.Descricao));
            objCommand.Parameters.Add(Mapped.Parameter("@qtd_adultos", sub_tipo_quarto.QtdAdultos));
            objCommand.Parameters.Add(Mapped.Parameter("@qtd_criancas", sub_tipo_quarto.QtdCriancas));
            objCommand.Parameters.Add(Mapped.Parameter("@valor", sub_tipo_quarto.Valor));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_tipo_quarto", sub_tipo_quarto.TipoQuarto.Cod_tipo_quarto));
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

    public static int Update(SubTipoQuarto sub_tipo_quarto)
    {
        int retorno = 0;
        try
        {
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("update sub_tipo_quarto set subtipo = @subtipo, descricao = @descricao, qrd_adultos = @qtd_adultos, qtd_criancas = @qtd_criancas, valor = @valor where cod_subtipo_quarto = @cod_subtipo_quarto;", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@subtipo", sub_tipo_quarto.SubTipo));
            objCommand.Parameters.Add(Mapped.Parameter("@descricao", sub_tipo_quarto.Descricao));
            objCommand.Parameters.Add(Mapped.Parameter("@qtd_adultos", sub_tipo_quarto.QtdAdultos));
            objCommand.Parameters.Add(Mapped.Parameter("@qtd_criancas", sub_tipo_quarto.QtdCriancas));
            objCommand.Parameters.Add(Mapped.Parameter("@valor", sub_tipo_quarto.Valor));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_subtipo_quarto", sub_tipo_quarto.Cod_subtipo_quarto));
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