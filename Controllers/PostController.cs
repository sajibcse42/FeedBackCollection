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
    public class PostController : ControllerBase
    {
        public readonly IPostInfoService _postInfoService;
        public PostController(IPostInfoService postInfoService)
        {
            _postInfoService = postInfoService;
        }
        // GET api/values
        [HttpPost]
        [Route("CreatePost")]
        public async Task<ActionResult> CreatePost(PostInfo data)
        {
            var model = await _postInfoService.Add(data);
            return Ok(model);
        }
    }
}