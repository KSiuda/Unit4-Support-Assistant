using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Unit4HomeOffice.Entities.Base
{
    public abstract class EntityBase
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        [Required]
        [DefaultValue("")]
        public virtual DateTime CreatedDate { get; set; }

        [Required]
        [DefaultValue("")]
        public virtual DateTime ModifiedDate { get; set; }
    }
}
