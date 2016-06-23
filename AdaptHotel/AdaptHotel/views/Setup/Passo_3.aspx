<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Passo_3.aspx.cs" Inherits="AdaptHotel.views.Setup.Passo_3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="col s12" style="margin-top: 37px;">
            <nav>
                <div class="nav-wrapper">
                    <div class="col s12">
                        <a href="#!" class="breadcrumb">Bem-Vindo</a>
                        <a href="#!" class="breadcrumb">Instalação</a>
                        <a href="#!" class="breadcrumb" style="font-weight: bold; color: white">Configuração</a>
                        <a href="#!" class="breadcrumb">Administradores</a>
                        <a href="#!" class="breadcrumb">Quartos</a>
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
                    <h3 class="card-title">Configuração</h3>
                </div>
                <div class="card-content">
                    <p>Estas são as configurações principais do sistema, preencha-as com cuidado.</p>

                    <div class="input-field">
                        <label>Nome do Hotel</label>
                        <input id="txtCidade" runat="server" type="text" />
                    </div>

                    <div class="input-field">
                        <label>Endereço do Hotel</label>
                        <input id="txtBairro" runat="server" type="text" />
                    </div>

                    <div class="file-field input-field">
                        <div class="btn">
                            <span>Logo</span>
                            <input type="file">
                        </div>
                        <div class="file-path-wrapper">
                            <input class="file-path validate" type="text">
                        </div>
                    </div>

                <div class="input-field">
                    <label>Cor Principal</label>
                    <input id="txtNumero" runat="server" type="color" />
                </div>

                <div class="input-field">
                    <label>Cor Secundária</label>
                    <input id="Text1" runat="server" type="color" />
                </div>

            </div>
            <div class="card-action">
                <a href="Passo_4.aspx">Cadastrar Administradores</a>
            </div>
        </div>
    </div>
    </div>

</asp:Content>
