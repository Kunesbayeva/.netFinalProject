using System;
using System.Collections.Generic;

namespace final_app.Models
{
    public class Category
    {
        public int Id { get; set; }
        public DateTime InvenotoryTime { get; set; }
        
        public List<CategoryDetail> CategoryDetails { get; set; }
        
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}