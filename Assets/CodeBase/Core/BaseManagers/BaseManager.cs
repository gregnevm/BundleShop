using Core.Interfaces;
using UnityEngine;

namespace Core
{
    public abstract class BaseManager : MonoBehaviour, IManager
    {
        [SerializeField] protected float _minCurrency = 0f;
        [SerializeField] protected float _maxCurrency = 100f;
        [SerializeField] protected float _playerCurrency = 50f;

        public virtual bool IsCurrencyEnough(float amount)
        {
            return amount <= _playerCurrency;
        }

        public virtual bool TrySpendCurrency(float amount)
        {
            if (IsCurrencyEnough(amount))
            {
                _playerCurrency -= amount;
                Core.EventBus.OnCurrenciesChanged.Invoke();
                return true;
            }
            return false;
        }

        public virtual void ChangeCurrency(float amount)
        {
            _playerCurrency += amount;
            ClampCurrency();
            Core.EventBus.OnCurrenciesChanged.Invoke();
        }

        public virtual float GetCurrency()
        {
            return _playerCurrency;
        }

        private void ClampCurrency()
        {
            if (_playerCurrency < _minCurrency)
            {
                _playerCurrency = _minCurrency;
            }
            else if (_playerCurrency > _maxCurrency)
            {
                _playerCurrency = _maxCurrency;
            }
        }
    }
}
