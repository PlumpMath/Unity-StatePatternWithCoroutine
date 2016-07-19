namespace NaruDesign.State
{
    public interface IModeState
    {
        void EnterState(IMode context);
        void ExitState(IMode context);
        void GoNext(IMode context);
        void DumpName(IMode context);
    }
}
