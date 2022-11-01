using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ghiura_Andreea_Lab2.Models;

namespace Ghiura_Andreea_Lab2.Data
{
    public class Ghiura_Andreea_Lab2Context : DbContext
    {
        public Ghiura_Andreea_Lab2Context (DbContextOptions<Ghiura_Andreea_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ghiura_Andreea_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
