namespace Core.Interfaces
{
    public interface ISpendable
    {        
        bool CanSpend();
        void Spend();
        float GetPrice();
    }
}