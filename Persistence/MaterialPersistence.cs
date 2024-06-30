using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using net.Controllers;

class MaterialPersistenceDB: DbContext, IMaterialPersistence {

    public static List<Material> Materials { get; private set; }

    static MaterialPersistenceDB() {
        Materials = [ Material.Create("Weizenmehl 550"), 
                      Material.Create("Trinkwasser"),
                      Material.Create("Meersalz, fein") ];
    }

    public ImmutableList<Material> GetAll()
    {
        return [.. Materials];
    }
}