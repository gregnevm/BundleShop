using UnityEngine;
using Core.Interfaces;

namespace Shop
{
    [CreateAssetMenu(fileName = "BundleShopData", menuName = "Assets/Shop/Resources/BundleData")]
    public class BundleData : ScriptableObject
    {
        public string Name;
        public Sprite Sprite;
        [SerializeReference, SelectImplementation(typeof(IReward))] 
        public IReward reward;
        [SerializeReference, SelectImplementation(typeof(ISpendable))]
        public ISpendable cost;
        public bool IsSpendPossible()
        {
            if (cost == null)
            {
                return true;
            }
            return cost.CanSpend();
        }
        public bool Buy()
        {
            if (IsSpendPossible())
            {
                cost.Spend();
                reward.GrantReward();
                Core.EventBus.OnCurrenciesChanged.Invoke();
                return true;
            }
            return false;
        }
    }
}

