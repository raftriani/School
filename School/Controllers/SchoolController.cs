using Microsoft.AspNetCore.Mvc;
using School.Application.Intefaces;
using School.Domain.Entities;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : Controller
    {
        private readonly IUserService _userService;

        public SchoolController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ObjectResult> FindAll()
        {
            try
            {
                var result = await _userService.FindAll();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<ObjectResult> Find(int id)
        {
            try
            {
                var result = await _userService.GetById(id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { ex.Message });
            }
        }

        [HttpPost]
        public async Task<ObjectResult> Add(User user)
        {
            try
            {
                string message = await _userService.Add(user);

                if (string.IsNullOrEmpty(message))
                {
                    return Ok("Usuario inserido com sucesso!");
                }
                else
                {
                    return Problem(message);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { ex.Message });
            }
        }

        [HttpPut]
        public async Task<ObjectResult> Update(User user)
        {
            try
            {
                string message = await _userService.Update(user);

                if (string.IsNullOrEmpty(message))
                {
                    return Ok("Usuario atualizado com sucesso!");
                }
                else
                {
                    return Problem(message);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<ObjectResult> Remove(int id)
        {
            try
            {
                await _userService.Delete(id);

                return Ok("Usuario removido com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(new { ex.Message });
            }
        }
    }
}
