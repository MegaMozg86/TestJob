using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TestJob.Models
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}