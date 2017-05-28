using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ForoIA.Models.Db {

    public class Category {

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        // Navigation Properties

        public virtual ICollection<Post> Posts { get; set; }

    }

}