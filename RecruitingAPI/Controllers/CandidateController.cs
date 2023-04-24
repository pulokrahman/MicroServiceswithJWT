using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recruiting.Core.Contracts.Services;
using Recruiting.Core.Models;
using Recruiting.Infrastructure.Services;

namespace RecruitingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService service;
        public CandidateController(ICandidateService service)
        {
            this.service = service;

        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CandidateRequestModel model)
        {
            if (model != null)
            {
                return Ok(await service.AddCandidateAsync(model));
            }
            return BadRequest();
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await service.GetCandidateByIdAsync(id));
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await service.GetAllCandidates());
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await service.DeleteCandidateAsync(id));
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(CandidateRequestModel model)
        {
            if (model != null)
            {
                return Ok(await service.UpdateCandidateAsync(model));
            }
            return BadRequest();
        }
    }
}
