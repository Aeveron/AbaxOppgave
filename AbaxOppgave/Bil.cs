using System;

namespace AbaxOppgave
{
    public class Bil
    {
        private string _regNr;
        private int _effect;
        private int _speed;
        private string _carColor;
        private Transportmiddeltype _VehicleType;

        public Bil(string regNr, int effect, int speed, string carColor, Transportmiddeltype vehicleType)
        {
            _regNr = regNr;
            _effect = effect;
            _speed = speed;
            _carColor = carColor;
            _VehicleType = vehicleType;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
