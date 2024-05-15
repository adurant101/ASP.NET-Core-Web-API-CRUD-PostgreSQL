using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_CRUD_PostgreSQL.Models
{
    [Table("users")]
    public class User
    {
        
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("email")]
        public string Email { get; set; }
    }
}
