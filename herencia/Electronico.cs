
public class Electronico : Producto
{
    public int GarantiaMeses { get; set; }
<<<<<<< Updated upstream
<<<<<<< Updated upstream
    public string? Voltaje { get; set; }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Garantía: {GarantiaMeses} meses");
        Console.WriteLine($"Voltaje: {Voltaje}");
        Console.WriteLine();
=======
=======
>>>>>>> Stashed changes

    public string? Voltaje { get; set; }

    public override void MostrarInformacion ()

    {
        base.MostrarInformacion();
        Console.WriteLine($"Garantia: {GarantiaMeses} meses");
        Console.WriteLine($"Voltaje: {Voltaje}");
        
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }
}