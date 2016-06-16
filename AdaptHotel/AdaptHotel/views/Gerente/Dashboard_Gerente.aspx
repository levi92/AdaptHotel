﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Dashboard_Gerente.aspx.cs" Inherits="AdaptHotel.views.Gerente.Dashboard_Gerente" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col s12 ">
                <div class="card" style="width: 100%; height: 20vh;">
                    <div class="col s12 light-blue lighten-1">
                        <div class="card-title" style="width: 100%;"><a class="white-text" style="font-size: 36px;" href="#">Estatísticas</a></div>
                    </div>
                    <div class="card-content" style="">
                        <div class="row">
                        </div>
                    </div>
                </div>
            </div>
            <div class="col s12 col m12 col l4">
                <div class="card" style="width: 100%; height: 60vh;">
                    <div class="col s12 light-blue lighten-1">
                        <div class="card-title" style="width: 100%;"><a class="white-text" style="font-size: 36px;" href="#">Funcionários</a></div>
                    </div>
                    <div class="card-content" style="max-height: 87%; overflow-y: scroll;">
                        <ul id="teste">
                            <% foreach (var funcionario in lista_funcionarios)
                                { %>
                            <li class="col s12">
                                <img src="../../images/quarto-1.jpg" alt="" class="col s3 circle" style="width:25%; height: 50px;">
                                <div class="col s9">
                                    <%= funcionario.Nome %> </br>
                                        <%= funcionario.End.Cidade %> 
                                        - <%= funcionario.End.Estado %>
                                </div>
                                <hr class="col s12" style="border-color: #FF9100;" />
                            </li>
                            <% } %>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="col s12 col m12 col l4">
                <div class="card" style="width: 100%; height: 60vh;">
                    <div class="col s12 light-blue lighten-1">
                        <div class="card-title" style="width: 100%;"><a class="white-text" style="font-size: 36px;" href="#">Hóspedes</a></div>
                    </div>
                    <div class="card-content" style="max-height: 87%; overflow-y: scroll;">
                        <ul>
                            <% foreach (var hospede in lista_hospedes)
                                { %>
                            <li class="col s12">
                                <img src="../../images/quarto-1.jpg" alt="" class="col s3 circle" style="width:25%; height: 50px;">
                                <div class="col s9">
                                    <%= hospede.Nome %> </br>
                                    <%= hospede.End.Cidade %> 
                                    - <%= hospede.End.Estado %>
                                </div>
                                <hr class="col s12" style="border-color: #FF9100;" />
                            </li>
                            <% } %>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="col s12 col m12 col l4">
                <div class="card" style="width: 100%; height: 60vh;">
                    <div class="col s12 light-blue lighten-1">
                        <div class="card-title" style="width: 100%;"><a class="white-text" style="font-size: 36px;" href="#">Reservas</a></div>
                    </div>
                    <div class="card-content" style="max-height: 87%; overflow-y: scroll;">
                        <ul>
                            <% foreach (var reserva in lista_reservas)
                                { %>
                            <li class="col s12 valign-wrapper">
                                <i class="material-icons md-48" style="float: left; color: #FF9100; margin-right: 3%;">event_available</i>
                                <div>
                                    <%= reserva.Hospede.Nome %> </br>
                                    <%= reserva.getDataReservaEntrada() %> 
                                    - <%= reserva.getDataReservaSaida() %>
                                </div>

                            </li>
                            <hr class="col s12" style="border-color: #FF9100;" />
                            <% } %>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="col s12 ">
                <div class="card" style="width: 100%; height: 75vh;">
                    <div class="col s12 light-blue lighten-1">
                        <div class="card-title" style="width: 100%;"><a class="white-text" style="font-size: 36px;" href="#">Quartos</a></div>
                    </div>
                    <div class="card-content" style="min-height: 75%; max-height: 75%; overflow-y: scroll;">
                        <% foreach (var numeroQuarto in lista_numeroQuartos)
                            { %>
                        <div class="col s3 col m2 col l1" style="padding-bottom: 2%;">
                            <div id="" style="border-radius: 5px; border: 2px solid #2196F3; background-color: <%= numeroQuarto.Cor%>; width: 90%; height: 10vh; display: table; text-align: center;">
                                <a href="#" style="display: table-cell; vertical-align: middle; color: #FFFFFF"><%= numeroQuarto.NumeroQuartoo%></a>
                            </div>
                        </div>
                        <% } %>
                        <% foreach (var numeroQuarto in lista_numeroQuartos)
                            { %>
                        <div class="col s3 col m2 col l1" style="padding-bottom: 2%;">
                            <div id="" style="border-radius: 5px; border: 2px solid #2196F3; background-color: <%= numeroQuarto.Cor%>; width: 90%; height: 10vh; display: table; text-align: center;">
                                <a href="#" style="display: table-cell; vertical-align: middle; color: #FFFFFF"><%= Convert.ToInt32(numeroQuarto.NumeroQuartoo) + 32%></a>
                            </div>
                        </div>
                        <% } %>
                    </div>
                    <div class="card-action">
                        <div class="col s3">
                            <div class="col s2" style="border-radius: 5px; border: 1px solid #2196F3; background-color: #4CAF50; width: 24px; height: 24px;"></div>
                            <span class="col s10">Disponível</span>
                        </div>
                        <div class="col s3">
                            <div class="col s2" style="border-radius: 5px; border: 1px solid #2196F3; background-color: #F44336; width: 24px; height: 24px;"></div>
                            <span class="col s10">Ocupado</span>
                        </div>
                        <div class="col s3">
                            <div class="col s2" style="border-radius: 5px; border: 1px solid #2196F3; background-color: #FFC107; width: 24px; height: 24px;"></div>
                            <span class="col s10">Manutenção</span>
                        </div>
                        <div class="col s3">
                            <div class="col s2" style="border-radius: 5px; border: 1px solid #2196F3; background-color: #9E9E9E; width: 24px; height: 24px;"></div>
                            <span class="col s10">Desabilitado</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
