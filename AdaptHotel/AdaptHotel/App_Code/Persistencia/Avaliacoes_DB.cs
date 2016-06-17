using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for avaliacoes_DB
/// </summary>
public class avaliacoes_DB
{
    public static void Insert()
    {
        SqlConnection objConnection;
        SqlCommand objCommand;
        SqlDataAdapter objDataAdapter;
        objConnection = Mapped.Connection();
        objCommand = Mapped.Command("Insert into avaliacoes (comentario, resposta, nota, dataHoraComentario, dataHoraResposta, codReserva) values @comentario, @resposta, @nota, @dataHoraComentario, @dataHoraResposta, @codReserva", objConnection);
        objDataAdapter = Mapped.Adapter(objCommand);
        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();

    }
}