using UnityEngine;

namespace Items
{
    public class AidKit : Item
    {
        [SerializeField] private float _healthPoints;

        public float HealthPoints => _healthPoints;
    }
}