using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero que se le va a sumar 50");
            int ingreso = Convert.ToInt32(Console.ReadLine());
            const int n= 50;
            int suma = ingreso + n;
            Console.WriteLine($"La suma da: {suma}");
            Console.ReadLine();
        }
    }
}
