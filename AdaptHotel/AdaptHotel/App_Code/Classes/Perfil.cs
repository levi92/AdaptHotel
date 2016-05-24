using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Perfil
{
    private int cod_perfil;
    public enum _tipo { administrador, gerente, recepcionista, hospede };
    private _tipo tipo; 

    public int Cod_perfil
    {
        get { return cod_perfil; }
        set { cod_perfil = value; }
    }

    public string getTipo()
    {
        return tipo.ToString();    
    }

    public void setTipo(string tipo)
    {
        this.tipo = (_tipo)Enum.Parse(typeof(_tipo), tipo); ;
    }
}
