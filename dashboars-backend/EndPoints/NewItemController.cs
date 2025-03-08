using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[Route("api/[controller]")]
[ApiController]
public class NewItemController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

  [HttpGet]
    public async Task<ActionResult<IEnumerable<NewItem>>> GetNewItems()
    {
        return await _context.NewItems.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<NewItem>> GetNewItem(int id)
    {
        var newItem = await _context.NewItems.FindAsync(id);

        if (newItem == null)
        {
            return NotFound();
        }

        return newItem;
    }

    [HttpPost]
    public async Task<ActionResult<NewItem>> CreateNewItem(NewItem newItem)
    {
        _context.NewItems.Add(newItem);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetNewItem), new { id = newItem.Id }, newItem);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateNewItem(int id, NewItem updatedNewItem)
    {
        if (id != updatedNewItem.Id)
        {
            return BadRequest();
        }

        _context.Entry(updatedNewItem).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!NewItemExists(id))
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
    public async Task<IActionResult> DeleteNewItem(int id)
    {
        var newItem = await _context.NewItems.FindAsync(id);
        if (newItem == null)
        {
            return NotFound();
        }

        _context.NewItems.Remove(newItem);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool NewItemExists(int id)
    {
        return _context.NewItems.Any(e => e.Id == id);
    }
}
