<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AdaptHotel.views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
    <link href="../Content/materialize.min.css" rel="stylesheet" />
    <link href="../Content/Site.css" rel="stylesheet" />
</head>
<body>
    <style>
        .modalLoader {
            position: fixed;
            z-index: 2000;
            height: 100%;
            width: 100%;
            top: 0;
            left: 0;
            bottom: 0;
            right: 0;
            background-color: rgba(0, 0, 0, 0.2);
        }

        .modalCenter {
            z-index: 1000;
            margin: 20% auto;
            padding: 10px;
            width: 100px;
            text-align: center;
            background-color: transparent;
            border-radius: 10px;
        }
    </style>
    <nav class="light-blue lighten-1" role="navigation">
        <div class="nav-wrapper container">
            <a id="logo-container" href="#" class="right brand-logo" style="font-family: gearsOfPeace;">AdaptHotel</a>
        </div>
    </nav>
    <form id="form1" class="col s12" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdateProgress ID="upgLogin" runat="server" AssociatedUpdatePanelID="UpdatePanel">
            <ProgressTemplate>
                <!-- Modal Structure -->
                <div class="modalLoader">
                    <div class="modalCenter">
                        <div class="preloader-wrapper big active">
                            <div class="spinner-layer spinner-blue-only">
                                <div class="circle-clipper left">
                                    <div class="circle"></div>
                                </div>
                                <div class="gap-patch">
                                    <div class="circle"></div>
                                </div>
                                <div class="circle-clipper right">
                                    <div class="circle"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </ProgressTemplate>
        </asp:UpdateProgress>
        <div class="container">
            <asp:UpdatePanel ID="UpdatePanel" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="row">
                        <div class="col s10 m8 l4" style="margin: 0 auto; float: none;">
                            <div id="logo" class="col s12 top-spacing-form" style="width: 100%; height: 33vh;">
                                <img src="../fonts/Aston-Horiz-Color-Large.png" style="width: inherit; height: inherit;" />
                            </div>
                            <div class="top-spacing-form input-field col s12">
                                <i class="material-icons prefix">email</i>
                                <input id="txtEmail1" type="email" class="validate" runat="server" />
                                <label for="txtEmail1">Email</label>
                            </div>
                            <div class="input-field col s12">
                                <i class="material-icons prefix">lock</i>
                                <input id="txtSenha1" type="password" class="validate" runat="server" />
                                <label for="txtSenha1">Senha</label>
                            </div>
                            <div class="col s12 center-align top-spacing-form">
                                <asp:Label ID="lblMsg" runat="server" Visible="false" ForeColor="Red"></asp:Label>
                            </div>
                            <div class="col s12">
                                <button id="btnEntrar" style="width: 100%;" class="btn orange waves-effect waves-light" runat="server" onserverclick="btnEntrar_Click">Entrar</button>
                            </div>
                            <div class="col s12 center-align top-spacing-form">
                                <asp:LinkButton ID="lkbEsquecerSenha" CssClass="link" Text="Esqueceu a senha?" runat="server"></asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
    <script type="text/javascript" src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script type="text/javascript" src="../../js/materialize.min.js"></script>
</body>
</html>
