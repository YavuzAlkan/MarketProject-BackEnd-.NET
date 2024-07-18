using ApplicationCore.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SeedData
{
    public class ProductSeedData : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
                 (
                new Product
                {
                    Id = 1,
                    Name = "Elma",
                    Price = 23.50,
                    Quantity = 25,
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 2,
                    Name = "Salatalık",
                    Price = 27.90,
                    Quantity = 45,
                    CategoryId = 1,

                },
                new Product
                {
                    Id = 3,
                    Name = "Telefon",
                    Price = 27.500,
                    Quantity = 3,
                    CategoryId = 2,
                },
                new Product
                {
                    Id = 4,
                    Name = "Tablet",
                    Price = 18.700,
                    Quantity = 6,
                    CategoryId = 2,
                },
                new Product
                {
                    Id = 5,
                    Name = "Sucuk",
                    Price = 400,
                    Quantity = 45,
                    CategoryId = 3,
                },
                new Product
                {
                    Id = 6,
                    Name = "Peynir",
                    Price = 280,
                    Quantity = 34,
                    CategoryId = 3,
                },
                new Product
                {
                    Id = 7,
                    Name = "Filtre Kahve",
                    Price = 85,
                    Quantity = 21,
                    CategoryId = 5,

                },
                new Product
                {
                    Id = 8,
                    Name = "Türk Kahvesi",
                    Price = 50,
                    Quantity = 15,
                    CategoryId = 5,
                }


                );
        }
    }
}
