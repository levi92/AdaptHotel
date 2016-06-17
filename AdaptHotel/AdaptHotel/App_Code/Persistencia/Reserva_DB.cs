using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class Reserva_DB
{
    public static void Insert()
    {
        SqlConnection objConnection;
        SqlCommand objCommand;
        SqlDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("Insert into avaliacoes (dataReservaEntrada, dataReservaSaida, dataChekIn, dataChekOut, statusReserva, pago, valorTotal, codHospedes) values @dataReservaEntrada, @dataReservaSaida, @dataChekIn, @dataChekOut, @statusReserva, @pago, @valorTotal, @codHospedes", objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();

    }

    public static DataSet Select10Ultimos()
    {
        DataSet ds = new DataSet();
        SqlConnection objConnection;
        SqlCommand objCommand;
        SqlDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("select p.nome, r.data_reservada_entrada, r.data_reservada_saida from pessoas p inner join hospedes h on p.cod_pessoa = h.cod_pessoa " +
        "inner join reservas r on r.cod_hospede = h.cod_hospede order by r.data_reservada_entrada desc offset 0 rows fetch next 10 rows only;", objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }
}