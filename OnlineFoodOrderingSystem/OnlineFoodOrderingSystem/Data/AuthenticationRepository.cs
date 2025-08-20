using Microsoft.EntityFrameworkCore;
using OnlineFoodOrderingSystem.Models;

namespace OnlineFoodOrderingSystem.Data
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly AppDbContext _context;
        public AuthenticationRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<RegisterVM> SignIn(SignInDTO signInDTO)
        {
            var user = await _context.registerUser.FirstOrDefaultAsync(u => u.emailID == signInDTO.emailID );

            
                

            return user;
        }


        public async Task<UserRole> GetUserRole(int role)
        {
            var userRole = await _context.userrole.FirstOrDefaultAsync(u => u.roleId == role);




            return userRole;
        }


        //public async Task<RegisterVM> Register(RegisterVM registerVM)
        //{
        //    await _context.registerUser.AddAsync(registerVM);
        //    await _context.SaveChangesAsync();
        //    return registerVM;
        //}





    }
}
