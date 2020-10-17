using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeedBackCollection.Model;
using FeedBackCollection.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeedBackCollection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        public readonly ICommentsInfoService _commentsInfoService;
        public CommentsController(ICommentsInfoService commentsInfoService)
        {
            _commentsInfoService = commentsInfoService;
        }
        // GET api/values
        [HttpPost]
        [Route("CreateComments")]
        public async Task<ActionResult> CreateComments(CommentsInfo data)
        {
            var model = await _commentsInfoService.Add(data);
            return Ok(model);
        }
    }
}