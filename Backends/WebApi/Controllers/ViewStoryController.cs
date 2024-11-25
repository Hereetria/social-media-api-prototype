

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using BussinessLogicLayer.Services.ViewStoryServices;
using DtoLayer.Dtos.ViewStoryDtos;

namespace WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ViewStoryController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IViewStoryServiceBLL _viewStoryServiceBLL;

        public ViewStoryController(IViewStoryServiceBLL viewStoryServiceBLL, IMapper mapper)
        {
            _viewStoryServiceBLL = viewStoryServiceBLL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetViewStoryInfo()
        {
            try
            {
                var values = await _viewStoryServiceBLL.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing viewStory information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetViewStoryById(int id)
        {
            try
            {
                var value = await _viewStoryServiceBLL.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"ViewStory information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving viewStory information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateViewStory(CreateViewStoryDto createViewStoryDto)
            {
            try
            {
                await _viewStoryServiceBLL.CreateAsync(createViewStoryDto);
                return Ok("ViewStory information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating viewStory information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteViewStory(int id)
        {
            try
            {
                await _viewStoryServiceBLL.DeleteAsync(id);
                return Ok("ViewStory information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting viewStory information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateViewStory(UpdateViewStoryDto updateViewStoryDto)
        {
            try
            {
                await _viewStoryServiceBLL.UpdateAsync(updateViewStoryDto);
                return Ok("ViewStory information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating viewStory information: " + ex.Message);
            }
        }

    }
}