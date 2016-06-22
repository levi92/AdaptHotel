using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdaptHotel.views
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnEntrar_Click(object sender, EventArgs e)
        {           
            string email = txtEmail1.Value.ToString();
            string senha = txtSenha1.Value.ToString();

            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(senha))
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Os campos devem ser preenchidos </br></br>";
            }
            else
            {
                dynamic usuario = Funcoes_DB.ValidarLogin(email, senha);

                try
                {
                    int msg = Convert.ToInt32(usuario);

                    if (msg == 0)
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = "Email e/ou senha inválido(s) </br></br>";
                    }
                    else
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = "Erro ao realizar login </br></br>";
                    }
                }
                catch (Exception)
                {
                    Session["usuario"] = usuario;

                    if (usuario.Perfil.getTipo() == "administrador")
                    {
                        //Página inicial do administrador
                    }
                    else if (usuario.Perfil.getTipo() == "gerente")
                    {
                        System.Threading.Thread.Sleep(2000);
                        Response.Redirect("~/views/Gerente/Dashboard_Gerente.aspx");
                    }
                    else if (usuario.Perfil.getTipo() == "recepcionista")
                    {
                        System.Threading.Thread.Sleep(2000);
                        Response.Redirect("~/views/Recepcionista/Dashboard_Recepcionista.aspx");
                    }
                    else if (usuario.Perfil.getTipo() == "hospede")
                    {
                        //Página inicial do hospede
                    }
                }
            }         
        }
    }
}