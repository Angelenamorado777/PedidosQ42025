
public class Electronico : Producto
{
    public int GarantiaMeses { get; set; }
<<<<<<< Updated upstream
    public string? Voltaje { get; set; }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Garantía: {GarantiaMeses} meses");
        Console.WriteLine($"Voltaje: {Voltaje}");
        Console.WriteLine();
=======

    public string? Voltaje { get; set; }

    public override void MostrarInformacion ()

    {
        base.MostrarInformacion();
        Console.WriteLine($"Garantia: {GarantiaMeses} meses");
        Console.WriteLine($"Voltaje: {Voltaje}");
        
>>>>>>> Stashed changes
    }
}