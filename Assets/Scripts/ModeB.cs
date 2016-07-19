using UnityEngine;

namespace NaruDesign.State
{
    public class ModeB : ModeState<ModeB>
    {
        public override void EnterState(IMode context)
        {
            Debug.Log("ModeB : EnterState()");
        }

        public override void ExitState(IMode context)
        {
            Debug.Log("ModeB : ExitState()");
        }

        public override void GoNext(IMode context)
        {
            context.ChangeState(ModeA.Instance);
        }

        public override void DumpName(IMode context)
        {
            Debug.Log("+++ ModeB +++");
        }

        public override void SpecialB(IMode context)
        {
            Debug.Log("*** Special B ***");
        }
    }
}
