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

namespace ClinicalTrialsWebApp
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudyStructuresController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;
        private readonly IUriService uriService;

        public StudyStructuresController(IRepositoryWrapper repoWrapper, IUriService uriService)
        {
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
        public async Task<ActionResult<Root>> GetRoot(int id)
        {
            var root = await _repoWrapper.StudyStructure.GetStudyByIdAsync(id);

            if (root == null)
            {
                return NotFound();
            }

            return root;
        }
       
        //GET: api/StudyStructures/search
        [HttpGet]
        [Route("search")] 
        public ActionResult<IEnumerable<Root>> SearchStudies([FromQuery] PaginationFilter filter)
        {
            //IEnumerable<Root> retValTotal = new List<Root>();
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter.Condition, filter.Country, filter.Sponsor);
            SearchDTO searchDTO = new SearchDTO();
            searchDTO.Condition = filter.Condition;
            searchDTO.Sponsor = filter.Sponsor;
            searchDTO.Country = filter.Country;

            //retValTotal = _repoWrapper.StudyStructure.SimpleSearch(searchDTO);

            var pagedData = _repoWrapper.StudyStructure.SimpleSearch(searchDTO).OrderBy(x => x.Id)
                .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                .Take(validFilter.PageSize).ToList();

            var totalRecords = _repoWrapper.StudyStructure.SimpleSearch(searchDTO).Count();

            if (pagedData == null)
            {
                return NotFound();
            }

            var pagedReponse = PaginationHelper.CreatePagedReponse<Root>(pagedData, validFilter, totalRecords, uriService, route);
            return Ok(pagedReponse);
            //return retVal.ToList();

        }

    }
}