using System;
using System.Collections.Generic;

namespace DAL
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        //Navigation Property, help full in lazy loading
        public virtual ICollection<Product> Products { get; set; }
    }
}
