<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AdaptHotel.views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-default navbar-fixed-top" role="navigation">
            <div class="container">
               <h4 align="right">Adapt Hotel</h4>
            </div>
        </nav>

        <div class="container" style="margin-top:10%">
            <div class="rows">
                <div class="col-xs-6 col-md-4">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h3 class="panel-title">
                                <center><img src="/logo" alt="logo"/></center>
                            </h3>
                        </div>
                        <div class="panel-body">
                                <center><input type="email" ID="txtLogin" class="form-control"  placeholder="Login" style="width:250px;" runat="server"></input></center>
                                <br>
                                <center><input type="password" ID="txtSenha" class="form-control" placeholder="Senha" style="width:250px;" runat="server"></input></center>
                                <br>
                                <center><input type="button" ID="enviar" class="btn btn-default" Style="width: 250px;" runat="server" value="login"/><br /></center>                      
                        </div>                
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
