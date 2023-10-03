using UnityEngine;

public class GodButton : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI _tMPro;
    [SerializeField] string _name;
    [SerializeField] Core.BaseManager baseManager;
    [SerializeField] Shop.BundleData _godModReward;
    [SerializeField] bool _godMode = false;
    private int CurrentAmount;
    // Start is called before the first frame update
    void Start()
    {
        Core.EventBus.OnCurrenciesChanged.AddListener(Refresh);
        Refresh();
    }

    // Update is called once per frame
    
    void Refresh()
    {
        CurrentAmount = (int) baseManager.GetCurrency();
        _tMPro.text = $"{ _name} " + $" {CurrentAmount}";
    }
    public void TouchOfGod()
    {
        if (_godMode) { _godModReward.reward.GrantReward(); }
    }
}
