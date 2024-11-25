

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using BussinessLogicLayer.Services.NotificationServices;
using DtoLayer.Dtos.NotificationDtos;

namespace WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly INotificationServiceBLL _notificationServiceBLL;

        public NotificationController(INotificationServiceBLL notificationServiceBLL, IMapper mapper)
        {
            _notificationServiceBLL = notificationServiceBLL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetNotificationInfo()
        {
            try
            {
                var values = await _notificationServiceBLL.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing notification information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNotificationById(int id)
        {
            try
            {
                var value = await _notificationServiceBLL.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Notification information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving notification information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateNotification(CreateNotificationDto createNotificationDto)
            {
            try
            {
                await _notificationServiceBLL.CreateAsync(createNotificationDto);
                return Ok("Notification information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating notification information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNotification(int id)
        {
            try
            {
                await _notificationServiceBLL.DeleteAsync(id);
                return Ok("Notification information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting notification information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateNotification(UpdateNotificationDto updateNotificationDto)
        {
            try
            {
                await _notificationServiceBLL.UpdateAsync(updateNotificationDto);
                return Ok("Notification information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating notification information: " + ex.Message);
            }
        }

    }
}