using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbFirstTest.Web.Models
{
    [Table("user", Schema = "testdb")]
    public partial class User
    {
        public User()
        {
            Post = new HashSet<Post>();
        }

        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Required]
        [Column("username")]
        [StringLength(255)]
        public string Username { get; set; }
        [Required]
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("role", TypeName = "enum('Author','Admin')")]
        public string Role { get; set; }
        [Required]
        [Column("password")]
        [StringLength(255)]
        public string Password { get; set; }
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Post> Post { get; set; }
    }
}
