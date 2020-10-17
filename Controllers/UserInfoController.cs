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
    public class UserInfoController : ControllerBase
    {
        public readonly IUserService _userService;
        public UserInfoController(IUserService userService)
        {
            _userService = userService;
        }
        // GET api/values
        [HttpPost]
        [Route("CreateUser")]
        public async Task<ActionResult> CreateUser(UserInfo data)
        {
            var model = await _userService.Add(data);
            return Ok(model);
        }

    }
}