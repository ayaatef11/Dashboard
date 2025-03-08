using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[EnableCors("AllowAngularApp")]

    [Route("api/[controller]")]
    [ApiController]
    public class WidgetController(AppDbContext dbContext) : ControllerBase
    {
        private readonly AppDbContext _dbContext = dbContext;

         [HttpGet]
        public async Task<ActionResult<IEnumerable<Widget>>> Get()
        {
            var widgets = await _dbContext.Widgets.ToListAsync();
            return Ok(widgets);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Widget>> Get(string id)
        {
            var widget = await _dbContext.Widgets.FindAsync(id);
            if (widget == null)
            {
                return NotFound();
            }

            return Ok(widget);
        }

        [HttpPost]
        public async Task<ActionResult<Widget>> Post([FromBody] Widget widget)
        {
            if (widget == null)
            {
                return BadRequest();
            }

            _dbContext.Widgets.Add(widget);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = widget.Id }, widget);
        }

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

