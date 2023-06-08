using ctrlspec.Data;
using ctrlspec.Models;
using Microsoft.EntityFrameworkCore;


namespace ctrlspec.Repos
{
    public class LoginRepository: ILogin
       {
          private readonly CtrlSpecDbContext _context;



        public LoginRepository(CtrlSpecDbContext context)

        {

            _context = context;

        }


        #region AddLoginDetailsAsync
        public async Task<Login> SignUp (Login loginTable)
        {
            try
            {
                await _context.login.AddAsync(loginTable);
                await _context.SaveChangesAsync();
                return loginTable;
            }
            catch(Exception)
            {
                throw;
            }
        }
        #endregion

        #region AuthenticateUserAsync
        public async Task<Login> Login (string emailId,string Password)
        {
          
                var user = await _context.login.FirstOrDefaultAsync(x => x.EmailId == emailId && x.Password == Password);
                if (user != null)
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
            // catch(Exception)
            // {
            //     throw;
            // }
        }
        #endregion
       
}

    