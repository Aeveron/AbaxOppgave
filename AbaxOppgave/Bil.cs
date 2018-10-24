using System;
using System.Dynamic;

namespace AbaxOppgave
{
    public class Bil : Transportmiddel
    {
      
        private string Farge { get; }

        public Bil(string kjennetegn, decimal maksimalfart, decimal effekt, string farge, Transportmiddeltype transportmiddeltype)
            : base(kjennetegn, maksimalfart, effekt, transportmiddeltype)
        {
            Farge = farge;
        }
  
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
