using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Movimentation
{
    public int MovId { get; set; }

    public List<MovimentationType> MovimentationType { get; set; }

    public DateTime DataInicial { get; set; }

    public DateTime DataFinal { get; set; }

    public Movimentation()
    {
        MovimentationType = new List<MovimentationType>();
    }
}
