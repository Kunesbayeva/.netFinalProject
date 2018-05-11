using System;
using System.Collections.Generic;

namespace final_app.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public DateTime RentTime { get; set; }
        
        public List<CategoryDetail> CategoryDetails { get; set; }
        
        public int CustomertId { get; set; }
        public Customer Customer { get; set; }
    }
}