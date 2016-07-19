namespace NaruDesign.State
{
    public interface IModeState
    {
        // common methods

        void EnterState(IMode context);
        void ExitState(IMode context);
        void GoNext(IMode context);
        void DumpName(IMode context);

        // special methods

        void SpecialA(IMode context);
        void SpecialB(IMode context);
    }
}
