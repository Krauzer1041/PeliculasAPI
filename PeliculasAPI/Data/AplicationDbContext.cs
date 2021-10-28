using Microsoft.EntityFrameworkCore;
using PeliculasAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> option ) : base(option)
        {   

        }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
