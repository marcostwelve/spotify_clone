using Microsoft.AspNetCore.Mvc;
using Modelos.Models;
using Services.Interfaces;

namespace spotifyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private readonly IService _service;
        public MediaController(IService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var medias = await _service.GetAll();
            return Ok(medias);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Media media)
        {
            if (media == null)
            {
                return BadRequest("Media cannot be null");
            }
            await _service.Insert(media);
            return CreatedAtAction(nameof(GetAll), new { id = media.Id }, media);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Media media)
        {
            if (media == null)
            {
                return BadRequest("Media cannot be null");
            }
            await _service.Update(media);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid media ID");
            }
            await _service.Delete(id);
            return NoContent();
        }
    }
}
