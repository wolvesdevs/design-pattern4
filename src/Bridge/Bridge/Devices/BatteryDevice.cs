using Bridge.Measures;
using System;

namespace Bridge.Devices
{
    public sealed class BatteryDevice : Device
    {
        private Random _random = new Random();

        public BatteryDevice(IMeasure measure) : base(measure)
        {
        }

        public string GetBatteryLeval()
        {
            return _random.Next(0, 100) + "%";
        }
    }
}
