using Bridge.Measures;

namespace Bridge.Devices
{
    public abstract class Device
    {
        private Random _random = new Random();
        private IMeasure _measure;

        public Device(IMeasure measure)
        {
            _measure = measure;
        }

        public string GetName()
        {
            return _measure.GetName();
        }

        public string GetMeasure()
        {
            return _measure.GetMeasure();
        }

        public string GetKando()
        {
            return _random.Next(0, 100) + "db";
        }
    }
}
