using Microsoft.AspNetCore.Mvc;
using template_form_backed.Api.Common;
using template_form_backed.Application.Users;

namespace template_form_backed.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateForm([FromBody] CreateUserRequest request)
        {
            var result = await _userService.CreateUserAsync(request);
            if (!result.IsSuccess)
            {
                return BadRequest(ApiResponse<string>.Fail(result.Error!));
            }
            var response = result.Value!.ToResponse();
            return CreatedAtAction(nameof(GetById), new {id = response.Id }, ApiResponse<UserResponse>.Success(response));
        }
        [HttpGet]
        public async Task<IActionResult> GetUsersForm()
        {
            var users = await _userService.GetUsersAsync();
            var response = users.ToResponse();


            return Ok(ApiResponse<IEnumerable<UserResponse>>.Success(response));
        }
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ApiResponse<UserResponse>>> GetById(Guid id)
        {
            var result = await _userService.GetUserByIdAsync(id);
            if(!result.IsSuccess || result.Value == null)
            {
                return NotFound(ApiResponse<string>.Fail(result.Error! ?? "User not found"));
            }
            var response = result.Value!.ToResponse();
            return Ok(ApiResponse<UserResponse>.Success(response));
        }
    }
}
