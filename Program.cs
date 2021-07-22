using System;

namespace CursoC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a C#"); // Esto imprime un mesaje en consola

            //------------------------Concatenacion de Strings------------------------------
            int edad = 19;
            Console.WriteLine("Tu edad es de " + edad +" años"); //Concatenacion Normal
            Console.WriteLine($"Tu edad es de {edad} años"); //Concatenacion interpolada

            //----------------------Conversion de texto a numero------------------------------
            //int.Parse();
            Console.WriteLine("Ingresa el primer valor");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo valor");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Total {num1+num2}");//Comentario
        }
    }
}
