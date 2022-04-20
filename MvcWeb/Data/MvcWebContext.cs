using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcWeb.Models;

namespace MvcWeb.Data
{
    public class MvcWebContext : DbContext
    {
        public MvcWebContext (DbContextOptions<MvcWebContext> options)
            : base(options)
        {
        }

        public DbSet<MvcWeb.Models.Student> Student { get; set; }
    }
}
