namespace Bridge.Devices
{
    public sealed class TempDevice : Device
    {
        public override string GetName() => "温度";

        public override string GetMeasure()
        {
            return File.ReadAllText("temp.txt") + "℃";
        }
    }
}
