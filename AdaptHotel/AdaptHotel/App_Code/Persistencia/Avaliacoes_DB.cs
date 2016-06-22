using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

public class Avaliacoes_DB
{
    public static int Insert(Avaliacoes avaliacoes)
    {
        int retorno = 0;
        try
        {
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("Insert into avaliacoes (comentario, resposta, nota, data_hora_comentario, data_hora_resposta, cod_reserva) values (@comentario, @resposta, @nota, @data_hora_comentario, @data_hora_resposta, @cod_reserva);", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@comentario", avaliacoes.Comentario));
            objCommand.Parameters.Add(Mapped.Parameter("@resposta", avaliacoes.Resposta));
            objCommand.Parameters.Add(Mapped.Parameter("@nota", avaliacoes.Nota));
            objCommand.Parameters.Add(Mapped.Parameter("@data_hora_comentario", avaliacoes.DataHoraComentario));
            objCommand.Parameters.Add(Mapped.Parameter("@data_hora_resposta", avaliacoes.DataHoraResposta));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_reserva", avaliacoes.Reserva.CodReserva));
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

    public static int Update (Avaliacoes avaliacoes)
    {
        int retorno = 0;

        try
        {
            SqlConnection objConnection = Mapped.Connection();
            SqlCommand objCommand = Mapped.Command("update avaliacoes set comentario = @comentario, resposta = @resposta, nota = @nota, data_hora_comentario = @data_hora_comentario, data_hora_resposta = @data_hora_resposta where cod_avaliacao = @cod_avaliacao;", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@comentario", avaliacoes.Comentario));
            objCommand.Parameters.Add(Mapped.Parameter("@resposta", avaliacoes.Resposta));
            objCommand.Parameters.Add(Mapped.Parameter("@nota", avaliacoes.Nota));
            objCommand.Parameters.Add(Mapped.Parameter("@data_hora_comentario", avaliacoes.DataHoraComentario));
            objCommand.Parameters.Add(Mapped.Parameter("@data_hora_resposta", avaliacoes.DataHoraResposta));
            objCommand.Parameters.Add(Mapped.Parameter("@cod_avaliacoes", avaliacoes.CodAvaliacoes));
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