class programas
{
    public static void multiplicador()
    {

        Console.Clear();

        Console.WriteLine(@"
                  
                  Multiplca dos numeros 
                            ____
                           ||""||
                           ||__||
                           [ -=.]
                           ====== 0
                  ");

        var num1 = function.Conversor("Digite el primer numero: ");
        var num2 = function.Conversor("Digite el segundo numero: ");

        Console.WriteLine($"{Environment.NewLine}El resultado es: {num1 * num2}{Environment.NewLine}");
        function.Salir();

    }
    public static void promedio()
    {
        Console.Clear();

        Console.WriteLine(@"
                  
                  Promedio de dos numeros 
                            ____
                           ||""||
                           ||__||
                           [ -=.]
                           ====== 0
                  ");

        var num1 = function.Conversor("Digite el primer numero: ");
        var num2 = function.Conversor("Digite el segundo numero: ");

        Console.WriteLine($"{Environment.NewLine}El promedio es: {(num1 + num2) / 2}{Environment.NewLine}");
        function.Salir();

    }
    public static void hipotenusa()
    {
        Console.Clear();

        Console.WriteLine(@"
                  
                  Hipotenusa de un triangulo 
                            ____
                           ||""||
                           ||__||
                           [ -=.]
                           ====== 0
                  ");

        var cateto1 = function.Conversor("Digite el primer cateto: ");
        var cateto2 = function.Conversor("Digite el segundo cateto: ");

        Console.WriteLine($"{Environment.NewLine}La hipotenusa es: {Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2))}{Environment.NewLine}");
        function.Salir();

    }
    public static void catetOpuesto()
    {
        Console.Clear();

        Console.WriteLine(@"
                  
                  Cateto opuesto de un triangulo 
                            ____
                           ||""||
                           ||__||
                           [ -=.]
                           ====== 0
                  ");

        var cateto = function.Conversor("Digite el cateto adyacente: ");
        var hipotenusa = function.Conversor("Digite la hipotenusa: ");

        Console.WriteLine($"{Environment.NewLine}El valor del cateto opuesto es: {Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(cateto, 2))}{Environment.NewLine}");
        function.Salir();

    }
    public static void areaTriangulo()
    {
        Console.Clear();

        Console.WriteLine(@"
                  
                  Area de un triangulo 
                            ____
                           ||""||
                           ||__||
                           [ -=.]
                           ====== 0
                  ");

        var base1 = function.Conversor("Digite la base B: ");
        var altura = function.Conversor("Digite la altura H: ");

        Console.WriteLine($"{Environment.NewLine}El area del triangulo es: {(base1 * altura) / 2}{Environment.NewLine}");
        function.Salir();
    }
    public static void ecuacionCuadratica()
    {

        Console.Clear();
        Console.WriteLine(@"
                  
                  Ecuacion cuadratica 
                            ____
                           ||""||
                           ||__||
                           [ -=.]
                           ====== 0
                  ");

        var a = function.Conversor("Ingrese el valor de A: ");
        var b = function.Conversor("Ingrese el valor de B: ");
        var c = function.Conversor("Ingrese el valor de C: ");

        double x1 = 0, x2 = 0;

        x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;
        x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;

        if (x1 == x2)
        {
            Console.WriteLine($"{Environment.NewLine}Esta ecuacion solo tiene una solucion x1 = {x1}");
        }
        else if (b * b - 4 * a * c < 0)
        {
            Console.WriteLine($"{Environment.NewLine}'La ecuacion no tiene solucion en los numeros reales'");
        }
        else
        {
            Console.WriteLine($"{Environment.NewLine}El valor para x1: {x1} y para x2: {x2}");
        }
        function.Salir();
    }
    public static void cantidadCaracteres()
    {
        Console.Clear();
        Console.WriteLine(@"
                  
                  Cantidad de caracteres 
                            ____
                           ||""||
                           ||__||
                           [ -=.]
                           ====== 0
                  ");

        int contador = 0;

        Console.Write("Ingrese una cadena de texto: ");
        string cadena = Console.ReadLine() ?? "0";

        contador = cadena.Length;

        Console.WriteLine($"{Environment.NewLine}La cantidad de caracteres es: {contador}");
        function.Salir();
    }
    public static void viajeMetro()
    {
        Console.Clear();
        Console.WriteLine(@"
                  
                      Reserva de tickets en tren

                                  &&&&&&&&&
                              &&&
                             &&
                           &  _____ ___________
                           II__|[] | |   I I   |
                          |        |_|_  I I  _|
                         < OO----OOO   OO---OO
                  ");

        const int precioTickets = 35;

        var cantidadDinero = function.Conversor("Ingrese la cantidad de dinero: ");

        if (cantidadDinero < precioTickets)
        {
            Console.WriteLine($"{Environment.NewLine}No tiene suficiente dinero para comprar tickets");
        }
        else
        {

            int cantidadTickets = (int)(cantidadDinero / precioTickets);

            Console.WriteLine($"{Environment.NewLine}La cantidad de tickets reservados es: {cantidadTickets}");
        }
        function.Salir();
    }
    public static void hamburgesas()
    {
        Console.Clear();
        Console.WriteLine(@"
                  
                  Calculador de hamburgesas

                           |\ /| /|_/|
                          |\||-|\||-/|/|
                           \\|\|//||///
          _..----.._       |\/\||//||||
        .'     o    '.     |||\\|/\\ ||
       /   o       o  \    | './\_/.' |
      |o        o     o|   |          |
      /'-.._o     __.-'\   |          |
      \      `````     /   |          |
      |``--........--'`|    '.______.'
       \              /
        `'----------'`                    
         ");

        var cantidadCarne = function.Conversor("Ingrese la cantidad de carne: ");
        var cantidadPanes = function.Conversor("Ingrese la cantidad de panes: ");
        var cantidadTocineta = function.Conversor("Ingrese la cantidad de tocineta: ");

        var maxCarne = (int)(cantidadCarne / 2);
        var maxPanes = (int)(cantidadPanes);
        var maxTocineta = (int)(cantidadTocineta / 0.2);

        var minimoHamburguesas = Math.Min(maxCarne, Math.Min(maxPanes, maxTocineta));

        Console.WriteLine($"{Environment.NewLine}La cantidad de hamburgesas que se pueden hacer es: {minimoHamburguesas}");
        function.Salir();
    }
    public static void conversorDolares()
    {
        Console.Clear();
        Console.WriteLine(@"

         Conversor de dolares a pesos

      
                  ");

        var dolares = function.Conversor("Ingrese taza de dolar actual: ");
        var pesos = function.Conversor("Ingrese la cantidad de pesos a convertir: ");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{Environment.NewLine}La cantidad de pesos convertidos a dolar es: {pesos / dolares}");

        Console.ForegroundColor = ConsoleColor.White;
        function.Salir();
    }
    public static void mitadCuadroDoble()
    {
        Console.Clear();
        Console.WriteLine(@"

                      Mitad, cuadrado y doble de un numero

          
                  ");

        var cantidad = function.Conversor("Ingrese un numero: ");

        var mitad = cantidad / 2;
        var cuadrado = cantidad * cantidad;
        var doble = cantidad * 2;

        Console.Write($@"
                  La mitad del numero es: {mitad}
                  El cuadrado del numero es: {cuadrado}
                  El doble del numero es: {doble}
                  ");

        function.Salir();
    }
    public static void calculoEnergia()
    {

        Console.Clear();
        Console.WriteLine(@"
                  
          Calculo de energia electrica
                    ..---..
                   /       \
                  |         |
                  :         ;
                   \  \~/  /
                    `, Y ,'
                     |_|_|
                     |===|
                     |===|
                      \_/
                   ");

        var kwh = function.Conversor("Ingrese la cantidad de kwh consumidos al mes: ");

        var costoKwh = kwh * 8.21;

        Console.WriteLine($"{Environment.NewLine}El costo total de la energia electrica a pagar es: {costoKwh} pesos");

        function.Salir();


    }
    public static void calculoEdad()
    {
        Console.Clear();

        Console.WriteLine(@"
                  
                           Calcula tu edad
                  
                  ");

        Console.WriteLine("Ingrese su fecha de nacimiento en formato dd/MM/yyyy");
        string fechaNacString = Console.ReadLine() ?? "";
        DateTime fechaNacDate = DateTime.Now;

        try
        {
            fechaNacDate = DateTime.ParseExact(fechaNacString, "dd/MM/yyyy", null);
        }
        catch
        {
            System.Console.WriteLine("Ingrese una fecha en formato dd/MM/yyyy");
        }

        DateTime fechaActual = DateTime.Now;
        TimeSpan diferencia = fechaActual - fechaNacDate;
        double dias = diferencia.TotalDays;
        double anos = Math.Floor((dias / 365));
        Console.WriteLine("Su edad actual es: " + anos);

        function.Salir();

    }
    public static void calculoTemperatura()
    {

        Console.Clear();

        Console.WriteLine(@"
                  
                           Conversor de temperatura
                  de grados Celsius a Kelvin y Fahrenheit
                  
                  ");

        var celsius = function.Conversor("Ingrese la temperatura en grados Celsius: ");

        double kelvin = celsius + 273.15;
        double fahrenheit = celsius * 1.8 + 32;

        Console.WriteLine("La temperatura en Kelvin es: " + kelvin);
        Console.WriteLine("La temperatura en Fahrenheit es: " + fahrenheit);

        function.Salir();
    }
    public static void calculoCombustible()
    {

        Console.Clear();

        Console.WriteLine(@"
                  
                           Calculadora de gasto de combustible
                  
                  ");

        var precioGasolina = function.Conversor("Ingrese el precio de la gasolina: ");
        var distancia = function.Conversor("Ingrese la cantidad de Km a recorrer: ");
        var rendimiento = function.Conversor("Cantidad de Km por galon que hace su carro: ");


        double total = (distancia / rendimiento) * precioGasolina;
 
        Console.WriteLine($"{Environment.NewLine}Gastaras un total de: {total} por el recorrido");

        function.Salir();
    }
    public static void videoExplicativo()
    {
        Console.Clear();

        Console.WriteLine(@"
                  
                      Como obtener la hipotenusa de un triangulo rectangulo
                  
                                        ▄███████████▄
                                        █████░▀██████
                                        █████░░░▀████
                                        █████░░░▄████
                                        █████░▄██████
                                        █████████████
                                        ─▀▀▀▀▀▀▀▀▀▀▀─
                  ");

        Console.WriteLine(@"
             Video explicativo en YouTube");

        var uri = "https://youtu.be/0ntkPUXTqqo";
        var psi = new System.Diagnostics.ProcessStartInfo();
        psi.UseShellExecute = true;
        psi.FileName = uri;
        System.Diagnostics.Process.Start(psi);

        function.Salir();
    }
}