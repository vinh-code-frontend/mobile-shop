using App.Application.Interfaces;
using App.Application.IServices;
using App.Core.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace App.WebAPI.Controllers
{
    public class AdminController : ApiControllerBase
    {
        private readonly ILogger<AdminController> logger;
        private readonly IAdminService adminService;
        private readonly ITokenService tokenService;
        private readonly IConfiguration configuration;
        public AdminController(ILogger<AdminController> logger, IAdminService adminService, ITokenService tokenService, IConfiguration configuration)
        {
            this.logger = logger;
            this.adminService = adminService;
            this.tokenService = tokenService;
            this.configuration = configuration;
        }
        [HttpPost("Register")]
        [AllowAnonymous]
        public async Task<ActionResult> Register(AdminRegisterRequestDTO? adminRegisterDTO)
        {
            if (adminRegisterDTO == null)
            {
                return BadRequest(new { error = "Bad Request" });
            }
            bool isValid = await adminService.ValidateRegisterRequest(adminRegisterDTO);
            if (!isValid)
            {
                return BadRequest(new { error = "Bad Request" });
            }
            AdminAuthResponseDTO registerResponse = await adminService.Register(adminRegisterDTO);

            return Ok(registerResponse);
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<ActionResult> Login(AdminLoginRequestDTO? adminLoginDTO)
        {
            if (adminLoginDTO == null || adminLoginDTO.Username.IsNullOrEmpty() || adminLoginDTO.Password.IsNullOrEmpty())
            {
                return BadRequest(new { error = "Missing required fields" });
            }
            AdminAuthResponseDTO? adminAuth = await adminService.Login(adminLoginDTO);
            if (adminAuth == null)
            {
                return NotFound(new { error = "Username or password is not correct" });
            }
            return Ok(adminAuth);

        }

    }
}
