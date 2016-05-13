using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class DescontoQuarto
{
    private double valor;
    private DateTime dataInicio, dataFim;
    private SubTipoQuarto subTipoQuarto;

	public DescontoQuarto(double valor, DateTime dataInicio, DateTime dataFim, SubTipoQuarto subTipoQuarto)
	{
        this.valor = valor;
        this.dataInicio = dataInicio;
        this.dataFim = dataFim;
        this.subTipoQuarto = subTipoQuarto;
	}

    public SubTipoQuarto SubTipoQuarto
    {
        get { return subTipoQuarto; }
        set { subTipoQuarto = value; }
    }

    public DateTime DataFim
    {
        get { return dataFim; }
        set { dataFim = value; }
    }

    public DateTime DataInicio
    {
        get { return dataInicio; }
        set { dataInicio = value; }
    }

    public double Valor
    {
        get { return valor; }
        set { valor = value; }
    }

    public string ImprimirDescontoQuarto()
    {
        return "VALOR: " + Valor + "DATA INICIAL: " + DataInicio + "DATA FINAL: " + DataFim + "SUB TIPO DE QUARTO: " + SubTipoQuarto;
    }

}