using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


    [Route("api/[controller]")]
    [ApiController]
    public class BackupTimeController : ControllerBase
    {
        // Temporary in-memory data store for BackupTimes (You would typically use a database here)
        private static List<BackupTime> backupTimes = new List<BackupTime>
        {
            new BackupTime("1", "Daily Backup", true),
            new BackupTime("2", "Weekly Backup", false)
        };

        // GET: api/BackupTime
        [HttpGet]
        public ActionResult<IEnumerable<BackupTime>> Get()
        {
            return Ok(backupTimes);
        }

        // GET: api/BackupTime/5
        [HttpGet("{id}")]
        public ActionResult<BackupTime> Get(string id)
        {
            var backupTime = backupTimes.FirstOrDefault(b => b.Id == id);
            if (backupTime == null)
            {
                return NotFound();
            }

            return Ok(backupTime);
        }

        // POST: api/BackupTime
        [HttpPost]
        public ActionResult<BackupTime> Post([FromBody] BackupTime backupTime)
        {
            if (backupTime == null)
            {
                return BadRequest();
            }

            backupTimes.Add(backupTime);
            return CreatedAtAction(nameof(Get), new { id = backupTime.Id }, backupTime);
        }

        // PUT: api/BackupTime/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] BackupTime backupTime)
        {
            var existingBackupTime = backupTimes.FirstOrDefault(b => b.Id == id);
            if (existingBackupTime == null)
            {
                return NotFound();
            }

            existingBackupTime.Label = backupTime.Label;
            existingBackupTime.Checked = backupTime.Checked;

            return NoContent();
        }

        // DELETE: api/BackupTime/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var backupTime = backupTimes.FirstOrDefault(b => b.Id == id);
            if (backupTime == null)
            {
                return NotFound();
            }

            backupTimes.Remove(backupTime);
            return NoContent();
        }
    }
