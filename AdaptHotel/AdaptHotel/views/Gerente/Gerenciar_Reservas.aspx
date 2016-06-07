<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Gerenciar_Reservas.aspx.cs" Inherits="AdaptHotel.views.Gerente.Gerenciar_Reservas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <div class="row">
        <div class="col s6">
            <input type="text" placeholder="BUSCAR">
        </div>
        <div class="col s3">
            <input type="date">
        </div>
        <div class="col s3">
            <input type="text" placeholder="ORDENAR">
        </div>
    </div>

    <div class="col s12">
        <div class="row">
            <div class="col s12" style="width: 100%;">
                <ul class="tabs">

                    <li class="tab col s3"><a href="#test1">Em Andamento</a></li>
                    <li class="tab col s3"><a href="#test4">Finalizada</a></li>
                    <li class="tab col s3"><a class="active" href="#test2">Cancelado</a></li>
                    <li class="tab col s3"><a href="#test4">Agendada</a></li>

                </ul>
            </div>
        </div>
    </div>

    <div class="row">
        <div class="col s12 m6 l3">
            <div class="card">
                <div class="card-image waves-effect waves-block waves-light">
                    <img class="activator" src="../../images/quarto-1.jpg">
                </div>
                <div class="card-content">
                    <span class="card-title activator grey-text text-darken-4">Nicolas Santos<i class="material-icons right">more_vert</i></span>
                </div>
                <div class="card-reveal">
                    <span class="card-title grey-text text-darken-4">Card Title<i class="material-icons right">close</i></span>
                    <p>Here is some more information about this product that is only revealed once clicked on.</p>
                </div>
            </div>
        </div>

        <div class="col s12 m6 l3">
            <div class="card">
                <div class="card-image waves-effect waves-block waves-light">
                    <img class="activator" src="../../images/quarto-2.jpg">
                </div>
                <div class="card-content">
                    <span class="card-title activator grey-text text-darken-4">Levi Monteiro<i class="material-icons right">more_vert</i></span>
                </div>
                <div class="card-reveal">
                    <span class="card-title grey-text text-darken-4">Card Title<i class="material-icons right">close</i></span>
                    <p>Here is some more information about this product that is only revealed once clicked on.</p>
                </div>
            </div>
        </div>
    </div>




</asp:Content>
