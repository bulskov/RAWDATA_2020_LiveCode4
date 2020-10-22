
using System;
using System.Linq;

namespace EFExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using var ctx = new NorthWindContext();

            //var maxId = ctx.Categories.Max(x => x.Id);

            //ctx.Categories.Add(new Category {Id = maxId + 1, Name = "Testing"});

            ctx.SaveChanges();

            foreach (var category in ctx.Categories)
            {
                Console.WriteLine(category);
            }
        }
    }
}
