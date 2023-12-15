
namespace Heater.States
{
    public sealed class Context
    {
        // 現在の状態を保持する
        private IState _state = new OffState();

        // Clientに公開する窓口を作る
        public void Up()
        {
            _state.UpState(this);

            string path = "heater.txt";
            //var list = new List<string>();
            //list.Add("OFF");
            //list.Add("0W");
            File.WriteAllLines(path, list);
        }

        internal string GetText()
        {
            return _state.GetText();
        }

        internal void ChangeState(IState state)
        {
            _state = state;
        }
    }
}
