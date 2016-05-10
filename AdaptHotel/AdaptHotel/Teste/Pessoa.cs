using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdaptHotel.Teste
{
    public class Pessoa
    {
        private string nome;
        private string cidade;
        private string estado;

        public Pessoa(string nome, string cidade, string estado)
        {
            this.nome = nome;
            this.cidade = cidade;
            this.estado = estado;
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }
    }
}