

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using BussinessLogicLayer.Services.CommentServices;
using DtoLayer.Dtos.CommentDtos;

namespace WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly ICommentServiceBLL _commentServiceBLL;

        public CommentController(ICommentServiceBLL commentServiceBLL, IMapper mapper)
        {
            _commentServiceBLL = commentServiceBLL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetCommentInfo()
        {
            try
            {
                var values = await _commentServiceBLL.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing comment information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommentById(int id)
        {
            try
            {
                var value = await _commentServiceBLL.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Comment information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving comment information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment(CreateCommentDto createCommentDto)
            {
            try
            {
                await _commentServiceBLL.CreateAsync(createCommentDto);
                return Ok("Comment information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating comment information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            try
            {
                await _commentServiceBLL.DeleteAsync(id);
                return Ok("Comment information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting comment information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateComment(UpdateCommentDto updateCommentDto)
        {
            try
            {
                await _commentServiceBLL.UpdateAsync(updateCommentDto);
                return Ok("Comment information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating comment information: " + ex.Message);
            }
        }

    }
}