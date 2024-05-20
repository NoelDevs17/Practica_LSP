

namespace Practica_LSP
{
    public class Cuadrado : FiguraGeometrica
    {
        private double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public override double CalcularArea()
        {
            // area incorrecta, devuelve el area de un rectangulo
            return lado * lado;
        }
    }

}
