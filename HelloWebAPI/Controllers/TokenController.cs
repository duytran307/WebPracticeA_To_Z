using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWebAPI.Models;
using HelloWebAPI.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace HelloWebAPI.Controllers
{
    [Route("token")]
 
    public class TokenController : Controller
    {
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Create([FromBody]User inputModel)
        {
            if (inputModel.UserID != "duy" && inputModel.Password != "pwd1")
                return Unauthorized();

            var token = new JwtTokenBuilder()
                                .AddSecurityKey(JwtSecurityKey.Create("this is my custom Secret key for authentication"))
                                .AddSubject("duy tran")
                                .AddIssuer("Security.Bearer")
                                .AddAudience("Security.Bearer")
                                .AddExpiry(15)
                                .Build();

           // return Ok(token);
            return Ok(token.Value);
        }
        [Authorize]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"1","2","3" };
        }
        [Authorize]
        [HttpGet("GetUserList")]
        public IEnumerable<User> GetUserList() {

            List<User> lstUSer = new List<Models.User>();
            lstUSer.Add(new User("duy", "pwd1"));
            lstUSer.Add(new User("duy2", "pwd2"));
            lstUSer.Add(new User("duy3", "pwd3"));
            lstUSer.Add(new User("duy4", "pwd4"));
            lstUSer.Add(new User("duy5", "pwd5"));

            return lstUSer;

        }
    }
}



