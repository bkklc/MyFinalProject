using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;

// SOLID
// Open Closed Principle
// DTO = Data Transformation Object
ProductManager productManager = new ProductManager(new EfProductDal());
CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());


ProductTest(productManager);
//CategoryTest(categoryManager);



static void ProductTest(ProductManager productManager)
{
    var result = productManager.GetProductDetails();

    if (result.Success == true)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
    }

    else Console.WriteLine(result.Message);


    //foreach (var product in productManager.GetAll())
    //{
    //   Console.WriteLine(product.ProductName);
    //}

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

static void CategoryTest(CategoryManager categoryManager)
{
    
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}