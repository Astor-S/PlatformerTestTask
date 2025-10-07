using UnityEngine;
using Characters.CharactersComponents;
using Detectors;
using Movement;

namespace Characters.PlayerComponents
{
    public class Player : CombatCharacter
    {
        public readonly int Speed = Animator.StringToHash(nameof(Speed));
        public readonly int IsJumping = Animator.StringToHash(nameof(IsJumping));

        [SerializeField] private InputReader _inputReader;
        [SerializeField] private GroundDetector _groundDetector;
        [SerializeField] private Mover _mover;
        [SerializeField] private Fliper _fliper;
        [SerializeField] private Animator _animator;

        private void FixedUpdate()
        {
            _fliper.Flip(_inputReader.Direction);
            _mover.Move(_inputReader.Direction);

            if (_inputReader.GetIsJump() && _groundDetector.IsGround)
            {
                _mover.Jump();
                _animator.SetBool(IsJumping, true);
            }
            else
            {
                _animator.SetBool(IsJumping, false);
            }

            _animator.SetFloat(Speed, Mathf.Abs(_inputReader.Direction));
        }
    }
}