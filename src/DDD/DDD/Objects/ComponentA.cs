using System.Diagnostics.Eventing.Reader;

namespace DDD.Objects
{
    public sealed class ComponentA : IComponent
    {
        public string GetData()
        {
            return File.ReadAllText("textA.txt");
        }
    }
}
