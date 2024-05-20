using Practica_LSP;

public class Program
{
    public static void Main(string[] args)
    {
        FiguraGeometrica figura1 = new Cuadrado(5);
        FiguraGeometrica figura2 = new Rectángulo(4, 3);

        Console.WriteLine("Área del cuadrado: " + figura1.CalcularArea()); // imprime 25 (incorrecto)
        Console.WriteLine("Área del rectángulo: " + figura2.CalcularArea()); // imprime 12 (correcto)
    }
}
