

namespace TareaAbstraccionKevinMendoza
{
    internal class Distancia : FormulaMatematica
    {
        public double tiempo;
        public double velocidad;
        public override double calcular()
        {
            return Math.Round(tiempo * velocidad,2);
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El tiempo que tomo el objeto es {calcular()}m");
        }
    }
}
