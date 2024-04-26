using Microsoft.EntityFrameworkCore;

namespace Ef_Core_Code_First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            CarManagementDbContext dbContext = new();

            //CarCategory carCategory = new()
            //{
            //    Name = "Econom"
            //};

            //dbContext.CarCategories.Add(carCategory);
            //dbContext.SaveChanges();


            //var data = dbContext.Cars
            //    .Include(x => x.CarCategory)
            //    .Where(x => x.Id > 10)
            //    .Where(x => x.Model == "Bmw")
            //    .ToList();

            /////foreach (var category in data) { }
            //Console.WriteLine("Added");
        }
    }
}
