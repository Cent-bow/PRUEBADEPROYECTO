using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PRUEBADEPROYECTO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRUEBADEPROYECTO.Data
{

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options){}
            public DbSet<Producto> Productos { get; set; }
        public DbSet<Direcciones> Direction { get; set; }
        public DbSet<Tarjeta> Tarjetas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    
    }
}
