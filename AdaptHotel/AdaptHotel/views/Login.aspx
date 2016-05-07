<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AdaptHotel.views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:BundleReference runat="server" Path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />

</head>
<body>

    <form id="form1" runat="server">
        <nav class="navbar navbar-default navbar-fixed-top" role="navigation">
            <div class="container">
                <h4 align="right">Adapt Hotel</h4>
            </div>
        </nav>

        <div class="container">
            <div class="row">
                <div class="col-xs-10 col-sm-6 col-md-4" style="margin: 0 auto; margin-top: 10%; float: none;">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <div class="panel-title" style="display: flex; justify-content: center;">
                                <img src="/logo" alt="logo" />
                            </div>
                        </div>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-xs-12" style="margin: 0 auto; float: none; text-align: center;">
                                    <div class="col-md-10 input-group" style="margin:0 auto; float:none;">
                                        <span class="input-group-addon" id="basic-addon1">
                                            <img src="../fonts/ic_email_black_18dp_1x.png" />
                                        </span>
                                        <asp:TextBox class="form-control" runat="server" placeholder="E-mail" TextMode="Email" aria-describedby="basic-addon1" style="width:100%;"></asp:TextBox>
                                    </div>
                                    <br />
                                    <div class="col-md-10 input-group" style="margin:0 auto; float:none;">
                                        <span class="input-group-addon" id="basic-addon1">
                                            <img src="../fonts/ic_lock_black_18dp_1x.png" />
                                        </span>
                                        <asp:TextBox class="form-control" runat="server" placeholder="Senha" TextMode="Password"></asp:TextBox>
                                    </div>
                                    <br />
                                    <asp:Button ID="btnEntrar" Text="Entrar" CssClass="btn btn-default" runat="server"/>
                                    <br /><br />
                                    <asp:LinkButton ID="lkbEsquecerSenha" Text="Esqueceu a senha?" runat="server"></asp:LinkButton>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
