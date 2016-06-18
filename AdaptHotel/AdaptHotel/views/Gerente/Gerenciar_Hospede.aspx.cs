using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace AdaptHotel.views.Gerente
{
    public partial class Gerenciar_Hospede : System.Web.UI.Page
    {
        public List<Hospede> lista_hospedes = new List<Hospede>();

        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarHospedes();
        }

        public void CarregarHospedes()
        {
            DataSet dataset_hospede = Hospede_DB.Select10Ultimos();
            foreach (DataRow row in dataset_hospede.Tables[0].Rows)
            {
                var values = row.ItemArray;

                Endereco endereco = new Endereco();
                endereco.Cidade = values[1].ToString();
                endereco.Estado = values[2].ToString();

                Hospede hospede = new Hospede(values[0].ToString(), endereco);
                lista_hospedes.Add(hospede);
            }
        }
    }
}