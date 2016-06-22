using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


public class ReservaQuarto_DB
{
    public static int Insert(Reserva reserva, SqlConnection objConnection)
    {
        int retorno = 0;

        foreach (NumeroQuarto numeroQuarto in reserva.ListaNumeroQuarto)
        {
            SqlCommand objCommand = Mapped.Command("Insert into reservaQuarto (cod_reserva, cod_numero_quarto) values (@cod_reserva, @cod_numero_quarto);", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@cod_reserva", reserva.CodReserva));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_numero_quarto", numeroQuarto.CodNumeroQuarto));
        }
        return retorno;
    }
}