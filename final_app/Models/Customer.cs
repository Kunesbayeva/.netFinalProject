using System.Collections.Generic;

namespace final_app.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        
        public List<Inventory> Inventory { get; set; }
    }
}