using System.Text;

namespace AbaxOppgave
{
    public class Båt : Transportmiddel
    {
       public decimal Bruttotonnasje { get; }

        public Båt(string kjennetegn, decimal? maksimalfart, decimal effekt, decimal bruttotonnasje) 
            : base(kjennetegn, maksimalfart, effekt, null)
        {
            Bruttotonnasje = bruttotonnasje;
            Enheter.Add(nameof(bruttotonnasje), "kg");
            Enheter[nameof(Maksimalfart)] = "knop";
        }

        public override void ToStringOptional(StringBuilder text)
        {
            Add(text, nameof(Bruttotonnasje), Bruttotonnasje);
        }
    }
}
