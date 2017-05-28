using System;
using System.ComponentModel.DataAnnotations;

namespace ForoIA.Models.Db {

    public class Comment {

        public int Id { get; set; }

        public int PostId { get; set; }

        [Required]
        [StringLength(25)]
        public string UserName { get; set; }

        [Required]
        public DateTime CommentTime { get; set; }

        [Required]
        [StringLength(1024)]
        public string Content { get; set; }

        // Navigation Properties

        public virtual Post Post { get; set; }

    }

}