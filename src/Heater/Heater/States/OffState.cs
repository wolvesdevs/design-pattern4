namespace Heater.States
{
    public sealed class OffState : IState
    {
        public IEnumerable<string> GetCommand()
        {
            return new List<string> { "OFF", "0W" };
        }

        public string GetText()
        {
            return "OFF";
        }

        public void UpState(Context context)
        {
            throw new Exception("OFF状態ではUpできません");
        }

        public void DownState(Context context)
        {
            throw new Exception("OFF状態ではDownできません");
        }

        public void OnOffState(Context context)
        {
            context.ChangeState(new LowState());
        }
    }
}
