

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using BussinessLogicLayer.Services.MessageServices;
using DtoLayer.Dtos.MessageDtos;

namespace WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IMessageServiceBLL _messageServiceBLL;

        public MessageController(IMessageServiceBLL messageServiceBLL, IMapper mapper)
        {
            _messageServiceBLL = messageServiceBLL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMessageInfo()
        {
            try
            {
                var values = await _messageServiceBLL.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing message information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMessageById(int id)
        {
            try
            {
                var value = await _messageServiceBLL.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"Message information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving message information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateMessageDto createMessageDto)
            {
            try
            {
                await _messageServiceBLL.CreateAsync(createMessageDto);
                return Ok("Message information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating message information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            try
            {
                await _messageServiceBLL.DeleteAsync(id);
                return Ok("Message information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting message information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            try
            {
                await _messageServiceBLL.UpdateAsync(updateMessageDto);
                return Ok("Message information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating message information: " + ex.Message);
            }
        }

    }
}