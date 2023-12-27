namespace Bridge.Devices
{
    public abstract class Device
    {
        private Random _random = new Random();
        public abstract string GetName();
        public abstract string GetMeasure();

        public string GetKando()
        {
            return _random.Next(0, 100) + "db";
        }
    }
}
