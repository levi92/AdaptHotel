using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class DescontoQuarto
{
    private double valor;
    private int cod_desconto;
    private DateTime dataInicio, dataFim;
    private SubTipoQuarto subTipoQuarto;

	public DescontoQuarto(int cod_desconto, double valor, DateTime dataInicio, DateTime dataFim, SubTipoQuarto subTipoQuarto)
	{
        this.cod_desconto = cod_desconto;
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

    public int Cod_desconto
    {
        get { return cod_desconto; }
        set { cod_desconto = value; }
    }
}