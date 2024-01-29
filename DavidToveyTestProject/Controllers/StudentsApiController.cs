using David_Tovey_Test_Project;
using DavidToveyTestProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DavidToveyTestProject.Controllers
{
    [Route("api/students")]
    public class StudentsApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentsApiController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("details/{id:int}")]
        public async Task<Students> Details(int id)
        {
            var students = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);

            return students ?? new Students();
        }

        [HttpGet]
        [Route("all")]
        public async Task<List<Students>> All()
        {
            return await _context.Students.ToListAsync();
        }
    }
}
