using System;

namespace AbaxOppgave
{
    class Program
    {
        static void Main(string[] args)
        {           
            var bil1 = new Bil("NF123456", 147, 200, "grønn", Transportmiddeltype.LettKjøretøy);
            bil1.Print();
            bil1.Kjør();
            Console.WriteLine();
            var bil2 = new Bil("NF654321", 150, 195, "blå", Transportmiddeltype.LettKjøretøy);
            bil2.Print();

            var fly1 = new Fly("LN1234", 1000, 30, 2000, 10000, Transportmiddeltype.Jetfly);
            fly1.Print();
            fly1.StartFly();

            var båt1 = new Båt("ABC123", 30, 100, 500);
            båt1.Print();
          
        }
    }
}
