using LoyalitySystem.Data;
using LoyalitySystem.Model;
using LoyalitySystem.Repository.IRepository;

namespace LoyalitySystem.Repository
{
    public class LoyalityUserRepository : ILoyalityUserRepository
    {
        private readonly ApplicationDbContext context;

        public LoyalityUserRepository(ApplicationDbContext context) { this.context = context; }

        public LoyalityUser AddLoyalityUser(LoyalityUser loyalityUser)
        {
            var createdEntity = context.Add(loyalityUser);
            return createdEntity.Entity;
        }

        public void DeleteLoyalityUser(int loyalityUserId)
        {
            var user = GetLoyalityUserById(loyalityUserId);
            context.Remove(user);
        }

        public LoyalityUser GetLoyalityUserById(int loyalityUserId)
        {
            return context.LoyalityUsers.FirstOrDefault(u => u.Id == loyalityUserId);
        }

        public LoyalityUser GetLoyalityUserByUserId(int userId)
        {
            return context.LoyalityUsers.FirstOrDefault(u => u.UserId == userId);
        }

        public List<LoyalityUser> GetLoyalityUsersByCompanyId(int companyId)
        {
            return context.LoyalityUsers.Where(u => u.CompanyId == companyId).ToList();
        }

        public List<LoyalityUser> GetLoyalityUsers()
        {
            return context.LoyalityUsers.ToList();
        }

        public bool SaveChanges()
        {
            return context.SaveChanges() > 0;
        }

        public void UpdateLoyalityUser(LoyalityUser loyalityUser)
        {
            throw new NotImplementedException();
        }
    }
}
