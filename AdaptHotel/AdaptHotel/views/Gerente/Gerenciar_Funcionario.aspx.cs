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
    }
}