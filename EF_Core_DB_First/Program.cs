namespace EF_Core_DB_First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCourseDbContext dbContext = new MyCourseDbContext();

            //Student student = new()
            //{
            //    Name = "Vuqar",
            //    Surname = "Rehimzade",
            //    Age = 22,
            //    Email = "vuqar@gmail.com"
            //};

            //dbContext.Students.Add(student);
            //dbContext.SaveChanges();

            var students = dbContext.Students
                .Where(x => x.Deleted == 0 && x.Name == "Omar").ToList();

            foreach (var item in students)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
