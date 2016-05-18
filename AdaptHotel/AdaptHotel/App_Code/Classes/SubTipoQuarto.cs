using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class SubTipoQuarto
{
    private string subTipo, descricao;
    private int qndteAdultos, qndteCriancas;
    private double valor;
    // fazer associação

	public SubTipoQuarto(string subTipo, string descricao, int qndteAdultos, int qndteCriancas, double valor)
	{
        this.subTipo = subTipo;
        this.descricao = descricao;
        this.qndteAdultos = qndteAdultos;
        this.qndteCriancas = qndteCriancas;
        this.valor = valor;
	}


    public double Valor
    {
        get { return valor; }
        set { valor = value; }
    }


    public int QndteCriancas
    {
        get { return qndteCriancas; }
        set { qndteCriancas = value; }
    }

    public int QndteAdultos
    {
        get { return qndteAdultos; }
        set { qndteAdultos = value; }
    }

    public string Descricao
    {
        get { return descricao; }
        set { descricao = value; }
    }

    public string SubTipo
    {
        get { return subTipo; }
        set { subTipo = value; }
    }

    public string ImprimirSubTipoQuarto()
    {
        return "SUB TIPO DE QUARTO: " + SubTipo + "DESCRICAO: " + Descricao + "QUANTIDADE ADULTOS: " + QndteAdultos + "QUANTIDADE CRIANÇAS: " + QndteCriancas+ "VALOR: "+Valor;
    }

}