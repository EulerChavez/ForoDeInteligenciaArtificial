using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ForoIA.Models.Db {

    public class Post {

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(25)]
        public string UserName { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public int CategoryId { get; set; }

        [Required]
        [StringLength(1024)]
        public string Review { get; set; }

        [Required]
        [StringLength(5120)]
        public string Content { get; set; }

        // Navigation Properties

        public virtual Category Category { get; set; }

        public virtual ICollection<Comment> Commments { get; set; }

    }

}