using System;

namespace AbaxOppgave
{
    class Program
    {
        static void Main(string[] args)
        {           
            var car1 = new Bil("NF123456", "147kw", "200km/t", "grønn", "lett kjøretøy");
            var car2 = new Bil("NF654321", "150kw", "195km/t", "blå", "lett kjøretøy");

            Console.WriteLine();
        }
    }
}
