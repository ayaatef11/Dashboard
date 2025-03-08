using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[EnableCors("AllowAngularApp")]

    [Route("api/[controller]")]
    [ApiController]
    public class SettingsItemsController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

    [HttpGet]
        public async Task<ActionResult<IEnumerable<SettingsItem>>> GetSettingsItems()
        {
            return await _context.SettingsItems.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SettingsItem>> GetSettingsItem(int id)
        {
            var SettingsItem = await _context.SettingsItems.FindAsync(id);

            if (SettingsItem == null)
            {
                return NotFound();
            }

            return SettingsItem;
        }

        [HttpPost]
        public async Task<ActionResult<SettingsItem>> PostSettingsItem(SettingsItem SettingsItem)
        {
            _context.SettingsItems.Add(SettingsItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSettingsItem), new { id = SettingsItem.Id }, SettingsItem);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSettingsItem(int id, SettingsItem SettingsItem)
        {
            if (id != SettingsItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(SettingsItem).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSettingsItem(int id)
        {
            var SettingsItem = await _context.SettingsItems.FindAsync(id);
            if (SettingsItem == null)
            {
                return NotFound();
            }

            _context.SettingsItems.Remove(SettingsItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }

