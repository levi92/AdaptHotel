using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdaptHotel.views.Recepcionista
{
    public partial class Gerenciar_Reservas : System.Web.UI.Page
    {
        public List<Reserva> reservas_agendadas = new List<Reserva>();
        public List<Reserva> reservas_andamentos = new List<Reserva>();
        public List<Reserva> reservas_finalizadas = new List<Reserva>();
        public List<Reserva> reservas_canceladas = new List<Reserva>();
        public List<Reserva> reservas_noshows = new List<Reserva>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            else
            {
                string acao = Request["__EVENTTARGET"];

                if (acao == "check-in")
                {
                    string parameter = Request["__EVENTARGUMENT"];
                    if (parameter != "")
                    {
                        int retorno = Reserva_DB.Realizar_Checkin(Convert.ToInt32(parameter), "ocupado");
                        if (retorno != -2)
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "tostado('Check-in realizado com sucesso !','agendada');", true);
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "tostado('Erro ao realizar Check-out !','agendada');", true);
                        }
                    }
                }
                else if (acao == "check-out")
                {
                    string parameter = Request["__EVENTARGUMENT"];
                    if (parameter != "")
                    {
                        int retorno = Reserva_DB.Realizar_Checkout(Convert.ToInt32(parameter), "manutencao");

                        if (retorno != -2)
                        {

                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "tostado('Check-out realizado com sucesso !','andamento');", true);

                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "tostado('Erro ao realizar Check-out !','andamento');", true);
                        }
                    }
                }
            }


            reservasAgendada();
            reservasAndamento();
            reservasFinalizada();
            reservasCancelada();
            reservasNoShow();

            UpdatePanelReservas.Update();
        }

        public void reservasAgendada()
        {
            DataSet dataset_reservas = Reserva_DB.SelectReservasByStatus("agendada");
            foreach (DataRow row in dataset_reservas.Tables[0].Rows)
            {
                var values = row.ItemArray;

                Hospede hospede = new Hospede();
                hospede.Nome = values[1].ToString();

                string[] quartos = (values[2].ToString()).Split(';');
                List<NumeroQuarto> lista_numero_quartos = new List<NumeroQuarto>();

                foreach (string quarto in quartos)
                {
                    SubTipoQuarto subtipo_quarto = new SubTipoQuarto();
                    subtipo_quarto.SubTipo = quarto.Split(',')[1];

                    NumeroQuarto numero_quarto = new NumeroQuarto();
                    numero_quarto.Numero_Quarto = quarto.Split(',')[0];
                    numero_quarto.SubTipoQuarto = subtipo_quarto;

                    lista_numero_quartos.Add(numero_quarto);
                }

                Reserva reserva = new Reserva(Convert.ToInt32(values[0]), hospede, lista_numero_quartos);
                reservas_agendadas.Add(reserva);
            }
        }

        public void reservasAndamento()
        {
            DataSet dataset_reservas = Reserva_DB.SelectReservasByStatus("andamento");
            foreach (DataRow row in dataset_reservas.Tables[0].Rows)
            {
                var values = row.ItemArray;

                Hospede hospede = new Hospede();
                hospede.Nome = values[1].ToString();

                string[] quartos = (values[2].ToString()).Split(';');
                List<NumeroQuarto> lista_numero_quartos = new List<NumeroQuarto>();

                foreach (string quarto in quartos)
                {
                    SubTipoQuarto subtipo_quarto = new SubTipoQuarto();
                    subtipo_quarto.SubTipo = quarto.Split(',')[1];

                    NumeroQuarto numero_quarto = new NumeroQuarto();
                    numero_quarto.Numero_Quarto = quarto.Split(',')[0];
                    numero_quarto.SubTipoQuarto = subtipo_quarto;

                    lista_numero_quartos.Add(numero_quarto);
                }

                Reserva reserva = new Reserva(Convert.ToInt32(values[0]), hospede, lista_numero_quartos);
                reservas_andamentos.Add(reserva);
            }
        }

        public void reservasFinalizada()
        {
            DataSet dataset_reservas = Reserva_DB.SelectReservasByStatus("finalizada");
            foreach (DataRow row in dataset_reservas.Tables[0].Rows)
            {
                var values = row.ItemArray;

                Hospede hospede = new Hospede();
                hospede.Nome = values[1].ToString();

                string[] quartos = (values[2].ToString()).Split(';');
                List<NumeroQuarto> lista_numero_quartos = new List<NumeroQuarto>();

                foreach (string quarto in quartos)
                {
                    SubTipoQuarto subtipo_quarto = new SubTipoQuarto();
                    subtipo_quarto.SubTipo = quarto.Split(',')[1];

                    NumeroQuarto numero_quarto = new NumeroQuarto();
                    numero_quarto.Numero_Quarto = quarto.Split(',')[0];
                    numero_quarto.SubTipoQuarto = subtipo_quarto;

                    lista_numero_quartos.Add(numero_quarto);
                }

                Reserva reserva = new Reserva(Convert.ToInt32(values[0]), hospede, lista_numero_quartos);
                reservas_finalizadas.Add(reserva);
            }
        }

        public void reservasCancelada()
        {
            DataSet dataset_reservas = Reserva_DB.SelectReservasByStatus("cancelada");
            foreach (DataRow row in dataset_reservas.Tables[0].Rows)
            {
                var values = row.ItemArray;

                Hospede hospede = new Hospede();
                hospede.Nome = values[1].ToString();

                string[] quartos = (values[2].ToString()).Split(';');
                List<NumeroQuarto> lista_numero_quartos = new List<NumeroQuarto>();

                foreach (string quarto in quartos)
                {
                    SubTipoQuarto subtipo_quarto = new SubTipoQuarto();
                    subtipo_quarto.SubTipo = quarto.Split(',')[1];

                    NumeroQuarto numero_quarto = new NumeroQuarto();
                    numero_quarto.Numero_Quarto = quarto.Split(',')[0];
                    numero_quarto.SubTipoQuarto = subtipo_quarto;

                    lista_numero_quartos.Add(numero_quarto);
                }

                Reserva reserva = new Reserva(Convert.ToInt32(values[0]), hospede, lista_numero_quartos);
                reservas_canceladas.Add(reserva);
            }
        }

        public void reservasNoShow()
        {
            DataSet dataset_reservas = Reserva_DB.SelectReservasByStatus("noshow");
            foreach (DataRow row in dataset_reservas.Tables[0].Rows)
            {
                var values = row.ItemArray;

                Hospede hospede = new Hospede();
                hospede.Nome = values[1].ToString();

                string[] quartos = (values[2].ToString()).Split(';');
                List<NumeroQuarto> lista_numero_quartos = new List<NumeroQuarto>();

                foreach (string quarto in quartos)
                {
                    SubTipoQuarto subtipo_quarto = new SubTipoQuarto();
                    subtipo_quarto.SubTipo = quarto.Split(',')[1];

                    NumeroQuarto numero_quarto = new NumeroQuarto();
                    numero_quarto.Numero_Quarto = quarto.Split(',')[0];
                    numero_quarto.SubTipoQuarto = subtipo_quarto;

                    lista_numero_quartos.Add(numero_quarto);
                }

                Reserva reserva = new Reserva(Convert.ToInt32(values[0]), hospede, lista_numero_quartos);
                reservas_noshows.Add(reserva);
            }
        }

        protected void btnCadastrar_ServerClick(object sender, EventArgs e)
        {

            // Reserva reserva = new Reserva(ddlHospede.Value, Convert.ToDateTime(txtDataEntrada.Value), Convert.ToDateTime(txtDataSaída.Value));

        }
    }
}