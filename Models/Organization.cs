namespace WebApp.Models;

public partial class Organization
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<DivisionsAndDdepartamentAndOrganization> DivisionsAndDdepartamentAndOrganizations { get; set; } = new List<DivisionsAndDdepartamentAndOrganization>();
}
