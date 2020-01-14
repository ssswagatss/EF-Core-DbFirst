using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbFirstTest.Web.Models
{
    [Table("post", Schema = "testdb")]
    public partial class Post
    {
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("user_id", TypeName = "int(11)")]
        public int? UserId { get; set; }
        [Required]
        [Column("title")]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        [Column("slug")]
        [StringLength(255)]
        public string Slug { get; set; }
        [Column("views", TypeName = "int(11)")]
        public int Views { get; set; }
        [Required]
        [Column("image")]
        [StringLength(255)]
        public string Image { get; set; }
        [Required]
        [Column("body")]
        public string Body { get; set; }
        [Column("published", TypeName = "tinyint(1)")]
        public byte Published { get; set; }
        [Column("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Post")]
        public virtual User User { get; set; }
    }
}
