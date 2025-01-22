using App.Application.Interfaces;
using App.Application.IServices;
using App.Core.DTO;
using App.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace App.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
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
            Admin newAdmin = await adminService.Register(adminRegisterDTO);

            int accessTokenExpiredIn = configuration.GetValue<int>("Jwt:AccessTokenExpiredIn");
            int refreshTokenExpiredIn = configuration.GetValue<int>("Jwt:RefreshTokenExpiredIn");

            string accessToken = tokenService.GenerateAdminToken(newAdmin, accessTokenExpiredIn);
            string refreshToken = tokenService.GenerateAdminToken(newAdmin, refreshTokenExpiredIn);

            AdminAuthResponseDTO adminAuthResponseDTO = new AdminAuthResponseDTO()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                AccessTokenExpiredIn = accessTokenExpiredIn,
                RefreshTokenExpiredIn = refreshTokenExpiredIn
            };
            return Ok(adminAuthResponseDTO);
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login()
        {
            return Ok("Details");

        }

    }
}
