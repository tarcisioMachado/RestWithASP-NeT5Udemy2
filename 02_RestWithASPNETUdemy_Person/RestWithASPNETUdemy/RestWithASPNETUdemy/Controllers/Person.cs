using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNETUdemy.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Controllers
{
    public class Person : Controller
    {
        private readonly ILogger<Person> _logger;

        public Person(ILogger<Person> logger)
        {
            _logger = logger;
        }

       
    }
}
