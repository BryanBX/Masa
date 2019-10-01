using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masa
{
    class Program
    {
        static void Main(string[] args)
        {
            double presion, volumen, temperatura, masa;

            Console.WriteLine("Digite la presion");
            presion = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el volumen");
            volumen = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la temperatura");
            temperatura = double.Parse(Console.ReadLine());

            masa = (presion * volumen) / (0.37 * (temperatura + 460));
            Console.WriteLine("La masa es: {0}", masa);
            Console.ReadKey();
        }
    }
}
