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

    public Avaliacoes(string comentario, string resposta, int codAvaliacoes, int nota, DateTime dataHoraResposta, DateTime dataHoraComentario, Hospede hos, SubTipoQuarto subQ)
    {
        this.Comentario = comentario;
        this.Resposta = resposta;
        this.CodAvaliacoes = codAvaliacoes;
        this.Nota = nota;
        this.DataHoraResposta = dataHoraResposta;
        this.DataHoraComentario = dataHoraComentario;
        this.Hos = hos;
        this.subQ = subQ;
    }

    public SubTipoQuarto SubQ
    {
        get { return subQ; }
        set { subQ = value; }
    }

        public string Comentario
    {
        get
        {
            return comentario;
        }

        set
        {
            comentario = value;
        }
    }

    public string Resposta
    {
        get
        {
            return resposta;
        }

        set
        {
            resposta = value;
        }
    }

    public int CodAvaliacoes
    {
        get
        {
            return codAvaliacoes;
        }

        set
        {
            codAvaliacoes = value;
        }
    }

    public int Nota
    {
        get
        {
            return nota;
        }

        set
        {
            nota = value;
        }
    }

    public DateTime DataHoraResposta
    {
        get
        {
            return dataHoraResposta;
        }

        set
        {
            dataHoraResposta = value;
        }
    }

    public DateTime DataHoraComentario
    {
        get
        {
            return dataHoraComentario;
        }

        set
        {
            dataHoraComentario = value;
        }
    }

    public Hospede Hos
    {
        get
        {
            return hos;
        }

        set
        {
            hos = value;
        }
    }

}
