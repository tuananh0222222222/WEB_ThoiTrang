using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CategoryModel
    {
        private ShopDbContext context = null;
        public CategoryModel()
        {
            context = new ShopDbContext();
        }
      

      public List<Category> listAll()
        {
            var list = context.Database.SqlQuery<Category>("Sp_Category_ListAll").ToList();
            return list;
        }
    }
}
