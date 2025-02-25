using Luftborn.NetCodeTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Luftborn.NetCodeTest.Infrastructure.Persistence.Context;

public class ProductDbContext : DbContext
{
    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }
    public DbSet<Product> Products { get; set; }
}

