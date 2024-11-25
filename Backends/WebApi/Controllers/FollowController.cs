

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using BussinessLogicLayer.Services.FollowServices;
using DtoLayer.Dtos.FollowDtos;

namespace WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class FollowController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IFollowServiceBLL _followServiceBLL;

        public FollowController(IFollowServiceBLL followServiceBLL, IMapper mapper)
        {
            _followServiceBLL = followServiceBLL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetFollowInfo()
        {
            try
            {
                var values = await _followServiceBLL.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing follow information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFollowById(int id)
        {
            try
            {
                var value = await _followServiceBLL.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Follow information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving follow information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateFollow(CreateFollowDto createFollowDto)
            {
            try
            {
                await _followServiceBLL.CreateAsync(createFollowDto);
                return Ok("Follow information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating follow information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFollow(int id)
        {
            try
            {
                await _followServiceBLL.DeleteAsync(id);
                return Ok("Follow information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting follow information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFollow(UpdateFollowDto updateFollowDto)
        {
            try
            {
                await _followServiceBLL.UpdateAsync(updateFollowDto);
                return Ok("Follow information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating follow information: " + ex.Message);
            }
        }

    }
}