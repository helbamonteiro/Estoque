using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    public class CadastroRepository

    {
        private List<Person> people;
        public CadastroRepository()
        {
            people = new List<Person>()
            {
                new Person ()
                {
                    Id = Guid.NewGuid(),
                    Name = "John",
                    Surname = "Wick",
                    Birthday = new DateTime (1991,03,03),
                    Email = "johnwick@gmail.com",
                    Phone = "21 99710-9785",
                                 

                }

            };
        }

        public List<Person> GetAll()
        {
            return people.Select(p => new Person()
            {
                Id = p.Id,
                Name = p.Name,
                Surname = p.Surname,
                Birthday = p.Birthday,
                Email = p.Email,
                Phone = p.Phone
            }).ToList();
        }




        public class Person
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public DateTime Birthday { get; set; }
        }
    }
}
