using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using ClinicalTrialsWebApp.DTO;
using ClinicalTrialsWebApp.Repository;
using ClinicalTrialsWebApp.Pagination;
using Microsoft.Extensions.Logging;
using ClinicalTrialsWebApp.Controllers;

namespace ClinicalTrialsWebApp
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudyStructuresController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;
        private readonly IUriService uriService;
        private ILogger<StudyStructuresController> _logger;


        public StudyStructuresController(IRepositoryWrapper repoWrapper, IUriService uriService, ILogger<StudyStructuresController> logger)
        {
            _logger = logger;
            _repoWrapper = repoWrapper;
            this.uriService = uriService;
        }

        // GET: api/StudyStructures
        [HttpGet]
        public async Task<IEnumerable<Root>> GetStudies()
        {
            return await _repoWrapper.StudyStructure.GetAllStudiesAsync();
        }

        // GET: api/StudyStructures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudyView>> GetStudy(int id)
        {
            var study = await _repoWrapper.StudyStructure.GetStudyWithDetailsAsync(id);

            if (study == null)
            {
                _logger.LogError($"Study with id: {id}, hasn't been found in db.");
                return NotFound();
            }

            IEnumerable<TagList> tagLists = await _repoWrapper.TagList.GetTagListByNCTIdAsync(study.NCTId);

            study.TagLists = tagLists.ToList();

            return study;
        }
       
        //GET: api/StudyStructures/search
        [HttpGet]
        [Route("search")] 
        public ActionResult<IEnumerable<Root>> SearchStudies([FromQuery] PaginationFilter filter)
        {
            try
            {
                var route = Request.Path.Value;
                var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter.Condition, filter.Country, filter.Sponsor);

                var pagedData = _repoWrapper.StudyStructure.SimpleSearch(validFilter);

                var totalRecords = _repoWrapper.StudyStructure.GetSearchCount(validFilter);
                //var totalRecords = 1000; 
                //mozda bi se mogli prvo vratiti rezultati pa onda ostalo za paging
                
                if (pagedData == null)
                {
                    _logger.LogInformation("No studies found.");
                    return NotFound();
                }

                var pagedReponse = PaginationHelper.CreatePagedReponse<ResultDTO>(pagedData, validFilter, totalRecords, uriService, route);
                return Ok(pagedReponse);
            } catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside SearchStudies action: {e.Message}");
                return StatusCode(404, e.Message);
            }
        }

        [HttpPost]
        [Route("searchIds")]
        public ActionResult<int[]> SearchStudyIds(SearchDTO searchDTO)
        {
            try
            {
                var ids = _repoWrapper.StudyStructure.SearchStudyIds(searchDTO);

                if (ids == null)
                {
                    _logger.LogInformation("No study ids found.");
                    return NotFound();
                }

                return Ok(ids);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside SearchStudyIds action: {e.Message}");
                return StatusCode(404, e.Message);
            }
        }

    }
}