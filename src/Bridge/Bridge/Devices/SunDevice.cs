using Bridge.Measures;

namespace Bridge.Devices
{
    public sealed class SunDevice : Device
    {
        private Random _random = new Random();

        public SunDevice(IMeasure measure) : base(measure)
        {
        }

        public override string GetBatteryLeval()
        {
            return "--";
        }

        public override string GetSunLeval()
        {
            return _random.Next(0, 100) + "kWh";
        }

        protected override string GetDeviceName()
        {
            return "太陽光";
        }
    }
}
