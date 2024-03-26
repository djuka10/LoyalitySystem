using LoyalitySystem.Model;

namespace LoyalitySystem.Repository.IRepository
{
    public interface IPurchaseRepository
    {
        Purchase AddPurchase(Purchase purchase);
        List<Purchase> GetPurchases();
    }
}
