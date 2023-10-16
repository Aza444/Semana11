
using GuiaSemana11EntityFramework;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class Context : DbContext
{

    public DbSet<EstudianteUNAB> Estudiantes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AD7C6T5\\SQLEXPRESS;Database=Program2;Trusted_Connection=True;");
        }
    }
}