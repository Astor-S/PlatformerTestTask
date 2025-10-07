using UnityEngine;

namespace Characters.PlayerComponents
{
    public class InputReader : MonoBehaviour
    {
        public const string Horizontal = "Horizontal";

        private KeyCode JumpKey = KeyCode.W;
        private bool _isJump;

        public float Direction { get; private set; }

        private void Update()
        {
            Direction = Input.GetAxis(Horizontal);

            if (Input.GetKeyDown(JumpKey))
                _isJump = true;
        }

        public bool GetIsJump()
        {
            bool localValue = _isJump;
            _isJump = false;

            return localValue;
        }
    }
}