using System;
using UnityEngine;

namespace Items
{
    public class Wallet : MonoBehaviour
    {
        private int _coins;

        public event Action CoinAdded;

        public int Coin => _coins;

        private void Awake()
        {
            _coins = 0;
        }

        public void AddCoins(int amount)
        {
            _coins += amount;
            CoinAdded?.Invoke();
        }
    }
}