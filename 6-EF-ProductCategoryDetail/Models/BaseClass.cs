using _6_EF_ProductCategoryDetail.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_EF_ProductCategoryDetail.Entities
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Statu Statu { get; set; } = Statu.Active;
    }
}
