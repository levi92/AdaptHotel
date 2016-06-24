﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Passo_3.aspx.cs" Inherits="AdaptHotel.views.Setup.Passo_3" %>

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
                    <p>Olá, você adquiriu o sistema AdaptHotel.</p>
                    <p>Nos próximos passos você será guiado para uma configuração inicial do sistema.</p>
                    <p>Preencha todos os campos com atenção.</p>
                </div>
                <div class="card-action">
                    <a href="Passo_2.aspx">Voltar</a> <a href="Passo_4.aspx">Cadastrar Funcionários</a>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
