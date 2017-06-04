using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForoIA.Models.Db {

    public class Answer {

        public int Id { get; set; }

        [Required]
        [StringLength(1024)]
        public string Description { get; set; }

        public int QuestionId { get; set; }

        public bool IsCorrect { get; set; }

        // Navigation Porperties

        public virtual Test Question { get; set; }

    }

}