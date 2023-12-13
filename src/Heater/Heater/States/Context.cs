namespace Heater.States
{
    public sealed class Context
    {
        private IState _state = new OffState(); // 現在の状態を保持する
    }
}
