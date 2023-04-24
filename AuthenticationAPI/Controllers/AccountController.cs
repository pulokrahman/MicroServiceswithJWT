using Authentication.Core.Contracts.Services;
using Authentication.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace AuthenticationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService service;
        public AccountController(IAccountService service)
        {
            this.service = service;

        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(AccountRequestModel model)
        {
            if (model != null)
            {
                return Ok(await service.AddAccountAsync(model));
            }
            return BadRequest();
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await service.GetAccountByIdAsync(id));
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await service.GetAllAccounts());
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await service.DeleteAccountAsync(id));
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(AccountRequestModel model)
        {
            if (model != null)
            {
                return Ok(await service.UpdateAccountAsync(model));
            }
            return BadRequest();
        }
    }
}
