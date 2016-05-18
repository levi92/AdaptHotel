<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Dashboard_Recepcionista.aspx.cs" Inherits="AdaptHotel.views.Recepcionista.Dashboard_Recepcionista" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">

            
            <div class="col-xs-12 col-sm-12 col-md-6">
                <div class="panel panel-default" style="width: 100%; height: 60vh;">
                    <div class="panel-heading" style="background-color: #2196F3; color: #FFF"><a href="#" style="font-size:2em; color:#FFF;">Últimas reservas</a></div>
                    <div class="panel-body" style="min-height: 84%; max-height: 84%; overflow-y: scroll;">
                        <ul>
                            <% foreach (var item in lista_pessoas)
                                { %>
                            <li>Nome: <%= item.Nome %> </br>
                                    Cidade: <%= item.Cidade %> 
                                    / Estado: <%= item.Estado %>
                                <hr style="border-color: #FF9100;" />
                            </li>
                            <% } %>
                        </ul>
                    </div>
                </div>
            </div>

            <div class="col-xs-12 col-sm-12 col-md-6">
                <div class="panel panel-default" style="width: 100%; height: 60vh;">
                    <div class="panel-heading" style="background-color: #2196F3; color: #FFF"><a href="#" style="font-size:2em; color:#FFF;">Hóspedes Recentes</a></div>
                    <div class="panel-body" style="min-height: 84%; max-height: 84%; overflow-y: scroll;">
                        <ul>
                            <% foreach (var item in lista_pessoas)
                                { %>
                            <li><div id="standard_icon" style="width:5rem; height:5rem; float:left; background-image:url(../../fonts/ic_person_white_36dp_1x.png); background-repeat:no-repeat; background-position:center; background-color:#FF9100; border-radius: 50%; margin-right:5%;">
                                    
                                </div>
                                <div><%= item.Nome %> </br>
                                    <%= item.Cidade %> 
                                    / <%= item.Estado %>
                                <hr style="border-color: #FF9100;" /></div>
                                
                            </li>
                            <% } %>
                        </ul>
                    </div>
                </div>
            </div>

            <div class="col-xs-12 ">
                <div class="panel panel-default" style="width: 100%; height: 60vh;">
                    <div class="panel-heading" style="background-color: #2196F3; color: #FFF"><a href="#" style="font-size:2em; color:#FFF;">Quartos</a></div>
                    <div class="panel-body" style="min-height: 84%; max-height: 84%; overflow-y: scroll;">
                        <div class="row">
                            <% int i = 0;
                                foreach (var item in lista_pessoas)
                                {
                                    i++;%>
                            <div class="col-xs-3 col-sm-2 col-md-1" style="">
                                <div style="background-color: antiquewhite; width: 90%; height: 10vh; display: table; text-align: center;">
                                    <a href="#" style="display:table-cell; vertical-align: middle; color: #000;"><%=i%></a>
                                </div>
                            </div>
                            <% } %>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
