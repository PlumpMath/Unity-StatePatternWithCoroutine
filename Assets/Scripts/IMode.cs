namespace NaruDesign.State
{
    public interface IMode
    {
        void ChangeState(IModeState newState);
    }
}
