<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"CodeBehind="Gerenciar_Reservas.aspx.cs" Inherits="AdaptHotel.views.Gerente.Gerenciar_Reservas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">




    <div class="col-md-12">
        <div class="col-md-6">
            <input type="text" placeholder="BUSCAR" class="buscar" style="margin-left: 0">
        </div>
        <div class="col-md-3">
            <input type="date" class="form-control buscar" style="margin-left: 0;height: 42px;">
        </div>
        <div class="col-md-3">
            <select class="form-control buscar" style="margin-left: 0;height: 42px;">
                <option>Ordenar</option>
            </select>
        </div>
    </div>

    <div class="col-md-12">
         <div class="row">
            <div class="col s12" style="width: 100%;">
              <ul class="tabs">    
                <li class="tab col s3" style="border-bottom: 1px solid #1976D2;font-weight: bold;"><a href="#test1">Em Andamento</a></li>
                <li class="tab col s3"><a class="active" href="#test2">Cancelado</a></li>
                <li class="tab col s3"><a href="#test3">No How</a></li>
                <li class="tab col s3"><a href="#test4">Reservado</a></li>
              </ul>
            </div> 
         </div>
    </div>
            
     <div class="col-md-12">
        <div class="col-md-3">
            <div class="sshadow card">
                <img class="card-img-top" src="../../images/quarto-1.jpg" alt="Reserva">
                <div class="card-block">
                   <h4 class="card-title">Nicolas Santos</h4>
                    <h4 class="card-title">21/06 - 23/06</h4>
                    <h4 class="card-title">Quarto Imperial Deluxe</h4>
                </div>
            </div>
        </div>

         <div class="col-md-3">
            <div class="sshadow card">
                <img class="card-img-top" src="../../images/quarto-1.jpg" alt="Reserva">
                <div class="card-block">
                    <h4 class="card-title">Levi Monteiro</h4>
                    <h4 class="card-title">07/07 - 12/07</h4>
                    <h4 class="card-title">Quarto Super Simples</h4>
                </div>
            </div>
        </div>
     </div>
        
  


</asp:Content>
