﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Gerenciar_Quartos.aspx.cs" Inherits="AdaptHotel.views.Gerente.Gerenciar_Quartos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">




    <div class="col-md-12">
        <div class="col-md-6">
            <input type="text" placeholder="BUSCAR" class="buscar" style="margin-left: 0">
        </div>
        <div class="col-md-3">
            <input type="date" class="form-control buscar" style="margin-left: 0;height: 42px;">
        </div>
        <div class="col-md-3">
            <select class="form-control buscar" style="margin-left: 0;height: 42px;">
                <option>Ordenar</option>
            </select>
        </div>
    </div>


    <div class="col-md-12">
        <div class="col-md-3">
            <div class="sshadow card">
                <img class="card-img-top" src="../../images/quarto-1.jpg" alt="Reserva">
                <div class="card-block">
                    <h4 class="card-title">Deluxe</h4>
                    <h4 class="card-title">Solteiro</h4>
                    <h4 class="card-title">(Hospede)</h4>
                </div>
            </div>
        </div>

        <div class="col-md-3">
            <div class="sshadow card">
                <img class="card-img-top" src="../../images/quarto-2.jpg" alt="Reserva">
                <div class="card-block">
                    <h4 class="card-title">Imperial</h4>
                    <h4 class="card-title">Casal</h4>
                    <h4 class="card-title">(Hospede)</h4>
                </div>
            </div>
        </div>

        <div class="col-md-3">
            <div class="sshadow card">
                <img class="card-img-top" src="../../images/quarto-3.jpg" alt="Reserva">
                <div class="card-block">
                    <h4 class="card-title">Twin Room</h4>
                    <h4 class="card-title">Solteiro</h4>
                    <h4 class="card-title">(Hospede)</h4>
                </div>
            </div>
        </div>
    </div>




</asp:Content>