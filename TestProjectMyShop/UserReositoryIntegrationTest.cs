<<<<<<< HEAD
﻿using DTO;
using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class UserIntegreationTesr : IClassFixture<DatabaseFixture>
    {
        private readonly ShopDb325338135Context _dbontext;
        private readonly UserRepository userRepository;

        public UserIntegreationTesr(DatabaseFixture databaseFixture)
        {
            _dbontext = databaseFixture.Context;
            userRepository = new UserRepository(_dbontext);

        }
        [Fact]
        public async Task GetUser_Valid_returnsUser()
        {
            var username = "aaa";
            var password = "a123s123";
            var login = new LoginDTO { Password = password,  UserName = username };
            var user = new User { Email = "aaa@gmail.com", Password = password, FirstName = "SHEVA", LastName = "KAPLAN", UserName = username };

            await _dbontext.Users.AddAsync(user);
            await _dbontext.SaveChangesAsync();

            //act
            var result = await userRepository.Login(login);

            //assert

            Assert.NotNull(result);
        }


    }
}
=======
﻿//using DTO;
//using Entities;
//using Microsoft.EntityFrameworkCore;
//using Repositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TestProject;

//namespace UserRepositoryUnitTest
//{
//    public class UserReositoryIntegrationTest:IClassFixture<DatabaseFixture>
//    {
//        private readonly ShopDb325338135Context _dbContext;
//        private readonly UserRepository _userRepository;

//        public UserReositoryIntegrationTest(DatabaseFixture databaseFixture)
//        {
//            _dbContext = databaseFixture.Context;
//            _userRepository = new UserRepository(_dbContext);
//        }

//        [Fact]
//        public async Task Get_User_ValidLogin()
//        {
//            User u = new User();
//            u.UserName = "aaa";
//            u.Password = "1234";


//            LoginDTO loginDto = new LoginDTO();
//            loginDto.Password = "1234";
//            loginDto.UserName = "aaa";

//            await _dbContext.Users.AddAsync(u);
//            await _dbContext.SaveChangesAsync();

//            var result = await _userRepository.Login(loginDto = new LoginDTO()); 

//            Assert.NotNull(result);
//        }

//    }
//}
>>>>>>> 288bcff (add configuration)
