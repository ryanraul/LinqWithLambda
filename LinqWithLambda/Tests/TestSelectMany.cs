using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    class TestSelectMany : ITest
    {
        public void Test()
        {
            var persons = new List<Person>();
            persons.Add(new Person
            {
                Id = 1,
                Name = "John",
                PersonPhones  = new List<PersonPhone>()
                {
                    new PersonPhone {PhoneNumber = "123456"},
                    new PersonPhone {PhoneNumber = "654321"},
                }
            });

            persons.Add(new Person
            {
                Id = 2,
                Name = "Mary",
                PersonPhones = new List<PersonPhone>()
                {
                    new PersonPhone {PhoneNumber = "321321"},
                    new PersonPhone {PhoneNumber = "456456"},
                }
            });

            var personPhones = persons.Select(person => person.PersonPhones);
            foreach (var personPhone in personPhones)
            {
                foreach (var phone in personPhone)
                {
                    Console.WriteLine("Using Select: " + phone.PhoneNumber);
                }
            }

            var phones = persons.SelectMany(person => person.PersonPhones);

            foreach (var phone in phones)
            {
                Console.WriteLine("Using SelectMany: " + phone.PhoneNumber);
            }

        }

        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<PersonPhone> PersonPhones { get; set; }
        }

        class PersonPhone
        {
            public string PhoneNumber { get; set; }
        }
    }
}
