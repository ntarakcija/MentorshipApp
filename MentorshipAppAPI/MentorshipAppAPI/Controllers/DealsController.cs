using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MentorshipAppAPI.Models;
using MentorshipAppAPI.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MentorshipAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealsController : ControllerBase
    {
        private readonly IDealsService _dealService;

        public DealsController(IDealsService dealsService)
        {
            _dealService = dealsService;
        }

        // GET api/deals
        [HttpGet]
        public ActionResult<IEnumerable<Deal>> Get()
        {
            var res = _dealService.GetDeals();
            return Ok(res);
        }

        // GET api/deal/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(Guid id)
        {
            var res = _dealService.GetDeal(id);
            return Ok(res);
        }

        // POST api/deals/1
        [HttpPost("{category}")]
        public void Post(DealCategory category)
        {
            _dealService.AddDeal(category);
        }
    }
}
