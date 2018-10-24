using System.Collections.Generic;

namespace AbaxOppgave
{
    public class Transportmiddel
    {
        public string Kjennetegn { get; }
        public decimal? Maksimalfart { get; }
        public decimal Effekt { get; }
        public Transportmiddeltype? Type { get; }

        protected Dictionary<string, string> Enheter = new Dictionary<string, string>
        {
            {nameof(Maksimalfart), "kmt/t"},
            {nameof(Effekt), "kw"},
        };

        protected Transportmiddel(string kjennetegn, decimal maksimalfart, decimal effekt, Transportmiddeltype? type)
        {
            Kjennetegn = kjennetegn;
            Maksimalfart = maksimalfart;
            Effekt = effekt;
            Type = type;
        }
    }
}
