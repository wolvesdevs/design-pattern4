using Bridge.Measures;

namespace Bridge.Devices
{
    public sealed class AcDevice : Device
    {
        public AcDevice(IMeasure measure) : base(measure)
        {
        }
    }
}
