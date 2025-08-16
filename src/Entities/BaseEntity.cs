namespace erp_back_net.Entities;

public class BaseEntity
{
    public long Id { get; set; }
    
    public long CreatedAt { get; set; }
    
    public long UpdatedAt { get; set; }
    
    public long LicenseId { get; set; }
}