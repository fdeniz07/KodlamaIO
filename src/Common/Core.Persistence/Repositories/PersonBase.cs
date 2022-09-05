namespace Core.Persistence.Repositories
{
    public abstract class PersonBase
    {
        // Base sinifimiz, tablolarimizdaki ortak alanlari tutar ve miras alan siniflar degisiklik isterlerse override anahtari ile degisiklik yapabilirler.

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual DateTime BirthDate { get; set; }

        public virtual string Picture { get; set; }

        public virtual string Description { get; set; }

        //public virtual Guid Id { get; set; } //CoreIdentity den gelecek

        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;

        public virtual bool IsDeleted { get; set; } = false;

        public virtual bool IsActive { get; set; } = true;

        public virtual string CreatedByName { get; set; } = "Admin";

        public virtual string ModifiedByName { get; set; } = "Admin";

        public virtual string Note { get; set; }

        public PersonBase()
        {

        }

        //public PersonBase(Guid id) : this()
        //{
        //    //Id = id;
        //    CreatedDate = ModifiedDate = DateTime.Now;
        //    IsActive = true;
        //    IsDeleted = false;
        //}

    }
}
