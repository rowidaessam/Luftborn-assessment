using Luftborn.NetCodeTest.Domain.Entities;
using Luftborn.NetCodeTest.Domain.Repositories;
using Luftborn.NetCodeTest.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Luftborn.NetCodeTest.Infrastructure.Persistence.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ProductDbContext _context;
    public ProductRepository(ProductDbContext context) => _context = context;

    public IEnumerable<Product> GetAll() => _context.Products.ToList();

    public Product GetById(int id) => _context.Products.Find(id);

    public void Add(Product product) { _context.Products.Add(product); Save(); }

    public void Update(Product product) { _context.Entry(product).State = EntityState.Modified; Save(); }

    public void Delete(int id)
    {
        var product = _context.Products.Find(id);
        if (product != null) _context.Products.Remove(product);
        Save();
    }

    public void Save() => _context.SaveChanges();
}
