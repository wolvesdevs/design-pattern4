namespace DDD.Objects
{
    internal sealed class ComponentA : IComponent
    {
        public string GetData()
        {
            return File.ReadAllText("textA.txt");
        }
    }
}
