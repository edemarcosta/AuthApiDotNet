using AuthApiDotNet.Data;
using AuthApiDotNet.DTOs;
using AuthApiDotNet.Models;
using AuthApiDotNet.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthApiDotNet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AuthDbContext _context;
    private readonly PasswordService _passwordService;
    private readonly TokenService _tokenService;

    public AuthController(AuthDbContext context, TokenService tokenService)
    {
        _context = context;
        _passwordService = new PasswordService();
        _tokenService = tokenService;
    }
    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto dto)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.Email == dto.Email);

        if (user == null)
            return Unauthorized("Invalid email or password");

        var validPassword = _passwordService.VerifyPassword(dto.Password, user.PasswordHash);

        if (!validPassword)
            return Unauthorized("Invalid email or password");

        var token = _tokenService.GenerateToken(user);

        return Ok(new AuthResponseDto
        {
            FullName = user.FullName,
            Email = user.Email,
            Role = user.Role,
            Token = token
        });
    }
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto dto)
    {
        var exists = await _context.Users
            .AnyAsync(u => u.Email == dto.Email);

        if (exists)
            return BadRequest("Email already registered");

        var user = new User
        {
            FullName = dto.FullName,
            Email = dto.Email,
            PasswordHash = _passwordService.HashPassword(dto.Password),
            Role = dto.Role
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return Ok(new
        {
            message = "User registered successfully",
            user.Email
        });
    }
}