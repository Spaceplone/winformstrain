using Data.Entities;
using Domain.Model;

namespace Data.Mappers
{
    public static class UserMapper
    {
        public static User ToDomainModel(UserEntity entity)
        {
            return new User
            {
                Id = entity.Id,
                Name = entity.Name,
                Gender = entity.Gender,
                DateOfBirth = entity.DateOfBirth
            };
        }

        public static UserEntity ToEntity(User domainModel)
        {
            return new UserEntity
            {
                Id = domainModel.Id,
                Name = domainModel.Name,
                Gender = domainModel.Gender,
                DateOfBirth = domainModel.DateOfBirth
            };
        }
    }
}
