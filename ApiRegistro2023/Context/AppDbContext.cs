using ApiRegistro2023.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiRegistro2023.Context
{
    //Herencia a la clase DbContext
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {



        }
        public DbSet<Rol> rol { get; set; }
        public DbSet<Dirección> dirección { get; set; }
        public DbSet<Empleado> empleado { get; set; }
    }
}