using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _6_EF_ProductCategoryDetail.Enums;

namespace _6_EF_ProductCategoryDetail.Entities
{
    public class Product
    {
        private double _stock;
        private decimal _price;
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Stock
        {
            get { return _stock; }
            set
            {
                if (value < 0)
                {
                    _stock = 10;
                }
                else _stock = value;
            }
        }
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("0 dan küçük olamaz");
                }
                else _price = value;
            }
        }
        public DateTime Date { get; set; } = DateTime.Now;
        public Statu Status { get; set; }

        public int CategoryRefId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }

    }
}
