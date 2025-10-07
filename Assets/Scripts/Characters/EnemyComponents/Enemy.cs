using UnityEngine;
using Characters.CharactersComponents;
using Movement;

namespace Characters.EnemyComponents
{
    public class Enemy : CombatCharacter
    {
        [SerializeField] private EnemyMover _enemyMover;

        private void Update()
        {
            _enemyMover.Move();
        }
    }
}