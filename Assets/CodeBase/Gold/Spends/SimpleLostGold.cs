using Core.Interfaces;
namespace Gold
{
    [System.Serializable]
    public class SimpleLostGold : ISpendable
    {
        public float Amount = 100f;


        public bool CanSpend()
        {
            return GoldManage.Instance.GetCurrency() > Amount;
        }

        public float GetPrice()
        {
            return Amount;
        }

        public void Spend()
        {
            GoldManage.Instance.TrySpendCurrency(Amount);          

        }
    }
}

