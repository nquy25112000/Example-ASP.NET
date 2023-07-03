using Microsoft.AspNetCore.Mvc;
using Sample1.Data;
using Sample1.Services.RoleService;

namespace Sample1.Controllers
{
    [Route("role")]
    [ApiController]
    public class RoleController : ControllerBase , IRoleController
    {
        private readonly IRoleService roleService;

        public RoleController(IRoleService roleService) {
            this.roleService = roleService;
        }

        [HttpGet("{id}")]
        public Role GetById(int id)
        {
            return roleService.GetById(id);
        }
    }
}
