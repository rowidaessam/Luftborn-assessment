using Luftborn.NetCodeTest.Application.core;
using Luftborn.NetCodeTest.Application.Models;
using Luftborn.NetCodeTest.Domain.Entities;
using Luftborn.NetCodeTest.Domain.Repositories;

namespace Luftborn.NetCodeTest.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;
    public ProductService(IProductRepository repository) => _repository = repository;

    public IEnumerable<Product> GetAll() => _repository.GetAll();

    public Product GetById(int id) => _repository.GetById(id);

    public void Add(ProductDto productDto)
    {
        var product = new Product { Name = productDto.Name, Price = productDto.Price };
        _repository.Add(product);
    }

    public void Update(int id, ProductDto productDto)
    {
        var product = _repository.GetById(id);
        if (product != null)
        {
            product.Name = productDto.Name;
            product.Price = productDto.Price;
            _repository.Update(product);
        }
    }

    public void Delete(int id) => _repository.Delete(id);
}
