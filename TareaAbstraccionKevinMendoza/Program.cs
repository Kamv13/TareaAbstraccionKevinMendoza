
using TareaAbstraccionKevinMendoza;

Console.WriteLine($"Bienvenido a la calculadora de formulas, que desea calcular hoy?");
Console.WriteLine($"1. Calcular velocidad");
Console.WriteLine($"2. Calcular Tiempo");
Console.WriteLine($"3. Calcular Distancia");
int? opc;

opc = Convert.ToInt32(Console.ReadLine());

switch (opc)
{
    case 1:
		Velocidad velocidad = new Velocidad();
		Console.WriteLine($"Porfavor introduzca el tiempo en segundos");
		velocidad.tiempo=Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"Porfavor introduzca la distancia en metros");
		velocidad.distancia=Convert.ToDouble(Console.ReadLine());

		velocidad.calcular();
		velocidad.Imprimir();

	   break;

	case 2:
		Tiempo tiempo = new Tiempo();
        Console.WriteLine($"Porfavor introduzca la distancia en metros");
        tiempo.distancia = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Porfavor introduzca la velocidad");
        tiempo.velocidad = Convert.ToDouble(Console.ReadLine());

		tiempo.calcular();
		tiempo.Imprimir();

		break;
    case 3:
        Distancia distancia = new Distancia();  
        Console.WriteLine($"Porfavor introduzca el tiempo en segundos");
        distancia.tiempo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Porfavor introduzca la velocidad");
        distancia.velocidad = Convert.ToDouble(Console.ReadLine());

        distancia.calcular();
        distancia.Imprimir();

        break;

    default:
		Console.WriteLine($"La opcion no es valida");
		break;
}