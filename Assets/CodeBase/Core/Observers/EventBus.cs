using UnityEngine.Events;
namespace Core
{
    public static class EventBus
    {
        public static UnityEvent OnCurrenciesChanged = new();

    }

}