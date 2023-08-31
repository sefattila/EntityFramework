using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _6_EF_ProductCategoryDetail.Enums;

namespace _6_EF_ProductCategoryDetail.Entities
{
    public class Category : BaseClass
    {
        //public int CategoryId { get; set; }
        public string Name { get; set; }
        //public Statu Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
