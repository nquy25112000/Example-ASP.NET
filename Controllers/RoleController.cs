using Microsoft.AspNetCore.Mvc;
using Sample1.Data;
using Sample1.Services.RoleService;
using System.Data;

namespace Sample1.Controllers
{
    [Route("role")]
    [ApiController]
    public class RoleController : ControllerBase, IRoleController
    {
        private readonly IRoleService roleService;

        public RoleController(IRoleService roleService)
        {
            this.roleService = roleService;
        }

        [HttpGet("{id}")]
        public Roles GetById(int id)
        {
            return roleService.GetById(id);
        }

        [HttpGet("findAll")]
        public List<Roles> findAll(int id)
        {
            return roleService.GetAll();
        }

        [HttpGet]
        public void TestSystax()
        {
            List<string> strings = new() { "một", "hai", "ba", "bốn", null };
            foreach (string item in strings)
            {
                if (item == "một")
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("--------------------------------------------------------------------");

            List<Roles> roles = new() { 
                new Roles() { id = 1, name = "Admin", users = new List<Users>() },
                new Roles() { id = 2, name = "Manager", users = new List<Users>() },
                new Roles() { id = 3, name = "Employee", users = new List<Users>() },
                new Roles() { id = 4, name = "Customer", users = new List<Users>() }
            };


            roles = roles.Where(role => role.id <= 2 && role.name == "Admin").ToList();
            foreach (Roles role in roles)
            {
                Console.WriteLine(role.name);
            }
        }
    }
}
