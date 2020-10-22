using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExample
{
    public class DataService
    {

        IList<Category> GetCategories()
        {
            using var ctx = new NorthWindContext();
            return ctx.Categories.ToList();
        }

    }
}
