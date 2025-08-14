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
        private readonly IAuthenticationRepository _authenticationRepository;
        public AuthenticationService(IAuthenticationRepository authenticationRepository)
        {
            _authenticationRepository = authenticationRepository;
        }
        [HttpPost]
        public IActionResult authenticateUser([FromBody] SignInDTO signInDTO)
        {
            var user=   _authenticationRepository.SignIn(signInDTO);

            if(user==null)
            {
                return Unauthorized("Invalid credentials");
            }
            else
            {
                // Assuming user is not null, proceed with authentication   
                // You can generate a token or set up a session here


                return Ok("Authentication successful");

            }



            // Implement login logic here
           
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
