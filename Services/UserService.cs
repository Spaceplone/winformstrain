using Data; // Reference to the Data Layer
using Domain.Model; // Reference to the Domain Layer
using Data.Entities; // Reference to UserEntity
using Microsoft.EntityFrameworkCore;

using Data.Mappers;

namespace YourApp.Services
{
    public class UserService
    {
        private readonly UserManagementDbContext _dbContext;

        public UserService(UserManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Method to Get All Users
        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            List<UserEntity> entities = await _dbContext.Users.ToListAsync();
            return entities.Select(UserMapper.ToDomainModel);
        }

        // Method to Add a New User
        public async Task AddUserAsync(User user)
        {
            var entity = UserMapper.ToEntity(user);
            await _dbContext.Users.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        // Method to Update an Existing User
        public async Task UpdateUserAsync(User user)
        {
            var entity = await _dbContext.Users.FindAsync(user.Id);
            if (entity != null)
            {
                entity.Name = user.Name;
                entity.Gender = user.Gender;
                entity.DateOfBirth = user.DateOfBirth;

                _dbContext.Users.Update(entity);
                await _dbContext.SaveChangesAsync();
            }
        }

        // Method to Delete a User
        public async Task DeleteUserAsync(int userId)
        {
            var entity = await _dbContext.Users.FindAsync(userId);
            if (entity != null)
            {
                _dbContext.Users.Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
