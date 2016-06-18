using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class TipoQuarto
{
    private int cod_tipo_quarto;
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

    public int Cod_tipo_quarto
    {
        get { return cod_tipo_quarto; }
        set { cod_tipo_quarto = value; }
    }

    public string ImprimiTipoQuarto()
    {
        return "SUB TIPO DE QUARTO: " + Tipo;
    }
}