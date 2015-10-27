using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace eForm.Win.Data
{
    public class BaseData
    {
        [Required]
        [StringLength(128)]
        [Column("Id")]
        [Key]
        public string Id { get; set; }

        [Required]
        [Column("CreatedAt")]
        //[Index(IsClustered = true)]
        public DateTime CreatedAt { get; set; }

        [Column("UpdatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [Column("Version")]
        [Timestamp]
        public byte[] Version { get; set; }

        [Column("Deleted")]
        public bool Deleted { get; set; }

        [Required]
        [StringLength(150)]
        [Column("CreatedBy")]
        public string CreatedBy { get; set; }

        [StringLength(150)]
        [Column("UpdatedBy")]
        public string UpdatedBy { get; set; }

        public BaseData()
        {
            Id = Guid.NewGuid().ToString("N");
            if (CreatedAt == DateTime.MinValue)
                CreatedAt = new DateTime(1753, 1, 1);
            if (UpdatedAt == DateTime.MinValue)
                UpdatedAt = new DateTime(1753, 1, 1);
        }

        public virtual string Describe()
        {
            return "";
        }
    }
}
