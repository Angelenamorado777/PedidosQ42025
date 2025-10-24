
public class Libro : Producto
{
<<<<<<< Updated upstream
<<<<<<< Updated upstream
    public string? ISBN { get; set; }
    public string? Autor { get; set; }
=======
=======
>>>>>>> Stashed changes

    public string? ISBN { get; set; }

    public string? Autor { get; set; }

<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    public int NumeroPaginas { get; set; }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Autor: {Autor}");
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        Console.WriteLine($"Numero de Páginas: {NumeroPaginas}");
        Console.WriteLine();
=======
        Console.WriteLine($"NumeroPaginas: {NumeroPaginas}");
>>>>>>> Stashed changes
=======
        Console.WriteLine($"NumeroPaginas: {NumeroPaginas}");
>>>>>>> Stashed changes
    }
}