using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class Perfil
{
    private int cod;
    private string tipo;

    public Perfil (int cod, string tipo)
    {
        this.Cod = cod;
        this.Tipo = tipo;
    }

    public int Cod
    {
        get { return cod; }
        set { cod = value; }
    }

    public string Tipo
    {
        get { return tipo; }
        set { tipo = value;}
    }

    public static DataSet SelectAll()
    {
        DataSet ds = new DataSet();
        SqlConnection objConnection;
        SqlCommand objCommand;
        SqlDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("select * from perfis;", objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }
}