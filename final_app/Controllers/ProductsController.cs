using System;
using System.Collections.Specialized;
using System.Linq;
using final_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace final_app.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private InventoryContext InvContext;

        public ProductsController()
        {
            InvContext = new InventoryContext();
        }


        [HttpPost]
        public string Post([FromBody] Product product)
        {
            InvContext.Add(product);
            InvContext.SaveChanges();
            return Ok(query.ToList());;
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            var product = InvContext.Products.First(x => x.Id == id);
            InvContext.Products.Remove(product);
            InvContext.SaveChanges();
            return Ok(query.ToList());;
        }
    }
}