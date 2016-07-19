using UnityEngine;
using System.Collections;

namespace NaruDesign.State
{
    public class ModeA : Singleton<ModeA>, IModeState
    {
        public void EnterState(IMode context)
        {
            Debug.Log("ModeA : EnterState()");
        }

        public void ExitState(IMode context)
        {
            Debug.Log("ModeA : ExitState()");
        }

        public void GoNext(IMode context)
        {
            StartCoroutine(GoNextCoroutine(context));
        }
        IEnumerator GoNextCoroutine(IMode context)
        {
            Debug.Log("Wait 3 seconds");
            yield return new WaitForSeconds(3);

            context.ChangeState(ModeB.Instance);
        }

        public void DumpName(IMode context)
        {
            Debug.Log("--- ModeA ---");
        }
    }
}
