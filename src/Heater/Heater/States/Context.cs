
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
        }

        internal string GetText()
        {
            return _state.GetText(this);
        }

        internal void ChangeState(IState state)
        {
            _state = state;
        }
    }
}
