<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Passo_5.aspx.cs" Inherits="AdaptHotel.views.Setup.Passo_5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="col s12" style="margin-top: 37px;">
            <nav>
                <div class="nav-wrapper">
                    <div class="col s12">
                        <a href="#!" class="breadcrumb">Bem-Vindo</a>
                        <a href="#!" class="breadcrumb">Configuração</a>
                        <a href="#!" class="breadcrumb">Quartos</a>
                        <a href="#!" class="breadcrumb">Funcionarios</a>
                        <a href="#!" class="breadcrumb" style="font-weight: bold; color: white">Finalizar</a>
                    </div>
                </div>

            </nav>
        </div>

        <div class="col s12">
            <div class="card hoverable">
                <div class="card-image">
                    <img src="../../images/user-profile-bg.jpg" />
                    <h3 class="card-title">Finalizar</h3>
                </div>
                <div class="card-content">
                    <p>Parabéns, você finalizou a configuração.</p>
                </div>
                <div class="card-action">
                    <a href="Passo_4.aspx">Voltar</a> <a href="../Login.aspx">Acessar Sistema</a>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
