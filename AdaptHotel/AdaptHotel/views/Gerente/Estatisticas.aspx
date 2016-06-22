<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Gerente.Master" CodeBehind="Estatisticas.aspx.cs" Inherits="AdaptHotel.views.Gerente.Estatisticas" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script src="../../js/Chart.min.js"></script>

    <div class="row blue darken-4 z-depth-1">
        <div class="container">
            <div class="col s12">
                <input type="text" style="color: white; border-color: white;" placeholder="BUSCAR">
            </div>




        </div>
    </div>

    <div class="container">
        <div class="col s12 m6">
            <div class="card hoverable">
                <div class="card-content">
                    <canvas id="canvas1"></canvas>
                </div>
            </div>
        </div>

        <div class="col s12 m6">
            <div class="card hoverable">
                <div class="card-content">
                    <canvas id="canvas2"></canvas>
                </div>
            </div>
        </div>

        <div class="col s12">
            <div class="card hoverable">
                <div class="card-content">
                    <canvas id="canvas3"></canvas>
                </div>
            </div>
        </div>

        <div class="col s12">
            <div class="card hoverable">
                <div class="card-content">
                    <canvas id="canvas4"></canvas>
                </div>
            </div>
        </div>

    </div>

    <script>

        var randomScalingFactor = function () {
            return Math.round(Math.random() * 100);
        };
        var randomColorFactor = function () {
            return Math.round(Math.random() * 255);
        };
        var randomColor = function (opacity) {
            return 'rgba(' + randomColorFactor() + ',' + randomColorFactor() + ',' + randomColorFactor() + ',' + (opacity || '.3') + ')';
        };

        //CHART 1
        var config1 = {
            type: 'line',
            data: {
                labels: ["Janeiro", "Fevereiro", "Março", "Abril", "Mario", "Junho"],
                datasets: [{
                    label: "Quantidade de Hóspedes",
                    data: [randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor()],
                }]
            },
            options: {
                responsive: true,
                title: {
                    display: true, text: 'Número de Hóspedes'
                },
            }
        };
        $.each(config1.data.datasets, function (i, dataset) {
            dataset.backgroundColor = randomColor(0.5);
        });


        //CHART 2
        var config2 = {
            type: 'pie',
            data: {
                labels: ["Janeiro", "Fevereiro", "Março", "Abril", "Mario", "Junho"],
                datasets: [{
                    label: "Quartos Mais Reservados",
                    data: [randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor()],
                }]
            },
            options: {
                responsive: true,
                title: {
                    display: true, text: 'Quartos Mais Reservados'
                },
            }
        };
        $.each(config2.data.datasets, function (i, dataset) {
            dataset.backgroundColor = randomColor(0.5);
        });


        //CHART 3
        var config3 = {
            type: 'radar',
            data: {
                labels: ["Janeiro", "Fevereiro", "Março", "Abril", "Mario", "Junho"],
                datasets: [{
                    label: "Quartos ocupados",
                    data: [randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor()],
                }]
            },
            options: {
                responsive: true,
                title: {
                    display: true, text: 'Ocupação do Hotel'
                },
            }
        };
        $.each(config3.data.datasets, function (i, dataset) {
            dataset.backgroundColor = randomColor(0.5);
        });


        //CHART 4
        var config4 = {
            type: 'line',
            data: {
                labels: ["Janeiro", "Fevereiro", "Março", "Abril", "Mario", "Junho"],
                datasets: [{
                    label: "Valores (R$)",
                    data: [randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor(), randomScalingFactor()],
                }]
            },
            options: {
                responsive: true,
                title: {
                    display: true, text: 'Movimentação da Conta'
                },
            }
        };
        $.each(config4.data.datasets, function (i, dataset) {
            dataset.backgroundColor = randomColor(0.5);
        });


        window.onload = function () {
            var ctx = document.getElementById("canvas1").getContext("2d");
            window.myLine = new Chart(ctx, config1);

            var ctx = document.getElementById("canvas2").getContext("2d");
            window.myLine = new Chart(ctx, config2);

            var ctx = document.getElementById("canvas3").getContext("2d");
            window.myLine = new Chart(ctx, config3);

            var ctx = document.getElementById("canvas4").getContext("2d");
            window.myLine = new Chart(ctx, config4);
        };



    </script>


</asp:Content>
