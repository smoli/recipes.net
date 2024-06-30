using System.Runtime.InteropServices;

public class Material
{
    public MaterialId Id { get; private set; }

    public String Name { get; private set; }


    private Material(String Name)
    {
        this.Id = MaterialId.Create(Guid.NewGuid());
        this.Name = Name;
    }

    public static Material Create(String Name) {
        return new Material(Name);
    }

}

class Nutrition
{
    public Guid Id { get; private set; }
    
    public MaterialId Material { get; private set; }
    
    public Decimal CaloriesPer100g { get; private set; }
    public Decimal ProteinPer100g { get; private set; }
    public Decimal CarbsPer100g { get; private set; }
    public Decimal FatsPer100g { get; private set; }


    private Nutrition(MaterialId Material)
    {
        this.Id = Guid.NewGuid();
        this.Material = Material;
    }
}

public record MaterialId
{
    public Guid Value { get; private set; }

    protected MaterialId(Guid Value)
    {
        this.Value = Value;
    }

    public static MaterialId Create(Guid Value)
    {
        return new MaterialId(Value);
    }
}

