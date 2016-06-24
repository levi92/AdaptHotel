using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Globalization;

namespace AdaptHotel.views.Gerente
{
    public partial class Gerenciar_Hospede : System.Web.UI.Page
    {
        public List<Hospede> lista_hospedes = new List<Hospede>();
        public Hospede hospede = new Hospede();


        protected void Page_Load(object sender, EventArgs e)
        {           
            if (!IsPostBack)
            {              
                int codigo_detalhes = Convert.ToInt32(Request.QueryString["id"]);

                if(codigo_detalhes != 0)
                {
                    CarregarDetalhes(codigo_detalhes);
                    Session["cod_pessoa"] = hospede.CodPessoa;
                    Session["cod_endereco"] = hospede.Endereco.CodEnd;
                    Session["cod_hospede"] = hospede.CodHospede;

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showDiv(" + codigo_detalhes + ");", true);
                } 
            }
            else
            {                
                string parameter = Request["__EVENTARGUMENT"];

                if (parameter != "logout" && parameter != "")
                {                
                    CarregarDetalhes(Convert.ToInt32(parameter));
                    Session["cod_pessoa"] = hospede.CodPessoa;
                    Session["cod_endereco"] = hospede.Endereco.CodEnd;
                    Session["cod_hospede"] = hospede.CodHospede;

                    UpdatePanelHospedes.Update();
                    UpdatePanelEdit.Update();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showDiv(" + hospede.CodHospede + ");", true);
                }
            }

            lista_hospedes.Clear();
            CarregarHospedes();
            UpdatePanelHospedes.Update();
            UpdatePanelEdit.Update();
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
            hospede = Hospede_DB.SelectByID(id);

            if (hospede.Sexo.ToString() == "M")
            {
                lblSexo.InnerText = "Masculino";
            }
            else
            {
                lblSexo.InnerText = "Feminino";
            }

            lblNome.InnerText = hospede.Nome;
            lblTelefone.InnerText = hospede.Telefone;
            lblDataNasc.InnerText = (hospede.DataNascimento).ToString("dd/MM/yyyy");
            lblCpf.InnerText = hospede.Cpf;
            lblEmail.InnerText = hospede.Email;

            lblRua.InnerText = hospede.Endereco.Rua;
            lblBairro.InnerText = hospede.Endereco.Bairro;
            lblCep.InnerText = hospede.Endereco.Cep;
            lblCidade.InnerText = hospede.Endereco.Cidade;
            lblEstado.InnerText = hospede.Endereco.Estado;
            lblNumero.InnerText = hospede.Endereco.Numero;

            lblPlaca.InnerText = hospede.PlacaCarro;
            lblCidadeOrigem.InnerText = hospede.CidadeOrigem;

            txtAlterarNome.Value = hospede.Nome;
            txtAlterarDataNasc.Value = (hospede.DataNascimento).ToString("yyyy-MM-dd");
            txtAlterarCpf.Value = hospede.Cpf;
            txtAlterarTelefone.Value = hospede.Telefone;
            txtAlterarEmail.Value = hospede.Email;
            txtAlterarEstado.Value = hospede.Endereco.Estado;
            rblAlterarSexo.SelectedValue = hospede.Sexo.ToString();

            txtAlterarCep.Value = hospede.Endereco.Cep;
            txtAlterarCidade.Value = hospede.Endereco.Cidade;
            txtAlterarRua.Value = hospede.Endereco.Rua;
            txtAlterarBairro.Value = hospede.Endereco.Bairro;
            txtAlterarNumero.Value = hospede.Endereco.Numero;

            txtAlterarPlaca.Value = hospede.PlacaCarro;
            txtAlterarCidadeOrigem.Value = hospede.CidadeOrigem;
        }

        protected void btnCadastrar_ServerClick(object sender, EventArgs e)
        {
            Foto foto = new Foto(null);
            Endereco endereco = new Endereco(txtRua.Value, txtNumero.Value, txtComplemento.Value, txtBairro.Value, txtCep.Value, txtCidade.Value, ddlEstado.Value);
            Perfil perfil = new Perfil(4);

            Hospede hospede = new Hospede(txtNome.Value, txtTelefone.Value, txtEmail.Value, txtCpf.Value, Convert.ToChar(rblSexo.SelectedValue), Convert.ToDateTime(txtData.Value), perfil, endereco, txtPlacaCarro.Value, txtCidadeOrigem.Value, null, foto, null);
            Hospede_DB.Insert(hospede);

            lista_hospedes.Clear();

            CarregarHospedes();

            UpdatePanelHospedes.Update();
            UpdatePanelEdit.Update();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "tostado( 'Cadastrado com Sucesso !', " + Session["cod_hospede"] + ");", true);
        }

        protected void btnEditar_ServerClick(object sender, EventArgs e)
        {
            Foto foto = new Foto(null);
            Endereco endereco = new Endereco(txtAlterarRua.Value, txtAlterarNumero.Value, txtAlterarComplemento.Value, txtAlterarBairro.Value, txtAlterarCep.Value, txtAlterarCidade.Value, txtAlterarEstado.Value, Convert.ToInt32(Session["cod_endereco"]));
            Perfil perfil = new Perfil(4);

            Hospede Alterarhospede = new Hospede(txtAlterarNome.Value, txtAlterarTelefone.Value, txtAlterarEmail.Value, txtAlterarCpf.Value, Convert.ToChar(rblAlterarSexo.SelectedValue), Convert.ToDateTime(txtAlterarDataNasc.Value), perfil, endereco, txtAlterarPlaca.Value, txtAlterarCidadeOrigem.Value, Convert.ToInt32(Session["cod_pessoa"]), foto, null, Convert.ToInt32(Session["cod_hospede"]));
            Hospede_DB.Update(Alterarhospede);

            CarregarDetalhes(Convert.ToInt32(Session["cod_hospede"]));

            UpdatePanelHospedes.Update();
            UpdatePanelEdit.Update();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "tostado( 'Alterado com Sucesso !', " + Session["cod_hospede"] + ");", true);
        }
    }
}