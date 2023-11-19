using System;
using System.Text.RegularExpressions;

public class ContainerManager
{
    public int ContainerId { get; set; }
    public string Cliente { get; set; }
    private string containerIdentity;

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

    public string BillOfLading { get; set; }
    public string ContainerType { get; set; }
    public bool IsStuffed { get; set; }
    public bool IsExport { get; set; }
}
