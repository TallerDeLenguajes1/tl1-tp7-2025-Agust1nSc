using EspacioCalculadora;

Calculadora calculadora = new Calculadora();

double numero;
int opcion;


do
{
    Console.WriteLine("-----Calculadora------");
    Console.WriteLine("1_Sumar");
    Console.WriteLine("2_Restar");
    Console.WriteLine("3_Multiplicar");
    Console.WriteLine("4_Dividir");
    Console.WriteLine("5_Limpiar");
    Console.WriteLine("6_Salir");

    Console.WriteLine("Ingrese una opcion");
    string entrada2 = Console.ReadLine() ?? "";

    bool control2 = int.TryParse(entrada2, out opcion);

    if (!control2)
    {
        Console.WriteLine("Debe ingresar un número válido para seleccionar una opción.");
        continue;
    }

    Console.WriteLine("Ingrese un numero");
    string entrada = Console.ReadLine() ?? "";

    bool control = double.TryParse(entrada, out numero);

    if (!control)
    {
        Console.WriteLine("Debe ingresar un número válido para calcular.");
        continue;
    }

    switch (opcion)
    {
        case 1:
            calculadora.sumar(numero);
            break;
        case 2:
            calculadora.restar(numero);
            break;
        case 3:
            calculadora.multiplicar(numero);
            break;
        case 4:
            calculadora.dividir(numero);
            break;
        case 5:
            calculadora.limpiar(numero);
            Console.WriteLine("Resultado limpiado.");
            break;
        case 6:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

    Console.WriteLine("Numero resultante: " + calculadora.resultado);

} while (opcion != 6);


