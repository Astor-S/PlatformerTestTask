using UnityEngine;
using Detectors;

namespace Movement
{
    public class EnemyMover : MonoBehaviour
    {
        [SerializeField] private float _speed = 1f;
        [SerializeField] private PlayerDetector _playerDetection;
        [SerializeField] private Patroller _patrolling;
        [SerializeField] private Fliper _fliper;

        public void Move()
        {
            Vector2 targetPoint;

            if (_playerDetection.IsPlayerDetected)
            {
                targetPoint = _playerDetection.PlayerTransform.position;
                _fliper.Flip(_playerDetection.PlayerTransform.position);
            }
            else
            {
                targetPoint = _patrolling.GetCurrentPoint();
                _fliper.Flip(targetPoint);
            }

            transform.position = Vector2.MoveTowards(transform.position, targetPoint, _speed * Time.deltaTime);
        }
    }
}