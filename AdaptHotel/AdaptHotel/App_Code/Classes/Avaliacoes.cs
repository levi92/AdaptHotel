using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Avaliacoes
/// </summary>
public class Avaliacoes
{
    private string comentario, resposta;
    private int codAvaliacoes, nota;
    private DateTime dataHoraResposta, dataHoraComentario;
    private Hospede hos;
    private SubTipoQuarto subQ;
    private Reserva reserva;

    public Avaliacoes(string comentario, string resposta, int codAvaliacoes, int nota, DateTime dataHoraResposta, DateTime dataHoraComentario, Hospede hos, SubTipoQuarto subQ, Reserva reserva)
    {
        this.comentario = comentario;
        this.resposta = resposta;
        this.codAvaliacoes = codAvaliacoes;
        this.nota = nota;
        this.dataHoraResposta = dataHoraResposta;
        this.dataHoraComentario = dataHoraComentario;
        this.hos = hos;
        this.subQ = subQ;
        this.reserva = reserva;
    }

    public SubTipoQuarto SubQ
    {
        get { return subQ; }
        set { subQ = value; }
    }

        public string Comentario
    {
        get { return comentario; }

        set { comentario = value; }
    }

    public string Resposta
    {
        get { return resposta; }
        set { resposta = value; }
    }

    public int CodAvaliacoes
    {
        get { return codAvaliacoes; }
        set { codAvaliacoes = value; }
    }

    public int Nota
    {
        get { return nota; }
        set { nota = value; }
    }

    public DateTime DataHoraResposta
    {
        get { return dataHoraResposta; }
        set { dataHoraResposta = value; }
    }

    public DateTime DataHoraComentario
    {
        get { return dataHoraComentario; }
        set { dataHoraComentario = value; }
    }

    public Hospede Hos
    {
        get { return hos; }
        set { hos = value; }
    }

    public Reserva Reserva
    {
        get { return reserva; }
        set { reserva = value; }
    }
}
