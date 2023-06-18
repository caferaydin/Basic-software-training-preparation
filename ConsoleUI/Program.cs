using SmartPro.Business.Abstraction;
using SmartPro.Business.Concrete;
using SmartPro.DataAccess.Concrete.InMemory;

public class Program
{
    private static void Main(string[] args)
    {
        IProductService productService = new ProductManager( new InMemoryProductDao());

        foreach (var product in productService.GetAll())
        {
            Console.WriteLine(product.Name);

        }
    }
}