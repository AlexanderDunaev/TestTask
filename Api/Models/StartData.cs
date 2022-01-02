using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public static class StartData
    {
        public static void StartDatabase(ApiDbContext context)
        {
            //context.Database.Migrate();
            //if (context.TestDatas.Count() == 0)
            //{

            //    context.TestDatas.AddRange(
            //        new TestData { Name = "FirstData" },
            //        new TestData { Name = "SecondData" });

            //    context.SaveChanges();
            //}
        }
}
}
