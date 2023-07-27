using System;
using System.Linq;
using System.Threading.Tasks;
using DBModel.Models;
using Logic_Action.Encript_Pass;
using Microsoft.EntityFrameworkCore;

namespace Logic_Action.UserAction
{
    public interface IUserAccountService
    {
        Task<Result<bool>> CheckAsync(string searchName);
        Task<Result<bool>> RegisterAsync(string userName, string password, bool isAdmin);
        Task<Result<bool>> UpdateUserAsync(string oldName, string newUserName, string newHashPassword, byte[] newSalt, bool newIsAdmin);
        Task<SignInResult> SignInAsync(string userName, string password);
        Task<Result<bool>> DeleteUserAsync(string userName);
    }

    public class UserAccountService : IUserAccountService, IDisposable
    {
        private readonly StoreContext dbContext;

        public UserAccountService(StoreContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Result<bool>> CheckAsync(string searchName)
        {
            try
            {
                bool userExists = await dbContext.Users.AnyAsync(user => user.UserName == searchName);
                return Result<bool>.Success(userExists);
            }
            catch (Exception ex)
            {
                return Result<bool>.Failure(ex);
            }
        }

        public async Task<Result<bool>> RegisterAsync(string userName, string password, bool isAdmin)
        {
            var checkResult = await CheckAsync(userName);

            if (checkResult.Data)
            {
                return Result<bool>.Success(false); // User already exists
            }
            else if (checkResult.Error != null)
            {
                return Result<bool>.Failure(checkResult.Error);
            }
            else
            {
                // Hash the password and save the user to the database
                var hashSalt = Encript.HashPassword(password);

                var newUser = new User
                {
                    IsAdmin = isAdmin,
                    UserName = userName,
                    HashPassword = hashSalt.Item1,
                    Salt = hashSalt.Item2
                };

                try
                {
                    dbContext.Users.Add(newUser);
                    await dbContext.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    return Result<bool>.Failure(ex);
                }

                return Result<bool>.Success(true);
            }
        }

        public async Task<Result<bool>> UpdateUserAsync(string oldName, string newUserName, string newHashPassword, byte[] newSalt, bool newIsAdmin)
        {
            try
            {
                // Retrieve the existing user from the database based on the UserName
                var user = await dbContext.Users.FirstOrDefaultAsync(u => u.UserName == oldName);

                if (user == null)
                {
                    return Result<bool>.Success(false); // User not found
                }

                
                user.UserName = newUserName;
                user.HashPassword = newHashPassword;
                user.Salt = newSalt;
                user.IsAdmin = newIsAdmin;

                // Save the changes to the database
                await dbContext.SaveChangesAsync();

                // Update successful
                return Result<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return Result<bool>.Failure(ex);
            }
        }

        public async Task<SignInResult> SignInAsync(string userName, string password)
        {
            var result = new SignInResult();

            var user = await dbContext.Users
                .Where(u => u.UserName == userName)
                .Select(u => new { UserName = u.UserName, HashPassword = u.HashPassword, Salt = u.Salt })
                .FirstOrDefaultAsync();

            if (user == null)
            {
                result.IsSuccessful = false;
                result.ErrorMessage = "User not found";
            }
            else
            {
                if (Encript.VerifyPassword(password, user.HashPassword, user.Salt))
                {
                    // Sign-in successful
                    result.IsSuccessful = true;
                }
                else
                {
                    // Incorrect password
                    result.IsSuccessful = false;
                    result.ErrorMessage = "Incorrect password.";
                }
            }

            return result;
        }

        public async Task<Result<bool>> DeleteUserAsync(string userName)
        {
            try
            {
                var user = await dbContext.Users.FirstOrDefaultAsync(u => u.UserName == userName);

                if (user == null)
                {
                    return Result<bool>.Success(false); // User not found
                }

                dbContext.Users.Remove(user);
                await dbContext.SaveChangesAsync();

                // Deletion successful
                return Result<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return Result<bool>.Failure(ex);
            }
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }

    public class Result<T>
    {
        public T Data { get; private set; }
        public Exception Error { get; private set; }
        public bool IsSuccess => Error == null;

        private Result(T data, Exception error)
        {
            Data = data;
            Error = error;
        }

        public static Result<T> Success(T data) => new Result<T>(data, null);
        public static Result<T> Failure(Exception error) => new Result<T>(default(T), error);
    }

    public class SignInResult
    {
        public bool IsSuccessful { get; set; }
        public string ErrorMessage { get; set; }
    }
}
