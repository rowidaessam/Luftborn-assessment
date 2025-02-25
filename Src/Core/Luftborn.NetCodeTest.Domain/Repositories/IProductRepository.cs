using Luftborn.NetCodeTest.Domain.Entities;

namespace Luftborn.NetCodeTest.Domain.Repositories;

public interface IProductRepository
{
    IEnumerable<Product> GetAll();
    Product GetById(int id);
    void Add(Product product);
    void Update(Product product);
    void Delete(int id);
    void Save();
}
