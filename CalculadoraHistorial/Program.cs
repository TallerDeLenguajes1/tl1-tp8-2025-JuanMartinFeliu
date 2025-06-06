using System;
using CALCULADORA;

class Program
{
    static void Main()
    {
        Calculadora calc = new Calculadora();
        int decidir = 1;

        while (decidir != 0)
        {
            Console.WriteLine("-----CALCULADORA-----");
            Console.WriteLine("1-Suma");
            Console.WriteLine("2-Resta");
            Console.WriteLine("3-Multiplicacion");
            Console.WriteLine("4-Division");
            Console.WriteLine("5-Limpiar");
            Console.WriteLine("6-Ver Historial");
            Console.WriteLine("0-Salir");
            Console.Write("Ingrese la operacion que desea realizar: ");
            decidir = Convert.ToInt32(Console.ReadLine());

            switch (decidir)
            {
                case 1:
                    Funcion_Sumar(calc);
                    break;
                case 2:
                    Funcion_Restar(calc);
                    break;
                case 3:
                    Funcion_Multiplicar(calc);
                    break;
                case 4:
                    Funcion_Dividir(calc);
                    break;
                case 5:
                    calc.AplicarOperacion(0, TipoOperacion.Limpiar);
                    Console.WriteLine("Calculadora reiniciada.");
                    break;
                case 6:
                    MostrarHistorial(calc);
                    break;
                case 0:
                    Console.WriteLine("Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void Funcion_Sumar(Calculadora calc)
    {
        Console.Write("Ingrese el número a sumar: ");
        double valor = Convert.ToDouble(Console.ReadLine());
        calc.AplicarOperacion(valor, TipoOperacion.Suma);
        Console.WriteLine("Resultado actual: " + calc.ResultadoActual);
    }

    static void Funcion_Restar(Calculadora calc)
    {
        Console.Write("Ingrese el número a restar: ");
        double valor = Convert.ToDouble(Console.ReadLine());
        calc.AplicarOperacion(valor, TipoOperacion.Resta);
        Console.WriteLine("Resultado actual: " + calc.ResultadoActual);
    }

    static void Funcion_Multiplicar(Calculadora calc)
    {
        Console.Write("Ingrese el número a multiplicar: ");
        double valor = Convert.ToDouble(Console.ReadLine());
        calc.AplicarOperacion(valor, TipoOperacion.Multiplicacion);
        Console.WriteLine("Resultado actual: " + calc.ResultadoActual);
    }

    static void Funcion_Dividir(Calculadora calc)
    {
        Console.Write("Ingrese el número a dividir: ");
        double valor = Convert.ToDouble(Console.ReadLine());
        if (valor == 0)
        {
            Console.WriteLine("Error: no se puede dividir por cero.");
        }
        else
        {
            calc.AplicarOperacion(valor, TipoOperacion.Division);
            Console.WriteLine("Resultado actual: " + calc.ResultadoActual);
        }
    }

    static void MostrarHistorial(Calculadora calc)
    {
        Console.WriteLine("Historial de operaciones:");
        foreach (var op in calc.ObtenerHistorial())
        {
            Console.WriteLine($"{op.Resultado} = ({op.NuevoValor})");
        }
    }
}




