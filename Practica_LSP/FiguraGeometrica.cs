

namespace Practica_LSP
{
    public abstract class FiguraGeometrica
    {
        public abstract double CalcularAreaBase();

        public double CalcularArea()
        {
            return CalcularAreaBase();
        }
    }
}
