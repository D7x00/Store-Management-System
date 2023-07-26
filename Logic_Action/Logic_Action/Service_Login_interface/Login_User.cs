using System;
using DBModel.Models;
using Logic_Action.Encript_Pass;
using Microsoft.EntityFrameworkCore;

namespace Logic_Action.UserAction
{
    public class Login_User : IDisposable
    {
        private readonly StoreContext dbContext;

        public Login_User()
        {
            dbContext = new StoreContext();
        }

        public Result<bool> Check(string searchName)
        {
            try
            {
                bool userExists = dbContext.Users.Any(user => user.UserName == searchName);
                return Result<bool>.Success(userExists);
            }
            catch (Exception ex)
            {
                return Result<bool>.Failure(ex);
            }
        }

        public Result<bool> login(string userName, string password, bool isAdmin)
        {
            var checkResult = Check(userName);
            

            if (checkResult.Data == true)
            {
                return Result<bool>.Success(false);
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
                    dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    return Result<bool>.Failure(ex);
                }

                return Result<bool>.Success(true);
            }
               
        }

        public Result<bool> UpdateUser(string OldName, string newUserName, string newHashPassword, byte[] newSalt, bool newIsAdmin)
        {
            try
            {
                // Retrieve the existing user from the database based on the UserName
                var user = dbContext.Users.FirstOrDefault(u => u.UserName == OldName);

                if (user == null)
                {

                    return Result<bool>.Success(false);
                }
                
                // Update the user properties with new values
                user.UserName = newUserName;
                user.HashPassword = newHashPassword;
                user.Salt = newSalt;
                user.IsAdmin = newIsAdmin;

                // Save the changes to the database
                dbContext.SaveChanges();

                // Update successful
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
}
