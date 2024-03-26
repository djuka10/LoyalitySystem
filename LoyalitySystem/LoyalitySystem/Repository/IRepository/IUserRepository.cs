using LoyalitySystem.Model;

namespace LoyalitySystem.Repository.IRepository
{
    public interface IUserRepository 
    {
        List<User> GetUsers();

        User GetUserById(int userId);

        User AddUser(User user);

        void UpdateUser(User user);

        void DeleteUser(int userId);

        bool SaveChanges();

    }
}
