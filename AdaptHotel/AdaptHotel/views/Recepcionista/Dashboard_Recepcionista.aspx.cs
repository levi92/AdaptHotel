using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdaptHotel.Teste;

namespace AdaptHotel.views.Recepcionista
{
    public partial class Dashboard_Recepcionista : System.Web.UI.Page
    {
        public List<Pessoa> lista_pessoas = new List<Pessoa>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Pessoa p1 = new Pessoa("nicolas", "Guaratingueta", "SP");
            Pessoa p2 = new Pessoa("levi", "Guaratingueta", "SP");
            Pessoa p3 = new Pessoa("daniel", "Lorena", "SP");
            Pessoa p4 = new Pessoa("marry", "Aparecida", "SP");
            Pessoa p5 = new Pessoa("thais", "Aparecida", "SP");
            Pessoa p6 = new Pessoa("Gabi", "Pinda", "SP");
            Pessoa p7 = new Pessoa("Janaina", "Guaratingueta", "SP");
            Pessoa p8 = new Pessoa("Janaina", "Guaratingueta", "SP");
            Pessoa p9 = new Pessoa("Janaina", "Guaratingueta", "SP");
            Pessoa p10 = new Pessoa("Janaina", "Guaratingueta", "SP");
            Pessoa p11 = new Pessoa("Gabi", "Pinda", "SP");
            Pessoa p12 = new Pessoa("Janaina", "Guaratingueta", "SP");
            Pessoa p13 = new Pessoa("Janaina", "Guaratingueta", "SP");
            Pessoa p14 = new Pessoa("Janaina", "Guaratingueta", "SP");
            Pessoa p15 = new Pessoa("Janaina", "Guaratingueta", "SP");

            lista_pessoas.Add(p1);
            lista_pessoas.Add(p2);
            lista_pessoas.Add(p3);
            lista_pessoas.Add(p4);
            lista_pessoas.Add(p5);
            lista_pessoas.Add(p6);
            lista_pessoas.Add(p7);
            lista_pessoas.Add(p8);
            lista_pessoas.Add(p9);
            lista_pessoas.Add(p10);
            lista_pessoas.Add(p11);
            lista_pessoas.Add(p12);
            lista_pessoas.Add(p13);
            lista_pessoas.Add(p14);
            lista_pessoas.Add(p15);
        }
    }
}