using System;
using Microsoft.AspNetCore.Mvc;
using Model;
using ClinicalTrialsWebApp.DTO;
using ClinicalTrialsWebApp.Repository;
using Microsoft.Extensions.Logging;
using System.IO;
using RDotNet;

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

        [HttpPost]
        [Route("country")]
        public ActionResult Country(SearchDTO searchDTO)
        {
            try
            {
                var retVal = _repoWrapper.StatisticsSearch.CountryStatistics(searchDTO);
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
        public ActionResult LocationFromView()
        {
            try
            {
                var retVal = _repoWrapper.StatisticsSearch.LocationFromViewStatistics();
                return Ok(retVal);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside LocationFromViewStatistics action: {e.Message}");
                return StatusCode(404, e.Message);
            }
        }

        [HttpPost]
        [Route("location")]
        public ActionResult Location(SearchDTO searchDTO)
        {
            try
            {
                var retVal = _repoWrapper.StatisticsSearch.LocationStatistics(searchDTO);
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

        [HttpGet]
        [Route("interventionalStudies")]
        public ActionResult InterventionalStudies()
        {
            try
            {
                var retVal = _repoWrapper.StatisticsSearch.InterventionalStudiesStatistics();
                return Ok(retVal);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside InterventionalStudies action: {e.Message}");
                return StatusCode(404, e.Message);
            }
        }

        [HttpGet]
        [Route("test")]
        public ActionResult Test()
        {
            try
            {
                var scriptpath = Path.Combine(Directory.GetCurrentDirectory(), "..\\test.R");

                string result;
                string input;
                REngine engine;

                //init the R engine            
                REngine.SetEnvironmentVariables();
                engine = REngine.GetInstance();
                engine.Initialize();

                //input
                Console.WriteLine("Please enter the calculation");
                //input = Console.ReadLine();
                input = "2+5*3";
                //calculate
                CharacterVector vector = engine.Evaluate(input).AsCharacter();
                result = vector[0];

                //clean up
                engine.Dispose();

                //output
                Console.WriteLine("");
                Console.WriteLine("Result: '{0}'", result);
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();

                Console.ReadLine();
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong inside Test action: {e.Message}");
                return StatusCode(404, e.Message);
            }
        }


    }
}