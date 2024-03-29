using System.ComponentModel.DataAnnotations;

namespace NetCore8CRUD.Models
{
    public class Category
    {
        public Int64 Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
