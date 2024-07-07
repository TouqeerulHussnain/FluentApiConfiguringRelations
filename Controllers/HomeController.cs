using FluentApiConfiguringRelations.Core.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FluentApiConfiguringRelations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public HomeController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet("GetEmployee")]
        public async Task<IActionResult> GetEmployee()
        {
            var employee = await context.Employees.ToArrayAsync();
            return Ok(employee);
        }
    }
}
