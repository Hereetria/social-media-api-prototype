

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using BussinessLogicLayer.Services.UserServices;
using DtoLayer.Dtos.UserDtos;

namespace WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IUserServiceBLL _userServiceBLL;

        public UserController(IUserServiceBLL userServiceBLL, IMapper mapper)
        {
            _userServiceBLL = userServiceBLL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetUserInfo()
        {
            try
            {
                var values = await _userServiceBLL.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing user information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            try
            {
                var value = await _userServiceBLL.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"User information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving user information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDto createUserDto)
            {
            try
            {
                await _userServiceBLL.CreateAsync(createUserDto);
                return Ok("User information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating user information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                await _userServiceBLL.DeleteAsync(id);
                return Ok("User information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting user information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(UpdateUserDto updateUserDto)
        {
            try
            {
                await _userServiceBLL.UpdateAsync(updateUserDto);
                return Ok("User information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating user information: " + ex.Message);
            }
        }

    }
}