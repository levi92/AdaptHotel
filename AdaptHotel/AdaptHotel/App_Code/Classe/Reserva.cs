using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Reserva
{
    private enum statusReserva {disponivel, ocupado, manutencao};
    private DateTime dataReservaEntrada, dataReservaSaida, dataCheckin, dataCheckout;
    private bool pago; 
    private double valorTotal;
    private Hospede hos;
    // fazer associação


    public Reserva(DateTime dataReservaEntrada, DateTime dataReservaSaida, DateTime dataCheckin, DateTime dataCheckout, double valorTotal, bool pago, Hospede hos)
    {
        this.dataReservaEntrada = dataReservaEntrada;
        this.dataReservaSaida = dataReservaSaida;
        this.dataCheckin = dataCheckin;
        this.dataCheckout = dataCheckout;
        this.valorTotal = valorTotal;
        this.pago=pago;
        this.Hos = hos;
        
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

    public DateTime DataReservaSaida
    {
        get { return dataReservaSaida; }
        set { dataReservaSaida = value; }
    }

    public DateTime DataReservaEntrada
    {
        get { return dataReservaEntrada; }
        set { dataReservaEntrada = value; }
    }

    public Hospede Hos
    {
        get
        {
            return hos;
        }

        set
        {
            hos = value;
        }
    }

    public string ImprimirReserva()
    {
        return Hos.ImprimirHospede()+"DATA RESERVA ENTRADA: " + DataReservaEntrada + "DATA RESERVA SAÍDA: " + DataReservaSaida + "DATA CHECK-IN: " + DataCheckin + "DATA CHECK-OUT: " + DataCheckout + "VALOR TOTAL: " + ValorTotal + " PAGO: " + Pago;
    }

}