using System.Diagnostics.Eventing.Reader;

namespace DDD.Objects
{
    internal sealed class ComponentA : IComponent
    {
        private bool _isUpper = false;
        private bool _isLower = false;

        public ComponentA(bool isUpper, bool isLower)
        {
            _isUpper = isUpper;
            _isLower = isLower;
        }

        public string GetData()
        {
            var result = File.ReadAllText("textA.txt");

            if (_isUpper)
            {
                return result.ToUpper();
            }
            else if (_isLower)
            {
                return result.ToLower();
            }

            return result;
        }
    }
}
