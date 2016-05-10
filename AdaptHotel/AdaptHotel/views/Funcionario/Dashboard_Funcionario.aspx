<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard_Funcionario.aspx.cs" Inherits="AdaptHotel.views.Funcionario.Dashboard_Funcionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:BundleReference runat="server" Path="~/Content/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 col-sm-6">
                    <div class="panel panel-default" style="width: 100%; height: 60vh;">
                        <div class="panel-heading" style="text-align: center; background-color: #2196F3; color: #FFF">Útimas Reservas</div>
                        <div class="panel-body" style="min-height: 90%; max-height: 90%; overflow-y: scroll;">
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
                <div class="col-xs-12 col-sm-6">
                    <div class="panel panel-default" style="width: 100%; height: 60vh;">
                        <div class="panel-heading" style="text-align: center; background-color: #2196F3; color: #FFF">Hóspedes</div>
                        <div class="panel-body" style="min-height: 90%; max-height: 90%; overflow-y: scroll;">
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
                <div class="col-xs-12 ">
                    <div class="panel panel-default" style="width: 100%; height: 60vh;">
                        <div class="panel-heading" style="text-align: center; background-color: #2196F3; color: #FFF">Quartos</div>
                        <div class="panel-body" style="min-height: 90%; max-height: 90%; overflow-y: scroll;">
                            <div class="row">
                                <% int i = 0;
                                    foreach (var item in lista_pessoas)
                                    {
                                        i++;%>
                                <div class="col-xs-3 col-sm-2 col-md-1" style="">
                                    <div style="background-color: antiquewhite; width: 90%; height: 10vh; display: table; text-align: center;">
                                        <a href="#" style="display: table-cell; vertical-align: middle; color:#000;"><%=i%></a>
                                    </div>
                                </div>
                                <% } %>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
