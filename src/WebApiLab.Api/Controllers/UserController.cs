using Domain.DTO;
using Model = Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Application;
using Domain.Contracts.Application;

namespace WebApiLab.Api.Controllers
{
    [Route("v1/[controller]"), ApiController]
    public class UserController : ControllerBase
    {
        IUserApplication _userApplication { get; set; }
        public UserController(IUserApplication userApplication)
        {
            _userApplication = userApplication;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var usr = new User() { Id = Guid.NewGuid(), Name = "John Doe", Email = "teste" };


            return Ok(usr);
        }


        [HttpPost, Route("")]
        public IActionResult Save(User user)
        {
            var result = _userApplication.Save(user);
            
            return Ok(result);
        }
    }


}
