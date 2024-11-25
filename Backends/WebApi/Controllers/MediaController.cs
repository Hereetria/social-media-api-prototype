

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using BussinessLogicLayer.Services.MediaServices;
using DtoLayer.Dtos.MediaDtos;

namespace WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IMediaServiceBLL _mediaServiceBLL;

        public MediaController(IMediaServiceBLL mediaServiceBLL, IMapper mapper)
        {
            _mediaServiceBLL = mediaServiceBLL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMediaInfo()
        {
            try
            {
                var values = await _mediaServiceBLL.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing media information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMediaById(int id)
        {
            try
            {
                var value = await _mediaServiceBLL.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Media information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving media information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateMedia(CreateMediaDto createMediaDto)
            {
            try
            {
                await _mediaServiceBLL.CreateAsync(createMediaDto);
                return Ok("Media information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating media information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedia(int id)
        {
            try
            {
                await _mediaServiceBLL.DeleteAsync(id);
                return Ok("Media information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting media information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMedia(UpdateMediaDto updateMediaDto)
        {
            try
            {
                await _mediaServiceBLL.UpdateAsync(updateMediaDto);
                return Ok("Media information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating media information: " + ex.Message);
            }
        }

    }
}