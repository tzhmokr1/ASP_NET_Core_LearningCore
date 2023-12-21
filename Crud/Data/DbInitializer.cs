using Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Data
{
    public class DbInitializer
    {
        public static void Initialize(CrudContext context)
        {
            context.Database.EnsureCreated();

            if (context.People.Any())
            {
                return;
            }

            var people = new Person[]
            {
                new Person { FirstName = "John", LastName = "Johnson", Email = "john@gmail.com", Age = 32, Subscribed = true },
                new Person { FirstName = "Bob", LastName = "Bobson", Email = "bob@gmail.com", Age = 22, Subscribed = false },
                new Person { FirstName = "Sally", LastName = "Stevens", Email = "sally@gmail.com", Age = 26, Subscribed = false }
            };

            foreach (Person p in people)
            {
                context.People.Add(p);
            }
            context.SaveChanges();
        }
    }
}
