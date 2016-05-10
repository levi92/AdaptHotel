<%@ Page Title="Index" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AdaptHotel.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="container body">


        <div class="main_container">

            <!-- top navigation -->
            <nav class="navbar navbar-default navbar-fixed-top" role="navigation" style="background-color: #2196F3; color: #FFF;">
                 <div class="nav toggle">
                            <a id="menu_toggle"><i class="fa fa-bars"></i></a>
                        </div>

                        <ul class="nav navbar-nav navbar-right">
                            <li class=""><span class=" fa fa-angle-down"></span> </li>

                        </ul>
            </nav>
            <!-- /top navigation -->


            <div class="col-md-2 left_col">
                <div class="left_col scroll-view">               
                 
                    <!-- sidebar menu -->
                    <div id="sidebar-menu" class="main_menu_side hidden-print main_menu">

                        <div class="menu_section">                           
                            <ul class="nav side-menu">

                                <li><a href="hospede"><i class="fa fa-user"></i> Hospede</a></li> 
                                <li><a href="reserva"><i class="fa fa-cog"></i> Reserva</a></li>
                                <li><a href="reserva"><i class="fa fa-cog"></i> Pagamento</a></li>
                                <li><a href="reserva"><i class="fa fa-cog"></i> Funcionário</a></li>
                                <li><a href="reserva"><i class="fa fa-cog"></i> Quartos</a></li>

                            </ul>
                        </div>
                    </div>
                    <!-- /sidebar menu -->

          
                
                </div>
            </div>

            


  
            <!-- page content -->
            <div class="col-md-10 right_col" role="main">
                <div class="">
                     

                    <div class="row">

                        <div class="col-md-12 col-sm-12 col-xs-12">                            
                            <div class="x_panel">
                                <div class="x_title">
                                    <h2><? echo lang_conf_categorias; ?></h2>  
                                    <div class="clearfix"></div>
                                </div>
                                <div class="x_content"> 
                                   
                               

                                </div>
                            </div>
                        </div>

                        <br />
                        <br />
                        <br />

                    </div>
                </div>
          
                    
                </div>
                <!-- /page content -->

        </div>

    </div>
</asp:Content>
