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

                            <li class="tab"><a class="active" href="#andamento">Em Andamento</a></li>
                            <li class="tab"><a href="#finalizada">Finalizada</a></li>
                            <li class="tab"><a href="#cancelado">Cancelado</a></li>
                            <li class="tab"><a href="#agendada">Agendada</a></li>
                            <li class="tab"><a href="#noshow">No Show</a></li>

                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="row">

        <div id="andamento" class="container">
            <div class="col s12 m6 l3">
                <div class="card">
                    <div class="card-image waves-effect waves-block waves-light">
                        <img class="activator" src="../../images/quarto-1.jpg">
                    </div>
                    <div class="card-content">
                        <span class="card-title activator grey-text text-darken-4">Nicolas Santos<i class="material-icons right">more_vert</i></span>
                    </div>

                    <div class="card-action" style="text-align: center;">
                        <a onclick="Materialize.toast('Check-out realizado com sucesso !', 4000)"><i class="material-icons">input</i></a>
                    </div>

                    <div class="card-reveal">
                        <span class="card-title grey-text text-darken-4">Informações<i class="material-icons right">close</i></span>
                        <p>Reserva : 052235</p>
                        <p>Cliente : Nicolas Santos</p>
                        <p>Quarto  : Deluxe Imperial Plus</p>
                        <p>Status  : Em Andamento</p>
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

                    <div class="card-action" style="text-align: center;">
                        <a onclick="Materialize.toast('Check-out realizado com sucesso !', 4000)"><i class="material-icons">input</i></a>
                    </div>

                    <div class="card-reveal">
                        <span class="card-title grey-text text-darken-4">Informações<i class="material-icons right">close</i></span>
                        <p>Reserva : 068224</p>
                        <p>Cliente : Levi Monteiro</p>
                        <p>Quarto  : Quarto Simples</p>
                        <p>Status  : Em Andamento</p>
                    </div>
                </div>
            </div>
        </div>

        <div id="finalizada" class="container" style="display: none">
            <div class="col s12 m6 l3">
                <div class="card">
                    <div class="card-image waves-effect waves-block waves-light">
                        <img class="activator" src="../../images/quarto-2.jpg">
                    </div>
                    <div class="card-content">
                        <span class="card-title activator grey-text text-darken-4">Gabrielle de Paula<i class="material-icons right">more_vert</i></span>
                    </div>
                    <div class="card-reveal">
                        <span class="card-title grey-text text-darken-4">Informações<i class="material-icons right">close</i></span>
                        <p>Reserva : 052235</p>
                        <p>Cliente : Nicolas Santos</p>
                        <p>Quarto  : Deluxe Imperial Plus</p>
                        <p>Status  : Em Andamento</p>
                    </div>
                </div>
            </div>

            <div class="col s12 m6 l3">
                <div class="card">
                    <div class="card-image waves-effect waves-block waves-light">
                        <img class="activator" src="../../images/quarto-1.jpg">
                    </div>
                    <div class="card-content">
                        <span class="card-title activator grey-text text-darken-4">Thais Rodrigues<i class="material-icons right">more_vert</i></span>
                    </div>
                    <div class="card-reveal">
                        <span class="card-title grey-text text-darken-4">Informações<i class="material-icons right">close</i></span>
                        <p>Reserva : 068224</p>
                        <p>Cliente : Levi Monteiro</p>
                        <p>Quarto  : Quarto Simples</p>
                        <p>Status  : Em Andamento</p>
                    </div>
                </div>
            </div>
        </div>

        <div id="agendada" class="container"  style="display: none">
            <div class="col s12 m6 l3">
                <div class="card">
                    <div class="card-image waves-effect waves-block waves-light">
                        <img class="activator" src="../../images/quarto-1.jpg">
                    </div>
                    <div class="card-content">
                        <span class="card-title activator grey-text text-darken-4">Pablo Mauricio<i class="material-icons right">more_vert</i></span>
                    </div>

                    <div class="card-action" style="text-align: center;">
                        <a onclick="Materialize.toast('Check-in realizado com sucesso !', 4000)"><i class="material-icons">done</i></a>
                    </div>

                    <div class="card-reveal">
                        <span class="card-title grey-text text-darken-4">Informações<i class="material-icons right">close</i></span>
                        <p>Reserva : 052235</p>
                        <p>Cliente : Nicolas Santos</p>
                        <p>Quarto  : Deluxe Imperial Plus</p>
                        <p>Status  : Em Andamento</p>
                    </div>
                </div>
            </div>

            <div class="col s12 m6 l3">
                <div class="card">
                    <div class="card-image waves-effect waves-block waves-light">
                        <img class="activator" src="../../images/quarto-2.jpg">
                    </div>
                    <div class="card-content">
                        <span class="card-title activator grey-text text-darken-4">Sandra Bolterine<i class="material-icons right">more_vert</i></span>
                    </div>

                    <div class="card-action" style="text-align: center;">
                        <a onclick="Materialize.toast('Check-in realizado com sucesso !', 4000)"><i class="material-icons">done</i></a>
                    </div>

                    <div class="card-reveal">
                        <span class="card-title grey-text text-darken-4">Informações<i class="material-icons right">close</i></span>
                        <p>Reserva : 068224</p>
                        <p>Cliente : Levi Monteiro</p>
                        <p>Quarto  : Quarto Simples</p>
                        <p>Status  : Em Andamento</p>
                    </div>
                </div>
            </div>
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
                <input id="txtDataEntrada" runat="server" type="date" class="validate" />
            </div>

            <div class="col s12 m6">
                <label>Data de Saída</label>
                <input id="txtDataSaída" runat="server" type="date" class="validate" />
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
            $('select').material_select();
            $('ul.tabs').tabs();
        });

        $(document).ready(function () {
            $('.modal-trigger').leanModal();
        });

    </script>


</asp:Content>
