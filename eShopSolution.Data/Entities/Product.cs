using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int OriginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public int DateCreated { get; set; }
        public int SeoAlias { get; set; }
    }
}
