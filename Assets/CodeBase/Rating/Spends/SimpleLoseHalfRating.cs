namespace Rating
{
    [System.Serializable]
    public class SimpleLoseHalfRating : Core.Interfaces.ISpendable
    {
        [UnityEngine.Range(0, 1)] public float Percentage = 0.5f;

        public bool CanSpend()
        {
            return Rating.RatingManage.Instance.GetCurrency() > 0;
        }

        public float GetPrice()
        {
            return Percentage;
        }

        
        public void Spend()
        {
            Rating.RatingManage.Instance.TrySpendCurrency( Rating.RatingManage.Instance.GetCurrency() * Percentage);
        }
    }
}
