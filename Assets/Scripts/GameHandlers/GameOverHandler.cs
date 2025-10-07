using UnityEngine;
using UnityEngine.SceneManagement;
using Characters.CharactersComponents;
using Detectors;

namespace GameHandlers
{
    public class GameOverHandler : MonoBehaviour
    {
        [SerializeField] private Health _playerHealth;
        [SerializeField] private DeathZoneDetector _deathZoneDetector;

        private void OnEnable()
        {
            _playerHealth.Died += GameOver;
            _deathZoneDetector.Died += GameOver;
        }

        private void OnDisable()
        {
            _playerHealth.Died -= GameOver;
            _deathZoneDetector.Died -= GameOver;
        }

        private void GameOver() =>
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}