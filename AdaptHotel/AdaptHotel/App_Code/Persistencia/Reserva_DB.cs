using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class Reserva_DB
{
    public static int Insert(Reserva reserva)
    {
        int retorno = 0;
        try
        {
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("Insert into reserva (data_reserva_entrada, data_reserva_saida, data_chek_in, data_chek_out, status_reserva, pago, valor_total, cod_hospedes) output Inserted.cod_reserva values (@data_reserva_entrada, @data_reserva_saida, @data_chek_in, @data_chek_out, @status_reserva, @pago, @valor_total, @cod_hospedes);", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@data_reserva_entrada", reserva.getDataReservaEntrada()));
            objCommand.Parameters.Add(Mapped.Parameter("@data_reserva_saida", reserva.getDataReservaSaida()));
            objCommand.Parameters.Add(Mapped.Parameter("@data_chek_in", reserva.DataCheckin));
            objCommand.Parameters.Add(Mapped.Parameter("@data_chek_out", reserva.DataCheckout));
            objCommand.Parameters.Add(Mapped.Parameter("@status_reserva", reserva.getStatusReserva()));
            objCommand.Parameters.Add(Mapped.Parameter("@pago", reserva.Pago));
            objCommand.Parameters.Add(Mapped.Parameter("@valor_total", reserva.ValorTotal));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_hospede", reserva.Hospede.CodHospede));
            retorno = Convert.ToInt32(objCommand.ExecuteScalar());
            ReservaQuarto_DB.Insert(reserva, objConnection);
            objConnection.Close();
            objCommand.Dispose();
            objConnection.Dispose();
        }
        catch (Exception)
        {
            retorno = -2;
        }
        return retorno;
    }
    
    public static int Realizar_Checkin (Reserva reserva)
    {
        int retorno = 0;
        try
        {
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("update reserva set data_chek_in = @data_chek_in, status_reserva = @status_reserva where cod_reserva = @cod_reserva;", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@status_reserva", reserva.getStatusReserva()));
            objCommand.Parameters.Add(Mapped.Parameter("@data_chek_in", reserva.DataCheckin));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_reserva", reserva.CodReserva));
            objCommand.ExecuteNonQuery();
            NumeroQuarto_DB.UpdateStatusQuarto(reserva.ListaNumeroQuarto, objConnection);
            objConnection.Close();
            objCommand.Dispose();
            objConnection.Dispose();
        }
        catch (Exception)
        {
            retorno = -2;
        }
        return retorno;
    }

    public static int Realizar_Checkout(Reserva reserva)
    {
        int retorno = 0;
        try
        {
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("update reserva set data_chek_out = @data_chek_out, status_reserva = @status_reserva where cod_reserva = @cod_reserva;", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@status_reserva", reserva.getStatusReserva()));
            objCommand.Parameters.Add(Mapped.Parameter("@data_chek_out", reserva.DataCheckout));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_reserva", reserva.CodReserva));
            objCommand.ExecuteNonQuery();
            NumeroQuarto_DB.UpdateStatusQuarto(reserva.ListaNumeroQuarto, objConnection);
            objConnection.Close();
            objCommand.Dispose();
            objConnection.Dispose();
        }
        catch (Exception)
        {
            retorno = -2;
        }
        return retorno;
    }

    public static int UpdateStatusReserva(Reserva reserva)
    {
        int retorno = 0;
        try
        {
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("update reserva set status_reserva = @status_reserva where cod_reserva = @cod_reserva;", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@status_reserva", reserva.getStatusReserva()));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_reserva", reserva.CodReserva));
            objCommand.ExecuteNonQuery();
            objConnection.Close();
            objCommand.Dispose();
            objConnection.Dispose();
        }
        catch (Exception)
        {
            retorno = -2;
        }
        return retorno;
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