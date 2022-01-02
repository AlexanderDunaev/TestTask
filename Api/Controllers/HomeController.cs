using Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private ApiDbContext _db;
        public HomeController(ApiDbContext context)
        {
            _db = context;
        }
        [HttpGet]
        public IEnumerable<TestData> GetTestDatas()
        {
            _db.Add(new TestData { Name = "666" });
            _db.SaveChanges();

            var x = _db.TestDatas.ToList();
            return x;
        }
    }
}
