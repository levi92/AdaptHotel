using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Opcoes
{
    private string corPrimaria, corSecundaria, logotipo;
    private int? diasCancelamento, valorBaixaTemporada, valorAltaTemporada, multaAusencia, cod_Opcoes;
    private DateTime? dataInicialAltaTemporada, dataFinalAltaTemporada, dataInicialBaixaTemporada, dataFinalBaixaTemporada;

    public Opcoes (int? diasCancelamento = null, int? valorBaixaTemporada = null, int? valorAltaTemporada = null, int? multaAusencia = null, string corPrimaria = null, string corSecundaria = null, string logotipo = null, DateTime? dataInicialAltaTemporada = null, DateTime? dataFinalAltaTemporada = null, DateTime? dataInicialBaixaTemporada = null, DateTime? dataFinalBaixaTemporada = null)
    {
        this.diasCancelamento = diasCancelamento;
        this.valorBaixaTemporada = valorBaixaTemporada;
        this.valorAltaTemporada = valorAltaTemporada;
        this.multaAusencia = multaAusencia;
        this.corPrimaria = corPrimaria;
        this.corSecundaria = corSecundaria;
        this.logotipo = logotipo;
        this.dataInicialAltaTemporada = dataInicialAltaTemporada;
        this.dataFinalAltaTemporada = dataFinalAltaTemporada;
        this.dataInicialBaixaTemporada = dataInicialBaixaTemporada;
        this.dataFinalBaixaTemporada = dataFinalBaixaTemporada;
    }

    public DateTime? DataFinalBaixaTemporada
    {
        get { return dataFinalBaixaTemporada; }
        set { dataFinalBaixaTemporada = value; }
    }

    public DateTime? DataInicialBaixaTemporada
    {
        get { return dataInicialBaixaTemporada; }
        set { dataInicialBaixaTemporada = value; }
    }

    public DateTime? DataFinalAltaTemporada
    {
        get { return dataFinalAltaTemporada; }
        set { dataFinalAltaTemporada = value; }
    }

    public DateTime? DataInicialAltaTemporada
    {
        get { return dataInicialAltaTemporada; }
        set { dataInicialAltaTemporada = value; }
    }

    public int? MultaAusencia
    {
        get { return multaAusencia; }
        set { multaAusencia = value; }
    }

    public int? ValorAltaTemporada
    {
        get { return valorAltaTemporada; }
        set { valorAltaTemporada = value; }
    }

    public int? ValorBaixaTemporada
    {
        get { return valorBaixaTemporada; }
        set { valorBaixaTemporada = value; }
    }

    public int? DiasCancelamento
    {
        get { return diasCancelamento; }
        set { diasCancelamento = value; }
    }

    public string Logotipo
    {
        get { return logotipo; }
        set { logotipo = value; }
    }

    public string CorSecundaria
    {
        get { return corSecundaria; }
        set { corSecundaria = value; }
    }

    public string CorPrimaria
    {
        get { return corPrimaria; }
        set { corPrimaria = value; }
    }
}