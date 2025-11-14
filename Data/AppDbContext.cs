using Microsoft.EntityFrameworkCore;
using EcommerceApi.Models;

namespace EcommerceApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Cliente> Clientes => Set<Cliente>();
    public DbSet<Producto> Productos => Set<Producto>();
    public DbSet<Venta> Ventas => Set<Venta>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>().HasData(
            new Cliente { Id = 1, Nombre = "Juan", Apellido = "Perez", Correo = "juan.p@mail.com", Zona = "Norte", Edad = 30, Genero = "Masculino" },
            new Cliente { Id = 2, Nombre = "Maria", Apellido = "Gomez", Correo = "maria.g@mail.com", Zona = "Sur", Edad = 25, Genero = "Femenino" },
            new Cliente { Id = 3, Nombre = "Carlos", Apellido = "Lopez", Correo = "carlos.l@mail.com", Zona = "Este", Edad = 45, Genero = "Masculino" }
        );

        modelBuilder.Entity<Producto>().HasData(
            new Producto { Id = 101, Nombre = "Teclado Mecanico", Categoria = "Electronica", Precio = 50.00, Stock = 150 },
            new Producto { Id = 102, Nombre = "Mouse Inalambrico", Categoria = "Electronica", Precio = 25.50, Stock = 200 },
            new Producto { Id = 103, Nombre = "Camiseta Algodon", Categoria = "Ropa", Precio = 15.00, Stock = 300 }
        );

        base.OnModelCreating(modelBuilder);
    }
}