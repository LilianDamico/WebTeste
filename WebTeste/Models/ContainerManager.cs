using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class ContainerManager
{
    public int ContainerId { get; set; }

    [Required]
    public string Cliente { get; set; }
    private string containerIdentity;

    [Required]
    public string ContainerIdentity
    {
        get { return containerIdentity; }
        set
        {
            if (Regex.IsMatch(value, @"^[A-Za-z]{4}\d{7}$"))
            {
                containerIdentity = value;
            }
            else
            {
                throw new ArgumentException("O identificador do contêiner deve ter 4 letras seguidas por 7 números.");
            }
        }
    }

    [Required]
    public string BillOfLading { get; set; }

    [Required]
    public string ContainerType { get; set; }

    [Required]
    public bool IsStuffed { get; set; }

    [Required]
    public bool IsExport { get; set; }
}
