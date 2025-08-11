using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineFoodOrderingSystem.Data;
using OnlineFoodOrderingSystem.Models;

namespace OnlineFoodOrderingSystem.Controllers.Authentication
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationService : ControllerBase
    {
        public IActionResult authenticateUser([FromBody] SignInDTO signInDTO)
        {
           
            
            
            // Implement login logic here
            return Ok("Login successful");
        }

        //user : FName, LNaME, eMAILId, MobileNumnber ,Passwrod //// Encryption,addr
        // 

        public IActionResult validateCredentials([FromBody]  RegisterDTO registerDTO)
        {
            // Implement registration logic here
            return Ok("Registration successful");
        }

        public IActionResult generateAuthToken()
        {
            // Implement logout logic here
            return Ok("Logout successful");
        }

        public IActionResult logoutUser()
        {
            // Implement logout logic here
            return Ok("Logout successful");
        }
    }
}
