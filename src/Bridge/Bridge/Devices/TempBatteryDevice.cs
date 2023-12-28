namespace Bridge.Devices
{
    public sealed class TempBatteryDevice : Device
    {
        private Random _random = new Random();

        public override string GetName() => "温度バッテリー";

        public override string GetMeasure()
        {
            return File.ReadAllText("temp.txt") + "℃";
        }

        public string GetBatteryLeval()
        {
            return _random.Next(0, 100) + "%";
        }
    }
}
