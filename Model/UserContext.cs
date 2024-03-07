using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace Model
{
    // Definerer UserContext-klassen, der fungerer som en databasekontekst for brugere
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; } // DbSet, der repræsenterer "Users"-tabellen i databasen

        public string DbPath { get; } // Sti til databasen

        // Konstruktør, der angiver standardstien til databasen
        public UserContext()
        {
            DbPath = "bin/User.db";
        }

        // Konfigurerer databasen og forbindelsesindstillingerne
        protected override void OnConfiguring(DbContextOptionsBuilder options)
               => options.UseSqlite($"Data Source={DbPath}");
        // Definerer modelkonfigurationen og tabellens navn
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");  // Konfigurerer "User"-modellen til at blive gemt i "Users"-tabellen
        }
    }
}
