using Microsoft.AspNetCore.Mvc;
using Sample1.Data;
using Sample1.Dto;
using Sample1.Repository;
using Sample1.Services.UserService;

namespace Sample1.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase, IUserController
    {
        private readonly UserRepositry repositry;
        private readonly IUserService service;
        public UserController(UserRepositry repositry, IUserService service)
        {
            this.repositry = repositry;
            this.service = service;
        }

        [HttpPost]
        public List<Users> test([FromBody] Dictionary<string, string> paras)
        {

            paras.TryGetValue("id", out string ids);
            List<int> roleIds = new List<int>();

            foreach (string id in ids.Split(','))
            {
                roleIds.Add(int.Parse(id));
            }

            return repositry.getUserByRoleIds(roleIds);
        }


        [HttpGet]
        public List<Users> test2([FromQuery] int roleId)
        {
            return repositry.findAllByRoleId(roleId);
        }

        [HttpGet("getByName")]
        public UserRole getUserAndRoleByName([FromQuery] string name)
        {
            return service.GetUserAndRole(name);
        }

        [HttpGet("multipleItem")]
        public List<Users> getUsserInMultipleReturn()
        {
            int count = repositry.testMultipleReturn().Item1;
            return repositry.testMultipleReturn().Item2;
        }
    }
}
