using LoyalitySystem.Model;

namespace LoyalitySystem.Repository.IRepository
{
    public interface ILoyalityUserRepository
    {
        List<LoyalityUser> GetLoyalityUsers();

        LoyalityUser GetLoyalityUserById(int loyalityUserId);

        LoyalityUser GetLoyalityUserByUserId(int userId);

        List<LoyalityUser> GetLoyalityUsersByCompanyId(int companyId);

        LoyalityUser AddLoyalityUser(LoyalityUser loyalityUser);

        void UpdateLoyalityUser(LoyalityUser loyalityUser);

        void DeleteLoyalityUser(int loyalityUserId);

        bool SaveChanges();
    }
}
