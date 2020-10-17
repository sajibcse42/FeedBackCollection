using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeedBackCollection.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeedBackCollection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedBackCollectionController : ControllerBase
    {
        public readonly IFeedBackCollectionService _feedBackCollectionService;
        public FeedBackCollectionController(IFeedBackCollectionService feedBackCollectionService)
        {
            _feedBackCollectionService = feedBackCollectionService;
        }
       
       [HttpPost]
       [Route("GetFeedBackCollection")]
        public async Task<ActionResult> GetFeedBackCollection(int postid)
        {
            //can not fininsh need to work
            var model = await _feedBackCollectionService.GetAll();
            return Ok(model);
        }
    }
}