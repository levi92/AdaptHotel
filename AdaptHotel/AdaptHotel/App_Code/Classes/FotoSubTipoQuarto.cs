using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class FotoSubTipoQuarto
{
    private int cod_fotos;
    private string endereco_foto;

    public FotoSubTipoQuarto(int cod_fotos, string endereco_foto)
    {
        this.cod_fotos = cod_fotos;
        this.endereco_foto = endereco_foto;
    }

    public int Cod_fotos
    {
        get { return cod_fotos; }
        set { cod_fotos = value; }
    }

    public string Endereco_foto
    {
        get { return endereco_foto; }
        set { endereco_foto = value; }
    }
}
