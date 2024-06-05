using Microsoft.AspNetCore.Mvc;
using Entities;
using Services;
using AutoMapper;
using DTO;
using Azure.Identity;

<<<<<<< HEAD
=======

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

>>>>>>> 288bcff (add configuration)
namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;
        private IMapper mapper;
        private readonly ILogger<UserController> logger;

        public UserController(IUserService userService,IMapper mapper, ILogger<UserController> logger)
        {
            this.userService = userService;
            this.mapper = mapper;
            this.logger = logger;
        }
        
        [HttpPost("login")]
<<<<<<< HEAD
        public async Task<ActionResult<UserWithIDDTO>> Login([FromBody] LoginDTO userLogin)
        {
            User u = await userService.Login(userLogin);

            UserWithIDDTO userAfter = mapper.Map<User, UserWithIDDTO>(u);
=======
        public async Task<ActionResult<UserAfterLoginDTO>> Login([FromBody] LoginDTO userLogin)
        {
            User u = await userService.Login(userLogin);

            UserAfterLoginDTO userAfter = mapper.Map<User, UserAfterLoginDTO>(u);
>>>>>>> 288bcff (add configuration)
            if (userAfter != null)
            {
                logger.LogInformation($"login attempted with UserName {userAfter.UserName}");
                return Ok(userAfter);
            }   
            return NoContent();
        }


        [HttpPost("register")]
<<<<<<< HEAD
        public async Task<ActionResult<UserWithIDDTO>> Register([FromBody] RegisterDTO userDto)
=======
        public async Task<ActionResult<User>> Register([FromBody] RegisterDTO userDto)
>>>>>>> 288bcff (add configuration)
        {
            var user = mapper.Map<RegisterDTO, User>(userDto);

            User u =await userService.Register(user);
<<<<<<< HEAD
            if (u != null)
            {
                var userToReturn = mapper.Map<User, UserWithIDDTO>(u);
                return CreatedAtAction(nameof(Get), new { id = userToReturn.UserId }, userToReturn);
            }
                
=======
            if (u!=null)
                return CreatedAtAction(nameof(Get), new { id = u.UserId }, u);
            //return Ok(u);
>>>>>>> 288bcff (add configuration)
            return NoContent();
        }

        [HttpPost("check")]
        public ActionResult Check([FromBody] object password)
        {
            
            var result = userService.Check(password);
            if (result >= 2)
                return Ok(result);
            return Accepted(result);
        }

        [HttpGet("{id}")]
<<<<<<< HEAD
        public async Task<UserDTO> Get(int id)
        {
            var user = await userService.Get(id);
            var userToReturn = mapper.Map<User, UserDTO>(user);
            return userToReturn;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserDTO>> Update(int id, [FromBody] UserDTO user)
        {
            UserDTO prevUser=await userService.returnPrev(id,user);

            User userAfter = mapper.Map<UserDTO, User>(prevUser);

            User u =await userService.Update(id, userAfter);
            if (u != null)
            {
                UserDTO uu = mapper.Map<User, UserDTO>(u);
                return Ok(uu);
            }     
            return NoContent();
        } 
=======
        public async Task<User> Get(int id)
        {
            var user = await userService.Get(id);
            return user;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<User>> Update(int id, [FromBody] User user)
        {
            User u=await userService.Update(id,user);
            if (u != null)
                return Ok(u);
            return NoContent();
        }

   
>>>>>>> 288bcff (add configuration)
    }
}
