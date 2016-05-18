using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class NumeroQuarto
{
    private string numeroQuartoo;
    private bool disponivel;
    private SubTipoQuarto subTipoQuartoN;

    

    
    public NumeroQuarto(string numeroQuartoo, bool disponivel, SubTipoQuarto subTipoQuartoN)
    {
        this.numeroQuartoo = numeroQuartoo;
        this.disponivel = disponivel;
        this.subTipoQuartoN = subTipoQuartoN;
    }

    public SubTipoQuarto SubTipoQuartoN
    {
        get { return subTipoQuartoN; }
        set { subTipoQuartoN = value; }
    }

    public string NumeroQuartoo
    {
        get
        {
            return numeroQuartoo;
        }

        set
        {
            numeroQuartoo = value;
        }
    }

    public bool Disponivel
    {
        get
        {
            return disponivel;
        }

        set
        {
            disponivel = value;
        }
    }
    public string ImprimirNumeroQuarto()
    {
        return "NUMERO DO QUARTO: " + NumeroQuartoo + "DISPONIBILIDADE: " + Disponivel + "SUB TIPO DE QUARTO: " + subTipoQuartoN;
    }
    
}