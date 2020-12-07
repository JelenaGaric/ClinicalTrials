using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClinicalTrialsWebApp.Repository;
using Microsoft.Extensions.Logging;

namespace ClinicalTrialsWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegressionController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;
        private ILogger<RegressionController> _logger;

        public RegressionController(IRepositoryWrapper repoWrapper, ILogger<RegressionController> logger)
        {
            _logger = logger;
            _repoWrapper = repoWrapper;
        }

        [HttpGet]
        public ActionResult Regression()
        {
            if (_repoWrapper.StatisticsSearch.getRegression())
            {
                return Ok();
            }
            return NotFound();
        }

        [HttpGet("{type}")]
        public ActionResult RegressionCsv(string type)
        {
            return Ok(_repoWrapper.StatisticsSearch.getStatsCsv(type));
        }

    }
}
