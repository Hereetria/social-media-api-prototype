

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using BussinessLogicLayer.Services.PostTagServices;
using DtoLayer.Dtos.PostTagDtos;

namespace WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class PostTagController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IPostTagServiceBLL _postTagServiceBLL;

        public PostTagController(IPostTagServiceBLL postTagServiceBLL, IMapper mapper)
        {
            _postTagServiceBLL = postTagServiceBLL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetPostTagInfo()
        {
            try
            {
                var values = await _postTagServiceBLL.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing postTag information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPostTagById(int id)
        {
            try
            {
                var value = await _postTagServiceBLL.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"PostTag information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving postTag information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreatePostTag(CreatePostTagDto createPostTagDto)
            {
            try
            {
                await _postTagServiceBLL.CreateAsync(createPostTagDto);
                return Ok("PostTag information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating postTag information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePostTag(int id)
        {
            try
            {
                await _postTagServiceBLL.DeleteAsync(id);
                return Ok("PostTag information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting postTag information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePostTag(UpdatePostTagDto updatePostTagDto)
        {
            try
            {
                await _postTagServiceBLL.UpdateAsync(updatePostTagDto);
                return Ok("PostTag information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating postTag information: " + ex.Message);
            }
        }

    }
}