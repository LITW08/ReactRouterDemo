using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ReactRouterDemo.Data;

namespace ReactRouterDemo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleCarsController : ControllerBase
    {
        private string _connectionString;

        public PeopleCarsController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ConStr");
        }

        [Route("getall")]
        public List<Person> GetPeople()
        {
            var repo = new PeopleCarsRepository(_connectionString);
            return repo.GetPeople();
        }

        [Route("foo")]
        public Human GetHooman()
        {
            return new Human
            {
                Name = "Dude",
                House = new House
                {
                    Address = "123 Main st"
                }
            };
        }
    }

    public class House
    {
        public string Address { get; set; }
    }

    public class Human
    {
        public string Name { get; set; }
        public House House { get; set; }
    }
}
