﻿using System;
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
        public static Funcionario funcionario = new Funcionario();

        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarFuncionario();

            if (IsPostBack)
            {

                string parameter = Request["__EVENTARGUMENT"];

                if (parameter != "")
                {
                    funcionario = CarregarDetalhes(Convert.ToInt32(parameter));

                    txtAlterarNome.Value = funcionario.Nome;
                    txtAlterarDataNasc.Value = funcionario.DataNascimento.ToString();
                    txtAlterarCpf.Value = funcionario.Cpf;
                    txtAlterarTelefone.Value = funcionario.Telefone;
                    txtAlterarEmail.Value = funcionario.Email;
                    txtAlterarEstado.Value = funcionario.Endereco.Estado;

                    txtAlterarCep.Value = funcionario.Endereco.Cep;
                    txtAlterarCidade.Value = funcionario.Endereco.Cidade;
                    txtAlterarRua.Value = funcionario.Endereco.Rua;
                    txtAlterarBairro.Value = funcionario.Endereco.Bairro;
                    txtAlterarNumero.Value = funcionario.Endereco.Numero;

                    txtAlterarCargo.Value = funcionario.Cargo;
                    txtAlterarSalario.Value = funcionario.Salario.ToString();
                    txtdataAdm.Value = funcionario.DataAdmissao.ToString();
                    txtAlterarNumConta.Value = funcionario.NumeroCnt;

                    if (funcionario.Sexo.ToString() == "M")
                    {
                        lblSexo.InnerText = "Masculino";
                    }
                    else
                    {
                        lblSexo.InnerText = "Feminino";
                    }


                    lblNome.InnerText = funcionario.Nome;
                    lblTelefone.InnerText = funcionario.Telefone;
                    lblDataNasc.InnerText = funcionario.DataNascimento.ToString();
                    lblCpf.InnerText = funcionario.Cpf;
                    lblEmail.InnerText = funcionario.Email;

                    lblRua.InnerText = funcionario.Endereco.Rua;
                    lblBairro.InnerText = funcionario.Endereco.Bairro;
                    lblCep.InnerText = funcionario.Endereco.Cep;
                    lblCidade.InnerText = funcionario.Endereco.Cidade;
                    lblEstado.InnerText = funcionario.Endereco.Estado;
                    lblNumero.InnerText = funcionario.Endereco.Numero;

                    lblCargo.InnerHtml = funcionario.Cargo;
                    lblDataAdmissao.InnerHtml = funcionario.DataAdmissao.ToString();
                    lblNConta.InnerHtml = funcionario.NumeroCnt;

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showDiv();", true);
                    UpdatePanelHospedes.Update();
                    UpdatePanelEdit.Update();

                }
            }
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

                Funcionario funcionario = new Funcionario(values[0].ToString(), endereco, Convert.ToInt32(values[3]));
                lista_funcionarios.Add(funcionario);
            }
        }

        public Funcionario CarregarDetalhes(int id)
        {
            Funcionario funcionario = Funcionario_DB.SelectByID(id);

            return funcionario;
        }

        protected void btnCadastrar_ServerClick(object sender, EventArgs e)
        {
            Foto foto = new Foto(null);
            Endereco endereco = new Endereco(txtRua.Value, txtNumero.Value, txtComplemento.Value, txtBairro.Value, txtCep.Value, txtCidade.Value, ddlEstado.Value);
            Perfil perfil = new Perfil(3);

            Funcionario funcionario = new Funcionario(txtNome.Value, txtTelefone.Value, txtEmail.Value, txtCpf.Value, Convert.ToChar(rblSexo.SelectedValue), Convert.ToDateTime(txtData.Value), perfil, endereco, txtCargo.Value, txtNumeroConta.Value, Convert.ToDouble(txtSalário.Value), Convert.ToDateTime(txtDataAdmissao.Value), null, null, foto, null);
            Funcionario_DB.Insert(funcionario);
        }

        protected void btnAlterarDados_ServerClick(object sender, EventArgs e)
        {

        }
    }
}