using Entities;
using Repositories;
using DTO;

namespace Services
{
<<<<<<< HEAD
    public class UserService : IUserService
=======
    public class UserService: IUserService
>>>>>>> 288bcff (add configuration)
    {
        private IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        async Task<User> IUserService.Update(int id, User user)
        {
            var checkStrength = Check(user.Password);
            if (checkStrength < 2)
                return null;
<<<<<<< HEAD
            User u = await userRepository.Update(id, user);
=======
            User u=await userRepository.Update(id,user);
>>>>>>> 288bcff (add configuration)
            return u;
        }
        async Task<User> IUserService.Login(LoginDTO userLogin)
        {
            User u = await userRepository.Login(userLogin);
            return u;
        }
        async Task<User> IUserService.Register(User user)
        {
            var checkStrength = Check(user.Password);
            if (checkStrength < 2)
                return null;
            User u = await userRepository.Register(user);
            return u;
        }

        public async Task<User> Get(int id)
        {
<<<<<<< HEAD
            return await userRepository.Get(id);
=======
            return await userRepository.Get(id) ;
>>>>>>> 288bcff (add configuration)
        }
        public int Check(object password)
        {
            var result = Zxcvbn.Core.EvaluatePassword(password.ToString());
            return result.Score;
        }
<<<<<<< HEAD

        public async Task<UserDTO> returnPrev(int id, UserDTO user)
        {
            User prevUser = await Get(id);

            user.UserName = user.UserName == null ? prevUser.UserName : user.UserName;
            user.Password = user.Password == null ? prevUser.Password : user.Password;
            user.FirstName = user.FirstName == null ? prevUser.FirstName : user.FirstName;
            user.LastName = user.LastName == null ? prevUser.LastName : user.LastName;
            user.Email = user.Email == null ? prevUser.Email : user.Email;

            return user;
        }
=======
>>>>>>> 288bcff (add configuration)
    }
}
