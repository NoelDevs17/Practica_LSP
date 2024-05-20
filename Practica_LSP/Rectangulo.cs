

namespace Practica_LSP
{
    public class Rectángulo : FiguraGeometrica
    {
        private double baseRectangulo;
        private double alturaRectangulo;

        public Rectángulo(double baseRectangulo, double alturaRectangulo)
        {
            this.baseRectangulo = baseRectangulo;
            this.alturaRectangulo = alturaRectangulo;
        }

        public override double CalcularArea()
        {
            return baseRectangulo * alturaRectangulo;
        }
    }

}
