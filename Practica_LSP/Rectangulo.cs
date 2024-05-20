

namespace Practica_LSP
{
    public class Rectangulo : FiguraGeometrica
    {
        private double baseRectangulo;
        private double alturaRectangulo;

        public Rectangulo(double baseRectangulo, double alturaRectangulo)
        {
            this.baseRectangulo = baseRectangulo;
            this.alturaRectangulo = alturaRectangulo;
        }

        public override double CalcularAreaBase()
        {
            return baseRectangulo * alturaRectangulo;
        }
    }

}
