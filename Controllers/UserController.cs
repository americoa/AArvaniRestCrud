using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpGet(Name = "GetUsers")]
    public List<string> Get()
    {
        using(AArvaniContext context = new AArvaniContext()){
            var users = context.Users.ToList();
            return users.Select( x=> x.UserName).ToList();
        }
    }
}