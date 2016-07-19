using UnityEngine;
using System.Collections;

namespace NaruDesign.State
{
    public class ModeState<T> : Singleton<T>, IModeState where T : MonoBehaviour 
    {
        public virtual void EnterState(IMode context)
        {
        }

        public virtual void ExitState(IMode context)
        {
        }

        public virtual void GoNext(IMode context)
        {
        }

        public virtual void DumpName(IMode context)
        {
        }

        public virtual void SpecialA(IMode context)
        {
        }

        public virtual void SpecialB(IMode context)
        {
        }
    }
}
