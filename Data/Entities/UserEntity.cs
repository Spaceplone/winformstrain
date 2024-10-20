using Domain.Model;

namespace Data.Entities
{
    public class UserEntity
    {//todo: enhance user with address (Normalized)

        public Guid Id { get; private set; }

        string name;

        DateOnly dateOfBirth;

        Gender gender;

        public string Name
        {
            get => name;
            set => name = value;
        }


        public Gender Gender
        {  
            get => gender; 
            set => gender = value; 
        }
        public DateOnly DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        //todo: make private-only constructor that sets the Id 
        public UserEntity()
        {
            
        }

        public UserEntity(string name, DateOnly dateOfBirth, Gender gender)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            
        }
    }
}
