using UnityEngine;
using UnityEngine.UI;

namespace NaruDesign.State
{
    public class ModeController : MonoBehaviour, IMode
    {
        private IModeState state = null;

        [SerializeField]
        private Button buttonGoNext;

        [SerializeField]
        private Button buttonDumpName;

        [SerializeField]
        private Button buttonSpecialA;

        [SerializeField]
        private Button buttonSpecialB;

        void Start()
        {
            buttonGoNext.onClick.AddListener(() =>
            {
                state.GoNext(this);
            });
            buttonDumpName.onClick.AddListener(() =>
            {
                state.DumpName(this);
            });
            buttonSpecialA.onClick.AddListener(() =>
            {
                state.SpecialA(this);
            });
            buttonSpecialB.onClick.AddListener(() =>
            {
                state.SpecialB(this);
            });

            state = ModeA.Instance;
            ChangeState(ModeB.Instance);
            ChangeState(ModeA.Instance);
        }

        #region IMode

        public void ChangeState(IModeState newState)
        {
            if (state != null)
            {
                state.ExitState(this);
            }
            state = newState;
            state.EnterState(this);
        }

        #endregion
    }
}
