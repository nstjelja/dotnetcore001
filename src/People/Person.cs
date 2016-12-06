using System;

namespace People
{
    public class Person
    {
        public string FirstName {get; private set;}
        public string LastName {get; private set;}

        public DateTime DateOfBirth {get; private set;}
        public DateTime? DateOfDeath {get; private set;}

        public Person(string firstName, string lastName, DateTime dateOfBirth){
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString(){
            return $"{FirstName} {LastName}";
        }

        public void Kill(){
            if (DateOfDeath != null){
                throw new ArgumentException("Can't kill what is already dead. But in the strange enons that have passed even death my die");
            }

            DateOfDeath = DateTime.Now;
        }
    }
}
