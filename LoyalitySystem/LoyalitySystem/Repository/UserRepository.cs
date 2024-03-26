using LoyalitySystem.Data;
using LoyalitySystem.Model;
using LoyalitySystem.Repository.IRepository;

namespace LoyalitySystem.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext context;

        public UserRepository(ApplicationDbContext context) { this.context = context; }

        public User AddUser(User user)
        {
            var createdEntity = context.Add(user);
            return createdEntity.Entity;
        }

        public void DeleteUser(int userId)
        {
            var user = GetUserById(userId);
            context.Remove(user);
        }

        public User GetUserById(int userId)
        {
            return context.Users.FirstOrDefault(u => u.Id == userId);
        }

        public List<User> GetUsers()
        {
            return context.Users.ToList();
        }

        public bool SaveChanges()
        {
            return context.SaveChanges() > 0;
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
