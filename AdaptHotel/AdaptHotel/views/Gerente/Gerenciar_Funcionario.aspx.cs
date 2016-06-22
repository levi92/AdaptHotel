using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace AdaptHotel.views.Gerente
{
    public partial class Gerenciar_Funcionario : System.Web.UI.Page
    {
        public List<Funcionario> lista_funcionarios = new List<Funcionario>();

        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarFuncionario();
        }

        public void CarregarFuncionario()
        {
            DataSet dataset_funcionario = Funcionario_DB.SelectAll();
            foreach (DataRow row in dataset_funcionario.Tables[0].Rows)
            {
                var values = row.ItemArray;

                Endereco endereco = new Endereco();
                endereco.Cidade = values[1].ToString();
                endereco.Estado = values[2].ToString();

                Funcionario funcionario = new Funcionario(values[0].ToString(), endereco);
                lista_funcionarios.Add(funcionario);
            }
        }

        protected void btnCadastrar_ServerClick(object sender, EventArgs e)
        {
            Foto foto = new Foto(null);
            Endereco endereco = new Endereco(txtRua.Value, txtNumero.Value, txtComplemento.Value, txtBairro.Value, txtCep.Value, txtCidade.Value, ddlEstado.Value);
            Perfil perfil = new Perfil(3);

            Funcionario funcionario = new Funcionario(txtNome.Value, txtTelefone.Value, txtEmail.Value, txtCpf.Value, Convert.ToChar(rblSexo.SelectedValue), Convert.ToDateTime(txtData.Value), perfil, endereco, txtCargo.Value, txtNumeroConta.Value, Convert.ToDouble(txtSalário.Value), Convert.ToDateTime(txtDataAdmissao.Value), foto, null, null);
            Funcionario_DB.Insert(funcionario);
        }

        protected void btnAlterarDados_ServerClick(object sender, EventArgs e)
        {

        }
    }
}