namespace Rating
{
    public class RatingManage : Core.BaseManager
    {
        public static RatingManage Instance { get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                // Якщо екземпляр вже існує, то можливо потрібно обробити цю ситуацію або видалити поточний об'єкт
                Destroy(gameObject);
            }
        }
    }
}

