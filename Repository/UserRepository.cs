﻿using DTO;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
namespace Repositories
{
    public class UserRepository: IUserRepository
    {
        ShopDb325338135Context shopDbContext;
        public UserRepository(ShopDb325338135Context shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }

        public async Task<User> Login(LoginDTO userLogin)
        {
            User userDb= await shopDbContext.Users.FirstOrDefaultAsync(u => userLogin.UserName.Equals(u.UserName)&& userLogin.Password.Equals(u.Password));
            if(userDb==null)
            {
                return null;
            }
            return userDb;
        }
        public async Task<User> Register(User user)
        {
            var userDb = await shopDbContext.Users.FirstOrDefaultAsync(u=>user.UserName.Equals(u.UserName));
                
            if (userDb != null)
            {
                return null;  
            }
<<<<<<< HEAD


=======
>>>>>>> a3847faecf94dcd15fa9e2a2541b09d81fefac35
            await shopDbContext.Users.AddAsync(user);
            await shopDbContext.SaveChangesAsync();
            return user;
        }
        public async Task<User> Update(int id,User user)
        {
<<<<<<< HEAD
            var userDb=await shopDbContext.Users.FirstOrDefaultAsync(u => user.UserId==id);
            if (userDb == null)
                return null;
            //shopDbContext.Entry(userDb).CurrentValues.SetValues(user);
            userDb.UserName = user.UserName;
            userDb.Password = user.Password;
            userDb.FirstName = user.FirstName;
            userDb.LastName = user.LastName;
            userDb.Email = user.Email;

            //await shopDbContext.SaveChangesAsync();
=======
            var userDb=await shopDbContext.Users.FindAsync(id);
            if (userDb == null)
                return null;
            shopDbContext.Entry(userDb).CurrentValues.SetValues(user);
>>>>>>> a3847faecf94dcd15fa9e2a2541b09d81fefac35
            await shopDbContext.SaveChangesAsync();
            return user;
        }

        public async Task<User> Get(int id)
        {
            var user = await shopDbContext.Users.FindAsync(id);
            return user;
        }
    }
}
