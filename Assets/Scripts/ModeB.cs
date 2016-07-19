using UnityEngine;

namespace NaruDesign.State
{
    public class ModeB : Singleton<ModeB>, IModeState
    {
        public void EnterState(IMode context)
        {
            Debug.Log("ModeB : EnterState()");
        }

        public void ExitState(IMode context)
        {
            Debug.Log("ModeB : ExitState()");
        }

        public void GoNext(IMode context)
        {
            context.ChangeState(ModeA.Instance);
        }

        public void DumpName(IMode context)
        {
            Debug.Log("+++ ModeB +++");
        }
    }
}
