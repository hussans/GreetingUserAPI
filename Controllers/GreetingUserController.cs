using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SayHelloEndPoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingUserController : ControllerBase
    {
        public List<string> nameList = new();

        [HttpPost]
        [Route("UserName/{name}")]

        public List<string> GetGreetUser(string name)
        {
            nameList.Add("Hello, " + name + " .");
            return nameList;
        }
    }
}