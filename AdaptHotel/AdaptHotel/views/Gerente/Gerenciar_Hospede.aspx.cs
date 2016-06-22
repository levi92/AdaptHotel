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
            if (!IsPostBack)
            {
                CarregarHospedes();
            }           
        }

        public void CarregarHospedes()
        {
            DataSet dataset_hospede = Hospede_DB.SelectAll();
            foreach (DataRow row in dataset_hospede.Tables[0].Rows)
            {
                var values = row.ItemArray;

                Endereco endereco = new Endereco();
                endereco.Cidade = values[1].ToString();
                endereco.Estado = values[2].ToString();

                Hospede hospede = new Hospede(values[0].ToString(), endereco, Convert.ToInt32(values[3]));
                lista_hospedes.Add(hospede);
            }
        }

        public void CarregarDetalhes(int id)
        {
            Hospede hospede = Hospede_DB.SelectByID(id);
        }

        protected void btnCadastrar_ServerClick(object sender, EventArgs e)
        {
            Foto foto = new Foto(null);
            Endereco endereco = new Endereco(txtRua.Value, txtNumero.Value, txtComplemento.Value, txtBairro.Value, txtCep.Value, txtCidade.Value, ddlEstado.Value);
            Perfil perfil = new Perfil(4);
                    

            Hospede hospede = new Hospede(txtNome.Value, txtTelefone.Value, txtEmail.Value, txtCpf.Value, Convert.ToChar(rblSexo.SelectedValue), Convert.ToDateTime(txtData.Value), perfil, endereco, txtPlacaCarro.Value, txtCidadeOrigem.Value, null, foto, null);
            Hospede_DB.Insert(hospede);
        }

        protected void btnEditar_ServerClick(object sender, EventArgs e)
        {

        }
    }
}