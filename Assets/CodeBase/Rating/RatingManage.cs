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
                // ���� ��������� ��� ����, �� ������� ������� �������� �� �������� ��� �������� �������� ��'���
                Destroy(gameObject);
            }
        }
    }
}

