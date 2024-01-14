using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuOpcionesEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE Y RECONOCIDO");
            int a = 10, b = 2;
            //Variable que va a guardar la opcion del menu
            OpcionesMenu opcion;

            Console.Write("Elige una opcion:  ");
            opcion = (OpcionesMenu)Enum.Parse(typeof(OpcionesMenu), Console.ReadLine());

            switch(opcion) 
            {
                case OpcionesMenu.Suma:
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;

                case OpcionesMenu.Resta:
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case OpcionesMenu.Multiplicacion:
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case OpcionesMenu.Division:
                    Console.WriteLine($"{a} /{b} = {a / b}");
                    break;


            }


            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");



        }
    }
    enum OpcionesMenu
    {
        Suma,
        Resta,
        Multiplicacion,
        Division
    }
}
