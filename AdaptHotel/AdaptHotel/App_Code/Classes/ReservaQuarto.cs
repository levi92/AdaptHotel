using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class ReservaQuarto
{
    private int codReservaQuarto;
    private Reserva codReserva;
    private NumeroQuarto codNumeroQuarto;


    public ReservaQuarto(int codReservaQuarto, Reserva codReserva, NumeroQuarto codNumeroQuarto)
    {
        this.codReservaQuarto = codReservaQuarto;
        this.codReserva = codReserva;
        this.codNumeroQuarto = codNumeroQuarto;
    }

    public int CodReservaQuarto
    {
        get { return codReservaQuarto; }
        set { codReservaQuarto = value; }
    }

    public Reserva CodReserva
    {
        get { return codReserva; }
        set { codReserva = value; }
    }

    public NumeroQuarto CodNumeroQuarto
    {
        get { return codNumeroQuarto; }
        set { codNumeroQuarto = value; }
    }
}