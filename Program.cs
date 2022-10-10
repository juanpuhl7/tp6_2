using System;

namespace tp6_2
{
    class Program
    {
        static void Main(string[] args)
        {
           //tp 6- punto 2     
           string nombre="", apellido="";


            Console.WriteLine("Ingrese su nombre: ");
            nombre=Console.ReadLine();
            Console.WriteLine("Ingrese su Apellido: ");
            apellido=Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Hola " + nombre + " " + apellido + " , como estas?");
            Console.ReadKey();

        }
    }
}
