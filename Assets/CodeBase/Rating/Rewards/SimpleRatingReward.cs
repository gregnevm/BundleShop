namespace Rating
{
    [System.Serializable]
    public class SimpleRatingReward : Core.Interfaces.IReward
    {
        [UnityEngine.Range(0,1000)]public float Amount = 300;
        public void GrantReward()
        {
            Rating.RatingManage.Instance.ChangeCurrency(Amount);
        }


    }
}

