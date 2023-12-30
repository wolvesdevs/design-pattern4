using Bridge.Measures;

namespace Bridge.Devices
{
    public sealed class AcDevice : Device
    {
        public AcDevice(IMeasure measure) : base(measure)
        {
        }

        public override string GetBatteryLeval()
        {
            return "--";
        }

        public override string GetSunLeval()
        {
            return "--";
        }

        protected override string GetDeviceName()
        {
            return "AC";
        }
    }
}
