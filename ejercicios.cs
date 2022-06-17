class programas
{
    public static void typetriangle()
    {

        Console.Clear();

        Console.WriteLine(@"
                  
                  Bienvenido al programa para determinar el 
                   tipo de triángulo en función de sus lados 
                            ____
                           ||""||
                           ||__||
                           [ -=.]
                           ====== 0
                  ");

        var lado1 = function.Conversor("Por favor introduzca el lado 1: ");
        var lado2 = function.Conversor("Ahora introduzca el lado 2: ");
        var lado3 = function.Conversor("Por ultimo introduzca el lado 3: ");


        if (lado1 == lado2 ^ lado1 == lado2 ^ lado2 == lado3)
        {
            Console.WriteLine($"{Environment.NewLine}El Triangulo Es Equilatero");
        }
        else if ((lado1 != lado2) ^ (lado1 != lado3) ^ (lado2 != lado3))
        {
            Console.WriteLine($"{Environment.NewLine}El Triangulo es Escaleno");
        }
        else
        {
            Console.WriteLine($"{Environment.NewLine}El Triangulo Es Isoseles");
        }

        function.Salir();
    }


    public static void TipoDeTriangulo()
    {
        Console.Clear();

        Console.WriteLine(@"
                  
                  Tipos de Triangulos 
                            ____
                           ||""||
                           ||__||
                           [ -=.]
                           ====== 0
                  ");

        var valor1 = function.Conversor("Ingrese el angulo 1: ");
        var valor2 = function.Conversor("Ingrese el angulo 2: ");
        var valor3 = function.Conversor("Ingrese el angulo 3: ");

        if (valor1 == 90 && valor2 < 90 && valor3 < 90 || valor2 == 90 && valor1 < 90 && valor3 < 90 
        || valor3 == 90 && valor2 < 90 && valor1 < 90)
        {
            Console.WriteLine($"{Environment.NewLine}El triangulo es Rect\u00E1ngulo");
        }
        else
        {
            if (valor1 < 90 && valor2 < 90 && valor3 < 90)

            {
                Console.WriteLine($"{Environment.NewLine}El triangulo es Acut\u00E1ngulo");
            }

            else
            {
                if (valor1 > 90 && valor2 < 90 && valor3 < 90 || valor2 > 90 && valor1 < 90 && valor3 < 90 || valor3 > 90 && valor1 < 90 && valor2 < 90)
                {
                    Console.WriteLine($"{Environment.NewLine}El triangulo es Obtus\u00E1ngulo");
                }
            }

        }

        function.Salir();

    }
    public static void tablaMultiplicar()
    {
        Console.Clear();

        Console.WriteLine(@"
                  
                  Calcula la tabla de multiplicar 
                            ____
                           ||""||
                           ||__||
                           [ -=.]
                           ====== 0
                  ");

        var factor = function.Conversor("Ingrese un numero: ");

        Console.WriteLine();

        for (int i = 1; i <= 12; i++)
        {
            Console.Write(factor + " x " + i + " = " + i * factor + $"{Environment.NewLine}");
        }

        function.Salir();

    }
    public static void cuadrado()
    {
        Console.Clear();

        Console.WriteLine(@"
                  
                  Determinar si la figura es un cuadrado
                            ____
                           ||""||
                           ||__||
                           [ -=.]
                           ====== 0
                  ");

        var angulo1 = function.Conversor("Ingrese el lado 1: ");
        var angulo2 = function.Conversor("Ingrese el lado 2: ");
        var angulo3 = function.Conversor("Ingrese el lado 3: ");
        var angulo4 = function.Conversor("Ingrese el lado 4: ");

        if (angulo1 == angulo2 && angulo3 == angulo4 && angulo1 == angulo3 
            && angulo1 == angulo4 && angulo2 == angulo3 && angulo2 == angulo4)
        {
            Console.WriteLine($"La figura es un cuadrado");
        }
        else
        {
            Console.WriteLine("la figura no es un cuadrado");
        }

        function.Salir();

    }
    public static void ingresaNumero()
    {
        Console.Clear();

        Console.WriteLine(@"
                  
                  Determinar si la figura es un cuadrado
                            ____
                           ||""||
                           ||__||
                           [ -=.]
                           ====== 0
                  ");

        var angulo1 = function.Conversor("Ingrese el lado 1: ");
        var angulo2 = function.Conversor("Ingrese el lado 2: ");
        var angulo3 = function.Conversor("Ingrese el lado 3: ");
        var angulo4 = function.Conversor("Ingrese el lado 4: ");

        if (angulo1 == angulo2 && angulo3 == angulo4 && angulo1
            == angulo3 && angulo1 == angulo4 && angulo2 == angulo3 && angulo2 == angulo4)
        {
            Console.WriteLine($"{Environment.NewLine} La figura es un cuadrado");
        }
        else
        {
            Console.WriteLine($"{Environment.NewLine} La figura no es un cuadrado");
        }

        function.Salir();

    }
}