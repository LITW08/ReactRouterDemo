using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ReactRouterDemo.Data
{
    public class PeopleCarsRepository
    {
        private readonly string _connectionString;

        public PeopleCarsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Person> GetPeople()
        {
            using var context = new PeopleCarsDataContext(_connectionString);
            return context.People.Include(p => p.Cars).ToList();
        }
    }
}