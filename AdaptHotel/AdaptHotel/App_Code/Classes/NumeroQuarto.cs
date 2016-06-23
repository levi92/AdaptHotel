using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class NumeroQuarto
{
    private int codNumeroQuarto;
    private string numero_quarto;
    public enum _status_quarto { disponivel, ocupado, manutencao, desabilitado };
    private _status_quarto status_quarto;
    private SubTipoQuarto subTipoQuarto;
    private string cor;

    public NumeroQuarto(int codNumeroQuarto, string numero_quarto, string status_quarto, SubTipoQuarto subTipoQuarto, string cor)
    {
        this.CodNumeroQuarto = codNumeroQuarto;
        this.numero_quarto = numero_quarto;
        this.status_quarto = (_status_quarto)Enum.Parse(typeof(_status_quarto), status_quarto);
        this.subTipoQuarto = subTipoQuarto;
        this.cor = cor;
    }

    public NumeroQuarto()
    {

    }

    public SubTipoQuarto SubTipoQuarto
    {
        get { return subTipoQuarto; }
        set { subTipoQuarto = value; }
    }

    public string Numero_Quarto
    {
        get { return numero_quarto; }
        set { numero_quarto = value; }
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

    public void setStatusQuarto(string status_quarto)
    {
        this.status_quarto = (_status_quarto)Enum.Parse(typeof(_status_quarto), status_quarto);
    }    
}