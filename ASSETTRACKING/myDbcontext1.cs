using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ASSETTRACKING
{
    internal class myDbcontext1 : DbContext
    {
        
        public DbSet<Item>Items { get; set; }
       public DbSet<Asset> Assets { get; set; }

        string ConnectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=AssetTracking;Integrated Security=True;"; 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.Entity<Item>().HasData(
                new Item { Id = 5, catagory= "Phone", brand = "apple", model = "2022", purchaseDate = 2020-11-14, office = "Spain", purchasePrice = 2470, currency = "EUR", exchangeRate = 24.7  });
            ModelBuilder.Entity<Item>().HasData(
                new Item { Id = 1, catagory = "Phone", brand = "apple", model = "2022", purchaseDate = 2020 - 11 - 14, office = "Sweden", purchasePrice = 5470, currency = "SEK", exchangeRate = 54.7 });
            
            ModelBuilder.Entity<Asset>().HasData(
                new Asset { id = 2, name= "Lexicon" });
            

        }



    }

}
