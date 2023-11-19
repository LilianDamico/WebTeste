using System;
using System.Collections.Generic;

public class Movimentation
{
    public int MovId { get; set; }
    public List<MovimentationTypeEnum> MovimentationType { get; set; }
    public DateTime DataInicial { get; set; }
    public DateTime DataFinal { get; set; }

    public Movimentation()
    {
        MovimentationType = new List<MovimentationTypeEnum>();
    }
}
