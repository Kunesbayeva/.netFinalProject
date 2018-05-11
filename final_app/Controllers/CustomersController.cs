using System.Linq;
using final_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace final_app.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private InventoryContext InvContext;
        public CustomersController()
        {
            InvContext = new InventoryContext();
        }
        
        // GET
        

    }
}