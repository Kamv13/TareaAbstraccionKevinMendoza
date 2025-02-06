﻿
namespace TareaAbstraccionKevinMendoza
{
    internal class Tiempo : FormulaMatematica
    {
        public double distancia;
        public double velocidad;
        public override double calcular()
        {
            return distancia / velocidad;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El tiempo que tomo el objeto es {calcular()}s");
        }
    }
}
