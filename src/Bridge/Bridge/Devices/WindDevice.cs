namespace Bridge.Devices
{
    public sealed class WindDevice : Device
    {
        public override string GetName() => "風力";

        public override string GetMeasure()
        {
            return File.ReadAllText("wind.txt") + "m/s";
        }
    }
}
