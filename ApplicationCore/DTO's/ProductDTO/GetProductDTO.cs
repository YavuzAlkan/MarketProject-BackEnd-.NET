using ApplicationCore.Entities.Abstract;
using ApplicationCore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DTO_s.ProductDTO
{
    public class GetProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Status Status { get; set; }

        public string CategoryName { get; set; }
        
    }
}
