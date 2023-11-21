using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.InMemory;

ProductManager productManager = new ProductManager(new InMemoryIProductDal());

foreach (var product in productManager.GetAll())
{
    Console.WriteLine(product.ProductName);
}
