using Data;
using Microsoft.AspNetCore.Mvc;

namespace Specification_pattern.Controllers
{
    public class EmployeeController : Controller
    {
        //private readonly ItemSpecifications _itemSpecifications;

        public EmployeeController() 
        {
          //  _itemSpecifications = itemSpecifications;
        }




        //[HttpGet("{id}")]
        //public async Task<ActionResult<Employee>> GetItem(int id)
        //{
        //    var item = await _itemSpecifications.GetItemByIdAsync(id);
        //    if (item == null)
        //    {
        //        return NotFound();
        //    }
        //    return item;
        //}
    }
}
