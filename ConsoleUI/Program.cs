using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;

// SOLID
// Open Closed Principle

ProductManager productManager = new ProductManager(new EfProductDal());
/*
foreach (var product in productManager.GetAll())
{
   Console.WriteLine(product.ProductName);
}
*/

/*
foreach (var product in productManager.GetAllByCategoryId(2))
{
    Console.WriteLine(product.ProductName + " " + product.UnitPrice);
}
*/


foreach (var product in productManager.GetByUnitprice(40,100))
{
    Console.WriteLine(product.ProductName + " " + product.UnitPrice);
}
