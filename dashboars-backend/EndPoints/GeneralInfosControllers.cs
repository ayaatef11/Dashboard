using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


    [Route("api/[controller]")]
    [ApiController]
    public class GeneralInfoController : ControllerBase
    {
        // Temporary in-memory data store for GeneralInfos (You would typically use a database here)
        private static List<GeneralInfo> generalInfos = new List<GeneralInfo>
        {
            new GeneralInfo("Username", "text", "username", "Enter your username", "", false, true),
            new GeneralInfo("Email", "email", "email", "Enter your email", "", false, false)
        };

        // GET: api/GeneralInfo
        [HttpGet]
        public ActionResult<IEnumerable<GeneralInfo>> Get()
        {
            return Ok(generalInfos);
        }

        // GET: api/GeneralInfo/5
        [HttpGet("{id}")]
        public ActionResult<GeneralInfo> Get(string id)
        {
            var generalInfo = generalInfos.FirstOrDefault(g => g.Id == id);
            if (generalInfo == null)
            {
                return NotFound();
            }

            return Ok(generalInfo);
        }

        // POST: api/GeneralInfo
        [HttpPost]
        public ActionResult<GeneralInfo> Post([FromBody] GeneralInfo generalInfo)
        {
            if (generalInfo == null)
            {
                return BadRequest();
            }

            generalInfos.Add(generalInfo);
            return CreatedAtAction(nameof(Get), new { id = generalInfo.Id }, generalInfo);
        }

        // PUT: api/GeneralInfo/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] GeneralInfo generalInfo)
        {
            var existingGeneralInfo = generalInfos.FirstOrDefault(g => g.Id == id);
            if (existingGeneralInfo == null)
            {
                return NotFound();
            }

            existingGeneralInfo.Label = generalInfo.Label;
            existingGeneralInfo.Type = generalInfo.Type;
            existingGeneralInfo.Placeholder = generalInfo.Placeholder;
            existingGeneralInfo.Value = generalInfo.Value;
            existingGeneralInfo.Disabled = generalInfo.Disabled;
            existingGeneralInfo.ShowLink = generalInfo.ShowLink;

            return NoContent();
        }

        // DELETE: api/GeneralInfo/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var generalInfo = generalInfos.FirstOrDefault(g => g.Id == id);
            if (generalInfo == null)
            {
                return NotFound();
            }

            generalInfos.Remove(generalInfo);
            return NoContent();
        }
    }
