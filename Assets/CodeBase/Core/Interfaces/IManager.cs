namespace Core.Interfaces
{
    public interface IManager
    {
        public bool IsCurrencyEnough(float amount);
        public bool TrySpendCurrency(float amount);
        public void ChangeCurrency(float amount);
        
    }
}


