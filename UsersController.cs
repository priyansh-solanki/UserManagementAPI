[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserRepository _repo;

    public UsersController(IUserRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public ActionResult<IEnumerable<User>> GetAll() => Ok(_repo.GetAll());

    [HttpGet("{id}")]
    public ActionResult<User> GetById(int id)
    {
        var user = _repo.GetById(id);
        return user is not null ? Ok(user) : NotFound(new { error = "User not found." });
    }

    [HttpPost]
    public ActionResult Add(User user)
    {
        if (string.IsNullOrWhiteSpace(user.Name) || !user.Email.Contains("@"))
            return BadRequest(new { error = "Invalid name or email." });

        _repo.Add(user);
        return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
    }

    [HttpPut("{id}")]
    public ActionResult Update(int id, User user)
    {
        if (_repo.GetById(id) is null)
            return NotFound(new { error = "User not found." });

        user.Id = id;
        _repo.Update(user);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        if (_repo.GetById(id) is null)
            return NotFound(new { error = "User not found." });

        _repo.Delete(id);
        return NoContent();
    }
}
