using System;
using UnityEngine;
using Characters.PlayerComponents;

namespace Detectors
{
    public class DeathZoneDetector : MonoBehaviour
    {
        public event Action Died;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponent<Player>(out _))
                Died?.Invoke();
        }
    }
}