

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using BussinessLogicLayer.Services.ReportCommentServices;
using DtoLayer.Dtos.ReportCommentDtos;

namespace WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ReportCommentController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IReportCommentServiceBLL _reportCommentServiceBLL;

        public ReportCommentController(IReportCommentServiceBLL reportCommentServiceBLL, IMapper mapper)
        {
            _reportCommentServiceBLL = reportCommentServiceBLL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetReportCommentInfo()
        {
            try
            {
                var values = await _reportCommentServiceBLL.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing reportComment information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetReportCommentById(int id)
        {
            try
            {
                var value = await _reportCommentServiceBLL.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"ReportComment information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving reportComment information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateReportComment(CreateReportCommentDto createReportCommentDto)
            {
            try
            {
                await _reportCommentServiceBLL.CreateAsync(createReportCommentDto);
                return Ok("ReportComment information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating reportComment information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReportComment(int id)
        {
            try
            {
                await _reportCommentServiceBLL.DeleteAsync(id);
                return Ok("ReportComment information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting reportComment information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateReportComment(UpdateReportCommentDto updateReportCommentDto)
        {
            try
            {
                await _reportCommentServiceBLL.UpdateAsync(updateReportCommentDto);
                return Ok("ReportComment information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating reportComment information: " + ex.Message);
            }
        }

    }
}