using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace AdaptHotel.views.Gerente
{
    public partial class Dashboard_Gerente : System.Web.UI.Page
    {
        public List<Perfil> lista_perfil = new List<Perfil>();

        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarDashboard();
        }

        public void CarregarDashboard()
        {
            DataSet dataset_perfil = Perfil.SelectAll();

            foreach (DataRow row in dataset_perfil.Tables[0].Rows)
            {
                var values = row.ItemArray;
                Perfil perfil = new Perfil(Convert.ToInt32(values[0]), values[1].ToString());
                lista_perfil.Add(perfil);
            }
        }
    }
}