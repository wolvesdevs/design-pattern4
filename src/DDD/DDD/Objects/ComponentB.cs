using System.Diagnostics.Eventing.Reader;

namespace DDD.Objects
{
    public sealed class ComponentB : IComponent
    {
        public string GetData()
        {
            return File.ReadAllText("textB.txt");
        }
    }
}
