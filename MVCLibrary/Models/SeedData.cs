using Microsoft.EntityFrameworkCore;
using MVCLibrary.Data;

namespace MVCLibrary.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context=new LibraryContext(serviceProvider.GetRequiredService<DbContextOptions<LibraryContext>>()))
            {
                if (context.Book.Any())
                {
                    return;
                }
                context.Book.AddRange(new Book { Title = "C# project", CallNumber = "RDX 2023",Author="ram" },
                    new Book { Title = "Android project", CallNumber = "TDX 2024" ,Author="sam"});
                context.SaveChanges();
            }
        }
    }
}
