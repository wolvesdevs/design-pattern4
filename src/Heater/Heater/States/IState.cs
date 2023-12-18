namespace Heater.States
{
    public interface IState
    {
        void UpState(Context context);
        void DownState(Context context);
        string GetText();
        IEnumerable<string> GetCommand();
    }
}
