using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class DashboardController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

  [HttpGet]
    public async Task<ActionResult<IEnumerable<Dashboard>>> GetDashboards()
    {
        return await _context.Dashboards.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Dashboard>> GetDashboard(int id)
    {
        var dashboard = await _context.Dashboards.FindAsync(id);

        if (dashboard == null)
        {
            return NotFound();
        }

        return dashboard;
    }

    [HttpPost]
    public async Task<ActionResult<Dashboard>> CreateDashboard(Dashboard dashboard)
    {
        _context.Dashboards.Add(dashboard);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetDashboard), new { id = dashboard.Id }, dashboard);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateDashboard(int id, Dashboard updatedDashboard)
    {
        if (id != updatedDashboard.Id)
        {
            return BadRequest();
        }

        _context.Entry(updatedDashboard).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!DashboardExists(id))
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
    public async Task<IActionResult> DeleteDashboard(int id)
    {
        var dashboard = await _context.Dashboards.FindAsync(id);
        if (dashboard == null)
        {
            return NotFound();
        }

        _context.Dashboards.Remove(dashboard);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool DashboardExists(int id)
    {
        return _context.Dashboards.Any(e => e.Id == id);
    }
}
