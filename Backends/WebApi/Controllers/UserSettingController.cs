

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using BussinessLogicLayer.Services.UserSettingServices;
using DtoLayer.Dtos.UserSettingDtos;

namespace WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class UserSettingController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IUserSettingServiceBLL _userSettingServiceBLL;

        public UserSettingController(IUserSettingServiceBLL userSettingServiceBLL, IMapper mapper)
        {
            _userSettingServiceBLL = userSettingServiceBLL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetUserSettingInfo()
        {
            try
            {
                var values = await _userSettingServiceBLL.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing userSetting information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserSettingById(int id)
        {
            try
            {
                var value = await _userSettingServiceBLL.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"UserSetting information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving userSetting information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserSetting(CreateUserSettingDto createUserSettingDto)
            {
            try
            {
                await _userSettingServiceBLL.CreateAsync(createUserSettingDto);
                return Ok("UserSetting information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating userSetting information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserSetting(int id)
        {
            try
            {
                await _userSettingServiceBLL.DeleteAsync(id);
                return Ok("UserSetting information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting userSetting information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUserSetting(UpdateUserSettingDto updateUserSettingDto)
        {
            try
            {
                await _userSettingServiceBLL.UpdateAsync(updateUserSettingDto);
                return Ok("UserSetting information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating userSetting information: " + ex.Message);
            }
        }

    }
}