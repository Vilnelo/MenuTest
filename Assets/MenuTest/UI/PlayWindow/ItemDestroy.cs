using UnityEngine;

namespace MenuTest.UI.PlayWindow
{
    public class ItemDestroy : MonoBehaviour
    {
        private Animator _animator;
        private static readonly int _destroy = Animator.StringToHash("Destroy");

        private void Start()
        {
            _animator = GetComponent<Animator>();
        }
        public void RemoveItem()
        {
            _animator.SetTrigger(_destroy);
        }

        public void OnDestroyAnimationComplete()
        {
            Destroy(gameObject);
        }
    }
}