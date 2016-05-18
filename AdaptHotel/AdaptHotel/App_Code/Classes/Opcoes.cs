using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Opcoes
{
    private string corPrimaria, corSecundaria, logotipo;
    private int diasCancelamento, baixaTemporada, altaTemporada, multaAusencia;
    private DateTime dataInicialAltaTemporada, dataFinalAltaTemporada, dataInicialBaixaTemporada, dataFinalBaixaTemporada;




    public DateTime DataFinalBaixaTemporada
    {
        get { return dataFinalBaixaTemporada; }
        set { dataFinalBaixaTemporada = value; }
    }

    public DateTime DataInicialBaixaTemporada
    {
        get { return dataInicialBaixaTemporada; }
        set { dataInicialBaixaTemporada = value; }
    }

    public DateTime DataFinalAltaTemporada
    {
        get { return dataFinalAltaTemporada; }
        set { dataFinalAltaTemporada = value; }
    }

    public DateTime DataInicialAltaTemporada
    {
        get { return dataInicialAltaTemporada; }
        set { dataInicialAltaTemporada = value; }
    }

    public int MultaAusencia
    {
        get { return multaAusencia; }
        set { multaAusencia = value; }
    }

    public int AltaTemporada
    {
        get { return altaTemporada; }
        set { altaTemporada = value; }
    }

    public int BaixaTemporada
    {
        get { return baixaTemporada; }
        set { baixaTemporada = value; }
    }

    public int DiasCancelamento
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