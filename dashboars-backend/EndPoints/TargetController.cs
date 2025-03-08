using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class TargetController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

  [HttpGet]
    public async Task<ActionResult<IEnumerable<Target>>> GetTargets()
    {
        return await _context.Targets.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Target>> GetTarget(int id)
    {
        var target = await _context.Targets.FindAsync(id);

        if (target == null)
        {
            return NotFound();
        }

        return target;
    }

    [HttpPost]
    public async Task<ActionResult<Target>> CreateTarget(Target target)
    {
        _context.Targets.Add(target);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetTarget), new { id = target.Id }, target);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTarget(int id, Target updatedTarget)
    {
        if (id != updatedTarget.Id)
        {
            return BadRequest();
        }

        _context.Entry(updatedTarget).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!TargetExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTarget(int id)
    {
        var target = await _context.Targets.FindAsync(id);
        if (target == null)
        {
            return NotFound();
        }

        _context.Targets.Remove(target);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool TargetExists(int id)
    {
        return _context.Targets.Any(e => e.Id == id);
    }
}
