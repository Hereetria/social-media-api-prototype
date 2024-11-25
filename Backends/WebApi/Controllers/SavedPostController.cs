

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using BussinessLogicLayer.Services.SavedPostServices;
using DtoLayer.Dtos.SavedPostDtos;

namespace WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class SavedPostController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly ISavedPostServiceBLL _savedPostServiceBLL;

        public SavedPostController(ISavedPostServiceBLL savedPostServiceBLL, IMapper mapper)
        {
            _savedPostServiceBLL = savedPostServiceBLL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetSavedPostInfo()
        {
            try
            {
                var values = await _savedPostServiceBLL.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing savedPost information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSavedPostById(int id)
        {
            try
            {
                var value = await _savedPostServiceBLL.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"SavedPost information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving savedPost information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateSavedPost(CreateSavedPostDto createSavedPostDto)
            {
            try
            {
                await _savedPostServiceBLL.CreateAsync(createSavedPostDto);
                return Ok("SavedPost information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating savedPost information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSavedPost(int id)
        {
            try
            {
                await _savedPostServiceBLL.DeleteAsync(id);
                return Ok("SavedPost information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting savedPost information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSavedPost(UpdateSavedPostDto updateSavedPostDto)
        {
            try
            {
                await _savedPostServiceBLL.UpdateAsync(updateSavedPostDto);
                return Ok("SavedPost information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating savedPost information: " + ex.Message);
            }
        }

    }
}