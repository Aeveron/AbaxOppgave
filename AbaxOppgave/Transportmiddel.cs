namespace AbaxOppgave
{
    public class Transportmiddel
    {
        protected Transportmiddel(string kjennetegn, decimal maksimalfart, decimal effekt, Transportmiddeltype transportmiddeltype)
        {
            
        }

        public string Kjennetegn { get; }
        public decimal? Maksimalfart { get; }
        public decimal Effekt { get; }
        public Transportmiddeltype? Type { get; }
    }
}
