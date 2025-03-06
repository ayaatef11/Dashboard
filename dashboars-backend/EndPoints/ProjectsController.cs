using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[EnableCors("AllowAngularApp")]

    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

         [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
        {
            return await _context.Projects.ToListAsync();
        }

            [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetMenuItem(int id)
        {
            var menuItem = await _context.Projects.FindAsync(id);

            if (menuItem == null)
            {
                return NotFound();
            }

            return menuItem;
        }

           [HttpPost]
        public async Task<ActionResult<Project>> PostMenuItem(Project menuItem)
        {
            _context.Projects.Add(menuItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMenuItem), new { id = menuItem.Id }, menuItem);
        }

            [HttpPut("{id}")]
        public async Task<IActionResult> PutMenuItem(int id, Project menuItem)
        {
            if (id != menuItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(menuItem).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenuItem(int id)
        {
            var menuItem = await _context.Projects.FindAsync(id);
            if (menuItem == null)
            {
                return NotFound();
            }

            _context.Projects.Remove(menuItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
