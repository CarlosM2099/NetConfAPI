using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetConfAPI.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsIntStock { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public static implicit operator ProductDTO(Product product)
        {
            return new ProductDTO(product.Id, product.Name, product.UnitPrice, product.UnitsIntStock);
        }
    }

    public record ProductDTO(int Id, string Name, decimal UnitPrice, int UnitsIntStock);
}
