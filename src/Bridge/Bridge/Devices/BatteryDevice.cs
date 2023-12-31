﻿using Bridge.Measures;

namespace Bridge.Devices
{
    public sealed class BatteryDevice : Device
    {
        private Random _random = new Random();

        public BatteryDevice(IMeasure measure) : base(measure)
        {
        }

        public override string GetBatteryLeval()
        {
            return _random.Next(0, 100) + "%";
        }

        public override string GetSunLeval()
        {
            return "--";
        }

        protected override string GetDeviceName()
        {
            return "バッテリー";
        }
    }
}
