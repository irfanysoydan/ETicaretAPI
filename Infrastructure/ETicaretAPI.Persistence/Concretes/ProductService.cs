using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts() =>
            new()
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product 1",
                    Price = 100,
                    Stock = 10,
                    CreatedDate = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product 1",
                    Price = 100,
                    Stock = 10,
                    CreatedDate = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product 1",
                    Price = 100,
                    Stock = 10,
                    CreatedDate = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product 1",
                    Price = 100,
                    Stock = 10,
                    CreatedDate = DateTime.Now
                },
            };
    }
}
