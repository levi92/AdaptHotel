<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Dashboard_Recepcionista.aspx.cs" Inherits="AdaptHotel.views.Recepcionista.Dashboard_Recepcionista" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">       
            <div class="col-xs-12 col-sm-12 col-md-6">
                <div class="panel panel-default" style="width: 100%; height: 60vh;">
                    <div class="panel-heading" style="background-color: #2196F3; color: #FFF"><a href="#" style="font-size:2em; color:#FFF;">Hóspedes Recentes</a></div>
                    <div class="panel-body" style="min-height: 84%; max-height: 84%; overflow-y: scroll;">
                        <ul>
                            <% foreach (var hospede in lista_hospedes)
                                { %>
                            <li>
                                <div id="standard_icon" style="width: 5rem; height: 5rem; float: left; background-image: url(../../fonts/ic_person_white_36dp_1x.png); background-repeat: no-repeat; background-position: center; background-color: #FF9100; border-radius: 50%; margin-right: 5%;">
                                </div>
                                <div>
                                    <%= hospede.Nome %> </br>
                                    <%= hospede.End.Cidade %> 
                                    - <%= hospede.End.Estado %>
                                    <hr style="border-color: #FF9100;" />
                                </div>

                            </li>
                            <% } %>
                        </ul>
                    </div>
                </div>
            </div>

            <div class="col-xs-12 col-sm-12 col-md-6">
                <div class="panel panel-default" style="width: 100%; height: 60vh;">
                    <div class="panel-heading" style="background-color: #2196F3; color: #FFF"><a href="#" style="font-size:2em; color:#FFF;">Últimas reservas</a></div>
                    <div class="panel-body" style="min-height: 84%; max-height: 84%; overflow-y: scroll;">
                        <ul>
                            <% foreach (var reserva in lista_reservas)
                                { %>
                            <li>
                                <i class="material-icons md-48" style="float:left; color:#FF9100; margin-right:3%;">event_available</i>
                                <div style="padding-top:1%;">
                                    <%= reserva.Hospede.Nome %> </br>
                                    <%= reserva.getDataReservaEntrada() %> 
                                    - <%= reserva.getDataReservaSaida() %>
                                    <hr style="border-color: #FF9100;" />
                                </div>

                            </li>
                            <% } %>
                        </ul>
                    </div>
                </div>
            </div>

            <div class="col-xs-12 ">
                <div class="panel panel-default" style="width: 100%; height: auto;">
                    <div class="panel-heading" style="background-color: #2196F3; color: #FFF"><a href="#" style="font-size: 2em; color: #FFF;">Quartos</a></div>
                    <div class="panel-body" style="min-height: 60%; max-height: 60%; overflow-y: scroll;">
                        <div class="row">
                            <% foreach (var numeroQuarto in lista_numeroQuartos)
                                { %>
                            <div class="col-xs-3 col-sm-2 col-md-1" style="">
                                <div id="" style="border-radius: 5px; border: 2px solid #2196F3; background-color: <%= numeroQuarto.Cor%>; width: 90%; height: 10vh; display: table; text-align: center;">
                                    <a href="#" style="display: table-cell; vertical-align: middle; color: #FFFFFF"><%= numeroQuarto.NumeroQuartoo%></a>
                                </div>
                            </div>
                            <% } %>
                        </div>

                    </div>
                    <div class="panel-footer" style="background-color:#FFFFFF;">
                        <div class="row">
                            <div class="col-xs-6 col-sm-3">
                                <div class="row">
                                    <div class="col-xs-2">
                                        <div style="border-radius: 5px; border: 1px solid #2196F3; background-color:#4CAF50; width:24px; height:24px;"></div>
                                    </div>
                                    <div class="col-xs-10" style="padding-top:5%;">
                                        <span>Disponível</span>
                                    </div>
                                </div>                                
                            </div>
                            <div class="col-xs-6 col-sm-3">
                                <div class="row">
                                    <div class="col-xs-2">
                                        <div style="border-radius: 5px; border: 1px solid #2196F3; background-color:#F44336; width:24px; height:24px;"></div>
                                    </div>
                                    <div class="col-xs-10" style="padding-top:5%;">
                                        <span>Ocupado</span>
                                    </div>
                                </div>   
                            </div>
                            <div class="col-xs-6 col-sm-3">
                                <div class="row">
                                    <div class="col-xs-2">
                                        <div style="border-radius: 5px; border: 1px solid #2196F3; background-color:#FFC107; width:24px; height:24px;"></div>
                                    </div>
                                    <div class="col-xs-10" style="padding-top:5%;">
                                        <span>Manutenção</span>
                                    </div>
                                </div>   
                            </div>
                            <div class="col-xs-6 col-sm-3">
                                <div class="row">
                                    <div class="col-xs-2">
                                        <div style="border-radius: 5px; border: 1px solid #2196F3; background-color:#9E9E9E; width:24px; height:24px;"></div>
                                    </div>
                                    <div class="col-xs-10" style="padding-top:5%;">
                                        <span>Desabilitado</span>
                                    </div>
                                </div>   
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
