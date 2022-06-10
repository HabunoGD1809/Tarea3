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
          
                  \_______/
              `.,-'\_____/`-.,'
               /`..'\ _ /`.,'\
              /  /`.,' `.,'\  \
             /__/__/     \__\__\__
             \  \  \     /  /  /
              \  \,'`._,'`./  /
               \,'`./___\,'`./
              ,'`-./_____\,-'`.
                  /       \

            Elija la opción deseada

         1. Multiplicar 2 numeros
         2. Promedio de dos numeros
         3. Encontrar la hipotenusa de un triangulo
         4. Encontrar el cateto opuesto de un triangulo
         5. Encontrar el area de un triangulo
         6. Calcular ecuacion cuadratica
         7. Cantidad de caracteres de una cadena
         8. Viaje en metro
         9. Calculador de hamburgesas
         10. Conversor a dolares
         11. Numero y mostrar: la mitad, el cuadrado, el doble
         12. Calculo de energía
         13. Calcula tu edad
         14. Calcula la temperatura
         15. Calculadora de gasto de combustible
         16. Video
         17. Acerca de mi
         18. Salir
         ");

         int.TryParse(Console.ReadLine(), out opcion);
         
         switch (opcion)
         {
                  case 1:
                           programas.multiplicador();
                           break;
                  case 2:
                           programas.promedio();
                           break;
                  case 3:
                           programas.hipotenusa();
                           break;
                  case 4:
                           programas.catetOpuesto();
                           break;   
                  case 5:
                           programas.areaTriangulo();   
                           break;
                  case 6:
                           programas.ecuacionCuadratica();
                           break;
                  case 7:
                           programas.cantidadCaracteres();
                           break;
                  case 8:
                           programas.viajeMetro();
                           break;
                  case 9:
                           programas.hamburgesas();
                           break;
                  case 10:
                           programas.conversorDolares();
                           break;
                  case 11:
                           programas.mitadCuadroDoble();
                           break;
                  case 12:
                           programas.calculoEnergia();
                           break;
                  case 13:
                           programas.calculoEdad();
                           break;
                  case 14:
                           programas.calculoTemperatura();
                           break;
                  case 15:
                           programas.calculoCombustible();
                           break;
                  case 16:
                           programas.videoExplicativo();
                           break;
                  case 17:
                           acercame.acerca();
                           break;
                  case 18:
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



