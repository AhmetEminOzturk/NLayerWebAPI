using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product 
                { 
                    Id = 1, 
                    CategoryId=1, 
                    Name="Asus Zephyrus", 
                    Price=40000, 
                    CreatedDate=DateTime.Now, 
                    Stock=20
                },
                new Product 
                { 
                    Id = 2, 
                    CategoryId = 2, 
                    Name = "Buz Dolabı", 
                    Price = 25000, 
                    CreatedDate = DateTime.Now, 
                    Stock = 50 
                },
                new Product 
                { 
                    Id = 3, 
                    CategoryId = 3, 
                    Name = "Kahve Makinesi", 
                    Price = 10000, 
                    CreatedDate = DateTime.Now, 
                    Stock = 100 
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Çamaşır Makinesi",
                    Price = 17000,
                    CreatedDate = DateTime.Now,
                    Stock = 7000
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 1,
                    Name = "Lenova Legion",
                    Price = 35000,
                    CreatedDate = DateTime.Now,
                    Stock = 30
                });
        }
    }
}
