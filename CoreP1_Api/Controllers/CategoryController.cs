using CoreP1_Api.DAL.ApiContext;
using CoreP1_Api.DAL.ApiEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq;

namespace CoreP1_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult Categorylist()
        {
            using var c = new Context();
            return Ok(c.Categories.ToList()); 
        }
        [HttpGet("{id}")]
        public IActionResult CategoryGetByID(int id)
        {
            using var c = new Context();
            var values = c.Categories.Find(id);
            if(values==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(values);
            }
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category p) 
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("",p);
        }
        [HttpDelete]
        public IActionResult CategoryDelete(int id)
        {
            using var c = new Context();
            var x = c.Categories.Find(id);
            if(x==null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(x);
                c.SaveChanges();
                return NoContent();
            }
        }
        [HttpPut]
        public IActionResult UpdateCategory(Category p)
        {
            using var c = new Context();
            var x = c.Find<Category>(p.CategoryID);
            if(x==null)
            {
                return NotFound();
            }
            else
            {
                x.CategoryName = p.CategoryName;
                c.Update(x);
                c.SaveChanges();
                return NoContent();
            }
        }
    }
}
