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
            SqlCommand objCommand = Mapped.Command("Insert into avaliacoes (comentario, resposta, nota, data_hora_comentario, data_hora_resposta, codReserva) values (@comentario, @resposta, @nota, @data_hora_comentario, @data_hora_resposta, @codReserva);", objConnection);
            objCommand.Parameters.Add(Mapped.Parameter("@comentario", avaliacoes.Comentario));
            objCommand.Parameters.Add(Mapped.Parameter("@resposta", avaliacoes.Resposta));
            objCommand.Parameters.Add(Mapped.Parameter("@nota", avaliacoes.Nota));
            objCommand.Parameters.Add(Mapped.Parameter("@data_hora_comentario", avaliacoes.DataHoraComentario));
            objCommand.Parameters.Add(Mapped.Parameter("@data_hora_resposta", avaliacoes.DataHoraResposta));
            retorno = Convert.ToInt32(objCommand.ExecuteScalar());
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