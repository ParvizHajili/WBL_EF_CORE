using WBL_EF_CORE.Concrete;
using WBL_EF_CORE.Models;
using WBL_EF_CORE.SqlDbContext;

namespace WBL_EF_CORE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             -- Category(Id,Name,IsDeleted,CreatedDAte)
             -- Product(Id,Name,CategoryId,Quantity)            
             */

            CategoryRepository categoryRepository = new CategoryRepository();
            int id = Convert.ToInt32(Console.ReadLine());

            switch (id)
            {
                case 1:
                    {
                        Console.WriteLine("Kateqoriya adını daxil edin");
                        string name = Console.ReadLine();


                        Category category = new()
                        {
                            Name = name,
                        };
                        categoryRepository.Add(category);
                        Console.WriteLine("Category Əlavə olundu");

                        break;
                    }
                case 2:
                    {
                        var categories = categoryRepository.GetAll();

                        foreach (var item in categories)
                        {
                            Console.WriteLine($"{item.Id}  {item.Name}");
                        }

                        return;
                    }
                default:
                    break;
            }
        }
    }
}
