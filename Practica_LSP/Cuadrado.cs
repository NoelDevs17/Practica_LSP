

namespace Practica_LSP
{
    public class Cuadrado : FiguraGeometrica
    {
        private double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public override double CalcularAreaBase()
        {
            return lado * lado; // Área correcta de un cuadrado
        }
    }


}
