using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _6_EF_ProductCategoryDetail.Enums;

namespace _6_EF_ProductCategoryDetail.Entities
{
    public class ProductDetail
    {
        public int ProductDetailId { get; set; }
        public string? Color { get; set; } //boş geçilebilir
        public double Width { get; set; }
        public double Height { get; set; }
        public Statu Status { get; set; }

        public int ProductRefId { get; set; }
        public virtual Product Product { get; set; }

    }
}
