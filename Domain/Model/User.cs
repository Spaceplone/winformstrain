using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class User
    {//todo: enhance user with address (Normalized)
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

        public User()
        {
            
        }

        public User(string name, DateOnly dateOfBirth, Gender gender)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            
        }
    }
}
