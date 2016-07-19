using UnityEngine;
using System.Collections;

namespace NaruDesign.State
{
    public class ModeA : ModeState<ModeA>
    {
        public override void EnterState(IMode context)
        {
            Debug.Log("ModeA : EnterState()");
        }

        public override void ExitState(IMode context)
        {
            Debug.Log("ModeA : ExitState()");
        }

        public override void GoNext(IMode context)
        {
            StartCoroutine(GoNextCoroutine(context));
        }
        IEnumerator GoNextCoroutine(IMode context)
        {
            Debug.Log("Wait 3 seconds");
            yield return new WaitForSeconds(3);

            context.ChangeState(ModeB.Instance);
        }

        public override void DumpName(IMode context)
        {
            Debug.Log("--- ModeA ---");
        }

        public override void SpecialA(IMode context)
        {
            Debug.Log("*** Special A ***");
        }
    }
}
