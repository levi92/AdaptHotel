﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Recepcionista.Master" AutoEventWireup="true" CodeBehind="Gerenciar_Hospede.aspx.cs" Inherits="AdaptHotel.views.Recepcionista.Gerenciar_Hospede" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     
    <div class="row blue darken-4 z-depth-1">
        <div class="container">
            <div class="col s12">
                <input type="text" style="color: white; border-color: white;" placeholder="BUSCAR">
            </div>




        </div>
    </div>

    <div class="container">
        <div class="col s12">
            <div class="col s12 m6 z-depth-1" style="overflow-y: auto; height: 669px;">
                <ul class="collection">
                    <% foreach (var hospede in lista_hospedes)
                        { %>
                    <a class="collection-item avatar waves-effect waves" style="min-height: 60px;" onclick="showDiv()">
                        <img src="../../images/quarto-1.jpg" alt="" class="circle">
                        <span class="title"><%= hospede.Nome %> </span>
                        <p><%= hospede.Endereco.Cidade %> - <%= hospede.Endereco.Estado %></p>
                    </a>
                    <% } %>
                </ul>
            </div>



            <div class="col s12 m6">
                <div id="details" style="display: none">
                    <div class="card-panel hoverable">
                        <h5 class="card-title activator grey-text text-darken-4" style="margin-top: 0;">Dados Pessoais</h5>

                        <div class="panel-body" style="padding: 0;">
                            <label>Nome:</label>
                            Carol Shilles Abulquerque
                    <br />
                            <label>Sexo:</label>
                            Feminino
                    <br />
                            <label>Telefone:</label>
                            (11) 985642345 
                    <br />
                            <label>Data de Nascimento:</label>
                            30/02/1982
                    <br />
                            <label>CPF:</label>
                            641.273.594-18
                    <br />
                            <label>E-mail:</label>
                            carol_shilles@gmail.com.br
                    <br />
                        </div>
                    </div>

                    <div class="card-panel hoverable">
                        <h5 class="card-title activator grey-text text-darken-4" style="margin-top: 0;">Endereço</h5>

                        <div class="panel-body" style="padding: 0;">

                            <label>Endereço:</label>
                            R. Satirnado
                    <br />
                            <label>Bairro:</label>
                            Vila das Loruncias
                    <br />
                            <label>CEP:</label>
                            12.765 - 120
                    <br />

                            <label>Cidade:</label>
                            São José dos Campos
                    <br />
                            <label>UF:</label>
                            SP<br />
                            <label>Nº:</label>
                            52<br />

                        </div>
                    </div>

                    <div class="card-panel hoverable">
                        <h5 class="card-title grey-text text-darken-4" style="margin-top: 0;">Dados do Hóspede</h5>

                        <div class="panel-body" style="padding: 0;">
                            <label>Placa do Carro:</label>
                            BQN-1859
                    <br />
                            <label>Cidade de Origem:</label>
                            São Paulo
                    <br />
                        </div>
                    </div>

                    <div class="card-panel hoverable">
                        <h5 class="card-title grey-text text-darken-4" style="margin-top: 0;">Ultimas Reservas</h5>
                        <div class="panel-body" style="padding: 0;">
                            <div class="col s12">
                            </div>
                        </div>
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
            <li><a class="btn-floating red  modal-trigger" href="#edit"><i class="material-icons">delete</i></a></li>
        </ul>
    </div>


    <!-- Button trigger modal -->
    <!-- Modal -->
    <div id="add" class="modal modal-fixed-footer">
        <div class="modal-content">

           
                <h4>Adicionar Dados</h4>


                <div class="col s12">
                    <h5>Dados Pessoais</h5>
                </div>





                <div class="input-field col s12 m6">
                    <label>Nome</label>
                    <input id="txtNome" runat="server" type="text" class="validate" />
                </div>

                <div class="input-field col s12 m6">
                    <input id="txtData" runat="server" type="date" class="validate" />

                </div>

                <div class="input-field col s12 m6">
                    <label>Cpf</label>
                    <input id="txtCpf" runat="server" type="text" class="validate" />
                </div>

                <div class="input-field col s12 m6">
                    <label>Telefone</label>
                    <input id="txtTelefone" runat="server" type="text" class="validate" />
                </div>

                <div class="input-field col s12 m6">
                    <label>E-mail</label>
                    <input id="txtEmail" runat="server" type="email" class="validate" />
                </div>

                <div class="col s12 m6" >
                    <asp:RadioButtonList runat="server" ID="rblSexo">
                        <asp:ListItem Value="M">Masculino</asp:ListItem>
                        <asp:ListItem Value="F">Feminino</asp:ListItem>
                    </asp:RadioButtonList>
                </div>

                <div class="col s12">
                    <h5>Endereço</h5>
                </div>

                <div class="input-field col s12 m6">
                    <label>CEP</label>
                    <input id="txtCep" runat="server" type="text" />
                </div>

                <div class="input-field col s12 m6">
                    <select id="ddlEstado" runat="server">
                        <option value="" disabled selected>Selecione o estado</option>
                        <option value="AC">Acre</option>
                        <option value="AL">Alagoas</option>
                        <option value="AP">Amapá</option>
                        <option value="AM">Amazonas</option>
                        <option value="BA">Bahia</option>
                        <option value="CE">Ceará</option>
                        <option value="DF">Distrito Federal</option>
                        <option value="ES">Espirito Santo</option>
                        <option value="GO">Goiás</option>
                        <option value="MA">Maranhão</option>
                        <option value="MS">Mato Grosso do Sul</option>
                        <option value="MT">Mato Grosso</option>
                        <option value="MG">Minas Gerais</option>
                        <option value="PA">Pará</option>
                        <option value="PB">Paraíba</option>
                        <option value="PR">Paraná</option>
                        <option value="PE">Pernambuco</option>
                        <option value="PI">Piauí</option>
                        <option value="RJ">Rio de Janeiro</option>
                        <option value="RN">Rio Grande do Norte</option>
                        <option value="RS">Rio Grande do Sul</option>
                        <option value="RO">Rondônia</option>
                        <option value="RR">Roraima</option>
                        <option value="SC">Santa Catarina</option>
                        <option value="SP">São Paulo</option>
                        <option value="SE">Sergipe</option>
                        <option value="TO">Tocantins</option>
                    </select>
                    <label>Estado</label>
                </div>



                <div class="input-field col s12 m6">
                    <label>Cidade</label>
                    <input id="txtCidade" runat="server" type="text" />
                </div>

                <div class="input-field col s12 m6">
                    <label>Bairro</label>
                    <input id="txtBairro" runat="server" type="text" />
                </div>

                <div class="input-field col s12 m6">
                    <label>Rua</label>
                    <input id="txtRua" runat="server" type="text" />
                </div>

                <div class="input-field col s12 m6">
                    <label>Numero</label>
                    <input id="txtNumero" runat="server" type="text" />
                </div>

                <div class="input-field col s12 m6">
                    <label>Complemento</label>
                    <input id="txtComplemento" runat="server" type="text" />
                </div>

                <div class="col s12">
                    <h5>Dados do Hospede</h5>
                </div>
                <div class="input-field col s12 m6">
                    <label>Placa do Carro</label>
                    <input id="txtPlacaCarro" runat="server" type="text" />
                </div>
                <div class="input-field col s12 m6">
                    <label>Cidade de Origem</label>
                    <input id="txtCidadeOrigem" runat="server" type="text" />
                </div>
           
        </div>

        <div class="modal-footer">
            <button id="btnCadastrar" class="modal-action modal-close waves-effect waves-green btn-flat" runat="server" onserverclick="btnCadastrar_ServerClick">Cadastrar</button>
        </div>
    </div>



    <div id="edit" class="modal modal-fixed-footer">
        <div class="modal-content">
            <h4>Alterar Dados</h4>


            <div class="col s12">
                <h5>Dados Pessoais</h5>
            </div>

            <div class="col s12">
                <label>Nome</label>
                <input type="text" value="Arthur Benedito Royol Pereira " />
            </div>

            <div class="col s6">
                <label>Data de Nascimento</label>
                <input type="date" />

                <label>Sexo</label>
                <br />
                <input name="group1" type="radio" id="test1" />
                <label for="test1" style="margin-top: 15px;">Feminino</label>

                <input name="group1" type="radio" id="test2" />
                <label for="test2">Masculino</label>
            </div>

            <div class="col s6">
                <label>E-mail</label>
                <input type="text" value="arthur@royal.com.br" />

                <label>CPF</label>
                <input type="text" value="543.678.897-98 " />
            </div>



            <div class="col s12">
                <h5>Endereço</h5>
            </div>

            <div class="col s6">
                <label>Rua</label>
                <input type="text" value="R. Primavera, 271" />

                <label>Bairro</label>
                <input type="text" value="Vila das Comélias" />
            </div>

            <div class="col s6">
                <label>Cidade</label>
                <input type="text" value="Birigui " />

                <label>CEP</label>
                <input type="text" value="12.505-235" />
            </div>

            <div class="col s12">
                <label>Estado</label>
                <select>
                    <option value="SP">SP</option>
                </select>
            </div>

            <div class="col s12">
                <h5>Dados do Hospede</h5>
            </div>
            <div class="col s6">
                <label>Placa do Carro</label>
                <input type="text" value="BQN-1859 " />
            </div>
            <div class="col s6">
                <label>Cidade de Origem</label>
                <input type="text" value="São Paulo" />
            </div>

        </div>
        <div class="modal-footer">
            <a href="#!" class="modal-action modal-close waves-effect waves-green btn-flat ">Alterar</a>
        </div>
    </div>

    <script>
        function showDiv() {
            $("#details").slideUp("slow");
            $("#details").slideDown("slow");
        }

        $(document).ready(function () {


            $('select').material_select();
            $('.modal-trigger').leanModal();
        });

        $(document).ready(function () {
            $('select').material_select();
        });

        </script>
     
</asp:Content>
