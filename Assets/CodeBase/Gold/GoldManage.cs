using Core;
namespace Gold
{
    public class GoldManage : BaseManager
    {
        public static GoldManage Instance { get; private set; }

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

