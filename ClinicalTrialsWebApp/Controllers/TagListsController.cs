using ClinicalTrialsWebApp.DTO;
using ClinicalTrialsWebApp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        //private ILoggerManager _logger;
        private IRepositoryWrapper _repoWrapper;
        public TagListsController(IRepositoryWrapper repoWrapper)
        {
            //ILoggerManager logger as param
            //_logger = logger;

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
                return NotFound();
            }

            return tagList;
        }
        
        [HttpGet]
        [Route("study/{NCTId}")]
        public async Task<IEnumerable<TagList>> GetTagListsByNCTId(string? NCTId)
        {
                return await _repoWrapper.TagList.GetTagListByNCTIdAsync(NCTId);
        }

        //POST: api/TagLists
        [HttpPost]
        public IActionResult CreateTagList([FromBody]TagListDTO tagListDTO)
        {
          
            //create a mapper in next version
             try
             {
                 if (tagListDTO == null)
                 {
                     //_logger.LogError("Tag object sent from client is null.");
                     Console.WriteLine("Tag object sent from client is null.");
                     return BadRequest("Tag object is null");
                 }
                 if (!ModelState.IsValid)
                 {
                     //_logger.LogError("Invalid tag object sent from client.");
                     Console.WriteLine("Invalid tag object sent from client.");
                     return BadRequest("Invalid model object");
                 }
                 //var tagEntity = _mapper.Map<Tag>(tag);

                 TagList tagList = new TagList();
                 tagList.NCTId = tagListDTO.NCTId;
                 tagList.TagId = tagListDTO.TagId;
                 if(!String.IsNullOrEmpty(tagListDTO.Section))
                     tagList.Section = tagListDTO.Section;

                 _repoWrapper.TagList.Create(tagList);
                 _repoWrapper.Save();

                 //var createdTag = _mapper.Map<TagDto>(tagEntity);
                 //return CreatedAtRoute("TagById", new { id = createdTag.Id }, createdTag);
                 return CreatedAtRoute("GetTagList", new { id = tagList.Id }, tagList);
             }
             catch (Exception ex)
             {
                 //_logger.LogError($"Something went wrong inside Create action: {ex.Message}");
                 Console.WriteLine($"Something went wrong inside Create action: {ex.Message}");
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
                //_logger.LogError($"Something went wrong inside Delete action: {ex.Message}");
                Console.WriteLine($"Something went wrong inside Delete action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
