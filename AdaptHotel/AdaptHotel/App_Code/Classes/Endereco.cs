using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Endereco
{
    private string rua, numero, complemento, bairro, cep, cidade, estado;
    private int codEnd;

    public int CodEnd
    {
        get { return codEnd; }
        set { codEnd = value; }
    }

    public string Estado
    {
        get { return estado; }
        set { estado = value; }
    }

    public string Cidade
    {
        get { return cidade; }
        set { cidade = value; }
    }

    public string Cep
    {
        get { return cep; }
        set { cep = value; }
    }

    public string Bairro
    {
        get { return bairro; }
        set { bairro = value; }
    }

    public string Complemento
    {
        get { return complemento; }
        set { complemento = value; }
    }

    public string Numero
    {
        get { return numero; }
        set { numero = value; }
    }

    public string Rua
    {
        get { return rua; }
        set { rua = value; }
    }

    public string Imprimir()
    {
        return "RUA: " + Rua + "NUMERO: " + Numero + "COMPLEMENTO: " + Complemento + "BAIRRO: " + Bairro + "CIDADE: " + Cidade + "ESTADO: " + Estado + "CEP: " + Cep;
    }
}