using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbFirstTest.Web.Models
{
    [Table("nested_category", Schema = "testdb")]
    public partial class NestedCategory
    {
        [Key]
        [Column("category_id", TypeName = "int(11)")]
        public int CategoryId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(20)]
        public string Name { get; set; }
        [Column("lft", TypeName = "int(11)")]
        public int Lft { get; set; }
        [Column("rgt", TypeName = "int(11)")]
        public int Rgt { get; set; }
    }
}
