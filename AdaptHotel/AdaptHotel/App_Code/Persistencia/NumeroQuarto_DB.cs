using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class NumeroQuarto_DB
{
    public static DataSet SelectAll()
    {
        DataSet ds = new DataSet();
        SqlConnection objConnection;
        SqlCommand objCommand;
        SqlDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("select t.tipo, s.subtipo, s.descricao, s.qtd_adultos, s.qtd_criancas, s.valor, n.cod_numero_quarto, n.numero_quarto, n.status_quarto " +
        "from tipo_quartos t inner join subtipo_quartos s on t.cod_tipo_quarto = s.cod_tipo_quarto " +
        "inner join numero_quartos n on n.cod_subtipo_quarto = s.cod_subtipo_quarto; ", objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }
}