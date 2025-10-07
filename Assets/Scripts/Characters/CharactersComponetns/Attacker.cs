using UnityEngine;

namespace Characters.CharactersComponents
{
    public class Attacker : MonoBehaviour
    {
        [SerializeField] private float _damage;

        public float Attack() =>
            _damage;
    }
}