using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdaptHotel.App_Code
{


    public class avaliacoes
    {
        private string comentario;
        private string resposta;
        private int nota;
        private string dt_hora_comentario;
        private string dt_hora_resposta;

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

        public string Dt_hora_comentario
        {
            get
            {
                return dt_hora_comentario;
            }

            set
            {
                dt_hora_comentario = value;
            }
        }

        public string Dt_hora_resposta
        {
            get
            {
                return dt_hora_resposta;
            }

            set
            {
                dt_hora_resposta = value;
            }
        }
    }
}