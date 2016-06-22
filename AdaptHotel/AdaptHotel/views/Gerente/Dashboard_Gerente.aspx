<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Gerente.Master" CodeBehind="Dashboard_Gerente.aspx.cs" Inherits="AdaptHotel.views.Gerente.Dashboard_Gerente" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
          
            <div class="col s12 col m12 col l4">
                <div class="card hoverable" style="width: 100%; height: 60vh;">
                    <div class="col s12 blue darken-4">
                        <div class="card-title" style="width: 100%;"><a class="white-text" style="font-size: 36px;" href="#">Funcionários</a></div>
                    </div>
                    <div class="card-content" style="padding:1px; max-height: 87%; overflow-y: scroll;">
                        <ul class="collection" style="margin-top: -1px;">
                            <% foreach (var funcionario in lista_funcionarios)
                                { %>
                            <a class="collection-item avatar waves-effect waves" onclick="teste('<%= funcionario.Nome %>')">
                                <div style="padding-top:5%;">
                                    <img src="../../images/quarto-1.jpg" alt="" class="circle">
                                    <span class="title"> <%= funcionario.Nome %> </span>
                                    <p>   <%= funcionario.Endereco.Cidade %> 
                                        - <%= funcionario.Endereco.Estado %>
                                    </p>
                                </div>
                            </a>
                            <% } %>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="col s12 col m12 col l4">
                <div class="card hoverable" style="width: 100%; height: 60vh;">
                    <div class="col s12 blue darken-4">
                        <div class="card-title" style="width: 100%;"><a class="white-text" style="font-size: 36px;" href="#">Hóspedes</a></div>
                    </div>
                    <div class="card-content" style="padding:1px; max-height: 87%; overflow-y: scroll;">
                        <ul class="collection" style="margin-top: -1px;">
                            <% foreach (var hospede in lista_hospedes)
                                { %>
                            <a class="collection-item avatar waves-effect waves" href="../Gerente/Gerenciar_Hospede.aspx?id=<%= hospede.Nome%>">
                                <div style="padding-top:5%;">
                                    <img src="../../images/quarto-1.jpg" alt="" class="circle">
                                    <span class="title"><%= hospede.Nome %></span>
                                    <p>
                                        <%= hospede.Endereco.Cidade %> 
                                        - <%= hospede.Endereco.Estado %>
                                    </p>
                                </div>
                            </a>
                            <% } %>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="col s12 col m12 col l4">
                <div class="card hoverable" style="width: 100%; height: 60vh;">
                    <div class="col s12 blue darken-4">
                        <div class="card-title" style="width: 100%;"><a class="white-text" style="font-size: 36px;" href="#">Reservas</a></div>
                    </div>
                    <div class="card-content" style="padding:1px; max-height: 87%; overflow-y: scroll;">
                        <ul class="collection" style="margin-top: -1px;">
                            <% foreach (var reserva in lista_reservas)
                                { %>
                            <a class="collection-item avatar waves-effect waves" onclick="teste('<%= reserva.Hospede.Nome%>')">
                                <div style="padding-top:5%;">
                                    <img src="../../images/quarto-1.jpg" alt="" class="circle">
                                    <span class="title"> <%= reserva.Hospede.Nome %> </span>
                                    <p>   <%= reserva.getDataReservaEntrada() %> 
                                        - <%= reserva.getDataReservaSaida() %>
                                    </p>
                                </div>
                            </a>
                            <% } %>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="col s12 ">
                <div class="card hoverable" style="width: 100%; height: 75vh;">
                    <div class="col s12 blue darken-4">
                        <div class="card-title" style="width: 100%;"><a class="white-text" style="font-size: 36px;" href="#">Quartos</a></div>
                    </div>
                    <div class="card-content" style="min-height: 75%; max-height: 75%; overflow-y: scroll;">
                        <% foreach (var numeroQuarto in lista_numeroQuartos)
                            { %>
                        <div class="col s3 col m2 col l1" style="padding-bottom: 2%;">
                            <div class="hoverable" style="border-radius: 5px; border: 0px solid #2196F3; background-color: <%= numeroQuarto.Cor%>; width: 90%; height: 9vh; display: table; text-align: center;">
                                <a href="#" style="display: table-cell; vertical-align: middle; color: #FFFFFF"><%= numeroQuarto.Numero_Quarto%></a>
                            </div>
                        </div>
                        <% } %>
                        <% foreach (var numeroQuarto in lista_numeroQuartos)
                            { %>
                        <div class="col s3 col m2 col l1" style="padding-bottom: 2%;">
                            <div class="hoverable" style="border-radius: 5px; border: 0px solid #2196F3; background-color: <%= numeroQuarto.Cor%>; width: 90%; height: 9vh; display: table; text-align: center;">
                                <a href="#" style="display: table-cell; vertical-align: middle; color: #FFFFFF"><%= Convert.ToInt32(numeroQuarto.Numero_Quarto) + 32%></a>
                            </div>
                        </div>
                        <% } %>
                    </div>
                    <div class="card-action">
                        <div class="col s3">
                            <div class="col s2" style="border-radius: 5px; border: 0px solid #2196F3; background-color: #4CAF50; width: 24px; height: 24px;"></div>
                            <span class="col s10">Disponível</span>
                        </div>
                        <div class="col s3">
                            <div class="col s2" style="border-radius: 5px; border: 0px solid #2196F3; background-color: #F44336; width: 24px; height: 24px;"></div>
                            <span class="col s10">Ocupado</span>
                        </div>
                        <div class="col s3">
                            <div class="col s2" style="border-radius: 5px; border: 0px solid #2196F3; background-color: #FFC107; width: 24px; height: 24px;"></div>
                            <span class="col s10">Manutenção</span>
                        </div>
                        <div class="col s3">
                            <div class="col s2" style="border-radius: 5px; border: 0px solid #2196F3; background-color: #9E9E9E; width: 24px; height: 24px;"></div>
                            <span class="col s10">Desabilitado</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
