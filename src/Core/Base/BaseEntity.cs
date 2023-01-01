using System.ComponentModel.DataAnnotations;

namespace Core.Base;

public class BaseEntity<T> : IBaseEntity<T>
{
    public BaseEntity()
    {
        Name = string.Empty;
        CreatedDate = DateTime.Now;
        ModifiedDate = DateTime.Now;

        Status = EntityStatus.Active;
    }
    
    [Key]
    public T Id { get; set; }
    
    public string Name { get; set; }
    
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    
    public Guid CreatedBy { get; set; }
    public Guid ModifyBy { get; set; }
    
    public int Status { get; set; }
}