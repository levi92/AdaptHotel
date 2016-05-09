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
        <nav class="navbar navbar-default navbar-fixed-top" role="navigation" style="background-color: #2196F3; color: #FFF;">
            <div class="container">
                <h4 style="font-size: 3rem; font-family: gearsOfPeace; text-align:right;">Adapt Hotel</h4>
            </div>
        </nav>

        <div class="container">
            <div class="row">
                <div class="col-xs-10 col-sm-8 col-md-4" style="margin:0 auto; float:none; text-align:center;">
                    <div id="logo" style="width:100%; height:33vh;">
                        <img src="../fonts/Aston-Horiz-Color-Large.png" style="width:inherit; height:inherit;"/>
                    </div>
                    <asp:TextBox class="form-control" runat="server" placeholder="E-mail" Style="border:#FFF 1px solid; margin:0 auto; float:none; padding-left: 10%; background-image: url(../fonts/ic_email_black_18dp_1x.png); background-repeat: no-repeat; background-position: 4%;" TextMode="Email"></asp:TextBox>
                    <br />
                    <asp:TextBox class="form-control" runat="server" placeholder="Senha" Style="border:#FFF 1px solid; margin:0 auto; float:none; padding-left: 10%; background-image: url(../fonts/ic_lock_black_18dp_1x.png); background-repeat: no-repeat; background-position: 4%;" TextMode="Password"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnEntrar" Text="Entrar" CssClass="btn btn-default" runat="server" Style="background-color:#FF9100; color:#FFF; width: 100%; margin:0 auto; float:none;" />
                    <br />
                    <br />
                    <asp:LinkButton ID="lkbEsquecerSenha" CssClass="link" Text="Esqueceu a senha?" runat="server"></asp:LinkButton>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
