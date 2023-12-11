using UnityEngine;

namespace MenuTest.UI
{
    public class AnimatedWindow : MonoBehaviour
    {
        private Animator _animator;
        private static readonly int _show = Animator.StringToHash("Show");
        private static readonly int _hide = Animator.StringToHash("Hide");

        private void Start () 
        { 
            _animator = GetComponent<Animator>();

            _animator.SetTrigger(_show);
        }

        public void Close () 
        {
            _animator.SetTrigger(_hide);
        }

        public void OnCloseAnimationComplete()
        {
            Destroy(gameObject);
        }
    }
}
