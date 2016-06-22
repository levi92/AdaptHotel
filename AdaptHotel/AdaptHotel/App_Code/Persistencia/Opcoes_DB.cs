using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


public class Opcoes_DB
{
    public static int Insert(Opcoes opcoes)
    {
        int retorno = 0;
        try
        {
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("insert into opcoes (dias_cancelamento, data_ini_alta_temp, data_fim_alta_temp, data_ini_baixa_tempo, data_fim_baixa_tempo, valor_alta_temp, valor_baixa_temp, multa_no_show, cor_primaria, cor_secundaria, logo)" +
                "  values (dias_cancelamento, data_ini_alta_temp, data_fim_alta_temp, data_ini_baixa_tempo, data_fim_baixa_tempo, valor_alta_temp, valor_baixa_temp, multa_no_show, cor_primaria, cor_secundaria, logo);", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@dias_cancelamento", opcoes.DiasCancelamento));
            objCommand.Parameters.Add(Mapped.Parameter("@data_ini_alta_temp", opcoes.DataInicialAltaTemporada));
            objCommand.Parameters.Add(Mapped.Parameter("@data_fim_alta_temp", opcoes.DataFinalAltaTemporada));
            objCommand.Parameters.Add(Mapped.Parameter("@data_ini_baixa_tempo", opcoes.DataInicialBaixaTemporada));
            objCommand.Parameters.Add(Mapped.Parameter("@data_fim_baixa_tempo", opcoes.DataFinalBaixaTemporada));
            objCommand.Parameters.Add(Mapped.Parameter("@valor_alta_temp", opcoes.ValorAltaTemporada));
            objCommand.Parameters.Add(Mapped.Parameter("@valor_baixa_temp", opcoes.ValorBaixaTemporada));
            objCommand.Parameters.Add(Mapped.Parameter("@multa_no_show", opcoes.MultaAusencia));
            objCommand.Parameters.Add(Mapped.Parameter("@cor_primaria", opcoes.CorPrimaria));
            objCommand.Parameters.Add(Mapped.Parameter("@cor_secundaria", opcoes.CorSecundaria));
            objCommand.Parameters.Add(Mapped.Parameter("@logo", opcoes.Logotipo));
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

    public static int UpdateOpcoes(Opcoes opcoes)
    {
        int retorno = 0;
        try
        {
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("update opcoes set dias_cancelamento = @dias_cancelamento, data_ini_alta_temp = @data_ini_alta_temp, data_fim_alta_temp = @data_fim_alta_temp, data_ini_baixa_tempo = @data_ini_baixa_tempo, data_fim_baixa_tempo = @data_fim_baixa_tempo, valor_alta_temp = @valor_alta_temp, valor_baixa_temp = @valor_baixa_temp, multa_no_show = @multa_no_show, cor_primaria = @cor_primaria, cor_secundaria = @cor_secindaria, logo = @logo" +
                " where cod_opcao = @opcao ;", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@dias_cancelamento", opcoes.DiasCancelamento));
            objCommand.Parameters.Add(Mapped.Parameter("@data_ini_alta_temp", opcoes.DataInicialAltaTemporada));
            objCommand.Parameters.Add(Mapped.Parameter("@data_fim_alta_temp", opcoes.DataFinalAltaTemporada));
            objCommand.Parameters.Add(Mapped.Parameter("@data_ini_baixa_tempo", opcoes.DataInicialBaixaTemporada));
            objCommand.Parameters.Add(Mapped.Parameter("@data_fim_baixa_tempo", opcoes.DataFinalBaixaTemporada));
            objCommand.Parameters.Add(Mapped.Parameter("@valor_alta_temp", opcoes.ValorAltaTemporada));
            objCommand.Parameters.Add(Mapped.Parameter("@valor_baixa_temp", opcoes.ValorBaixaTemporada));
            objCommand.Parameters.Add(Mapped.Parameter("@multa_no_show", opcoes.MultaAusencia));
            objCommand.Parameters.Add(Mapped.Parameter("@cor_primaria", opcoes.CorPrimaria));
            objCommand.Parameters.Add(Mapped.Parameter("@cor_secundaria", opcoes.CorSecundaria));
            objCommand.Parameters.Add(Mapped.Parameter("@logo", opcoes.Logotipo));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_opcao", opcoes.Cod_opcao));
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