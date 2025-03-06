using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    [Route("api/[controller]")]
    [ApiController]
    public class BackupTimesController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public BackupTimeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BackupTime>>> Get()
        {
            var backupTimes = await _dbContext.BackupTimes.ToListAsync();
            return Ok(backupTimes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BackupTime>> Get(string id)
        {
            var backupTime = await _dbContext.BackupTimes.FindAsync(id);
            if (backupTime == null)
            {
                return NotFound();
            }

            return Ok(backupTime);
        }

        [HttpPost]
        public async Task<ActionResult<BackupTime>> Post([FromBody] BackupTime backupTime)
        {
            if (backupTime == null)
            {
                return BadRequest();
            }

            _dbContext.BackupTimes.Add(backupTime);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = backupTime.Id }, backupTime);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] BackupTime backupTime)
        {
            var existingBackupTime = await _dbContext.BackupTimes.FindAsync(id);
            if (existingBackupTime == null)
            {
                return NotFound();
            }

            existingBackupTime.Label = backupTime.Label;
            existingBackupTime.Checked = backupTime.Checked;

            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var backupTime = await _dbContext.BackupTimes.FindAsync(id);
            if (backupTime == null)
            {
                return NotFound();
            }

            _dbContext.BackupTimes.Remove(backupTime);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }

