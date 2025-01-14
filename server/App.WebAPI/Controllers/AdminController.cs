using App.Application.Interfaces;
using App.Core.DTO;
using Microsoft.AspNetCore.Mvc;

namespace App.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly ILogger<AdminController> logger;
        private readonly IAdminService adminService;
        public AdminController(ILogger<AdminController> logger, IAdminService adminService)
        {
            this.logger = logger;
            this.adminService = adminService;
        }
        [HttpPost("Register")]
        public async Task<ActionResult> Register(AdminRegisterRequestDTO? adminRegisterDTO)
        {
            bool isValid = await adminService.ValidateRegisterRequest(adminRegisterDTO);
            if (!isValid)
            {
                return BadRequest(new { error = "Bad Request" });
            }
            return Ok("OKe");
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login()
        {
            return Ok("Details");

        }

    }
}
