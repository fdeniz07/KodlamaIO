namespace Core.Persistence.Repositories
{
    public abstract class EntityBase
    {
        // Base sinifimiz, tablolarimizdaki ortak alanlari tutar ve miras alan siniflar degisiklik isterlerse override anahtari ile degisiklik yapabilirler.

        public virtual Guid Id { get; set; }

        public virtual DateTime CreatedDate { get; set; }

        public virtual DateTime ModifiedDate { get; set; }

        public virtual bool IsDeleted { get; set; }

        public virtual bool IsActive { get; set; }

        public virtual string CreatedByName { get; set; } = "Admin";

        public virtual string ModifiedByName { get; set; } = "Admin";

        public virtual string Note { get; set; }

        public EntityBase()
        {

        }

        public EntityBase(Guid id) : this()
        {
            Id = id;
            CreatedDate = ModifiedDate = DateTime.Now;
            IsActive = true;
            IsDeleted = false;
        }
    }
}
