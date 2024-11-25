

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using BussinessLogicLayer.Services.PostServices;
using DtoLayer.Dtos.PostDtos;

namespace WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IPostServiceBLL _postServiceBLL;

        public PostController(IPostServiceBLL postServiceBLL, IMapper mapper)
        {
            _postServiceBLL = postServiceBLL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetPostInfo()
        {
            try
            {
                var values = await _postServiceBLL.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing post information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPostById(int id)
        {
            try
            {
                var value = await _postServiceBLL.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Post information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving post information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(CreatePostDto createPostDto)
            {
            try
            {
                await _postServiceBLL.CreateAsync(createPostDto);
                return Ok("Post information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating post information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            try
            {
                await _postServiceBLL.DeleteAsync(id);
                return Ok("Post information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting post information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePost(UpdatePostDto updatePostDto)
        {
            try
            {
                await _postServiceBLL.UpdateAsync(updatePostDto);
                return Ok("Post information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating post information: " + ex.Message);
            }
        }

    }
}