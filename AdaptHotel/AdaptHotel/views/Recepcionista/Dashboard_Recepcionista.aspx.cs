using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace AdaptHotel.views.Recepcionista
{
    public partial class Dashboard_Recepcionista : System.Web.UI.Page
    {
        public List<Hospede> lista_hospedes = new List<Hospede>();
        public List<Reserva> lista_reservas = new List<Reserva>();
        public List<NumeroQuarto> lista_numeroQuartos = new List<NumeroQuarto>();

        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarDashboard();
        }

        public void CarregarDashboard()
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

            DataSet dataset_reserva = Reserva_DB.Select10Ultimos();
            foreach (DataRow row in dataset_reserva.Tables[0].Rows)
            {
                var values = row.ItemArray;

                Hospede hospede = new Hospede();
                hospede.Nome = values[0].ToString();

                Reserva reserva = new Reserva(hospede, Convert.ToDateTime(values[1]), Convert.ToDateTime(values[2]));
                lista_reservas.Add(reserva);
            }

            DataSet dataset_numeroQuarto = NumeroQuarto_DB.SelectAll();
            foreach (DataRow row in dataset_numeroQuarto.Tables[0].Rows)
            {
                string cor = "";
                var values = row.ItemArray;

                TipoQuarto tipoQuarto = new TipoQuarto(values[0].ToString());

                SubTipoQuarto subtipoQuarto = new SubTipoQuarto(values[1].ToString(), values[2].ToString(),
                    Convert.ToInt32(values[3]), Convert.ToInt32(values[4].ToString()), Convert.ToDecimal(values[5]), tipoQuarto);

                if (values[8].ToString() == "disponivel")
                {
                    cor = "#4CAF50";
                }
                else if (values[8].ToString() == "ocupado")
                {
                    cor = "#F44336";
                }
                else if (values[8].ToString() == "manutencao")
                {
                    cor = "#FFC107";
                }
                else if (values[8].ToString() == "desabilitado")
                {
                    cor = "#9E9E9E";
                }

                NumeroQuarto numeroQuarto = new NumeroQuarto(Convert.ToInt32(values[6]), values[7].ToString(),
                    values[8].ToString(), subtipoQuarto, cor);

                lista_numeroQuartos.Add(numeroQuarto);
            }
        }
    }
}