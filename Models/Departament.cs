namespace WebApp.Models;

public partial class Departament
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<DivisionsAndDdepartamentAndOrganization> DivisionsAndDdepartamentAndOrganizations { get; set; } = new List<DivisionsAndDdepartamentAndOrganization>();
}
