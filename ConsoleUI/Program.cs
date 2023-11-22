using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;

// SOLID
// Open Closed Principle
// DTO = Data Transformation Object

ProductTest();
//CategoryTest();



static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetProductDetails())
    {
        Console.WriteLine(product.ProductName + " " + product.CategoryName);
    }


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
    /*
    foreach (var product in productManager.GetByUnitprice(40, 100))
    {
        Console.WriteLine(product.ProductName + " " + product.UnitPrice);
    } 
    */

}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}