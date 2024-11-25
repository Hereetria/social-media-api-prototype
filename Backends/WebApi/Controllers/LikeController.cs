

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using BussinessLogicLayer.Services.LikeServices;
using DtoLayer.Dtos.LikeDtos;

namespace WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class LikeController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly ILikeServiceBLL _likeServiceBLL;

        public LikeController(ILikeServiceBLL likeServiceBLL, IMapper mapper)
        {
            _likeServiceBLL = likeServiceBLL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetLikeInfo()
        {
            try
            {
                var values = await _likeServiceBLL.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing like information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLikeById(int id)
        {
            try
            {
                var value = await _likeServiceBLL.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Like information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving like information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateLike(CreateLikeDto createLikeDto)
            {
            try
            {
                await _likeServiceBLL.CreateAsync(createLikeDto);
                return Ok("Like information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating like information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLike(int id)
        {
            try
            {
                await _likeServiceBLL.DeleteAsync(id);
                return Ok("Like information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting like information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateLike(UpdateLikeDto updateLikeDto)
        {
            try
            {
                await _likeServiceBLL.UpdateAsync(updateLikeDto);
                return Ok("Like information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating like information: " + ex.Message);
            }
        }

    }
}