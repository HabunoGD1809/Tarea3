class function
{
        public static double Conversor(string mensaje){
                  double num = 0; 
                  
                  try
                  {
                      Console.Write(mensaje);
                      num = double.Parse(Console.ReadLine()?? "0");
                  }
                  catch (Exception){
                      Console.WriteLine("Digite un numero valido");
                      num = Conversor(mensaje);
                  }
                    return num;
         }

        public static void Salir(){
                    Console.WriteLine($"{Environment.NewLine}Pulse cualquier tecla para volver al menu principal");
                    Console.ReadKey();
            }
}