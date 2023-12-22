using System.Diagnostics.Eventing.Reader;

namespace DDD.Objects
{
    public class ComponentA : IComponent
    {
        public virtual string GetData()
        {
            return File.ReadAllText("textA.txt");
        }
    }

    public sealed class ComponentAUpper : ComponentA
    {
        public override string GetData()
        {
            return base.GetData().ToUpper();
        }
    }

    public sealed class ComponentALower : ComponentA
    {
        public override string GetData()
        {
            return base.GetData().ToLower();
        }
    }
}
