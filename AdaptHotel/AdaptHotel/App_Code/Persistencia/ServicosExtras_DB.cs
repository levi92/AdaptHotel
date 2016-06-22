using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


public class ServicosExtras_DB
{
    public static int Insert(ServicosExtras servicos_extras)
    {
        int retorno = 0;

        try
        {
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("insert into servicos_extras (descricao, valor, data_pedido, cod_reserva) values (@descricao, @valor, @data_pedido, @cod_reserva);", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@descricao", servicos_extras.Descricao));
            objCommand.Parameters.Add(Mapped.Parameter("@valor", servicos_extras.Valor));
            objCommand.Parameters.Add(Mapped.Parameter("@data_pedido", servicos_extras.DataPedido));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_reserva", servicos_extras.Reserva.CodReserva));
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

    public static int Update(ServicosExtras servicos_extras)
    {
        int retorno = 0;

        try
        {
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("update servicos_extras set descricao = @descricao, valor = @valor, data_pedido = @data_pedido, cod_reserva = @cod_reserva where cod_servico = @cod_servico;", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@descricao", servicos_extras.Descricao));
            objCommand.Parameters.Add(Mapped.Parameter("@valor", servicos_extras.Valor));
            objCommand.Parameters.Add(Mapped.Parameter("@data_pedido", servicos_extras.DataPedido));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_reserva", servicos_extras.Reserva.CodReserva));
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
}