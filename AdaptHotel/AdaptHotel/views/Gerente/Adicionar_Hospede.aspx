<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Adicionar_Hospede.aspx.cs" Inherits="AdaptHotel.views.Gerente.Adicionar_Hospede" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel panel-default" style="width: 100%;">
                    <div class="panel-heading" style="background-color: #2196F3; color: #FFF"><a href="#" style="font-size:2em; color:#FFF;">Adicionar Hospedes</a></div>
                    <div class="panel-body" style="padding: 0;">     

     <div class="col-md-12">

        <div class="col-md-12">
            <h3>Dados Pessoais</h3>
        </div>

        <div class="col-md-12">
            <label>Nome</label>
            <input type="text" class="form-control" />
        </div>

        <div class="col-md-6">
            <label>Data de Nascimento</label>
            <input type="date" class="form-control" />
        </div>
        <div class="col-md-6" style="height: 78px;">
            <label>Sexo</label> <br />
            <input type="radio" /> Masculino
            <input type="radio" /> Feminino
        </div>
        <div class="col-md-6">
            <label>RG</label>
            <input type="text" class="form-control" />
        </div>
        <div class="col-md-6">
            <label>CPF</label>
            <input type="text" class="form-control" />
        </div>

        <div class="col-md-12">
            <h3>Endereço</h3>
        </div>

        <div class="col-md-6">
            <label>Rua</label>
            <input type="text" class="form-control" />
        </div>
        <div class="col-md-6">
            <label>Bairro</label>
            <input type="text" class="form-control" />
        </div>
        <div class="col-md-6">
            <label>Cidade</label>
            <input type="text" class="form-control" />
        </div>
        <div class="col-md-6">
            <label>CEP</label>
            <input type="text" class="form-control" />
        </div>
        <div class="col-md-6">
            <label>Estado</label>
            <select class="form-control">
                <option value="SP">SP</option>
            </select>
        </div>
    </div>
                </div></div>


     <div class="panel panel-default" style="width: 100%;">
        <div class="panel-body" style="padding: 0;">   
            <div class="col-md-12" style="text-align:right">
                <span class="fa fa-user"></span>
                <span class="fa fa-user"></span>
                <span class="fa fa-user"></span>
            </div>
        </div> 
     </div>

</asp:Content>
