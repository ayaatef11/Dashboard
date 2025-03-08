using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[Route("api/[controller]")]
[ApiController]
public class FileCategoryController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

  [HttpGet]
    public async Task<ActionResult<IEnumerable<FileCategory>>> GetFileCategories()
    {
        return await _context.FileCategories.ToListAsync();
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<FileCategory>> GetFileCategory(int id)
    {
        var fileCategory = await _context.FileCategories.FindAsync(id);

        if (fileCategory == null)
        {
            return NotFound();
        }

        return fileCategory;
    }

    [HttpPost]
    public async Task<ActionResult<FileCategory>> CreateFileCategory(FileCategory fileCategory)
    {
        _context.FileCategories.Add(fileCategory);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetFileCategory), new { id = fileCategory.Id }, fileCategory);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateFileCategory(int id, FileCategory updatedFileCategory)
    {
        if (id != updatedFileCategory.Id)
        {
            return BadRequest();
        }

        _context.Entry(updatedFileCategory).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!FileCategoryExists(id))
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
    public async Task<IActionResult> DeleteFileCategory(int id)
    {
        var fileCategory = await _context.FileCategories.FindAsync(id);
        if (fileCategory == null)
        {
            return NotFound();
        }

        _context.FileCategories.Remove(fileCategory);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool FileCategoryExists(int id)
    {
        return _context.FileCategories.Any(e => e.Id == id);
    }
}
