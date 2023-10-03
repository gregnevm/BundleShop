namespace Health
{
    [System.Serializable]
    public class PercentageHealthReward : Core.Interfaces.IReward
    {
        [UnityEngine.Range(0, 1f)] public float Percentage = 0.3f;
        public void GrantReward()
        {
            HealthManage.Instance.ChangeCurrency (HealthManage.Instance.GetCurrency() * Percentage);
        }


    }
}

