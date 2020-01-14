using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbFirstTest.DB.Entities
{
    [Table("category", Schema = "testdb")]
    public partial class Category
    {
        [Column("category_id", TypeName = "int(11)")]
        public int CategoryId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(20)]
        public string Name { get; set; }
        [Column("parent", TypeName = "int(11)")]
        public int? Parent { get; set; }
    }
}
