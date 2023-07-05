using Microsoft.AspNetCore.Mvc;
using Sample1.Data;

namespace Sample1.Controllers
{
    public interface IUserController
    {
        List<Users> test(Dictionary<string, string> paras);
    }
}
