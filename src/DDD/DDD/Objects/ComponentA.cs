namespace DDD.Objects
{
    internal sealed class ComponentA : IComponent
    {
        private bool _isUpper = false;

        public ComponentA(bool isUpper)
        {
            _isUpper = isUpper;
        }

        public string GetData()
        {
            var result = File.ReadAllText("textA.txt");
            
            if (_isUpper)
            {
                return result.ToUpper();
            }

            return result;
        }
    }
}
