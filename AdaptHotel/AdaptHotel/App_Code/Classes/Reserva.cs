using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Reserva
{
    private enum statusReserva {agendada, andamento, finalizada, cancelada, noshow};
    private DateTime dataReservaEntrada, dataReservaSaida, dataCheckin, dataCheckout;
    private bool pago; 
    private double valorTotal;
    private Hospede hospede;
    // fazer associação


    public Reserva(DateTime dataReservaEntrada, DateTime dataReservaSaida, DateTime dataCheckin, DateTime dataCheckout, double valorTotal, bool pago, Hospede hospede)
    {
        this.dataReservaEntrada = dataReservaEntrada.Date;
        this.dataReservaSaida = dataReservaSaida.Date;
        this.dataCheckin = dataCheckin;
        this.dataCheckout = dataCheckout;
        this.valorTotal = valorTotal;
        this.pago=pago;
        this.hospede = hospede;
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
        get
        {
            return hospede;
        }

        set
        {
            hospede = value;
        }
    }

    public string ImprimirReserva()
    {
        return Hospede.ImprimirHospede()+"DATA RESERVA ENTRADA: " + getDataReservaEntrada() + "DATA RESERVA SAÍDA: " + getDataReservaSaida() + "DATA CHECK-IN: " + DataCheckin + "DATA CHECK-OUT: " + DataCheckout + "VALOR TOTAL: " + ValorTotal + " PAGO: " + Pago;
    }

}