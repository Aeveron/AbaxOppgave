namespace AbaxOppgave
{
    public class Bil
    {
        private string _regNr;
        private string _effect;
        private string _speed;
        private string _carColor;
        private string _VehicleType;

        public Bil(string regNr, string effect, string speed, string carColor, string vehicleType)
        {
            _regNr = regNr;
            _effect = effect;
            _speed = speed;
            _carColor = carColor;
            _VehicleType = vehicleType;
        }

    }
}
