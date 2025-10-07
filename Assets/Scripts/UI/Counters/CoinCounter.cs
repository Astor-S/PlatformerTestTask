using UnityEngine;
using TMPro;
using Items;

namespace UI.Counters
{
    public class CoinCounter : MonoBehaviour
    {
        [SerializeField] private Wallet _wallet;
        [SerializeField] private TMP_Text _textMeshPro;

        private void OnEnable()
        {
            _wallet.CoinAdded += CountUpdate;
            CountUpdate();
        }

        private void OnDisable()
        {
            _wallet.CoinAdded -= CountUpdate;
        }

        private void CountUpdate() => 
            _textMeshPro.text = _wallet.Coin.ToString();
    }
}