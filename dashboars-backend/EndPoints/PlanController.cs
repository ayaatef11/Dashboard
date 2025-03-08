using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class PlanController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

  [HttpGet]
    public async Task<ActionResult<IEnumerable<Plan>>> GetPlans()
    {
        return await _context.Plans.Include(p => p.Features).ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Plan>> GetPlan(int id)
    {
        var plan = await _context.Plans.Include(p => p.Features).FirstOrDefaultAsync(p => p.Id == id);

        if (plan == null)
        {
            return NotFound();
        }

        return plan;
    }

    [HttpPost]
    public async Task<ActionResult<Plan>> CreatePlan(Plan plan)
    {
        _context.Plans.Add(plan);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetPlan), new { id = plan.Id }, plan);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePlan(int id, Plan updatedPlan)
    {
        if (id != updatedPlan.Id)
        {
            return BadRequest();
        }

        _context.Entry(updatedPlan).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!PlanExists(id))
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
    public async Task<IActionResult> DeletePlan(int id)
    {
        var plan = await _context.Plans.FindAsync(id);
        if (plan == null)
        {
            return NotFound();
        }

        _context.Plans.Remove(plan);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool PlanExists(int id)
    {
        return _context.Plans.Any(e => e.Id == id);
    }
}
