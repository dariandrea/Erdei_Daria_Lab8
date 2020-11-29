using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Erdei_Daria_Lab8.Models;

namespace Erdei_Daria_Lab8.Data
{
    public class Erdei_Daria_Lab8Context : DbContext
    {
        public Erdei_Daria_Lab8Context (DbContextOptions<Erdei_Daria_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Erdei_Daria_Lab8.Models.Book> Book { get; set; }

        public DbSet<Erdei_Daria_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Erdei_Daria_Lab8.Models.Category> Category { get; set; }
    }
}
