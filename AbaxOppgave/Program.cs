using System;

namespace AbaxOppgave
{
    class Program
    {
        static void Main(string[] args)
        {           
            var bil1 = new Bil("NF123456", 147, 200, "grønn", Transportmiddeltype.LettKjøretøy);
            bil1.Print();
            var bil2 = new Bil("NF654321", 150, 195, "blå", Transportmiddeltype.LettKjøretøy);

            
        }
    }
}
