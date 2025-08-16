namespace erp_back_net.Entities;

public class BaseEntity
{
    public string Id { get; set; }
    
    public long CreatedAt { get; set; }
    
    public long UpdatedAt { get; set; }
    
    public string LicenseId { get; set; }
}