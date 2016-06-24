<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Gerente.Master" CodeBehind="Gerenciar_Hospede.aspx.cs" Inherits="AdaptHotel.views.Gerente.Gerenciar_Hospede" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row blue darken-4 z-depth-1">
        <div class="container">
            <div class="col s12">
                <input type="text" style="color: white; border-color: white;" placeholder="BUSCAR">
            </div>


        </div>
    </div>

    <div class="container">
        <asp:UpdatePanel ID="UpdatePanelHospedes" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <div class="col s12">
                    <div class="col s12 m6 z-depth-1" style="overflow-y: auto; height: 669px;">
                        <ul class="collection">
                            <% foreach (var hospede in lista_hospedes)
                                { %>
                            <a id='<%= hospede.CodHospede%>' class="collection-item avatar waves-effect waves" style="min-height: 60px;" onclick="__doPostBack('<%= hospede.CodHospede%>', '<%= hospede.CodHospede%>')">
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
                                    Nome:
                                    <label id="lblNome" runat="server"></label>
                                    <br />
                                    Sexo:
                                    <label id="lblSexo" runat="server"></label>
                                    <br />
                                    Telefone:
                                    <label id="lblTelefone" runat="server"></label>
                                    <br />
                                    Data de Nascimento:
                                    <label id="lblDataNasc" runat="server"></label>
                                    <br />
                                    CPF:
                                    <label id="lblCpf" runat="server"></label>
                                    <br />
                                    E-mail:
                                    <label id="lblEmail" runat="server"></label>
                                    <br />
                                </div>
                            </div>

                            <div class="card-panel hoverable">
                                <h5 class="card-title activator grey-text text-darken-4" style="margin-top: 0;">Endereço</h5>

                                <div class="panel-body" style="padding: 0;">
                                    Endereço:
                                    <label id="lblRua" runat="server"></label>
                                    <br />
                                    Bairro:
                                    <label id="lblBairro" runat="server"></label>
                                    <br />
                                    CEP:
                                    <label id="lblCep" runat="server"></label>
                                    <br />

                                    Cidade:
                                    <label id="lblCidade" runat="server"></label>
                                    <br />
                                    UF:
                                    <label id="lblEstado" runat="server"></label>
                                    <br />
                                    Nº:
                                    <label id="lblNumero" runat="server"></label>
                                    <br />

                                </div>
                            </div>

                            <div class="card-panel hoverable">
                                <h5 class="card-title grey-text text-darken-4" style="margin-top: 0;">Dados do Hóspede</h5>

                                <div class="panel-body" style="padding: 0;">
                                    Placa do Carro:
                                    <label id="lblPlaca" runat="server"></label>
                                    <br />
                                    Cidade de Origem:
                                    <label id="lblCidadeOrigem" runat="server"></label>
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
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

    <div class="fixed-action-btn horizontal click-to-toggle" style="bottom: 30px; right: 24px;">
        <a class="btn-floating btn-large red">
            <i class="material-icons">menu</i>
        </a>
        <ul>
            <li><a class="btn-floating green modal-trigger" href="#add"><i class="material-icons">add</i></a></li>
            <li><a class="btn-floating blue  modal-trigger" href="#edit"><i class="material-icons">mode_edit</i></a></li>
            <%--<li><a class="btn-floating red  modal-trigger" href="#edit"><i class="material-icons">delete</i></a></li>--%>
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
                <label>Data de nascimento</label>
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

            <div class="col s12 m6">
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

    <!-- Alterando Dados -->

    <div id="edit" class="modal modal-fixed-footer">
        <asp:UpdatePanel ID="UpdatePanelEdit" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <div class="modal-content">
                    <h4>Alterar Dados</h4>


                    <div class="col s12">
                        <h5>Dados Pessoais</h5>
                    </div>


                    <div class="input-field col s12 m6">
                        <label class="active">Nome</label>
                        <input id="txtAlterarNome" runat="server" type="text" class="validate" />
                    </div>

                    <div class="input-field col s12 m6">
                        <label class="active">Data de nascimento</label>
                        <input id="txtAlterarDataNasc" runat="server" type="date" class="validate" />

                    </div>

                    <div class="input-field col s12 m6">
                        <label class="active">Cpf</label>
                        <input id="txtAlterarCpf" runat="server" type="text" class="validate" />
                    </div>

                    <div class="input-field col s12 m6">
                        <label class="active">Telefone</label>
                        <input id="txtAlterarTelefone" runat="server" type="text" class="validate" />
                    </div>

                    <div class="input-field col s12 m6">
                        <label class="active">E-mail</label>
                        <input id="txtAlterarEmail" runat="server" type="email" class="validate" />
                    </div>

                    <div class="col s12 m6">
                        <asp:RadioButtonList runat="server" ID="rblAlterarSexo">
                            <asp:ListItem Value="M">Masculino</asp:ListItem>
                            <asp:ListItem Value="F">Feminino</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>

                    <div class="col s12">
                        <h5>Endereço</h5>
                    </div>

                    <div class="input-field col s12 m6">
                        <label class="active">CEP</label>
                        <input id="txtAlterarCep" runat="server" type="text" />
                    </div>

                    
                    <div class="input-field col s12 m6">
                        <select id="txtAlterarEstado" runat="server">
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

                    <%--<div class="input-field col s12 m6">
                        <label class="active">Estado</label>
                        <input id="txtAlterarEstado" runat="server" type="text" />
                    </div>--%>

                    <div class="input-field col s12 m6">
                        <label class="active">Cidade</label>
                        <input id="txtAlterarCidade" runat="server" type="text" />
                    </div>

                    <div class="input-field col s12 m6">
                        <label class="active">Bairro</label>
                        <input id="txtAlterarBairro" runat="server" type="text" />
                    </div>

                    <div class="input-field col s12 m6">
                        <label class="active">Rua</label>
                        <input id="txtAlterarRua" runat="server" type="text" />
                    </div>

                    <div class="input-field col s12 m6">
                        <label class="active">Numero</label>
                        <input id="txtAlterarNumero" runat="server" type="text" />
                    </div>

                    <div class="input-field col s12 m6">
                        <label class="active">Complemento</label>
                        <input id="txtAlterarComplemento" runat="server" type="text" />
                    </div>

                    <div class="col s12">
                        <h5>Dados do Hospede</h5>
                    </div>
                    <div class="input-field col s12 m6">
                        <label class="active">Placa do Carro</label>
                        <input id="txtAlterarPlaca" runat="server" type="text" />
                    </div>
                    <div class="input-field col s12 m6">
                        <label class="active">Cidade de Origem</label>
                        <input id="txtAlterarCidadeOrigem" runat="server" type="text" />
                    </div>

                </div>

                <div class="modal-footer">
                    <button id="btnEditar" class="modal-action modal-close waves-effect waves-green btn-flat" runat="server" onserverclick="btnEditar_ServerClick">Alterar</button>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

    <script>
        function showDiv(id) {
            $("#" + id).addClass("active");
            $("#details").slideUp("slow");
            $("#details").slideDown("slow");
            $('select').material_select();
        }

        $(document).ready(function () {

            $('.datepicker').pickadate({
                selectMonths: true, // Creates a dropdown to control month
                selectYears: 15 // Creates a dropdown of 15 years to control year
            });

            $('select').material_select();
            $('.modal-trigger').leanModal();
        });

        $(document).ready(function () {
            $('select').material_select();
        });
    </script>
</asp:Content>