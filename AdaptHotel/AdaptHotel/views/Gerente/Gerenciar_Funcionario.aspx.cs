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
        public Funcionario funcionario = new Funcionario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int codigo_detalhes = Convert.ToInt32(Request.QueryString["id"]);

                if (codigo_detalhes != 0)
                {
                    CarregarDetalhes(codigo_detalhes);
                    Session["cod_pessoa"] = funcionario.CodPessoa;
                    Session["cod_endereco"] = funcionario.Endereco.CodEnd;
                    Session["cod_funcionario"] = funcionario.CodFuncionario;

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showDiv(" + codigo_detalhes + ");", true);
                }
            }
            else
            {
                string parameter = Request["__EVENTARGUMENT"];

                if (parameter != "logout" && parameter != "")
                {
                    CarregarDetalhes(Convert.ToInt32(parameter));

                    Session["cod_pessoa"] = funcionario.CodPessoa;
                    Session["cod_endereco"] = funcionario.Endereco.CodEnd;
                    Session["cod_funcionario"] = funcionario.CodFuncionario;

                    UpdatePanelFuncionarios.Update();
                    UpdatePanelEdit.Update();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "showDiv(" + funcionario.CodFuncionario + ");", true);
                }
            }

            lista_funcionarios.Clear();
            CarregarFuncionarios();
            UpdatePanelFuncionarios.Update();
            UpdatePanelEdit.Update();
        }

        public void CarregarFuncionarios()
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

        public void CarregarDetalhes(int id)
        {
            funcionario = Funcionario_DB.SelectByID(id);

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
            lblDataNasc.InnerText = (funcionario.DataNascimento).ToString("dd/MM/yyyy");
            lblCpf.InnerText = funcionario.Cpf;
            lblEmail.InnerText = funcionario.Email;

            lblRua.InnerText = funcionario.Endereco.Rua;
            lblBairro.InnerText = funcionario.Endereco.Bairro;
            lblCep.InnerText = funcionario.Endereco.Cep;
            lblCidade.InnerText = funcionario.Endereco.Cidade;
            lblEstado.InnerText = funcionario.Endereco.Estado;
            lblNumero.InnerText = funcionario.Endereco.Numero;

            lblCargo.InnerText = funcionario.Cargo;
            lblSalario.InnerText = funcionario.Salario.ToString();
            lblDataAdmissao.InnerText = (funcionario.DataAdmissao).ToString("dd/MM/yyyy");
            lblNConta.InnerText = funcionario.NumeroCnt;

            txtAlterarNome.Value = funcionario.Nome;
            txtAlterarDataNasc.Value = funcionario.DataNascimento.ToString("yyyy-MM-dd");
            txtAlterarCpf.Value = funcionario.Cpf;
            txtAlterarTelefone.Value = funcionario.Telefone;
            txtAlterarEmail.Value = funcionario.Email;
            txtAlterarEstado.Value = funcionario.Endereco.Estado;
            rblAlterarSexo.SelectedValue = funcionario.Sexo.ToString();


            txtAlterarCep.Value = funcionario.Endereco.Cep;
            txtAlterarCidade.Value = funcionario.Endereco.Cidade;
            txtAlterarRua.Value = funcionario.Endereco.Rua;
            txtAlterarBairro.Value = funcionario.Endereco.Bairro;
            txtAlterarNumero.Value = funcionario.Endereco.Numero;

            txtAlterarCargo.Value = funcionario.Cargo;
            txtAlterarSalario.Value = funcionario.Salario.ToString();
            txtdataAdm.Value = (funcionario.DataAdmissao).ToString("yyyy-MM-dd");
            txtAlterarNumConta.Value = funcionario.NumeroCnt;
        }

        protected void btnCadastrar_ServerClick(object sender, EventArgs e)
        {
            Foto foto = new Foto(null);
            Endereco endereco = new Endereco(txtRua.Value, txtNumero.Value, txtComplemento.Value, txtBairro.Value, txtCep.Value, txtCidade.Value, ddlEstado.Value);
            Perfil perfil = new Perfil(3);

            Funcionario funcionario = new Funcionario(txtNome.Value, txtTelefone.Value, txtEmail.Value, txtCpf.Value, Convert.ToChar(rblSexo.SelectedValue), Convert.ToDateTime(txtData.Value), perfil, endereco, txtCargo.Value, txtNumeroConta.Value, Convert.ToDouble(txtSalário.Value), Convert.ToDateTime(txtDataAdmissao.Value), null, null, foto, null);
            Funcionario_DB.Insert(funcionario);

            UpdatePanelFuncionarios.Update();
            UpdatePanelEdit.Update();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "tostado( 'Cadastrado com Sucesso !', " + Session["cod_funcionario"] + ");", true);
        }

        protected void btnEditar_ServerClick(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco(txtAlterarRua.Value, txtAlterarNumero.Value, txtComplemento.Value, txtAlterarBairro.Value, txtAlterarCep.Value, txtAlterarCidade.Value, txtAlterarEstado.Value, Convert.ToInt32(Session["cod_endereco"]));
            Perfil perfil = new Perfil(3);

            Funcionario AlterarFuncionario = new Funcionario(txtAlterarNome.Value, txtAlterarTelefone.Value, txtAlterarEmail.Value, txtAlterarCep.Value, Convert.ToChar(rblAlterarSexo.SelectedValue), Convert.ToDateTime(txtAlterarDataNasc.Value), perfil, endereco, txtAlterarCargo.Value, txtAlterarNumConta.Value, Convert.ToDouble(txtAlterarSalario.Value), Convert.ToDateTime(txtdataAdm.Value), Convert.ToInt32(Session["cod_funcionario"]), Convert.ToInt32(Session["cod_pessoa"]), null, null);
            Funcionario_DB.Update(AlterarFuncionario);

            CarregarDetalhes(Convert.ToInt32(Session["cod_funcionario"]));

            UpdatePanelFuncionarios.Update();
            UpdatePanelEdit.Update();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "tostado( 'Alterado com Sucesso !', "+ Session["cod_funcionario"] + ");", true);
        }
    }
}