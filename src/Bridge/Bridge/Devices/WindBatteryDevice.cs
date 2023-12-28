namespace Bridge.Devices
{
    public sealed class WindBatteryDevice : Device
    {
        private Random _random = new Random();

        public override string GetName() => "風力バッテリー";

        public override string GetMeasure()
        {
            return File.ReadAllText("wind.txt") + "m/s";
        }

        public string GetBatteryLeval()
        {
            return _random.Next(0, 100) + "%";
        }
    }
}
