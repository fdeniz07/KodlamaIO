namespace Core.Persistence.Repositories;

public class Entity
{
    public int Id { get; set; }

    public virtual DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    public virtual DateTime ModifiedDate { get; set; } = DateTime.UtcNow;

    public virtual bool IsDeleted { get; set; } = false;

    public virtual bool IsActive { get; set; } = true;

    public virtual string? CreatedByName { get; set; } = "Admin";

    public virtual string? ModifiedByName { get; set; } = "Admin";

    public virtual string? Note { get; set; }


    public Entity()
    {
    }

    public Entity(int id) : this()
    {
        Id = id;
    }
}