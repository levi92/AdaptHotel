using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Reserva
{
    private int codReserva;
    private enum _statusReserva {agendada, andamento, finalizada, cancelada, noshow};
    private DateTime dataReservaEntrada, dataReservaSaida, dataCheckin, dataCheckout;
    private bool pago; 
    private double valorTotal;
    private Hospede hospede;
    private _statusReserva statusReserva;
    private List<NumeroQuarto> listaNumeroQuarto = new List<NumeroQuarto>();

    public Reserva(int codReserva, DateTime dataReservaEntrada, DateTime dataReservaSaida, DateTime dataCheckin, DateTime dataCheckout, double valorTotal, bool pago, Hospede hospede, string statusReserva, List<NumeroQuarto> listaNumeroQuarto)
    {
        this.codReserva = codReserva;
        this.dataReservaEntrada = dataReservaEntrada.Date;
        this.dataReservaSaida = dataReservaSaida.Date;
        this.dataCheckin = dataCheckin;
        this.dataCheckout = dataCheckout;
        this.valorTotal = valorTotal;
        this.pago=pago;
        this.hospede = hospede;
        this.statusReserva = (_statusReserva)Enum.Parse(typeof(_statusReserva), statusReserva);
        this.listaNumeroQuarto = listaNumeroQuarto;
    }

    public Reserva(Hospede hospede, DateTime dataReservaEntrada, DateTime dataReservaSaida)
    {
        this.hospede = hospede;
        this.dataReservaEntrada = dataReservaEntrada.Date;
        this.dataReservaSaida = dataReservaSaida.Date;
    }

    public bool Pago 
    {
        get { return pago; }
        set { pago = value; }
    }

    public double ValorTotal
    {
        get { return valorTotal; }
        set { valorTotal = value; }
    }

    public DateTime DataCheckout
    {
        get { return dataCheckout; }
        set { dataCheckout = value; }
    }

    public DateTime DataCheckin
    {
        get { return dataCheckin; }
        set { dataCheckin = value; }
    }

    public string getDataReservaEntrada()
    {
        return dataReservaEntrada.ToString("d");
    }

    public void setDataReservaEntrada(DateTime dataReservaEntrada)
    {
        this.dataReservaEntrada = dataReservaEntrada;
    }

    public string getDataReservaSaida()
    {
        return dataReservaSaida.ToString("d");
    }

    public void setDataReservaSaida(DateTime dataReservaSaida)
    {
        this.dataReservaSaida = dataReservaSaida;
    }

    public Hospede Hospede
    {
        get { return hospede; }
        set { hospede = value; }
    }

    public int CodReserva
    {
        get { return codReserva; }
        set { codReserva = value; }
    }

    public List<NumeroQuarto> ListaNumeroQuarto
    {
        get { return listaNumeroQuarto; }
        set { listaNumeroQuarto = value; }
    }

    public string getStatusReserva()
    {
        return statusReserva.ToString();
    }

    public void setTipo(string statusReserva)
    {
        this.statusReserva = (_statusReserva)Enum.Parse(typeof(_statusReserva), statusReserva);
    }
}