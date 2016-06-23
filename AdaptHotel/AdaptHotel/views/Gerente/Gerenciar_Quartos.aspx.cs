using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdaptHotel.views.Gerente
{
    public partial class Gerenciar_Quartos : System.Web.UI.Page
    {
        public List<NumeroQuarto> quartos_disponiveis = new List<NumeroQuarto>();
        public List<NumeroQuarto> quartos_ocupados = new List<NumeroQuarto>();
        public List<NumeroQuarto> quartos_manutencao = new List<NumeroQuarto>();
        public List<NumeroQuarto> quartos_desabilitados = new List<NumeroQuarto>();

        protected void Page_Load(object sender, EventArgs e)
        {
            quartosDisponiveis();
            quartosOcupados();
            quartosManutencao();
            quartosDesabilitados();
        }

        public void quartosDisponiveis()
        {
            DataSet dataset_quartos = NumeroQuarto_DB.SelectQuartosByStatus("disponivel");
            foreach (DataRow row in dataset_quartos.Tables[0].Rows)
            {
                var values = row.ItemArray;

                TipoQuarto tipo_quarto = new TipoQuarto(values[1].ToString());
                SubTipoQuarto subtipo_quarto = new SubTipoQuarto(values[2].ToString(), values[3].ToString(), Convert.ToInt32(values[4]),
                    Convert.ToInt32(values[5]), Convert.ToDecimal(values[6]), tipo_quarto);

                NumeroQuarto numero_quarto = new NumeroQuarto(values[0].ToString(), subtipo_quarto);
                quartos_disponiveis.Add(numero_quarto);
            }
        }

        public void quartosOcupados()
        {
            DataSet dataset_quartos = NumeroQuarto_DB.SelectQuartosByStatus("ocupado");
            foreach (DataRow row in dataset_quartos.Tables[0].Rows)
            {
                var values = row.ItemArray;

                TipoQuarto tipo_quarto = new TipoQuarto(values[1].ToString());
                SubTipoQuarto subtipo_quarto = new SubTipoQuarto(values[2].ToString(), values[3].ToString(), Convert.ToInt32(values[4]),
                    Convert.ToInt32(values[5]), Convert.ToDecimal(values[6]), tipo_quarto);

                NumeroQuarto numero_quarto = new NumeroQuarto(values[0].ToString(), subtipo_quarto);
                quartos_ocupados.Add(numero_quarto);
            }
        }

        public void quartosManutencao()
        {
            DataSet dataset_quartos = NumeroQuarto_DB.SelectQuartosByStatus("manutencao");
            foreach (DataRow row in dataset_quartos.Tables[0].Rows)
            {
                var values = row.ItemArray;

                TipoQuarto tipo_quarto = new TipoQuarto(values[1].ToString());
                SubTipoQuarto subtipo_quarto = new SubTipoQuarto(values[2].ToString(), values[3].ToString(), Convert.ToInt32(values[4]),
                    Convert.ToInt32(values[5]), Convert.ToDecimal(values[6]), tipo_quarto);

                NumeroQuarto numero_quarto = new NumeroQuarto(values[0].ToString(), subtipo_quarto);
                quartos_manutencao.Add(numero_quarto);
            }
        }

        public void quartosDesabilitados()
        {
            DataSet dataset_quartos = NumeroQuarto_DB.SelectQuartosByStatus("desabilitado");
            foreach (DataRow row in dataset_quartos.Tables[0].Rows)
            {
                var values = row.ItemArray;

                TipoQuarto tipo_quarto = new TipoQuarto(values[1].ToString());
                SubTipoQuarto subtipo_quarto = new SubTipoQuarto(values[2].ToString(), values[3].ToString(), Convert.ToInt32(values[4]),
                    Convert.ToInt32(values[5]), Convert.ToDecimal(values[6]), tipo_quarto);

                NumeroQuarto numero_quarto = new NumeroQuarto(values[0].ToString(), subtipo_quarto);
                quartos_desabilitados.Add(numero_quarto);
            }
        }
    }
}