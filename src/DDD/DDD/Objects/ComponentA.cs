using System.Diagnostics.Eventing.Reader;

namespace DDD.Objects
{
    public class ComponentA : IComponent
    {

        public virtual string GetData()
        {
            return File.ReadAllText("textA.txt");
        }

        //public string GetData()
        //{
        //    var result = File.ReadAllText("textA.txt");

        //    if (_isUpper)
        //    {
        //        return result.ToUpper();
        //    }
        //    else if (_isLower)
        //    {
        //        return result.ToLower();
        //    }

        //    return result;
        //}
    }

    public sealed class ComponentAUpper : ComponentA
    {
        public override string GetData()
        {
            return base.GetData().ToUpper();
        }
    }

    public sealed class ComponentLower : ComponentA
    {
        public override string GetData()
        {
            return base.GetData().ToLower();
        }
    }
}
