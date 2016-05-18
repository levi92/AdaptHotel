using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class ServicosExtras
{
    private string descricao;
    private double valor;
    private DateTime dataPedido;
    private SubTipoQuarto subTipoDeQuarto;


	public ServicosExtras(string descricao, DateTime dataPedido, double valor, SubTipoQuarto subTipoDeQuarto)
	{
        this.descricao = descricao;
        this.valor = valor;
        this.dataPedido = dataPedido;
        this.subTipoDeQuarto = subTipoDeQuarto;
	}

    public SubTipoQuarto SubTipoDeQuarto
    {
        get { return subTipoDeQuarto; }
        set { subTipoDeQuarto = value; }
    }

    public DateTime DataPedido
    {
        get { return dataPedido; }
        set { dataPedido = value; }
    }

    public string Descricao
    {
        get { return descricao; }
        set { descricao = value; }
    }

    public double Valor
    {
        get { return valor; }
        set { valor = value; }
    }

    public string ImprimirServicosExtras()
    {
        return "DESCRICOES: " + Descricao + "VALOR: " + Valor + " DATA DO PEDIDO: " + DataPedido + "SUB TIPO DE  QUARTO: " + subTipoDeQuarto ; 
    }


}
