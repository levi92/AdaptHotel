using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class TipoQuarto
{
    private enum tipo { solteiro, casal }; // se for só isso, essa tabela vai ficar assim mesmo!
    private SubTipoQuarto subQuarto;

	public TipoQuarto(SubTipoQuarto subQuarto)
	{
        this.subQuarto = subQuarto;
	}

    public SubTipoQuarto SubQuarto
    {
        get { return subQuarto; }
        set { subQuarto = value; }
    }

    public string ImprimiTipoQuarto()
    {
        return "SUB TIPO DE QUARTO: " + subQuarto;
    }
}