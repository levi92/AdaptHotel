using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class NumeroQuarto
{
    private int codNumeroQuarto;
    private string numeroQuartoo;
    public enum _status_quarto { disponivel, ocupado, manutencao, desabilitado };
    private _status_quarto status_quarto;
    private SubTipoQuarto subTipoQuarto;
    private string cor;

    public NumeroQuarto(int codNumeroQuarto, string numeroQuartoo, string status_quarto, SubTipoQuarto subTipoQuarto, string cor)
    {
        this.CodNumeroQuarto = codNumeroQuarto;
        this.numeroQuartoo = numeroQuartoo;
        this.status_quarto = (_status_quarto)Enum.Parse(typeof(_status_quarto), status_quarto);
        this.subTipoQuarto = subTipoQuarto;
        this.cor = cor;
    }

    public SubTipoQuarto SubTipoQuarto
    {
        get { return subTipoQuarto; }
        set { subTipoQuarto = value; }
    }

    public string NumeroQuartoo
    {
        get { return numeroQuartoo; }
        set { numeroQuartoo = value; }
    }

    public string Cor
    {
        get { return cor; }
        set { cor = value; }
    }

    public int CodNumeroQuarto
    {
        get { return codNumeroQuarto; }
        set { codNumeroQuarto = value; }
    }

    public string getStatusQuarto()
    {
        return status_quarto.ToString();
    }

    public void setTipo(string status_quarto)
    {
        this.status_quarto = (_status_quarto)Enum.Parse(typeof(_status_quarto), status_quarto);
    }    
}