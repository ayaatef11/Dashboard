using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[EnableCors("AllowAngularApp")]

    [Route("api/[controller]")]
    [ApiController]
    public class WidgetController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        // Constructor to inject AppDbContext
        public WidgetController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/Widget
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Widget>>> Get()
        {
            // Retrieve all widgets from the database
            var widgets = await _dbContext.Widgets.ToListAsync();
            return Ok(widgets);
        }

        // GET: api/Widget/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Widget>> Get(string id)
        {
            // Find a specific widget entry by ID
            var widget = await _dbContext.Widgets.FindAsync(id);
            if (widget == null)
            {
                return NotFound();
            }

            return Ok(widget);
        }

        // POST: api/Widget
        [HttpPost]
        public async Task<ActionResult<Widget>> Post([FromBody] Widget widget)
        {
            if (widget == null)
            {
                return BadRequest();
            }

            // Add the new widget entry to the database
            _dbContext.Widgets.Add(widget);
            await _dbContext.SaveChangesAsync();

            // Return the created widget entry with the location of the new resource
            return CreatedAtAction(nameof(Get), new { id = widget.Id }, widget);
        }

        // PUT: api/Widget/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] Widget widget)
        {
            var existingWidget = await _dbContext.Widgets.FindAsync(id);
            if (existingWidget == null)
            {
                return NotFound();
            }

            existingWidget.Name = widget.Name;
            existingWidget.Checked = widget.Checked;

            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var widget = await _dbContext.Widgets.FindAsync(id);
            if (widget == null)
            {
                return NotFound();
            }

            _dbContext.Widgets.Remove(widget);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }

