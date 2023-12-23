﻿namespace Heater.States
{
    public sealed class OffState : IState
    {
        private OffState() { }
        public static OffState Instance { get; } = new OffState();

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
            throw new OffException();
        }

        public void DownState(Context context)
        {
            throw new OffException();
        }

        public void OnOffState(Context context)
        {
            context.ChangeState(LowState.Instance);
        }
    }
}
