using Core.Interfaces;
using UnityEngine;

namespace Gold
{
    [System.Serializable]
    public class SimpleIncreaseGold : IReward
    {
        [UnityEngine.Range(0,1000)]public float _amount = 100f;
        public void GrantReward()
        {
            Gold.GoldManage.Instance.ChangeCurrency(_amount);
        }
    }
}

