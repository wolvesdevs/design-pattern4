namespace Bridge.Devices
{
    public sealed class BatteryDevice : Device
    {
        private Random _random = new Random();

        public string GetBatteryLeval()
        {
            return _random.Next(0, 100) + "%";
        }

        public override string GetName()
        {
            throw new NotImplementedException();
        }

        public override string GetMeasure()
        {
            throw new NotImplementedException();
        }
    }
}
