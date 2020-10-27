using ClinicalTrialsWebApp.DTO;
using ClinicalTrialsWebApp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalTrialsWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagListsController : ControllerBase
    {
        private ILogger<TagListsController> _logger;
        private IRepositoryWrapper _repoWrapper;
        public TagListsController(IRepositoryWrapper repoWrapper, ILogger<TagListsController> logger)
        {
            _logger = logger;

            _repoWrapper = repoWrapper;
        }


        // GET: api/TagLists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TagList>>> GetTagLists()
        {
            return await _repoWrapper.TagList.FindAll().ToListAsync();
        }

        // GET: api/TagLists/5
        [HttpGet("{id}", Name = "GetTagList")]
        public async Task<ActionResult<TagList>> GetTagList(int id)
        {
            var tagList = await _repoWrapper.TagList.GetTagListByIdAsync(id);

            if (tagList == null)
            {
                _logger.LogError($"TagList with id: {id}, hasn't been found in db.");
                return NotFound();
            }

            return tagList;
        }
        
        [HttpGet]
        [Route("study/{NCTId}")]
        public async Task<ActionResult<IEnumerable<TagList>>> GetTagListsByNCTId(string? NCTId)
        {
            var tagList = await _repoWrapper.TagList.GetTagListByNCTIdAsync(NCTId);
            
            if (tagList == null)
            {
                _logger.LogError($"TagLists with NCTId: {NCTId}, hasn't been found in db.");
                return NotFound();
            }

            return tagList.ToList();
        }

        //POST: api/TagLists
        [HttpPost]
        public async Task<IActionResult> CreateTagList([FromBody]TagListDTO tagListDTO)
        {
            //create a mapper in next version
             try
             {
                 if (tagListDTO == null)
                 {
                     _logger.LogError("TagList object sent from client is null.");
                     return BadRequest("TagList object is null");
                 }
                 if (!ModelState.IsValid)
                 {
                     _logger.LogError("Invalid model object sent from client.");
                     return BadRequest("Invalid model object");
                 }
                 //var tagEntity = _mapper.Map<Tag>(tag);

                 TagList tagList = new TagList();
                 tagList.NCTId = tagListDTO.NCTId;
                 tagList.TagId = tagListDTO.TagId;
                 tagList.Section = tagListDTO.Section;

                if (await _repoWrapper.TagList.GetTagListByIdAsync(tagListDTO.Id) != null)
                {
                    _logger.LogError($"There's already a taglist with id: {tagListDTO.Id}, exiting CreateTagList action.");
                    return StatusCode(409, "Taglist already exists.");
                }

                 _repoWrapper.TagList.Create(tagList);
                 _repoWrapper.Save();

                 //var createdTag = _mapper.Map<TagDto>(tagEntity);
                 return CreatedAtRoute("GetTagList", new { id = tagList.Id }, tagList);
             }
             catch (Exception ex)
             {
                 _logger.LogError($"Something went wrong inside CreateTagList action: {ex.Message}");
                 return StatusCode(500, "Internal server error");
             }
        }

        [HttpDelete("{TagId}/{NCTId}/{Section}")]
        public async Task<IActionResult> DeleteTagList(int TagId, string NCTId, string Section)
        {
            try
            {
                TagList tagList = await _repoWrapper.TagList.FindByCondition
                    (x => x.TagId == TagId && x.NCTId == NCTId && x.Section == Section).FirstAsync();

                if (tagList == null)
                    return NotFound();

                _repoWrapper.TagList.Delete(tagList);
                _repoWrapper.Save();
                
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside DeleteTagList action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
