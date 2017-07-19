using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreSample.Models;

namespace NetCoreSample.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private NetCoreSampleContext _context;
        public UsersController(NetCoreSampleContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IQueryable<User> Get() {
            return _context.Users;
        }
    }
}