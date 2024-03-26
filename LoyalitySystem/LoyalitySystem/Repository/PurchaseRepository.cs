using LoyalitySystem.Data;
using LoyalitySystem.Model;
using LoyalitySystem.Repository.IRepository;

namespace LoyalitySystem.Repository
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly ApplicationDbContext context;

        public PurchaseRepository(ApplicationDbContext context) { this.context = context; }

        public Purchase AddPurchase(Purchase purchase)
        {
            var createdEntity = context.Add(purchase);
            return createdEntity.Entity;
        }

        public List<Purchase> GetPurchases()
        {
            return context.Purchases.ToList();
        }
    }
}
