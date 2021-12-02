using csharp_product_crud_api.Api.Controllers.Contracts;
using csharp_product_crud_api.Api.Core.Aplication.ProductAgg.Contracts;
using csharp_product_crud_api.Api.Core.Aplication.ProductAgg.Parsers;
using csharp_product_crud_api.Api.Core.Domain.ProductAgg.Entities;

namespace csharp_product_crud_api.Api.Controllers.Parsers
{
    public class ProductParser : IParser<Product, IProduct>
    {
        public IProduct Parse(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = "R$ " + (product.Price / 100M).ToString("C")
            };
        }
    }
}