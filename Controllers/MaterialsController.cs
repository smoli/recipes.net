using System.Collections.Immutable;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace net.Controllers;


public interface IMaterialPersistence {
    public ImmutableList<Material> GetAll();
}


[ApiController]
[Route("[controller]")]
public class MaterialsController : ControllerBase {

    private IMaterialPersistence _persistence;

    public MaterialsController(IMaterialPersistence persistence)
    {
        _persistence = persistence;
    }

    [HttpGet(Name = "GetAllMaterials")]
    public IEnumerable<Material> Get() {
        return _persistence.GetAll();
    }
}