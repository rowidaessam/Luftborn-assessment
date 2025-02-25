using Luftborn.NetCodeTest.Application.Models;
using Luftborn.NetCodeTest.Domain.Entities;

namespace Luftborn.NetCodeTest.Application.core;

public interface IProductService
{
    IEnumerable<Product> GetAll();
    Product GetById(int id);
    void Add(ProductDto productDto);
    void Update(int id, ProductDto productDto);
    void Delete(int id);
}
