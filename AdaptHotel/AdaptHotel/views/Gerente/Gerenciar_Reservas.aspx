<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Gerente.Master" CodeBehind="Gerenciar_Reservas.aspx.cs" Inherits="AdaptHotel.views.Gerente.Gerenciar_Reservas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row blue darken-4 z-depth-1">
        <div class="container">
            <div class="col s6">
                <input type="text" style="color: white; border-color: white;" placeholder="BUSCAR">
            </div>
            <div class="col s3">
                <input type="date" style="color: white; border-color: white;">
            </div>
            <div class="input-field col s3" style="margin-top: 0; color: white;">
                <select style="border-color: white">
                    <option value="" disabled selected>ORDENAR</option>
                    <option value="1">Nome</option>
                    <option value="2">ID</option>
                    <option value="3">Data</option>
                </select>

            </div>


            <div class="col s12">
                <div class="row">
                    <div class="col s12" style="width: 100%;">
                        <ul class="tabs">
                            <li class="tab"><a class="active" href="#agendada">Agendada</a></li>
                            <li class="tab"><a href="#andamento">Em Andamento</a></li>
                            <li class="tab"><a href="#finalizada">Finalizada</a></li>
                            <li class="tab"><a href="#cancelada">Cancelado</a></li>
                            <li class="tab"><a href="#noshow">No Show</a></li>

                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="row">
        <div id="agendada" class="container">
            <% foreach (var reserva_agendada in reservas_agendadas)
                { %>
            <div class="col s12 m6 l3">
                <div class="card">
                    <div class="card-image waves-effect waves-block waves-light">
                        <img class="activator" src="../../images/quarto-1.jpg">
                    </div>
                    <div class="card-content">
                        <span class="card-title activator grey-text text-darken-4"><%= reserva_agendada.Hospede.Nome%><i class="material-icons right">more_vert</i></span>
                    </div>

                    <div class="card-action" style="text-align: center;">
                        <a id="check-in" onclick="__doPostBack('check-in', '<%= reserva_agendada.CodReserva%>')"><i class="material-icons">done</i></a>
                    </div>

                    <div class="card-reveal">
                        <span class="card-title grey-text text-darken-4">Informações<i class="material-icons right">close</i></span>
                        <p>Reserva : <%= reserva_agendada.CodReserva%></p>
                        <p>Hóspede : <%= reserva_agendada.Hospede.Nome%></p>
                        <p>
                            Quartos  : <% var index = 0;
                                           foreach (var quarto in reserva_agendada.ListaNumeroQuarto)
                                           {
                                               index++; %>
                                <%= quarto.Numero_Quarto%> - <%= quarto.SubTipoQuarto.SubTipo%>
                                <%if (index < reserva_agendada.ListaNumeroQuarto.Count)
                                    { %>, 
                                     <% } %>
                            <% } %>
                        </p>
                    </div>
                </div>
            </div>
            <% } %>
        </div>

        <div id="andamento" class="container" style="display: none">
            <% foreach (var reserva_andamento in reservas_andamentos)
                { %>
            <div class="col s12 m6 l3">
                <div class="card">
                    <div class="card-image waves-effect waves-block waves-light">
                        <img class="activator" src="../../images/quarto-1.jpg">
                    </div>
                    <div class="card-content">
                        <span class="card-title activator grey-text text-darken-4"><%= reserva_andamento.Hospede.Nome%><i class="material-icons right">more_vert</i></span>
                    </div>

                    <div class="card-action" style="text-align: center;">
                        <a id="check-out" onclick="__doPostBack('check-out', '<%= reserva_andamento.CodReserva%>')"><i class="material-icons">done</i></a>
                    </div>

                    <div class="card-reveal">
                        <span class="card-title grey-text text-darken-4">Informações<i class="material-icons right">close</i></span>
                        <p>Reserva : <%= reserva_andamento.CodReserva%></p>
                        <p>Hóspede : <%= reserva_andamento.Hospede.Nome%></p>
                        <p>
                            Quartos  : <% var index = 0;
                                           foreach (var quarto in reserva_andamento.ListaNumeroQuarto)
                                           {
                                               index++; %>
                                <%= quarto.Numero_Quarto%> - <%= quarto.SubTipoQuarto.SubTipo%>
                                <%if (index < reserva_andamento.ListaNumeroQuarto.Count)
                                    { %>, 
                                     <% } %>
                            <% } %>
                        </p>
                    </div>
                </div>
            </div>
            <% } %>
        </div>

        <div id="finalizada" class="container" style="display: none">
            <% foreach (var reserva_finalizada in reservas_finalizadas)
                { %>
            <div class="col s12 m6 l3">
                <div class="card">
                    <div class="card-image waves-effect waves-block waves-light">
                        <img class="activator" src="../../images/quarto-1.jpg">
                    </div>
                    <div class="card-content">
                        <span class="card-title activator grey-text text-darken-4"><%= reserva_finalizada.Hospede.Nome%><i class="material-icons right">more_vert</i></span>
                    </div>

                    <div class="card-action" style="text-align: center;">
                        <a onclick="Materialize.toast('Check-in realizado com sucesso !', 3000)"><i class="material-icons">done</i></a>
                    </div>

                    <div class="card-reveal">
                        <span class="card-title grey-text text-darken-4">Informações<i class="material-icons right">close</i></span>
                        <p>Reserva : <%= reserva_finalizada.CodReserva%></p>
                        <p>Hóspede : <%= reserva_finalizada.Hospede.Nome%></p>
                        <p>
                            Quartos  : <% var index = 0;
                                           foreach (var quarto in reserva_finalizada.ListaNumeroQuarto)
                                           {
                                               index++; %>
                                <%= quarto.Numero_Quarto%> - <%= quarto.SubTipoQuarto.SubTipo%>
                                <%if (index < reserva_finalizada.ListaNumeroQuarto.Count)
                                    { %>, 
                                     <% } %>
                            <% } %>
                        </p>
                    </div>
                </div>
            </div>
            <% } %>
        </div>

        <div id="cancelada" class="container" style="display: none">
            <% foreach (var reserva_cancelada in reservas_canceladas)
                { %>
            <div class="col s12 m6 l3">
                <div class="card">
                    <div class="card-image waves-effect waves-block waves-light">
                        <img class="activator" src="../../images/quarto-1.jpg">
                    </div>
                    <div class="card-content">
                        <span class="card-title activator grey-text text-darken-4"><%= reserva_cancelada.Hospede.Nome%><i class="material-icons right">more_vert</i></span>
                    </div>

                    <div class="card-action" style="text-align: center;">
                        <a onclick="Materialize.toast('Check-in realizado com sucesso !', 3000)"><i class="material-icons">done</i></a>
                    </div>

                    <div class="card-reveal">
                        <span class="card-title grey-text text-darken-4">Informações<i class="material-icons right">close</i></span>
                        <p>Reserva : <%= reserva_cancelada.CodReserva%></p>
                        <p>Hóspede : <%= reserva_cancelada.Hospede.Nome%></p>
                        <p>
                            Quartos  : <% var index = 0;
                                           foreach (var quarto in reserva_cancelada.ListaNumeroQuarto)
                                           {
                                               index++; %>
                                <%= quarto.Numero_Quarto%> - <%= quarto.SubTipoQuarto.SubTipo%>
                                <%if (index < reserva_cancelada.ListaNumeroQuarto.Count)
                                    { %>, 
                                     <% } %>
                            <% } %>
                        </p>
                    </div>
                </div>
            </div>
            <% } %>
        </div>

        <div id="noshow" class="container" style="display: none">
            <% foreach (var reserva_noshow in reservas_noshows)
                { %>
            <div class="col s12 m6 l3">
                <div class="card">
                    <div class="card-image waves-effect waves-block waves-light">
                        <img class="activator" src="../../images/quarto-1.jpg">
                    </div>
                    <div class="card-content">
                        <span class="card-title activator grey-text text-darken-4"><%= reserva_noshow.Hospede.Nome%><i class="material-icons right">more_vert</i></span>
                    </div>

                    <div class="card-action" style="text-align: center;">
                        <a onclick="Materialize.toast('Check-in realizado com sucesso !', 4000)"><i class="material-icons">done</i></a>
                    </div>

                    <div class="card-reveal">
                        <span class="card-title grey-text text-darken-4">Informações<i class="material-icons right">close</i></span>
                        <p>Reserva : <%= reserva_noshow.CodReserva%></p>
                        <p>Hóspede : <%= reserva_noshow.Hospede.Nome%></p>
                        <p>
                            Quartos  : <% var index = 0;
                                           foreach (var quarto in reserva_noshow.ListaNumeroQuarto)
                                           {
                                               index++; %>
                                <%= quarto.Numero_Quarto%> - <%= quarto.SubTipoQuarto.SubTipo%>
                                <%if (index < reserva_noshow.ListaNumeroQuarto.Count)
                                    { %>, 
                                     <% } %>
                            <% } %>
                        </p>
                    </div>
                </div>
            </div>
            <% } %>
        </div>
    </div>

    <div class="fixed-action-btn horizontal click-to-toggle" style="bottom: 30px; right: 24px;">
        <a class="btn-floating btn-large red">
            <i class="material-icons">menu</i>
        </a>
        <ul>
            <li><a class="btn-floating green modal-trigger" href="#add"><i class="material-icons">add</i></a></li>
            <li><a class="btn-floating blue  modal-trigger" href="#edit"><i class="material-icons">mode_edit</i></a></li>
        </ul>
    </div>

    <!-- Modal -->
    <div id="add" class="modal modal-fixed-footer">
        <div class="modal-content">
            <h4>Nova reserva</h4>


            <div class="col s12 m6">
                <label>Data de Entrada</label>
                <input id="txtDataEntrada" runat="server" type="date" class="datepicker validate" />
            </div>

            <div class="col s12 m6">
                <label>Data de Saída</label>
                <input id="txtDataSaída" runat="server" type="date" class="datepicker validate" />
            </div>

            <div class="input-field col s12 m6">
                <select id="ddlHospede" runat="server">
                    <option value="" disabled selected>Selecione o Hospede</option>
                    <option value=""></option>
                </select>
            </div>

            <div class="input-field col s12 m6">
                <select id="ddlQuarto" runat="server">
                    <option value="" disabled selected>Selecione o quarto</option>
                    <option value=""></option>
                </select>
            </div>

            <select class="input-field col s12 m6" name="selecionarQuarto" runat="server" multiple>
                <option value="" disabled selected>Selecione o quarto</option>
                <option value="quarto1">Quarto 1</option>
                <option value="quarto2">Quarto 2</option>
                <option value="quarto3">Quarto 3</option>
            </select>


        </div>
        <div class="modal-footer">
            <button id="btnCadastrar" class="modal-action modal-close waves-effect waves-green btn-flat" runat="server" onserverclick="btnCadastrar_ServerClick">Efetuar Reserva</button>
        </div>
    </div>


    <script>

        

        $(document).ready(function () {
            $('.datepicker').pickadate({
                selectMonths: true, // Creates a dropdown to control month
                selectYears: 15 // Creates a dropdown of 15 years to control year
            });

            $('select').material_select();
            $('ul.tabs').tabs();
        });

        $(document).ready(function () {
            $('.modal-trigger').leanModal();
        });

    </script>


</asp:Content>
