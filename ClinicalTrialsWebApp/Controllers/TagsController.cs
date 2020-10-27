using ClinicalTrialsWebApp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private ILogger<TagsController> _logger;
        private IRepositoryWrapper _repoWrapper;
        public TagsController(IRepositoryWrapper repoWrapper, ILogger<TagsController> logger)
        {
            
            _logger = logger;
            _repoWrapper = repoWrapper;
        }


        // GET: api/Tags
        [HttpGet]
        public async Task<IEnumerable<Tag>> GetTags()
        {
            return await _repoWrapper.Tag.GetAllTagsAsync();
        }

        // GET: api/Tags/5
        [HttpGet("{id}", Name= "GetTag")]
        public async Task<ActionResult<Tag>> GetTag(int id)
        {
            var tag = await _repoWrapper.Tag.GetTagByIdAsync(id);

            if (tag == null)
            {
                _logger.LogError($"Tag with id: {id}, hasn't been found in db.");
                return NotFound();
            }

            return tag;
        }

        //POST: api/Tags
        [HttpPost]
        public IActionResult CreateTag([FromBody]Tag tag)
        {
            //create a dto in next version
            try
            {
                if (tag == null)
                {
                    _logger.LogError("Tag object sent from client is null.");
                    return BadRequest("Tag object is null");
                }
                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid tag object sent from client.");
                    return BadRequest("Invalid model object");
                }
                //var tagEntity = _mapper.Map<Tag>(tag);
                tag.Deleted = false;
                _repoWrapper.Tag.Create(tag);
                _repoWrapper.Save();
                //var createdTag = _mapper.Map<TagDto>(tagEntity);
                //return CreatedAtRoute("TagById", new { id = createdTag.Id }, createdTag);
                return CreatedAtRoute("GetTag", new { id = tag.Id }, tag);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside CreateTag action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTag(int id)
        {
            try
            {
                var tag = await _repoWrapper.Tag.GetTagByIdAsync(id);
                if (tag == null)
                {
                    _logger.LogError($"Tag with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                _repoWrapper.Tag.DeleteTag(tag);

                foreach (TagList tl in await _repoWrapper.TagList.GetTagListByTagIdAsync(id))
                {
                    _repoWrapper.TagList.Delete(tl);
                }
                _repoWrapper.Save();
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside DeleteTag action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
