using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class SubTipoQuarto
{
    private int cod_subtipo_quarto;
    private string subTipo, descricao;
    private int qtdAdultos, qtdCriancas;
    private decimal valor;
    private TipoQuarto tipoQuarto;

	public SubTipoQuarto(string subTipo, string descricao, int qtdAdultos, int qtdCriancas, decimal valor, TipoQuarto tipoQuarto)
	{
        this.subTipo = subTipo;
        this.descricao = descricao;
        this.qtdAdultos = qtdAdultos;
        this.qtdCriancas = qtdCriancas;
        this.valor = valor;
        this.TipoQuarto = tipoQuarto;
	}

    public SubTipoQuarto()
    {

    }

    public decimal Valor
    {
        get { return valor; }
        set { valor = value; }
    }

    public int QtdCriancas
    {
        get { return qtdCriancas; }
        set { qtdCriancas = value; }
    }

    public int QtdAdultos
    {
        get { return qtdAdultos; }
        set { qtdAdultos = value; }
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

    public TipoQuarto TipoQuarto
    {
        get { return tipoQuarto; }
        set { tipoQuarto = value; }
    }

    public int Cod_subtipo_quarto
    {
        get { return cod_subtipo_quarto; }
        set { cod_subtipo_quarto = value; }
    }

    public string ImprimirSubTipoQuarto()
    {
        return "SUB TIPO DE QUARTO: " + SubTipo + "DESCRICAO: " + Descricao + "QUANTIDADE ADULTOS: " + qtdAdultos + "QUANTIDADE CRIANÇAS: " + qtdCriancas+ "VALOR: "+Valor;
    }

}