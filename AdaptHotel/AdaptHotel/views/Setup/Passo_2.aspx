<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Passo_2.aspx.cs" Inherits="AdaptHotel.views.Setup.Passo_2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="col s12" style="margin-top: 37px;">
            <nav>
                <div class="nav-wrapper">
                    <div class="col s12">
                        <a href="#!" class="breadcrumb">Bem-Vindo</a>
                        <a href="#!" class="breadcrumb" style="font-weight: bold; color: white">Instalação</a>
                        <a href="#!" class="breadcrumb">Configuração</a>
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
                    <h3 class="card-title">Instalação</h3>
                </div>
                <div class="card-content">
                    <p>Abaixo você deverá preencher o dados de conexão. Se não possui conhecimento para isso, contacte seu host.</p>                    
            
                    <div class="input-field">
                        <label>Nome do Banco</label>
                        <input id="txtCidade" runat="server" type="text" />
                    </div>

                    <div class="input-field">
                        <label>Nome do Usuário</label>
                        <input id="txtBairro" runat="server" type="text" />
                    </div>

                    <div class="input-field">
                        <label>Senha</label>
                        <input id="txtRua" runat="server" type="text" />
                    </div>

                    <div class="input-field">
                        <label>Host</label>
                        <input id="txtNumero" runat="server" type="text" />
                    </div>

                    <div class="input-field">
                        <label>Prefixo da Tabela</label>
                        <input id="Text1" runat="server" type="text" />
                    </div>

                </div>
                <div class="card-action">
                    <a href="Passo_3.aspx">Configurar</a>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
