namespace Core.Base;

public interface IBaseEntity<T>
{
    public T Id { get; set; }
    
    public string Name { get; set; }

    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }

    public Guid CreatedBy { get; set; }
    public Guid ModifyBy { get; set; }

    public int Status { get; set; }
}