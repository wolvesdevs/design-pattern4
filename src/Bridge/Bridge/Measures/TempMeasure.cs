namespace Bridge.Measures
{
    public sealed class TempMeasure : IMeasure
    {
        public string GetName() => "温度";

        public string GetMeasure()
        {
            return File.ReadAllText("temp.txt") + "℃";
        }
    }
}
