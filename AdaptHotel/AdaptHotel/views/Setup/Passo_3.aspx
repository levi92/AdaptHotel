<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Passo_3.aspx.cs" Inherits="AdaptHotel.views.Setup.Passo_3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="col s12" style="margin-top: 37px;">
            <nav>
                <div class="nav-wrapper">
                    <div class="col s12">
                        <a href="#!" class="breadcrumb">Bem-Vindo</a>
                        <a href="#!" class="breadcrumb">Configuração</a>
                        <a href="#!" class="breadcrumb" style="font-weight: bold; color: white">Quartos</a>
                        <a href="#!" class="breadcrumb">Funcionarios</a>
                        <a href="#!" class="breadcrumb">Finalizar</a>
                    </div>
                </div>

            </nav>
        </div>

        <div class="col s12">
            <div class="card hoverable">
                <div class="card-image">
                    <img src="../../images/user-profile-bg.jpg" />
                    <h3 class="card-title">Quartos</h3>
                </div>
                <div class="card-content">
                    <p>Cadastro da quantidade de quartos e o subtipo.</p>

                    <div class="input-field">
                        <label>Nome</label>
                        <input id="txtCidade" runat="server" type="text" />
                    </div>

                    <div class="input-field">
                        <label class="active">Tipo</label>
                        <select>
                            <option value="" disabled selected>Cadastre um tipo</option>
                        </select>
                    </div>

                    <div class="input-field">
                        <label>Valor</label>
                        <input id="Text1" runat="server" type="text" />
                    </div>

                    <div class="input-field">
                        <label>Quantidade</label>
                        <input id="Text2" runat="server" type="text" />
                    </div>

                    <div class="input-field">
                        <a href="../Login.aspx" style="margin: 0 auto; float: none;" class="btn orange waves-effect waves-light"><i class="material-icons right">add</i>Adicionar Outro</a>
                        <a href="../Login.aspx" style="margin: 0 auto; float: none;" class="btn orange waves-effect waves-light"><i class="material-icons right">add</i>Cadastrar Tipo</a>
                    </div>
                </div>
                <div class="card-action">
                    <a href="Passo_2.aspx">Voltar</a> <a href="Passo_4.aspx">Cadastrar Funcionários</a>
                </div>
            </div>
        </div>
    </div>

    <script>
        $(document).ready(function () {
            $('select').material_select();
        });

    </script>

</asp:Content>
