﻿using System;
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
    public class StatisticsController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;
        private ILogger<StudyStructuresController> _logger;

        public StatisticsController(IRepositoryWrapper repoWrapper, ILogger<StudyStructuresController> logger)
        {
            _logger = logger;
            _repoWrapper = repoWrapper;
        }

        [HttpPost]
        public ActionResult MakeStatistics(SearchDTO searchDTO)
        {
            try
            {
                _repoWrapper.StatisticsSearch.Create(new StatisticsSearch { Condition = searchDTO.Condition, DateCreated = DateTime.Now });
                _repoWrapper.Save();
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside MakeStatistics action: {e.Message}");
                return StatusCode(404, e.Message);
            }
        }

        [HttpGet]
        [Route("trialsByYear")]
        public ActionResult TrialsByYears()
        {
            try
            {
                var retVal = _repoWrapper.StatisticsSearch.TrialsByYearsStatistics();
                return Ok(retVal);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside TrialsByYears action: {e.Message}");
                return StatusCode(404, e.Message);
            }
        }

        [HttpGet]
        [Route("studyType")]
        public ActionResult StudyType()
        {
            try
            {
                var retVal = _repoWrapper.StatisticsSearch.StudyTypeStatistics();
                return Ok(retVal);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside StudyType action: {e.Message}");
                return StatusCode(404, e.Message);
            }
        }

        [HttpGet]
        [Route("status")]
        public ActionResult Status()
        {
            try
            {
                var retVal = _repoWrapper.StatisticsSearch.StatusStatistics();
                return Ok(retVal);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside Status action: {e.Message}");
                return StatusCode(404, e.Message);
            }
        }

        [HttpGet]
        [Route("phaseList")]
        public ActionResult PhaseList()
        {
            try
            {
                var retVal = _repoWrapper.StatisticsSearch.PhaseListStatistics();
                return Ok(retVal);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside PhaseList action: {e.Message}");
                return StatusCode(404, e.Message);
            }
        }

        [HttpGet]
        [Route("country")]
        public ActionResult Country()
        {
            try
            {
                var retVal = _repoWrapper.StatisticsSearch.CountryStatistics();
                return Ok(retVal);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside Country action: {e.Message}");
                return StatusCode(404, e.Message);
            }
        }


        [HttpGet]
        [Route("location")]
        public ActionResult Location()
        {
            try
            {
                var retVal = _repoWrapper.StatisticsSearch.LocationStatistics();
                return Ok(retVal);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside Location action: {e.Message}");
                return StatusCode(404, e.Message);
            }
        }

        [HttpGet]
        [Route("sponsor")]
        public ActionResult Sponsor()
        {
            try
            {
                var retVal = _repoWrapper.StatisticsSearch.SponsorStatistics();
                return Ok(retVal);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside Sponsor action: {e.Message}");
                return StatusCode(404, e.Message);
            }
        }

        [HttpGet]
        [Route("duration")]
        public ActionResult Duration()
        {
            try
            {
                var retVal = _repoWrapper.StatisticsSearch.DurationStatistics();
                return Ok(retVal);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside Duration action: {e.Message}");
                return StatusCode(404, e.Message);
            }
        }

        [HttpGet]
        [Route("locationCities")]
        public ActionResult GetLocationCities()
        {
            try
            {
                var retVal = _repoWrapper.StatisticsSearch.GetLocationCitiesAsync();
                return Ok(retVal);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside GetLocationCities action: {e.Message}");
                return StatusCode(404, e.Message);
            }
        }

    }
}