using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContentManagementSystem.Data.Entities
{
    public abstract class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public DateTime CreatedDateTimeUtc { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime UpdatedDateTimeUtc { get; set; }
    }
}