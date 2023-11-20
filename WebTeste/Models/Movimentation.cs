using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Movimentation
{
    public int MovId { get; set; }

    [Required]
    public List<MovimentationTypeEnum> MovimentationType { get; set; }

    [Required]
    public DateTime DataInicial { get; set; }

    [Required]
    public DateTime DataFinal { get; set; }

    [Required]
    public Movimentation()
    {
        MovimentationType = new List<MovimentationTypeEnum>();
    }
}
