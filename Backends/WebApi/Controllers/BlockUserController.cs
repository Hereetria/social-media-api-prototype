

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using BussinessLogicLayer.Services.BlockUserServices;
using DtoLayer.Dtos.BlockUserDtos;

namespace WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class BlockUserController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IBlockUserServiceBLL _blockUserServiceBLL;

        public BlockUserController(IBlockUserServiceBLL blockUserServiceBLL, IMapper mapper)
        {
            _blockUserServiceBLL = blockUserServiceBLL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetBlockUserInfo()
        {
            try
            {
                var values = await _blockUserServiceBLL.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing blockUser information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlockUserById(int id)
        {
            try
            {
                var value = await _blockUserServiceBLL.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"BlockUser information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving blockUser information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlockUser(CreateBlockUserDto createBlockUserDto)
            {
            try
            {
                await _blockUserServiceBLL.CreateAsync(createBlockUserDto);
                return Ok("BlockUser information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating blockUser information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlockUser(int id)
        {
            try
            {
                await _blockUserServiceBLL.DeleteAsync(id);
                return Ok("BlockUser information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting blockUser information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlockUser(UpdateBlockUserDto updateBlockUserDto)
        {
            try
            {
                await _blockUserServiceBLL.UpdateAsync(updateBlockUserDto);
                return Ok("BlockUser information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating blockUser information: " + ex.Message);
            }
        }

    }
}