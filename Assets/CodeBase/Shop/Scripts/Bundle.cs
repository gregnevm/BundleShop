using UnityEngine;
using UnityEngine.UI;

namespace Shop
{
    public class Bundle : MonoBehaviour
    {
        [SerializeField] Button _main;
        [SerializeField] TMPro.TextMeshProUGUI TMPro;
        [SerializeField] private BundleData _bundleData;        

        private void Start()
        {
            Core.EventBus.OnCurrenciesChanged.AddListener(Refresh);
            
            TMPro.text = _bundleData.Name;
            Refresh();
        }
        private bool IsSpendPossible()
        {            
            if (_bundleData!= null)
            {
                return _bundleData.cost.CanSpend();
            }
            return true;
        }
        private void Refresh()
        {
            _main.interactable = IsSpendPossible();
            
        }
        public void BuyThisBundle()
        {
            _bundleData.Buy();
        }

    }
}

