using System.Collections.Generic;

namespace final_app.Models
{
    public class CategoryDetail
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public string ProductName {get; set;}
        public Product Product { get; set; }
        
        
        public Inventory Inventory { get; set; }
        public int InventoryId { get; set; }
    }
}