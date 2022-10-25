using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CRUDWebApplication.Data;

namespace CRUDWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
       
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            return Ok(await _context.Users.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
                return BadRequest("Usuario nao encontrado.");
            return Ok(user);
        }

      [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        } 

        [HttpPut ("{id}")]
        public async Task<ActionResult<List<User>>> UpdateUser(User request, int id)
        {
            var dbUser = await _context.Users.FindAsync(request.id);
            if (dbUser == null)
                return BadRequest("Usuario nao encontrado.");

            dbUser.name = request.name;
            dbUser.CPF = request.CPF;
            dbUser.email = request.email;
            dbUser.CEP = request.CEP;
            dbUser.street = request.street;
            dbUser.complement = request.complement;
            dbUser.district = request.district;
            dbUser.UF = request.UF;
            dbUser.userId = request.userId;
            dbUser.name = request.name;
            dbUser.cellPhone = request.cellPhone;

            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        } 

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User>>> Delete(int id)
        {
            var dbUser = await _context.Users.FindAsync(id);
            if (dbUser == null)
                return BadRequest("Usuario nao encontrado.");

            _context.Users.Remove(dbUser);
            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        }


    }
}
