   while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1.- Comparacion de cadenas");
    Console.WriteLine("2.- Concatenacion de cadenas");
    Console.WriteLine("3.- Buscar patron en la cadena de texto");
    Console.WriteLine("4.- Formatear una cadena");
    Console.WriteLine("0.- Salir");

    Console.Write("Ingrese una opción de las mostradas:");
    int opc;
    if (int.TryParse(Console.ReadLine(), out opc))
    {
        switch (opc)
        {
            case 1:
                string caden1, caden2;
                do
                {
                    Console.WriteLine("\nIngresa una cadena de texto:");
                    caden1 = Console.ReadLine();

                    Console.WriteLine("\nIngresa una segunda cadena para conparar");
                    caden2 = Console.ReadLine();

                    if (caden1 != caden2)
                    {
                        Console.WriteLine("\nLas cadenas no son iguales");
                    }
                } while (caden1 != caden2);

                Console.WriteLine("\nLas cadenas son iguales");
                break;

            case 2:
                Console.WriteLine("\nIngresa la primera cadena: ");
                string text1 = Console.ReadLine();

                Console.WriteLine("\nIngresa la segunda cadena: ");
                string text2 = Console.ReadLine();

                string concaten = text1 + text2;
                Console.WriteLine("\nLa concatenacion: " + concaten);
                break;

            case 3:
                Console.WriteLine("\nIngrese el texto: ");
                string text = Console.ReadLine();

                Console.WriteLine("\nIngrese el patron:");
                string patr = Console.ReadLine();

                int contar = 0;
                int find = text.IndexOf(patr);

                while (find != -1)
                {
                    contar++;
                    find = text.IndexOf(patr, find + 1);
                }

                if (contar > 0)
                {
                    Console.WriteLine($"El patron '{patr}' se encontro {contar} veces en el texto.");
                }
                else
                {
                    Console.WriteLine($"El patron '{patr}' no se encontro.");
                }
                break;

            case 4:
                Console.WriteLine("\nIngresa tu nombre:");
                string name = Console.ReadLine();

                Console.WriteLine("\nIngresa tu edad:");
                int age = Convert.ToInt32(Console.ReadLine());

                string mensaj = string.Format("\nMi nombre es {0} y tengo {1} años.", name, age);
                Console.WriteLine(mensaj);
                break;

            case 0:
                
                Console.WriteLine("Salio del programa ");
                return;
            default:
                Console.WriteLine("Por favor seleccione una opcion valida.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Por favor solo numeros: ");
    }
}






   while (true)
{
    Console.Write("Ingrese un numero entero positivo: ");
    string input = Console.ReadLine();

    int number;
    if (!int.TryParse(input, out number) || number < 0)
    {
        Console.WriteLine("Ingresar solo numeros positivos. ");
        continue;
    }

    if (number == 0)
    {
        Console.WriteLine("No se puede ninguna operación con 0. ");
        continue;
    }

    Console.WriteLine("Menu.");
    Console.WriteLine("1.- Calcular el factorial");
    Console.WriteLine("2.- Calcula la raiz cuadrada ");
    Console.WriteLine("3.- Salir del programa");
    Console.Write("Seleccione una: ");

    string option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine($"El factorial es: {Factorial(number)}");
            break;
        case "2":
            Console.WriteLine($"La raiz cuadrada es: {Math.Sqrt(number)}");
            break;
        case "3":
            Console.WriteLine("Saliendo del programa.");
            return;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}
    

    static int Factorial(int nu)
{
    if (nu == 0)
        return 1;
    return nu * Factorial(nu - 1);

}







int number1, number2;
char operac;

Console.Write("Ingresa el primer entero ");
number1 = int.Parse(Console.ReadLine());

Console.Write("Ingresa el segundo entero ");
number2 = int.Parse(Console.ReadLine());

Console.Write("Ingresa un operador matematico: ");
operac = char.Parse(Console.ReadLine());

double resul = 0;

switch (operac)
{
    case '+':
        resul = number1 + number2;
        break;
    case '-':
        resul = number1 - number2;
        break;
    case '*':
        resul = number1 * number2;
        break;
    case '/':
        if (number2 != 0)
        {
            resul = (double)number1 / number2;
        }
        else
        {
            Console.WriteLine("Error.");
            return;
        }
        break;
    default:
        Console.WriteLine("Valido");
        return;
}

Console.WriteLine($"El resultado es: {resul}");









Console.Write("Ingresa el numero de la tabla de multiplicar que desee: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"La tabla de multiplicar del {num} escogido es:");
for (int o = 1; o <= 10; o++)
{
    int tab = num * o;
    Console.WriteLine($"{num} x {o} = {tab}");
}






 

Random random = new Random();
int secret = random.Next(1, 101);
int intent = 0;
int numer;

Console.WriteLine("\n Adivina el numero secreto ");
Console.WriteLine("El numero se encuentra entre el 1 y el 100 ;)");

while (true)
{
    Console.Write("\nIngresa el numero que crees que es el correcto: ");
    if (!int.TryParse(Console.ReadLine(), out numer))
    {
        Console.WriteLine("Solo numeros. ");
        continue;
    }

    intent++;

    if (numer < secret)
    {
        Console.WriteLine("El numero es mayor");
    }
    else if (numer > secret)
    {
        Console.WriteLine("El numero es menor");
    }
    else
    {
        Console.WriteLine($"\nEl numero secreto:'{secret}'  lo has logrado en:'{intent}' intentos.");
        break;
    }
}

