using System.Diagnostics.Eventing.Reader;

namespace DDD.Objects
{
    public class ComponentA : IComponent
    {
        public virtual string GetData()
        {
            return File.ReadAllText("textA.txt");
        }

        public string GetDataUpper()
        {
            return GetData().ToUpper();
        }
    }
}
