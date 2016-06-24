<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Passo_2.aspx.cs" Inherits="AdaptHotel.views.Setup.Passo_2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="col s12" style="margin-top: 37px;">
            <nav>
                <div class="nav-wrapper">
                    <div class="col s12">
                        <a href="#!" class="breadcrumb">Bem-Vindo</a>
                        <a href="#!" class="breadcrumb" style="font-weight: bold; color: white">Configuração</a>
                        <a href="#!" class="breadcrumb">Quartos</a>
                        <a href="#!" class="breadcrumb">Funcionarios</a>
                        <a href="#!" class="breadcrumb">Finalizar</a>
                    </div>
                </div>

            </nav>
        </div>

        <div class="col s12">
            <div class="card hoverable">
                <div class="card-image">
                    <img src="../../images/user-profile-bg.jpg" />
                    <h3 class="card-title">Configuração</h3>
                </div>
                <div class="card-content">
                    <p>Estas são as configurações principais do sistema, preencha-as com cuidado.</p>

                    <div class="input-field">
                        <label>Nome do Hotel</label>
                        <input id="txtCidade" runat="server" type="text" />
                    </div>

                    <div class="input-field">
                        <label>Endereço do Hotel</label>
                        <input id="txtBairro" runat="server" type="text" />
                    </div>

                    <div class="file-field input-field">
                        <div class="btn">
                            <span>Logo</span>
                            <input type="file">
                        </div>
                        <div class="file-path-wrapper">
                            <input class="file-path validate" type="text">
                        </div>
                    </div>

                    <div class="input-field">
                        <select>      
                             <option value="" disabled selected>Cor Principal</option>
                            <option>Amarelo</option>
                            <option>Azul</option>
                            <option>Laranja</option>
                            <option>Verde</option>
                            <option>Vermelho</option>
                            <option>Violeta</option>
                        </select>
                    </div>

                    <div class="input-field">
                        <select>     
                             <option value="" disabled selected>Cor Secundária</option> 
                            <option>Amarelo</option>
                            <option>Azul</option>
                            <option>Laranja</option>
                            <option>Verde</option>
                            <option>Vermelho</option>
                            <option>Violeta</option>
                        </select>
                    </div>
                </div>

                <div class="card-action">
                    <a href="Passo_1.aspx">Voltar</a> <a href="Passo_3.aspx">Cadastrar Quartos</a>
                </div>
            </div>
        </div>
    </div>


    <script>
         $(document).ready(function () {
            $('select').material_select();
        });

    </script>

</asp:Content>
