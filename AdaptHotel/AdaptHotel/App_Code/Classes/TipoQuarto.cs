using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class TipoQuarto
{
    private string tipo;

	public TipoQuarto(string tipo)
    {
        this.Tipo = tipo;
    }

    public string Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }

    public string ImprimiTipoQuarto()
    {
        return "SUB TIPO DE QUARTO: " + Tipo;
    }
}