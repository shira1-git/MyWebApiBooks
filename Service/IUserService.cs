﻿using DTO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IUserService
    {
<<<<<<< HEAD
        Task<User> Login(LoginDTO user);
        Task<User> Register(User user);
        Task<User> Update(int id, User user);
        Task<User> Get(int id);
        int Check(object password);
        Task<UserDTO> returnPrev(int id, UserDTO user);
=======
         Task<User> Login(LoginDTO user);
         Task<User> Register(User user);
         Task<User> Update(int id,User user);
         Task<User> Get(int id);
         int Check(object password);
        //object Check(object password);

>>>>>>> 288bcff (add configuration)
    }
}
