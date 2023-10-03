namespace Health
{
    [System.Serializable]
    public class SimpleLoseHalfHealth : Core.Interfaces.ISpendable
    {
        [UnityEngine.Range(0, 1)] public float Percentage = 0.5f;

        public bool CanSpend()
        {
            return HealthManage.Instance.GetCurrency() > 0;
        }

        public float GetPrice()
        {
            return Percentage;
        }

        
        public void Spend()
        {
            HealthManage.Instance.TrySpendCurrency(HealthManage.Instance.GetCurrency() * Percentage);
        }
    }
}
