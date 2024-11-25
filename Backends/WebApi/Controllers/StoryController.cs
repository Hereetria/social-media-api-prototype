

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using BussinessLogicLayer.Services.StoryServices;
using DtoLayer.Dtos.StoryDtos;

namespace WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class StoryController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IStoryServiceBLL _storyServiceBLL;

        public StoryController(IStoryServiceBLL storyServiceBLL, IMapper mapper)
        {
            _storyServiceBLL = storyServiceBLL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetStoryInfo()
        {
            try
            {
                var values = await _storyServiceBLL.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing story information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStoryById(int id)
        {
            try
            {
                var value = await _storyServiceBLL.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Story information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving story information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateStory(CreateStoryDto createStoryDto)
            {
            try
            {
                await _storyServiceBLL.CreateAsync(createStoryDto);
                return Ok("Story information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating story information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStory(int id)
        {
            try
            {
                await _storyServiceBLL.DeleteAsync(id);
                return Ok("Story information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting story information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStory(UpdateStoryDto updateStoryDto)
        {
            try
            {
                await _storyServiceBLL.UpdateAsync(updateStoryDto);
                return Ok("Story information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating story information: " + ex.Message);
            }
        }

    }
}