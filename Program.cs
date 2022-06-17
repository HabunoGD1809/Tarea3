int opcion = 0;
bool continuar = false;

while (continuar == false)
{
        Console.Clear();

        Console.WriteLine(@"
                            ╔══╗                   ╔╗
                            ║╔╗║                   ║║
                            ║╚╝╚╦╦══╦═╗╔╗╔╦══╦═╗╔╦═╝╠══╗
                            ║╔═╗╠╣║═╣╔╗╣╚╝║║═╣╔╗╬╣╔╗║╔╗║
                            ║╚═╝║║║═╣║║╠╗╔╣║═╣║║║║╚╝║╚╝║  
                            ╚═══╩╩══╩╝╚╝╚╝╚══╩╝╚╩╩══╩══╝
          
             ______            ______            ______
            /\_____\          /\_____\          /\_____\          ____
           _\ \__/_/_         \ \__/_/_         \ \__/_/         /\___\
          /\_\ \_____\        /\ \_____\        /\ \___\        /\ \___\
          \ \ \/ / / /        \ \/ / / /        \ \/ / /        \ \/ / /
           \ \/ /\/ /          \/_/\/ /          \/_/_/          \/_/_/
            \/_/\/_/              \/_/

                              Elija la opción deseada

         1. Determinar si el triangulo es: Equilatero, Isósceles o Escaleno
         2. Determinar si el triangulo es: Rectángulo, Acutángulo u Obtusángulo
         3. Ingrese las medidas para determinar si la figura es un cuadrado 
         4. Tabla de multiplicar de un numero. 
         5. Ingresa un numero y veras :D
         6. Acerca de mi
         7. Salir
         ");

         int.TryParse(Console.ReadLine(), out opcion);
         
         switch (opcion)
         {
                  case 1:
                           programas.Typetriangle();
                           break;
                  case 2:
                           programas.TipoDeTriangulo();
                           break;
                  case 3:
                           programas.Cuadrado();
                           break;
                  case 4:
                           programas.TablaMultiplicar();
                           break;
                  case 5:
                           //json.response();
                           break;
                  case 6:
                           acercame.acerca();
                           break;
                  case 7:
                           Console.Clear();
                           Console.WriteLine(@"
            Hasta la proxima");
                            continuar = true;
                            break;
                  default:
                           Console.Clear();
                           Console.WriteLine(@"
            Ingrese una opcion valida");
                            function.Salir();
                            break;
                           
         }

}



