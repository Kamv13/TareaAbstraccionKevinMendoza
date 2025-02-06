

namespace TareaAbstraccionKevinMendoza
{
    public class Velocidad : FormulaMatematica
    {
        public double distancia;
        public double tiempo;
        public override double calcular()
        {
            return distancia * tiempo;
        }
        public override void Imprimir()
        {
          Console.WriteLine($"La velocidad del objeto es de {calcular()}m/s");
        }
    }
}
