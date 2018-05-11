using System;
using System.Linq;
using final_app;
using final_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace final_app.Controllers
{
    [Route("api/[controller]")]
    public class InventoriesController : Controller
    {
        private InventoryContext InvContext;
        
        public InventoriesController()
        {
            InvContext = new InventoryContext();    
        }

        [HttpGet]
        public string Get()
        {
            var inventor = InvContext
                .Inventories
                .Include(x => x.CategoryDetails)
                .ThenInclude(r => r.Product)
                .Include(x => x.Customer)
                .ToList();
            
            return Ok(query.ToList());
        }

        [HttpPost]
        public string Post([FromBody] Inventory inventory)
        {
            var query = InvContext.Customers                
            .AsQueryable();                           
            InvContext.SaveChanges();
            return Ok(query.ToList());
        }

        [HttpPost("{id}/details")]
        public string PostDetails(int id, [FromBody] CategoryDetail[] categoryDetails)
        {
            var inventory = InvContext.Inventories.First(x => x.Id == id);
            foreach (var categoryDetail in categoryDetails)
            {
                InvContext.CategoryDetails.Add(categoryDetail);
            }

           InvContext.SaveChanges();
            return Ok(query.ToList());
        }
        
    }
}