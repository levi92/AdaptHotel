<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Gerenciar_Quartos.aspx.cs" Inherits="AdaptHotel.views.Gerente.Gerenciar_Quartos" %>

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

                            <li class="tab col s3"><a class="active" href="#disponivel">Disponível</a></li>
                            <li class="tab col s3"><a href="#ocupado">Ocupado</a></li>
                            <li class="tab col s3"><a href="#manutencao">Manutenção</a></li>
                            <li class="tab col s3"><a href="#desabilitado">Desabilitado</a></li>

                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="row">

        <div id="disponivel" class="container">
            <div class="col s12 m6 l3">
                <div class="card">
                    <div class="card-image waves-effect waves-block waves-light">
                        <img class="activator" src="../../images/quarto-1.jpg">
                    </div>
                    <div class="card-content">
                        <span class="card-title activator grey-text text-darken-4">Twin Room<i class="material-icons right">more_vert</i></span>
                    </div>

                    <div class="card-action" style="text-align: center;">
                        <a href="#"><i class="material-icons">mode_edit</i></a>
                        <a href="#"><i class="material-icons">delete</i></a>
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
                        <span class="card-title activator grey-text text-darken-4">Imperial<i class="material-icons right">more_vert</i></span>
                    </div>

                    <div class="card-action" style="text-align: center;">
                        <a href="#"><i class="material-icons">mode_edit</i></a>
                        <a href="#"><i class="material-icons">delete</i></a>
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

        <div id="ocupado" class="container" style="display: none">
            <div class="col s12 m6 l3">
                <div class="card">
                    <div class="card-image waves-effect waves-block waves-light">
                        <img class="activator" src="../../images/quarto-2.jpg">
                    </div>
                    <div class="card-content">
                        <span class="card-title activator grey-text text-darken-4">Casal Simples<i class="material-icons right">more_vert</i></span>
                    </div>

                    <div class="card-action" style="text-align: center;">
                        <a href="#"><i class="material-icons">mode_edit</i></a>
                        <a href="#"><i class="material-icons">delete</i></a>
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
                        <span class="card-title activator grey-text text-darken-4">Solteiro<i class="material-icons right">more_vert</i></span>
                    </div>

                    <div class="card-action" style="text-align: center;">
                        <a href="#"><i class="material-icons">mode_edit</i></a>
                        <a href="#"><i class="material-icons">delete</i></a>
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
        </ul>
    </div>

        <!-- Modal -->
    <div id="add" class="modal modal-fixed-footer">
        <div class="modal-content">
            <h4>Novo Quarto</h4>

          
            <div class="col s12">
                <label>Nome</label>
                <input type="text" />
            </div>

            <div class="col s6">
               <label>Tipo</label>
                <input type="text" />
            </div>

            <div class="col s6">

                <label>Valor</label>
                <input type="text" />
            </div>            

        </div>
        <div class="modal-footer">
            <a href="#!" class="modal-action modal-close waves-effect waves-green btn-flat ">Adicionar</a>
        </div>
    </div>

    <script>
        $(document).ready(function () {
            $('select').material_select();
            $('.modal-trigger').leanModal();
            $('ul.tabs').tabs();
        });
    </script>


</asp:Content>
