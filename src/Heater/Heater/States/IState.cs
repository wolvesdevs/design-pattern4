namespace Heater.States
{
    public interface IState
    {
        void UpState(Context context);
        string GetText();
    }
}
