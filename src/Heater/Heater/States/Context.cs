﻿namespace Heater.States
{
    public sealed class Context
    {
        // 現在の状態を保持する
        private IState _state = new OffState();
        public event Action? StateChanged;

        // Clientに公開する窓口を作る
        public void Up()
        {
            _state.UpState(this);
            Send();
        }

        public void Down()
        {
            _state.DownState(this);
            Send();
        }

        public void OnOff()
        {
            _state.OnOffState(this);
            Send();
        }

        public void Max()
        {
            if (_state is OffState)
            {
                throw new OffException();
            }

            ChangeState(new HighState());
            Send();
        }

        private void Send()
        {
            string path = "heater.txt";
            File.WriteAllLines(path, _state.GetCommand());
        }

        internal string GetText()
        {
            return _state.GetText();
        }

        internal void ChangeState(IState state)
        {
            _state = state;
            StateChanged?.Invoke();
        }
    }
}
