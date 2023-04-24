using Interview.Core.Contracts.Services;
using Interview.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace InterviewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewController : ControllerBase
    {
        private readonly IInterviewService service;
        public InterviewController(IInterviewService service)
        {
            this.service = service;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(InterviewRequestModel model)
        {
            if (model != null)
            {
                return Ok(await service.AddInterviewAsync(model));
            }
            return BadRequest();
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await service.GetInterviewByIdAsync(id));
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await service.GetAllInterviews());
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await service.DeleteInterviewAsync(id));
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(InterviewRequestModel model)
        {
            if (model != null)
            {
                return Ok(await service.UpdateInterviewAsync(model));
            }
            return BadRequest();
        }
    }
}
