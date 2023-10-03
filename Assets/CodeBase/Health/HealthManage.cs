namespace Health
{
    public class HealthManage : Core.BaseManager
    {
        public static HealthManage Instance { get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {                
                Destroy(gameObject);
            }
        }
    }
}

