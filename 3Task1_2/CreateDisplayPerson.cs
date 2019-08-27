using System;
using System.Collections.Generic;

namespace lab3task1_2_3
{
    public class CreateDisplayPerson : Person
    {
        protected List<Person> newList = new List<Person>();
        public CreateDisplayPerson(List<Person> newList)
        {
            this.newList = newList;
        }
        public List<Person> CreateSomePerson()
        {
            newList.Add(new Person() { Name = "Anna", PhoneNumbers = new string[] { "09834467346", "09055326545", "09345343536" }, Age = 21 });
            newList.Add(new Person() { Name = "Olha", PhoneNumbers = new string[] { "093455467546", "06043432345", "09623436236" }, Age = 15 });
            newList.Add(new Person() { Name = "Serhii", PhoneNumbers = new string[] { "09363467346", "096354345", "0964534567" }, Age = 18 });
            newList.Add(new Person() { Name = "Yaroslav", PhoneNumbers = new string[] { "093634467346", "09043432345", "0964536236" }, Age = 17 });
            newList.Add(new Person() { Name = "Oleksandr", PhoneNumbers = new string[] { "09365463440", "09645323455", "0964536436" }, Age = 25 });
            newList.Add(new Person() { Name = "Oleg", PhoneNumbers = new string[] { "093654673446", "09645534345", "09645343236" }, Age = 17 });
            return newList;
        }
        public void DisplayPerson()
        {
            foreach (var person in newList)
            {
                Console.WriteLine($"Name: {person.Name} , Age: {person.Age} ");
            }
        }
    }
}

