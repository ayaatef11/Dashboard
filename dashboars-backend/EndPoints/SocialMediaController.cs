using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        // Temporary in-memory data store for SocialMedia (You would typically use a database here)
        private static List<SocialMedia> socialMedias = new List<SocialMedia>
        {
            new SocialMedia("1", "facebook-icon", "Enter your Facebook URL"),
            new SocialMedia("2", "twitter-icon", "Enter your Twitter URL")
        };

        // GET: api/SocialMedia
        [HttpGet]
        public ActionResult<IEnumerable<SocialMedia>> Get()
        {
            return Ok(socialMedias);
        }

        // GET: api/SocialMedia/5
        [HttpGet("{id}")]
        public ActionResult<SocialMedia> Get(string id)
        {
            var socialMedia = socialMedias.FirstOrDefault(s => s.Id == id);
            if (socialMedia == null)
            {
                return NotFound();
            }

            return Ok(socialMedia);
        }

        // POST: api/SocialMedia
        [HttpPost]
        public ActionResult<SocialMedia> Post([FromBody] SocialMedia socialMedia)
        {
            if (socialMedia == null)
            {
                return BadRequest();
            }

            socialMedias.Add(socialMedia);
            return CreatedAtAction(nameof(Get), new { id = socialMedia.Id }, socialMedia);
        }

        // PUT: api/SocialMedia/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] SocialMedia socialMedia)
        {
            var existingSocialMedia = socialMedias.FirstOrDefault(s => s.Id == id);
            if (existingSocialMedia == null)
            {
                return NotFound();
            }

            existingSocialMedia.Icon = socialMedia.Icon;
            existingSocialMedia.Placeholder = socialMedia.Placeholder;

            return NoContent();
        }

        // DELETE: api/SocialMedia/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var socialMedia = socialMedias.FirstOrDefault(s => s.Id == id);
            if (socialMedia == null)
            {
                return NotFound();
            }

            socialMedias.Remove(socialMedia);
            return NoContent();
        }
    }
